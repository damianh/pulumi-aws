// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Kinesis.Inputs
{

    public sealed class FirehoseDeliveryStreamRedshiftConfigurationGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The CloudWatch Logging Options for the delivery stream. More details are given below
        /// </summary>
        [Input("cloudwatchLoggingOptions")]
        public Input<Inputs.FirehoseDeliveryStreamRedshiftConfigurationCloudwatchLoggingOptionsGetArgs>? CloudwatchLoggingOptions { get; set; }

        /// <summary>
        /// The jdbcurl of the redshift cluster.
        /// </summary>
        [Input("clusterJdbcurl", required: true)]
        public Input<string> ClusterJdbcurl { get; set; } = null!;

        /// <summary>
        /// Copy options for copying the data from the s3 intermediate bucket into redshift, for example to change the default delimiter. For valid values, see the [AWS documentation](http://docs.aws.amazon.com/firehose/latest/APIReference/API_CopyCommand.html)
        /// </summary>
        [Input("copyOptions")]
        public Input<string>? CopyOptions { get; set; }

        /// <summary>
        /// The data table columns that will be targeted by the copy command.
        /// </summary>
        [Input("dataTableColumns")]
        public Input<string>? DataTableColumns { get; set; }

        /// <summary>
        /// The name of the table in the redshift cluster that the s3 bucket will copy to.
        /// </summary>
        [Input("dataTableName", required: true)]
        public Input<string> DataTableName { get; set; } = null!;

        /// <summary>
        /// The password for the username above.
        /// </summary>
        [Input("password", required: true)]
        public Input<string> Password { get; set; } = null!;

        /// <summary>
        /// The data processing configuration.  More details are given below.
        /// </summary>
        [Input("processingConfiguration")]
        public Input<Inputs.FirehoseDeliveryStreamRedshiftConfigurationProcessingConfigurationGetArgs>? ProcessingConfiguration { get; set; }

        /// <summary>
        /// The length of time during which Firehose retries delivery after a failure, starting from the initial request and including the first attempt. The default value is 3600 seconds (60 minutes). Firehose does not retry if the value of DurationInSeconds is 0 (zero) or if the first delivery attempt takes longer than the current value.
        /// </summary>
        [Input("retryDuration")]
        public Input<int>? RetryDuration { get; set; }

        /// <summary>
        /// The arn of the role the stream assumes.
        /// </summary>
        [Input("roleArn", required: true)]
        public Input<string> RoleArn { get; set; } = null!;

        /// <summary>
        /// The configuration for backup in Amazon S3. Required if `s3_backup_mode` is `Enabled`. Supports the same fields as `s3_configuration` object.
        /// </summary>
        [Input("s3BackupConfiguration")]
        public Input<Inputs.FirehoseDeliveryStreamRedshiftConfigurationS3BackupConfigurationGetArgs>? S3BackupConfiguration { get; set; }

        /// <summary>
        /// The Amazon S3 backup mode.  Valid values are `Disabled` and `Enabled`.  Default value is `Disabled`.
        /// </summary>
        [Input("s3BackupMode")]
        public Input<string>? S3BackupMode { get; set; }

        /// <summary>
        /// The username that the firehose delivery stream will assume. It is strongly recommended that the username and password provided is used exclusively for Amazon Kinesis Firehose purposes, and that the permissions for the account are restricted for Amazon Redshift INSERT permissions.
        /// </summary>
        [Input("username", required: true)]
        public Input<string> Username { get; set; } = null!;

        public FirehoseDeliveryStreamRedshiftConfigurationGetArgs()
        {
        }
    }
}
