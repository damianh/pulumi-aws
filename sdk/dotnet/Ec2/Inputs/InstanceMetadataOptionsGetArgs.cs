// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Ec2.Inputs
{

    public sealed class InstanceMetadataOptionsGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Whether the metadata service is available. Can be `"enabled"` or `"disabled"`. (Default: `"enabled"`).
        /// </summary>
        [Input("httpEndpoint")]
        public Input<string>? HttpEndpoint { get; set; }

        /// <summary>
        /// The desired HTTP PUT response hop limit for instance metadata requests. The larger the number, the further instance metadata requests can travel. Can be an integer from `1` to `64`. (Default: `1`).
        /// </summary>
        [Input("httpPutResponseHopLimit")]
        public Input<int>? HttpPutResponseHopLimit { get; set; }

        /// <summary>
        /// Whether or not the metadata service requires session tokens, also referred to as _Instance Metadata Service Version 2_. Can be `"optional"` or `"required"`. (Default: `"optional"`).
        /// </summary>
        [Input("httpTokens")]
        public Input<string>? HttpTokens { get; set; }

        public InstanceMetadataOptionsGetArgs()
        {
        }
    }
}
