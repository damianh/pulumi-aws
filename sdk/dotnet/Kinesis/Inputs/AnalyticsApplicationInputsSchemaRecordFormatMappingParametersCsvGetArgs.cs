// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Kinesis.Inputs
{

    public sealed class AnalyticsApplicationInputsSchemaRecordFormatMappingParametersCsvGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The Column Delimiter.
        /// </summary>
        [Input("recordColumnDelimiter", required: true)]
        public Input<string> RecordColumnDelimiter { get; set; } = null!;

        /// <summary>
        /// The Row Delimiter.
        /// </summary>
        [Input("recordRowDelimiter", required: true)]
        public Input<string> RecordRowDelimiter { get; set; } = null!;

        public AnalyticsApplicationInputsSchemaRecordFormatMappingParametersCsvGetArgs()
        {
        }
    }
}
