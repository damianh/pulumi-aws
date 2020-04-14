// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.S3.Outputs
{

    [OutputType]
    public sealed class BucketGrant
    {
        /// <summary>
        /// Canonical user id to grant for. Used only when `type` is `CanonicalUser`.  
        /// </summary>
        public readonly string? Id;
        /// <summary>
        /// List of permissions to apply for grantee. Valid values are `READ`, `WRITE`, `READ_ACP`, `WRITE_ACP`, `FULL_CONTROL`.
        /// </summary>
        public readonly ImmutableArray<string> Permissions;
        /// <summary>
        /// - Type of grantee to apply for. Valid values are `CanonicalUser` and `Group`. `AmazonCustomerByEmail` is not supported.
        /// </summary>
        public readonly string Type;
        /// <summary>
        /// Uri address to grant for. Used only when `type` is `Group`.
        /// </summary>
        public readonly string? Uri;

        [OutputConstructor]
        private BucketGrant(
            string? id,

            ImmutableArray<string> permissions,

            string type,

            string? uri)
        {
            Id = id;
            Permissions = permissions;
            Type = type;
            Uri = uri;
        }
    }
}
