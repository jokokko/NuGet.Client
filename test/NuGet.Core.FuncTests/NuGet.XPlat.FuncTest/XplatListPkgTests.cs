// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Extensions.CommandLineUtils;
using Moq;
using NuGet.CommandLine.XPlat;
using NuGet.Packaging;
using NuGet.Test.Utility;
using Xunit;

namespace NuGet.XPlat.FuncTest
{
    [Collection("NuGet XPlat Test Collection")]
    public class XPlatListPkgTests
    {
        private static readonly string ProjectName = "test_project_listpkg";

        private static MSBuildAPIUtility MsBuild => new MSBuildAPIUtility(new TestCommandOutputLogger());

        [Fact]
        public void ListPkg()
        {
            // Arrange
            var projectPath = Path.Combine(Path.GetTempPath(), "project_foo.csproj");
            File.Create(projectPath).Dispose();
            var argList = new List<string>() {
                "list",
                projectPath,
                "package"};

            var logger = new TestCommandOutputLogger();
            var testApp = new CommandLineApplication();
            var mockCommandRunner = new Mock<IListPackageCommandRunner>();
            mockCommandRunner
                .Setup(m => m.ExecuteCommandAsync(It.IsAny<ListPackageArgs>()));
            testApp.Name = "dotnet nuget_test";

            ListPackageCommand.Register(testApp,
                () => logger,
                () => mockCommandRunner.Object);


            // Act
            var result = testApp.Execute(argList.ToArray());
    

            XPlatTestUtils.DisposeTemporaryFile(projectPath);

            // Assert
            //mockCommandRunner.Verify(m => m.ExecuteCommandAsync(It.Is<ListPackageArgs>(p =>
            //p.PackageDependency.Id == package &&
            //p.ProjectPath == projectPath)));

            Assert.Equal(0, result);
        }

        [Fact]
        public async void DotnetListPackage_Outdated_Succeed()
        {
            using (var pathContext = new SimpleTestPathContext())
            {
                var projectA = XPlatTestUtils.CreateProject(ProjectName, pathContext, "net46");
                var versions = new List<string> { "1.0.0", "1.0.9", "1.9.0", "2.1.0", "2.2.0-beta" };
                foreach (var version in versions)
                {
                    var packageX = XPlatTestUtils.CreatePackage(packageId: "packageX", packageVersion: version);

                    // Generate Package
                    await SimpleTestPackageUtility.CreateFolderFeedV3Async(
                        pathContext.PackageSource,
                        PackageSaveMode.Defaultv3,
                        packageX);
                }


                var buildFixture = new XPlatMsbuildTestFixture();
                var result = CommandRunner.Run(buildFixture._dotnetCli,
                    Directory.GetParent(projectA.ProjectPath).FullName,
                    $"add {projectA.ProjectPath} package packageX --version 1.0.0",
                    waitForExit: true);

                //var argList = new List<string>() {
                //        "add", "--package", "packageX", "--version",
                //        "1.0.0",
                //        "--project",
                //        projectA.ProjectPath,
                //        "--no-restore"};

                //var logger = new TestCommandOutputLogger();
                //var testApp = new CommandLineApplication();
                //var mockCommandRunner = new Mock<IPackageReferenceCommandRunner>();
                //mockCommandRunner
                //    .Setup(m => m.ExecuteCommand(It.IsAny<PackageReferenceArgs>(), It.IsAny<MSBuildAPIUtility>()))
                //    .ReturnsAsync(0);

                //testApp.Name = "dotnet nuget_test";
                //AddPackageReferenceCommand.Register(testApp,
                //    () => logger,
                //    () => mockCommandRunner.Object);
                //var result = testApp.Execute(argList.ToArray());

                var resultt = CommandRunner.Run(buildFixture._dotnetCli,
                    Directory.GetParent(projectA.ProjectPath).FullName,
                    $"restore {projectA.ProjectName}.csproj",
                    waitForExit: true);

            }
        }

        private static bool ContainsIgnoringSpaces(string output, string pattern)
        {
            var commandResultNoSpaces = output.Replace(" ", "");

            return commandResultNoSpaces.Contains(pattern);
        }
    }
}