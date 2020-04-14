// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Kinesis.Inputs
{

    public sealed class FirehoseDeliveryStreamSplunkConfigurationArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The CloudWatch Logging Options for the delivery stream. More details are given below.
        /// </summary>
        [Input("cloudwatchLoggingOptions")]
        public Input<Inputs.FirehoseDeliveryStreamSplunkConfigurationCloudwatchLoggingOptionsArgs>? CloudwatchLoggingOptions { get; set; }

        /// <summary>
        /// The amount of time, in seconds between 180 and 600, that Kinesis Firehose waits to receive an acknowledgment from Splunk after it sends it data.
        /// </summary>
        [Input("hecAcknowledgmentTimeout")]
        public Input<int>? HecAcknowledgmentTimeout { get; set; }

        /// <summary>
        /// The HTTP Event Collector (HEC) endpoint to which Kinesis Firehose sends your data.
        /// </summary>
        [Input("hecEndpoint", required: true)]
        public Input<string> HecEndpoint { get; set; } = null!;

        /// <summary>
        /// The HEC endpoint type. Valid values are `Raw` or `Event`. The default value is `Raw`.
        /// </summary>
        [Input("hecEndpointType")]
        public Input<string>? HecEndpointType { get; set; }

        /// <summary>
        /// The GUID that you obtain from your Splunk cluster when you create a new HEC endpoint.
        /// </summary>
        [Input("hecToken", required: true)]
        public Input<string> HecToken { get; set; } = null!;

        /// <summary>
        /// The data processing configuration.  More details are given below.
        /// </summary>
        [Input("processingConfiguration")]
        public Input<Inputs.FirehoseDeliveryStreamSplunkConfigurationProcessingConfigurationArgs>? ProcessingConfiguration { get; set; }

        /// <summary>
        /// After an initial failure to deliver to Splunk, the total amount of time, in seconds between 0 to 7200, during which Firehose re-attempts delivery (including the first attempt).  After this time has elapsed, the failed documents are written to Amazon S3.  The default value is 300s.  There will be no retry if the value is 0.
        /// </summary>
        [Input("retryDuration")]
        public Input<int>? RetryDuration { get; set; }

        /// <summary>
        /// Defines how documents should be delivered to Amazon S3.  Valid values are `FailedEventsOnly` and `AllEvents`.  Default value is `FailedEventsOnly`.
        /// </summary>
        [Input("s3BackupMode")]
        public Input<string>? S3BackupMode { get; set; }

        public FirehoseDeliveryStreamSplunkConfigurationArgs()
        {
        }
    }
}
