// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Ec2.Inputs
{

    public sealed class PeeringConnectionOptionsAccepterGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Allow a local linked EC2-Classic instance to communicate
        /// with instances in a peer VPC. This enables an outbound communication from the local ClassicLink connection
        /// to the remote VPC. This option is not supported for inter-region VPC peering.
        /// </summary>
        [Input("allowClassicLinkToRemoteVpc")]
        public Input<bool>? AllowClassicLinkToRemoteVpc { get; set; }

        /// <summary>
        /// Allow a local VPC to resolve public DNS hostnames to
        /// private IP addresses when queried from instances in the peer VPC.
        /// </summary>
        [Input("allowRemoteVpcDnsResolution")]
        public Input<bool>? AllowRemoteVpcDnsResolution { get; set; }

        /// <summary>
        /// Allow a local VPC to communicate with a linked EC2-Classic
        /// instance in a peer VPC. This enables an outbound communication from the local VPC to the remote ClassicLink
        /// connection. This option is not supported for inter-region VPC peering.
        /// </summary>
        [Input("allowVpcToRemoteClassicLink")]
        public Input<bool>? AllowVpcToRemoteClassicLink { get; set; }

        public PeeringConnectionOptionsAccepterGetArgs()
        {
        }
    }
}
