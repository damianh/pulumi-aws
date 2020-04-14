// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Kinesis.Inputs
{

    public sealed class AnalyticsApplicationInputsSchemaRecordColumnArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The Mapping reference to the data element.
        /// </summary>
        [Input("mapping")]
        public Input<string>? Mapping { get; set; }

        /// <summary>
        /// Name of the column.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        /// <summary>
        /// The SQL Type of the column.
        /// </summary>
        [Input("sqlType", required: true)]
        public Input<string> SqlType { get; set; } = null!;

        public AnalyticsApplicationInputsSchemaRecordColumnArgs()
        {
        }
    }
}
