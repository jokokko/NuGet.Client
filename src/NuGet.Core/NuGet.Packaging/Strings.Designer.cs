//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NuGet.Packaging {
    using System;
    using System.Reflection;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Strings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Strings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("NuGet.Packaging.Strings", typeof(Strings).GetTypeInfo().Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SHA1 hash: {0}.
        /// </summary>
        internal static string CertUtilityCertificateHash {
            get {
                return ResourceManager.GetString("CertUtilityCertificateHash", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Issued by: {0}.
        /// </summary>
        internal static string CertUtilityCertificateIssuer {
            get {
                return ResourceManager.GetString("CertUtilityCertificateIssuer", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Subject Name: {0}.
        /// </summary>
        internal static string CertUtilityCertificateSubjectName {
            get {
                return ResourceManager.GetString("CertUtilityCertificateSubjectName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Valid from: {0} to {1}.
        /// </summary>
        internal static string CertUtilityCertificateValidity {
            get {
                return ResourceManager.GetString("CertUtilityCertificateValidity", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ... {0} more..
        /// </summary>
        internal static string CertUtilityMultipleCertificatesFooter {
            get {
                return ResourceManager.GetString("CertUtilityMultipleCertificatesFooter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The following certificates meet all given criteria:.
        /// </summary>
        internal static string CertUtilityMultipleCertificatesHeader {
            get {
                return ResourceManager.GetString("CertUtilityMultipleCertificatesHeader", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to commitment-type-indication attribute contains an invalid value..
        /// </summary>
        internal static string CommitmentTypeIndicationAttributeInvalid {
            get {
                return ResourceManager.GetString("CommitmentTypeIndicationAttributeInvalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to commitment-type-indication attribute is invalid..
        /// </summary>
        internal static string CommitmentTypeIndicationInvalid {
            get {
                return ResourceManager.GetString("CommitmentTypeIndicationInvalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Certificate inside main SignerInfo is null..
        /// </summary>
        internal static string DebugNoCertificate {
            get {
                return ResourceManager.GetString("DebugNoCertificate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unsupported targetFramework value &apos;{0}&apos;..
        /// </summary>
        internal static string Error_InvalidTargetFramework {
            get {
                return ResourceManager.GetString("Error_InvalidTargetFramework", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SignedCms does not have one primary signature..
        /// </summary>
        internal static string Error_NotOnePrimarySignature {
            get {
                return ResourceManager.GetString("Error_NotOnePrimarySignature", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Byte signature not found in package archive:.
        /// </summary>
        internal static string ErrorByteSignatureNotFound {
            get {
                return ResourceManager.GetString("ErrorByteSignatureNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Byte signature too big to seek in current stream position..
        /// </summary>
        internal static string ErrorByteSignatureTooBig {
            get {
                return ResourceManager.GetString("ErrorByteSignatureTooBig", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Certificates with lifetime signer EKU are not supported..
        /// </summary>
        internal static string ErrorCertificateHasLifetimeSignerEKU {
            get {
                return ResourceManager.GetString("ErrorCertificateHasLifetimeSignerEKU", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Certificate is not a valid code signing certificate..
        /// </summary>
        internal static string ErrorCertificateNotCodeSigning {
            get {
                return ResourceManager.GetString("ErrorCertificateNotCodeSigning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There are duplicate packages: {0}.
        /// </summary>
        internal static string ErrorDuplicatePackages {
            get {
                return ResourceManager.GetString("ErrorDuplicatePackages", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid allowedVersions for package id &apos;{0}&apos;: &apos;{1}&apos;.
        /// </summary>
        internal static string ErrorInvalidAllowedVersions {
            get {
                return ResourceManager.GetString("ErrorInvalidAllowedVersions", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Certificate chain validation failed with error: {0}.
        /// </summary>
        internal static string ErrorInvalidCertificateChain {
            get {
                return ResourceManager.GetString("ErrorInvalidCertificateChain", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Certificate chain validation failed for an unspecified reason..
        /// </summary>
        internal static string ErrorInvalidCertificateChainUnspecifiedReason {
            get {
                return ResourceManager.GetString("ErrorInvalidCertificateChainUnspecifiedReason", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid minClientVersion: &apos;{0}&apos;.
        /// </summary>
        internal static string ErrorInvalidMinClientVersion {
            get {
                return ResourceManager.GetString("ErrorInvalidMinClientVersion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid package archive..
        /// </summary>
        internal static string ErrorInvalidPackageArchive {
            get {
                return ResourceManager.GetString("ErrorInvalidPackageArchive", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid package version for package id &apos;{0}&apos;: &apos;{1}&apos;.
        /// </summary>
        internal static string ErrorInvalidPackageVersion {
            get {
                return ResourceManager.GetString("ErrorInvalidPackageVersion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid package version for a dependency with id &apos;{0}&apos; in package &apos;{1}&apos;: &apos;{2}&apos;.
        /// </summary>
        internal static string ErrorInvalidPackageVersionForDependency {
            get {
                return ResourceManager.GetString("ErrorInvalidPackageVersionForDependency", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not validate signature. Certificate does not meet the public key requirements..
        /// </summary>
        internal static string ErrorInvalidPublicKey {
            get {
                return ResourceManager.GetString("ErrorInvalidPublicKey", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Manifest file not found at &apos;{0}&apos;.
        /// </summary>
        internal static string ErrorManifestFileNotFound {
            get {
                return ResourceManager.GetString("ErrorManifestFileNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not validate signature. Signature does not have a certificate..
        /// </summary>
        internal static string ErrorNoCertificate {
            get {
                return ResourceManager.GetString("ErrorNoCertificate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Null or empty package id.
        /// </summary>
        internal static string ErrorNullOrEmptyPackageId {
            get {
                return ResourceManager.GetString("ErrorNullOrEmptyPackageId", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Package is not signed..
        /// </summary>
        internal static string ErrorPackageNotSigned {
            get {
                return ResourceManager.GetString("ErrorPackageNotSigned", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Package signature is invalid..
        /// </summary>
        internal static string ErrorPackageSignatureInvalid {
            get {
                return ResourceManager.GetString("ErrorPackageSignatureInvalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Package contents might have been tampered..
        /// </summary>
        internal static string ErrorPackageTampered {
            get {
                return ResourceManager.GetString("ErrorPackageTampered", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Signature file is not of a reasonable size. Package contents might have been tampered..
        /// </summary>
        internal static string ErrorSignatureFileTooBig {
            get {
                return ResourceManager.GetString("ErrorSignatureFileTooBig", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Signature verification failed..
        /// </summary>
        internal static string ErrorSignatureVerificationFailed {
            get {
                return ResourceManager.GetString("ErrorSignatureVerificationFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Signing certificate chains to an untrusted root..
        /// </summary>
        internal static string ErrorSigningCertUntrustedRoot {
            get {
                return ResourceManager.GetString("ErrorSigningCertUntrustedRoot", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to delete temporary file &apos;{0}&apos;. Error: &apos;{1}&apos;..
        /// </summary>
        internal static string ErrorUnableToDeleteFile {
            get {
                return ResourceManager.GetString("ErrorUnableToDeleteFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Zip64 archives are not supported.
        /// </summary>
        internal static string ErrorZip64NotSupported {
            get {
                return ResourceManager.GetString("ErrorZip64NotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to update file time for {0}: {1}.
        /// </summary>
        internal static string FailedFileTime {
            get {
                return ResourceManager.GetString("FailedFileTime", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Fail to load packages.config as XML file. Please check it. .
        /// </summary>
        internal static string FailToLoadPackagesConfig {
            get {
                return ResourceManager.GetString("FailToLoadPackagesConfig", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to write packages.config as XML file &apos;{0}&apos;. Error: &apos;{1}&apos;..
        /// </summary>
        internal static string FailToWritePackagesConfig {
            get {
                return ResourceManager.GetString("FailToWritePackagesConfig", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to find fallback package folder &apos;{0}&apos;..
        /// </summary>
        internal static string FallbackFolderNotFound {
            get {
                return ResourceManager.GetString("FallbackFolderNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} This validation error occurred in a &apos;{1}&apos; element..
        /// </summary>
        internal static string InvalidNuspecElement {
            get {
                return ResourceManager.GetString("InvalidNuspecElement", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The nuspec contains an invalid entry &apos;{0}&apos; in package &apos;{1}&apos; ..
        /// </summary>
        internal static string InvalidNuspecEntry {
            get {
                return ResourceManager.GetString("InvalidNuspecEntry", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The framework in the folder name of &apos;{0}&apos; in package &apos;{1}&apos; could not be parsed..
        /// </summary>
        internal static string InvalidPackageFrameworkFolderName {
            get {
                return ResourceManager.GetString("InvalidPackageFrameworkFolderName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Package {0} signature is invalid..
        /// </summary>
        internal static string InvalidPackageSignature {
            get {
                return ResourceManager.GetString("InvalidPackageSignature", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The package signature content is invalid..
        /// </summary>
        internal static string InvalidSignatureContent {
            get {
                return ResourceManager.GetString("InvalidSignatureContent", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Installing {0} {1}..
        /// </summary>
        internal static string Log_InstallingPackage {
            get {
                return ResourceManager.GetString("Log_InstallingPackage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to MinClientVersion already exists in packages.config.
        /// </summary>
        internal static string MinClientVersionAlreadyExist {
            get {
                return ResourceManager.GetString("MinClientVersionAlreadyExist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Nuspec file does not exist in package..
        /// </summary>
        internal static string MissingNuspec {
            get {
                return ResourceManager.GetString("MissingNuspec", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Package contains multiple nuspec files..
        /// </summary>
        internal static string MultipleNuspecFiles {
            get {
                return ResourceManager.GetString("MultipleNuspecFiles", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; must contain an absolute path &apos;{1}&apos;..
        /// </summary>
        internal static string MustContainAbsolutePath {
            get {
                return ResourceManager.GetString("MustContainAbsolutePath", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Package entry already exists in packages.config. Id: {0}.
        /// </summary>
        internal static string PackageEntryAlreadyExist {
            get {
                return ResourceManager.GetString("PackageEntryAlreadyExist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Package entry does not exists in packages.config. Id: {0}, Version: {1}.
        /// </summary>
        internal static string PackageEntryNotExist {
            get {
                return ResourceManager.GetString("PackageEntryNotExist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The &apos;{0}&apos; package requires NuGet client version &apos;{1}&apos; or above, but the current NuGet version is &apos;{2}&apos;. To upgrade NuGet, please go to http://docs.nuget.org/consume/installing-nuget.
        /// </summary>
        internal static string PackageMinVersionNotSatisfied {
            get {
                return ResourceManager.GetString("PackageMinVersionNotSatisfied", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Packages node does not exists in packages.config at {0}..
        /// </summary>
        internal static string PackagesNodeNotExist {
            get {
                return ResourceManager.GetString("PackagesNodeNotExist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Package stream should be seekable.
        /// </summary>
        internal static string PackageStreamShouldBeSeekable {
            get {
                return ResourceManager.GetString("PackageStreamShouldBeSeekable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Package signature contains an invalid attribute: {0}.
        /// </summary>
        internal static string SignatureContainsInvalidAttribute {
            get {
                return ResourceManager.GetString("SignatureContainsInvalidAttribute", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Signature hash oid found: {0}.
        /// </summary>
        internal static string SignatureDebug_HashOidFound {
            get {
                return ResourceManager.GetString("SignatureDebug_HashOidFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Signature response does not contain an acceptable hash algorithm..
        /// </summary>
        internal static string SignatureFailureInvalidHashAlgorithmOid {
            get {
                return ResourceManager.GetString("SignatureFailureInvalidHashAlgorithmOid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Signature Hash Algorithm: {0}.
        /// </summary>
        internal static string SignatureHashAlgorithm {
            get {
                return ResourceManager.GetString("SignatureHashAlgorithm", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Package integrity check failed..
        /// </summary>
        internal static string SignaturePackageIntegrityFailure {
            get {
                return ResourceManager.GetString("SignaturePackageIntegrityFailure", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Signature type: {0}.
        /// </summary>
        internal static string SignatureType {
            get {
                return ResourceManager.GetString("SignatureType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The package is not signed. Unable to remove signature from an unsigned package..
        /// </summary>
        internal static string SignedPackageNotSignedOnRemove {
            get {
                return ResourceManager.GetString("SignedPackageNotSignedOnRemove", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The package is not signed. Unable to verify signature from an unsigned package..
        /// </summary>
        internal static string SignedPackageNotSignedOnVerify {
            get {
                return ResourceManager.GetString("SignedPackageNotSignedOnVerify", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The package already contains a signature. Please remove the existing signature before adding a new signature..
        /// </summary>
        internal static string SignedPackagePackageAlreadySigned {
            get {
                return ResourceManager.GetString("SignedPackagePackageAlreadySigned", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The package was not opened correctly to perform Signature operations. Please use a Stream based constructor to have access to Signature attributes of the package..
        /// </summary>
        internal static string SignedPackageUnableToAccessSignature {
            get {
                return ResourceManager.GetString("SignedPackageUnableToAccessSignature", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The following certificate cannot be used for package signing as the private key provider is unsupported:.
        /// </summary>
        internal static string SignFailureCertificateInvalidProviderType {
            get {
                return ResourceManager.GetString("SignFailureCertificateInvalidProviderType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to signing-certificate-v2 attribute value does not match the current certificate chain..
        /// </summary>
        internal static string SigningCertificateV2Invalid {
            get {
                return ResourceManager.GetString("SigningCertificateV2Invalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to String argument &apos;{0}&apos; cannot be null or empty.
        /// </summary>
        internal static string StringCannotBeNullOrEmpty {
            get {
                return ResourceManager.GetString("StringCannotBeNullOrEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The timestamp service&apos;s certificate chain could not be built for the following certificate:.
        /// </summary>
        internal static string TimestampCertificateChainBuildFailure {
            get {
                return ResourceManager.GetString("TimestampCertificateChainBuildFailure", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The timestamp service&apos;s certificate has a valid time in the future. -
        ///{0}.
        /// </summary>
        internal static string TimestampCertificateInvalid {
            get {
                return ResourceManager.GetString("TimestampCertificateInvalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Author certificate was not valid when it was timestamped..
        /// </summary>
        internal static string TimestampFailureAuthorCertNotValid {
            get {
                return ResourceManager.GetString("TimestampFailureAuthorCertNotValid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Timestamp service&apos;s certificate does not contain a valid Enhanced Key Usage for timestamping..
        /// </summary>
        internal static string TimestampFailureCertInvalidEku {
            get {
                return ResourceManager.GetString("TimestampFailureCertInvalidEku", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Timestamp signature contains invalid content type..
        /// </summary>
        internal static string TimestampFailureInvalidContentType {
            get {
                return ResourceManager.GetString("TimestampFailureInvalidContentType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Timestamp response contains invalid signature value hash..
        /// </summary>
        internal static string TimestampFailureInvalidHash {
            get {
                return ResourceManager.GetString("TimestampFailureInvalidHash", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Timestamp response does not contain an acceptable hash algorithm..
        /// </summary>
        internal static string TimestampFailureInvalidHashAlgorithmOid {
            get {
                return ResourceManager.GetString("TimestampFailureInvalidHashAlgorithmOid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The timestamper url &apos;{0}&apos; has an invalid uri scheme. The supported schemes are &apos;{1}&apos; and &apos;{2}&apos;..
        /// </summary>
        internal static string TimestampFailureInvalidHttpScheme {
            get {
                return ResourceManager.GetString("TimestampFailureInvalidHttpScheme", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Timestamp response does not contain a matching response..
        /// </summary>
        internal static string TimestampFailureNonceMismatch {
            get {
                return ResourceManager.GetString("TimestampFailureNonceMismatch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The signature contains an invalid timestamp..
        /// </summary>
        internal static string TimestampInvalid {
            get {
                return ResourceManager.GetString("TimestampInvalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Timestamp service&apos;s response does not meet the NuGet package signature specification: &apos;{0}&apos;..
        /// </summary>
        internal static string TimestampResponseExceptionGeneral {
            get {
                return ResourceManager.GetString("TimestampResponseExceptionGeneral", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Timestamp: {0}.
        /// </summary>
        internal static string TimestampValue {
            get {
                return ResourceManager.GetString("TimestampValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error occurred while updating packages.config. The file was closed before the entry could be added..
        /// </summary>
        internal static string UnableToAddEntry {
            get {
                return ResourceManager.GetString("UnableToAddEntry", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to parse the current NuGet client version..
        /// </summary>
        internal static string UnableToParseClientVersion {
            get {
                return ResourceManager.GetString("UnableToParseClientVersion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Package hash information could not be read from the package signature..
        /// </summary>
        internal static string UnableToReadPackageHashInformation {
            get {
                return ResourceManager.GetString("UnableToReadPackageHashInformation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The package signature format version is unsupported.  Updating your client may solve this problem..
        /// </summary>
        internal static string UnsupportedSignatureFormatVersion {
            get {
                return ResourceManager.GetString("UnsupportedSignatureFormatVersion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Verifying signature with author certificate: {0}.
        /// </summary>
        internal static string VerificationAuthorCertDisplay {
            get {
                return ResourceManager.GetString("VerificationAuthorCertDisplay", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Verifying signature with certificate: {0}.
        /// </summary>
        internal static string VerificationDefaultCertDisplay {
            get {
                return ResourceManager.GetString("VerificationDefaultCertDisplay", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Verifying timestamp with timestamping service certificate: {0}.
        /// </summary>
        internal static string VerificationTimestamperCertDisplay {
            get {
                return ResourceManager.GetString("VerificationTimestamperCertDisplay", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not check revocation status of signing certificate online..
        /// </summary>
        internal static string WarningOfflineRevocationCheck {
            get {
                return ResourceManager.GetString("WarningOfflineRevocationCheck", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not validate signature. Unknown signature type..
        /// </summary>
        internal static string WarningUnknownSignatureType {
            get {
                return ResourceManager.GetString("WarningUnknownSignatureType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Signing certificate does not chain to a trusted root..
        /// </summary>
        internal static string WarningUntrustedRoot {
            get {
                return ResourceManager.GetString("WarningUntrustedRoot", resourceCulture);
            }
        }
    }
}
