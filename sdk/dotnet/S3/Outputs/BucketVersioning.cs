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
    public sealed class BucketVersioning
    {
        /// <summary>
        /// Enable versioning. Once you version-enable a bucket, it can never return to an unversioned state. You can, however, suspend versioning on that bucket.
        /// </summary>
        public readonly bool? Enabled;
        /// <summary>
        /// Enable MFA delete for either `Change the versioning state of your bucket` or `Permanently delete an object version`. Default is `false`.
        /// </summary>
        public readonly bool? MfaDelete;

        [OutputConstructor]
        private BucketVersioning(
            bool? enabled,

            bool? mfaDelete)
        {
            Enabled = enabled;
            MfaDelete = mfaDelete;
        }
    }
}
