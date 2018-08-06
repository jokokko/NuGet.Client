// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Build.Evaluation;
using NuGet.CommandLine.XPlat.Utility;
using NuGet.Common;
using NuGet.Configuration;
using NuGet.Frameworks;
using NuGet.Protocol;
using NuGet.Protocol.Core.Types;
using NuGet.Versioning;

namespace NuGet.CommandLine.XPlat
{
    public class ListPackageCommandRunner : IListPackageCommandRunner
    {
        private const string LeftPadding = "   ";

        public async Task ExecuteCommandAsync(ListPackageArgs listPackageArgs)
        {
            //If the given file is a solution, get the list of projects
            //If not, then it's a project, which is put in a list
            var projectsPaths = Path.GetExtension(listPackageArgs.Path).Equals(".sln")?
                           MSBuildAPIUtility.GetProjectsFromSolution(listPackageArgs.Path).Where(f => File.Exists(f)):
                           new List<string>(new string[] { listPackageArgs.Path });

            var autoReferenceFound = false;

            var msBuild = new MSBuildAPIUtility(listPackageArgs.Logger);

            //Loop through all of the project paths
            foreach (var projectPath in projectsPaths)
            {
                //Open project to evaluate properties
                var project = MSBuildAPIUtility.GetProject(projectPath);
                var projectName = project.GetPropertyValue("MSBuildProjectName");

                Debugger.Launch();

                //Get all the packages that are referenced in a project
                var packages = msBuild.GetPackageReferencesForList(project, listPackageArgs.Frameworks, listPackageArgs.IncludeTransitive);

                //A null return means that reading the assets file failed
                //or that no package references at all were found 
                if (packages != null)
                {
                    if (listPackageArgs.IncludeOutdated)
                    {
                        packages = await AddLatestVersions(packages, listPackageArgs);
                    }

                    //The count is not 0 means that a package reference was found
                    if (packages.Count() != 0)
                    {
                        autoReferenceFound = PrintProjectPackages(packages, projectName, listPackageArgs.IncludeTransitive, listPackageArgs.IncludeOutdated);
                    }
                    else
                    {
                        Console.WriteLine(listPackageArgs.Frameworks.Count() == 0 ? string.Format(Strings.ListPkg_NoPackagesFound, projectName) : string.Format(Strings.ListPkg_NoPackagesFoundForFrameworks, projectName));
                    }
                    
                }

                ProjectCollection.GlobalProjectCollection.UnloadProject(project);
            }

            //If any auto-references were found, a line is printed
            //explaining what (A) means
            if (autoReferenceFound)
            {
                Console.WriteLine(Strings.ListPkg_AutoReferenceDescription);
            }

        }

        /// <summary>
        /// Fetches the latest versions for all of the packages that are
        /// to be listed
        /// </summary>
        /// <param name="packages">The packages to be listed</param>
        /// <param name="listPackageArgs">List args for the token and source provider</param>
        /// <returns>A data structure like packages, but includes the latest versions</returns>
        private async Task<Dictionary<string, Tuple<IEnumerable<PRPackage>, IEnumerable<PRPackage>>>> AddLatestVersions(Dictionary<string, Tuple<IEnumerable<PRPackage>, IEnumerable<PRPackage>>> packages, ListPackageArgs listPackageArgs)
        {
            var resultPackages = new Dictionary<string, Tuple<IEnumerable<PRPackage>, IEnumerable<PRPackage>>>();

            var providers = Repository.Provider.GetCoreV3();

            foreach (var frameworkPackages in packages)
            {
                var updatedTopLevel = frameworkPackages.Value.Item1.Select(async p =>
                    new PRPackage {
                        autoReference = p.autoReference,
                        name = p.name,
                        requestedVersion = p.requestedVersion,
                        projectFileRequestedVersion = p.projectFileRequestedVersion,
                        resolvedVersion = p.resolvedVersion,
                        suggestedVersion = await GetLatestVersion(p, NuGetFramework.Parse(frameworkPackages.Key), listPackageArgs, providers)
                    }
                );

                var updatedTransitive = frameworkPackages.Value.Item2.Select(async p =>
                    new PRPackage {
                        autoReference = p.autoReference,
                        name = p.name,
                        requestedVersion = p.requestedVersion,
                        projectFileRequestedVersion = p.projectFileRequestedVersion,
                        resolvedVersion = p.resolvedVersion,
                        suggestedVersion = await GetLatestVersion(p, NuGetFramework.Parse(frameworkPackages.Key), listPackageArgs, providers)
                    }
                );


                var resolvedTopLevelPackages = await Task.WhenAll(updatedTopLevel);
                var resolvedTransitivePackages = await Task.WhenAll(updatedTransitive);
                
                resultPackages.Add(
                    frameworkPackages.Key,
                    Tuple.Create(resolvedTopLevelPackages.AsEnumerable(), resolvedTransitivePackages.AsEnumerable())
                );

            }

            return resultPackages;
        }

