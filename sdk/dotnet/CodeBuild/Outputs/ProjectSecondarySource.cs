// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.CodeBuild.Outputs
{

    [OutputType]
    public sealed class ProjectSecondarySource
    {
        /// <summary>
        /// Information about the authorization settings for AWS CodeBuild to access the source code to be built. Auth blocks are documented below.
        /// </summary>
        public readonly ImmutableArray<Outputs.ProjectSecondarySourceAuth> Auths;
        /// <summary>
        /// The build spec declaration to use for this build project's related builds.
        /// </summary>
        public readonly string? Buildspec;
        /// <summary>
        /// Truncate git history to this many commits.
        /// </summary>
        public readonly int? GitCloneDepth;
        /// <summary>
        /// Information about the Git submodules configuration for an AWS CodeBuild build project. Git submodules config blocks are documented below. This option is only valid when the `type` is `CODECOMMIT`.
        /// </summary>
        public readonly Outputs.ProjectSecondarySourceGitSubmodulesConfig? GitSubmodulesConfig;
        /// <summary>
        /// Ignore SSL warnings when connecting to source control.
        /// </summary>
        public readonly bool? InsecureSsl;
        /// <summary>
        /// The location of the source code from git or s3.
        /// </summary>
        public readonly string? Location;
        /// <summary>
        /// Set to `true` to report the status of a build's start and finish to your source provider. This option is only valid when your source provider is `GITHUB`, `BITBUCKET`, or `GITHUB_ENTERPRISE`.
        /// </summary>
        public readonly bool? ReportBuildStatus;
        /// <summary>
        /// The source identifier. Source data will be put inside a folder named as this parameter inside AWS CodeBuild source directory
        /// </summary>
        public readonly string SourceIdentifier;
        /// <summary>
        /// The type of repository that contains the source code to be built. Valid values for this parameter are: `CODECOMMIT`, `CODEPIPELINE`, `GITHUB`, `GITHUB_ENTERPRISE`, `BITBUCKET` or `S3`.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private ProjectSecondarySource(
            ImmutableArray<Outputs.ProjectSecondarySourceAuth> auths,

            string? buildspec,

            int? gitCloneDepth,

            Outputs.ProjectSecondarySourceGitSubmodulesConfig? gitSubmodulesConfig,

            bool? insecureSsl,

            string? location,

            bool? reportBuildStatus,

            string sourceIdentifier,

            string type)
        {
            Auths = auths;
            Buildspec = buildspec;
            GitCloneDepth = gitCloneDepth;
            GitSubmodulesConfig = gitSubmodulesConfig;
            InsecureSsl = insecureSsl;
            Location = location;
            ReportBuildStatus = reportBuildStatus;
            SourceIdentifier = sourceIdentifier;
            Type = type;
        }
    }
}
