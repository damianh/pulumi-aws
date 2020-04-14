// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Kinesis.Inputs
{

    public sealed class FirehoseDeliveryStreamRedshiftConfigurationS3BackupConfigurationArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The ARN of the S3 bucket
        /// </summary>
        [Input("bucketArn", required: true)]
        public Input<string> BucketArn { get; set; } = null!;

        /// <summary>
        /// Buffer incoming data for the specified period of time, in seconds, before delivering it to the destination. The default value is 300.
        /// </summary>
        [Input("bufferInterval")]
        public Input<int>? BufferInterval { get; set; }

        /// <summary>
        /// Buffer incoming data to the specified size, in MBs, before delivering it to the destination. The default value is 5.
        /// We recommend setting SizeInMBs to a value greater than the amount of data you typically ingest into the delivery stream in 10 seconds. For example, if you typically ingest data at 1 MB/sec set SizeInMBs to be 10 MB or higher.
        /// </summary>
        [Input("bufferSize")]
        public Input<int>? BufferSize { get; set; }

        /// <summary>
        /// The CloudWatch Logging Options for the delivery stream. More details are given below
        /// </summary>
        [Input("cloudwatchLoggingOptions")]
        public Input<Inputs.FirehoseDeliveryStreamRedshiftConfigurationS3BackupConfigurationCloudwatchLoggingOptionsArgs>? CloudwatchLoggingOptions { get; set; }

        /// <summary>
        /// The compression format. If no value is specified, the default is UNCOMPRESSED. Other supported values are GZIP, ZIP &amp; Snappy. If the destination is redshift you cannot use ZIP or Snappy.
        /// </summary>
        [Input("compressionFormat")]
        public Input<string>? CompressionFormat { get; set; }

        /// <summary>
        /// Specifies the KMS key ARN the stream will use to encrypt data. If not set, no encryption will
        /// be used.
        /// </summary>
        [Input("kmsKeyArn")]
        public Input<string>? KmsKeyArn { get; set; }

        /// <summary>
        /// The "YYYY/MM/DD/HH" time format prefix is automatically used for delivered S3 files. You can specify an extra prefix to be added in front of the time format prefix. Note that if the prefix ends with a slash, it appears as a folder in the S3 bucket
        /// </summary>
        [Input("prefix")]
        public Input<string>? Prefix { get; set; }

        /// <summary>
        /// The role that Kinesis Data Firehose can use to access AWS Glue. This role must be in the same account you use for Kinesis Data Firehose. Cross-account roles aren't allowed.
        /// </summary>
        [Input("roleArn", required: true)]
        public Input<string> RoleArn { get; set; } = null!;

        public FirehoseDeliveryStreamRedshiftConfigurationS3BackupConfigurationArgs()
        {
        }
    }
}