        /// <summary>
        /// Fetches the latest version of the given packageId
        /// </summary>
        /// <param name="package">The package to get the latest version for</param>
        /// <param name="framework">The framework for the given package</param>
        /// <param name="listPackageArgs">List args for the token and source provider></param>
        /// <param name="providers"></param>
        /// <returns>The highest version at sources as a string</returns>
        private async Task<NuGetVersion> GetLatestVersion(
            PRPackage package,
            NuGetFramework framework,
            ListPackageArgs listPackageArgs,
            IEnumerable<Lazy<INuGetResourceProvider>> providers)
        {
            var sources = listPackageArgs.PackageSources;
            var tasks = new List<Task<NuGetVersion>>();

            foreach (var packageSource in sources)
            {
                tasks.Add(GetLatestVersionPerSourceAsync(packageSource, listPackageArgs, package, framework, providers));
            }
            var versions = await Task.WhenAll(tasks);

            return versions.Max();
        }

        /// <summary>
        /// Gets the highest version of a package from a specific source
        /// </summary>
        /// <param name="packageSource">The source to look for pacakges at</param>
        /// <param name="listPackageArgs">The list args for the cancellation token</param>
        /// <param name="p">Package to look for updates for</param>
        /// <param name="framework">The framework which the given package is for</param>
        /// <param name="providers"></param>
        /// <returns>The highest NuGetVersion at the source</returns>
        private async Task<NuGetVersion> GetLatestVersionPerSourceAsync(
            PackageSource packageSource,
            ListPackageArgs listPackageArgs,
            PRPackage p,
            NuGetFramework framework,
            IEnumerable<Lazy<INuGetResourceProvider>> providers)
        {

            var sourceRepository = Repository.CreateSource(providers, packageSource, FeedType.Undefined);
            var dependencyInfoResource = await sourceRepository.GetResourceAsync<FindPackageByIdResource>(listPackageArgs.CancellationToken);

            var packages = (await dependencyInfoResource.GetAllVersionsAsync(p.name, new SourceCacheContext(), NullLogger.Instance, listPackageArgs.CancellationToken)).ToList();

            var latestVersionAtSource = packages.Where(version => MeetsConstraints(version, p, listPackageArgs))
            .OrderByDescending(version => version, VersionComparer.Default)
            .FirstOrDefault();

            return latestVersionAtSource;
        }

        /// <summary>
        /// Given the a found version from a source and the current version and the args
        /// if list package, this function checks if the found version meets the required
        /// highest-patch, highest-minor or prerelease
        /// </summary>
        /// <param name="newVersion">Version from a source</param>
        /// <param name="p">The required package with its current version</param>
        /// <param name="listPackageArgs">Used to get the constraints</param>
        /// <returns>Whether the new version meets the constraints or not</returns>
        private bool MeetsConstraints(NuGetVersion newVersion, PRPackage p, ListPackageArgs listPackageArgs)
        {
            var result = true;
            NuGetVersion currentVersion;
            if (p.requestedVersion == null)
            {
                currentVersion = p.resolvedVersion;
            }
            else
            {
                currentVersion = p.requestedVersion.MaxVersion != null ?
                                 p.requestedVersion.MaxVersion : p.requestedVersion.MinVersion;
            }
                

            var prerelease = !newVersion.IsPrerelease || listPackageArgs.Prerelease || currentVersion.IsPrerelease;
            result = result && prerelease;

            result = listPackageArgs.HighestPatch ?
                newVersion.Minor.Equals(currentVersion.Minor) && newVersion.Major.Equals(currentVersion.Major) && result:
                result;

            result = listPackageArgs.HighestMinor ?
                newVersion.Major.Equals(currentVersion.Major) && result :
                result;

            return result;
        }


