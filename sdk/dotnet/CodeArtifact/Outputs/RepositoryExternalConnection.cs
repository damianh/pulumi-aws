// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.CodeArtifact.Outputs
{

    [OutputType]
    public sealed class RepositoryExternalConnection
    {
        /// <summary>
        /// The name of the external connection associated with a repository.
        /// </summary>
        public readonly string? ExternalConnectionName;
        /// <summary>
        /// The package format associated with a repository's external connection.
        /// </summary>
        public readonly string? PackageFormat;
        /// <summary>
        /// The status of the external connection of a repository.
        /// </summary>
        public readonly string? Status;

        [OutputConstructor]
        private RepositoryExternalConnection(
            string? externalConnectionName,

            string? packageFormat,

            string? status)
        {
            ExternalConnectionName = externalConnectionName;
            PackageFormat = packageFormat;
            Status = status;
        }
    }
}
