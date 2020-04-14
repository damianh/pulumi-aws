// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Glue.Inputs
{

    public sealed class CrawlerSchemaChangePolicyGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The deletion behavior when the crawler finds a deleted object. Valid values: `LOG`, `DELETE_FROM_DATABASE`, or `DEPRECATE_IN_DATABASE`. Defaults to `DEPRECATE_IN_DATABASE`.
        /// </summary>
        [Input("deleteBehavior")]
        public Input<string>? DeleteBehavior { get; set; }

        /// <summary>
        /// The update behavior when the crawler finds a changed schema. Valid values: `LOG` or `UPDATE_IN_DATABASE`. Defaults to `UPDATE_IN_DATABASE`.
        /// </summary>
        [Input("updateBehavior")]
        public Input<string>? UpdateBehavior { get; set; }

        public CrawlerSchemaChangePolicyGetArgs()
        {
        }
    }
}