        /// <summary>
        /// A function that prints all the information about the packages
        /// references by framework
        /// </summary>
        /// <param name="packages">A dictionary that maps a framework name to a tuple of 2
        /// enumerables of packages top-level and transitive in order</param>
        /// <param name="projectName">The project name</param>
        /// <param name="transitive">Whether include-transitive flag exists or not</param>
        /// <param name="outdated"></param>
        private bool PrintProjectPackages(Dictionary<string, Tuple<IEnumerable<PRPackage>, IEnumerable<PRPackage>>> packages,
           string projectName, bool transitive, bool outdated)
        {
            var autoReferenceFound = false;

            var frameworkMessage = new StringBuilder(LeftPadding);
            frameworkMessage.Append("'{0}'");

            Console.WriteLine(string.Format(Strings.ListPkgProjectHeaderLog, projectName));

            foreach (var frameworkPackages in packages)
            {
                if (frameworkPackages.Value.Item1.Count() == 0)
                {
                    frameworkMessage.Append(": ");
                    Console.WriteLine(string.Format(frameworkMessage.ToString() + Strings.ListPkg_NoPackagesForFramework, frameworkPackages.Key));
                }
                else
                {
                    Console.WriteLine(string.Format(frameworkMessage.ToString(), frameworkPackages.Key));

                    autoReferenceFound = PackagesTable(frameworkPackages.Value.Item1, false, outdated) || autoReferenceFound;

                    if (transitive)
                    {
                        autoReferenceFound = PackagesTable(frameworkPackages.Value.Item2, true, outdated) || autoReferenceFound;
                    }
                }
            }
            return autoReferenceFound;
            
        }

        /// <summary>
        /// Given a list of packages, this function will print them in a table
        /// </summary>
        /// <param name="packages">The list of packages</param>
        /// <param name="printingTransitive">Whether the function is printing transitive
        /// packages table or not</param>
        /// <param name="outdated"></param>
        /// <returns>The table as a string</returns>
        private bool PackagesTable(IEnumerable<PRPackage> packages, bool printingTransitive, bool outdated)
        {
            var autoReferenceFound = false;
            if (packages.Count() == 0)
            {
                return autoReferenceFound;
            }

            var sb = new StringBuilder();
            var headers = BuildTableHeaders(printingTransitive, outdated);

            if (printingTransitive)
            {

                if (outdated)
                {
                    sb.Append(packages.ToStringTable(
                        headers,
                        p => "", p => p.name, p => LeftPadding, p => p.resolvedVersion.ToString(), p => p.suggestedVersion == null ? "Not found at sources" : p.suggestedVersion.ToString()
                    ));
                }
                else
                {
                    sb.Append(packages.ToStringTable(
                        headers,
                        p => "", p => p.name, p => LeftPadding, p => p.resolvedVersion.ToString()
                    ));
                }
           
            }
            else
            {
                if (outdated)
                {
                    sb.Append(packages.ToStringTable(
                       headers,
                       p => "", p => p.name, p => {
                           if (p.autoReference)
                           {
                               autoReferenceFound = true;
                               return "(A)";
                           }
                           return LeftPadding;
                       }, p => p.projectFileRequestedVersion, p => p.resolvedVersion.ToString(), p => p.suggestedVersion == null ? "Not found at sources" : p.suggestedVersion.ToString()
                   ));
                }
                else
                {
                    sb.Append(packages.ToStringTable(
                       headers,
                       p => "", p => p.name, p => {
                           if (p.autoReference)
                           {
                               autoReferenceFound = true;
                               return "(A)";
                           }
                           return LeftPadding;
                       }, p => p.projectFileRequestedVersion, p => p.resolvedVersion.ToString()
                   ));
                }
                

            }

            Console.WriteLine(sb.ToString());
            return autoReferenceFound;
        }

        /// <summary>
        /// Prepares the headers for the tables that will be printed
        /// </summary>
        /// <param name="printingTransitive">Whether the table is for transitive or not</param>
        /// <param name="outdated">Whether we have an outdated/latest column or not</param>
        /// <returns></returns>
        private string[] BuildTableHeaders(bool printingTransitive, bool outdated)
        {
            var result = new List<string> { LeftPadding };
            if (printingTransitive)
            {
                result.Add("Transitive Package");
                result.Add("");
                result.Add("Resolved");
            }
            else
            {
                result.Add("Top-level Package");
                result.Add("");
                result.Add("Requested");
                result.Add("Resolved");
            }

            if (outdated)
            {
                result.Add("Latest");
            }

            return result.ToArray();
        }
    }

    /// <summary>
    /// A struct to simplify holding all of the information
    /// about a package reference when using list
    /// </summary>
    internal struct PRPackage
    {
        public string name;
        public VersionRange requestedVersion;
        public string projectFileRequestedVersion;
        public NuGetVersion resolvedVersion;
        public NuGetVersion suggestedVersion;
        //public bool deprecated;
        public bool autoReference;
    }
}