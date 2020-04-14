// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.GameLift.Outputs
{

    [OutputType]
    public sealed class BuildStorageLocation
    {
        /// <summary>
        /// Name of your S3 bucket.
        /// </summary>
        public readonly string Bucket;
        /// <summary>
        /// Name of the zip file containing your build files.
        /// </summary>
        public readonly string Key;
        /// <summary>
        /// ARN of the access role that allows Amazon GameLift to access your S3 bucket.
        /// </summary>
        public readonly string RoleArn;

        [OutputConstructor]
        private BuildStorageLocation(
            string bucket,

            string key,

            string roleArn)
        {
            Bucket = bucket;
            Key = key;
            RoleArn = roleArn;
        }
    }
}
