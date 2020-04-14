// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Glue.Inputs
{

    public sealed class CatalogTablePartitionKeyGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Free-form text comment.
        /// </summary>
        [Input("comment")]
        public Input<string>? Comment { get; set; }

        /// <summary>
        /// Name of the SerDe.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        /// <summary>
        /// The datatype of data in the Column.
        /// </summary>
        [Input("type")]
        public Input<string>? Type { get; set; }

        public CatalogTablePartitionKeyGetArgs()
        {
        }
    }
}
