// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Kinesis.Inputs
{

    public sealed class AnalyticsApplicationOutputGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The ARN of the Kinesis Analytics Application.
        /// </summary>
        [Input("id")]
        public Input<string>? Id { get; set; }

        /// <summary>
        /// The Kinesis Firehose configuration for the destination stream. Conflicts with `kinesis_stream`.
        /// See Kinesis Firehose below for more details.
        /// </summary>
        [Input("kinesisFirehose")]
        public Input<Inputs.AnalyticsApplicationOutputKinesisFirehoseGetArgs>? KinesisFirehose { get; set; }

        /// <summary>
        /// The Kinesis Stream configuration for the destination stream. Conflicts with `kinesis_firehose`.
        /// See Kinesis Stream below for more details.
        /// </summary>
        [Input("kinesisStream")]
        public Input<Inputs.AnalyticsApplicationOutputKinesisStreamGetArgs>? KinesisStream { get; set; }

        /// <summary>
        /// The Lambda function destination. See Lambda below for more details.
        /// </summary>
        [Input("lambda")]
        public Input<Inputs.AnalyticsApplicationOutputLambdaGetArgs>? Lambda { get; set; }

        /// <summary>
        /// The Name of the in-application stream.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        /// <summary>
        /// The Schema format of the data written to the destination. See Destination Schema below for more details.
        /// </summary>
        [Input("schema", required: true)]
        public Input<Inputs.AnalyticsApplicationOutputSchemaGetArgs> Schema { get; set; } = null!;

        public AnalyticsApplicationOutputGetArgs()
        {
        }
    }
}
