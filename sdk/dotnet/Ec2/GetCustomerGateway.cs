// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Ec2
{
    public static class GetCustomerGateway
    {
        /// <summary>
        /// Get an existing AWS Customer Gateway.
        /// 
        /// {{% examples %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetCustomerGatewayResult> InvokeAsync(GetCustomerGatewayArgs? args = null, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetCustomerGatewayResult>("aws:ec2/getCustomerGateway:getCustomerGateway", args ?? new GetCustomerGatewayArgs(), options.WithVersion());
    }


    public sealed class GetCustomerGatewayArgs : Pulumi.InvokeArgs
    {
        [Input("filters")]
        private List<Inputs.GetCustomerGatewayFilterArgs>? _filters;

        /// <summary>
        /// One or more [name-value pairs][dcg-filters] to filter by.
        /// </summary>
        public List<Inputs.GetCustomerGatewayFilterArgs> Filters
        {
            get => _filters ?? (_filters = new List<Inputs.GetCustomerGatewayFilterArgs>());
            set => _filters = value;
        }

        /// <summary>
        /// The ID of the gateway.
        /// </summary>
        [Input("id")]
        public string? Id { get; set; }

        [Input("tags")]
        private Dictionary<string, object>? _tags;

        /// <summary>
        /// Map of key-value pairs assigned to the gateway.
        /// </summary>
        public Dictionary<string, object> Tags
        {
            get => _tags ?? (_tags = new Dictionary<string, object>());
            set => _tags = value;
        }

        public GetCustomerGatewayArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetCustomerGatewayResult
    {
        /// <summary>
        /// (Optional) The gateway's Border Gateway Protocol (BGP) Autonomous System Number (ASN).
        /// </summary>
        public readonly int BgpAsn;
        public readonly ImmutableArray<Outputs.GetCustomerGatewayFilterResult> Filters;
        public readonly string? Id;
        /// <summary>
        /// (Optional) The IP address of the gateway's Internet-routable external interface.
        /// </summary>
        public readonly string IpAddress;
        /// <summary>
        /// Map of key-value pairs assigned to the gateway.
        /// </summary>
        public readonly ImmutableDictionary<string, object> Tags;
        /// <summary>
        /// (Optional) The type of customer gateway. The only type AWS supports at this time is "ipsec.1".
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private GetCustomerGatewayResult(
            int bgpAsn,

            ImmutableArray<Outputs.GetCustomerGatewayFilterResult> filters,

            string? id,

            string ipAddress,

            ImmutableDictionary<string, object> tags,

            string type)
        {
            BgpAsn = bgpAsn;
            Filters = filters;
            Id = id;
            IpAddress = ipAddress;
            Tags = tags;
            Type = type;
        }
    }
}
