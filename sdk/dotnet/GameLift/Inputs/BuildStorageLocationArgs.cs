// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.GameLift.Inputs
{

    public sealed class BuildStorageLocationArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Name of your S3 bucket.
        /// </summary>
        [Input("bucket", required: true)]
        public Input<string> Bucket { get; set; } = null!;

        /// <summary>
        /// Name of the zip file containing your build files.
        /// </summary>
        [Input("key", required: true)]
        public Input<string> Key { get; set; } = null!;

        /// <summary>
        /// ARN of the access role that allows Amazon GameLift to access your S3 bucket.
        /// </summary>
        [Input("roleArn", required: true)]
        public Input<string> RoleArn { get; set; } = null!;

        public BuildStorageLocationArgs()
        {
        }
    }
}
