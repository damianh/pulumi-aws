// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Kinesis.Inputs
{

    public sealed class FirehoseDeliveryStreamRedshiftConfigurationS3BackupConfigurationCloudwatchLoggingOptionsGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Enables or disables the logging. Defaults to `false`.
        /// </summary>
        [Input("enabled")]
        public Input<bool>? Enabled { get; set; }

        /// <summary>
        /// The CloudWatch group name for logging. This value is required if `enabled` is true.
        /// </summary>
        [Input("logGroupName")]
        public Input<string>? LogGroupName { get; set; }

        /// <summary>
        /// The CloudWatch log stream name for logging. This value is required if `enabled` is true.
        /// </summary>
        [Input("logStreamName")]
        public Input<string>? LogStreamName { get; set; }

        public FirehoseDeliveryStreamRedshiftConfigurationS3BackupConfigurationCloudwatchLoggingOptionsGetArgs()
        {
        }
    }
}
