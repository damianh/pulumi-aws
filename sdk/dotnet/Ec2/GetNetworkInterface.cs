// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Ec2
{
    public static class GetNetworkInterface
    {
        /// <summary>
        /// Use this data source to get information about a Network Interface.
        /// 
        /// {{% examples %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetNetworkInterfaceResult> InvokeAsync(GetNetworkInterfaceArgs? args = null, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetNetworkInterfaceResult>("aws:ec2/getNetworkInterface:getNetworkInterface", args ?? new GetNetworkInterfaceArgs(), options.WithVersion());
    }


    public sealed class GetNetworkInterfaceArgs : Pulumi.InvokeArgs
    {
        [Input("filters")]
        private List<Inputs.GetNetworkInterfaceFilterArgs>? _filters;

        /// <summary>
        /// One or more name/value pairs to filter off of. There are several valid keys, for a full reference, check out [describe-network-interfaces](https://docs.aws.amazon.com/cli/latest/reference/ec2/describe-network-interfaces.html) in the AWS CLI reference.
        /// </summary>
        public List<Inputs.GetNetworkInterfaceFilterArgs> Filters
        {
            get => _filters ?? (_filters = new List<Inputs.GetNetworkInterfaceFilterArgs>());
            set => _filters = value;
        }

        /// <summary>
        /// The identifier for the network interface.
        /// </summary>
        [Input("id")]
        public string? Id { get; set; }

        [Input("tags")]
        private Dictionary<string, object>? _tags;

        /// <summary>
        /// Any tags assigned to the network interface.
        /// </summary>
        public Dictionary<string, object> Tags
        {
            get => _tags ?? (_tags = new Dictionary<string, object>());
            set => _tags = value;
        }

        public GetNetworkInterfaceArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetNetworkInterfaceResult
    {
        /// <summary>
        /// The association information for an Elastic IP address (IPv4) associated with the network interface. See supported fields below.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetNetworkInterfaceAssociationResult> Associations;
        public readonly ImmutableArray<Outputs.GetNetworkInterfaceAttachmentResult> Attachments;
        /// <summary>
        /// The Availability Zone.
        /// </summary>
        public readonly string AvailabilityZone;
        /// <summary>
        /// Description of the network interface.
        /// </summary>
        public readonly string Description;
        public readonly ImmutableArray<Outputs.GetNetworkInterfaceFilterResult> Filters;
        public readonly string Id;
        /// <summary>
        /// The type of interface.
        /// </summary>
        public readonly string InterfaceType;
        /// <summary>
        /// List of IPv6 addresses to assign to the ENI.
        /// </summary>
        public readonly ImmutableArray<string> Ipv6Addresses;
        /// <summary>
        /// The MAC address.
        /// </summary>
        public readonly string MacAddress;
        /// <summary>
        /// The AWS account ID of the owner of the network interface.
        /// </summary>
        public readonly string OwnerId;
        /// <summary>
        /// The private DNS name.
        /// </summary>
        public readonly string PrivateDnsName;
        /// <summary>
        /// The private IPv4 address of the network interface within the subnet.
        /// </summary>
        public readonly string PrivateIp;
        /// <summary>
        /// The private IPv4 addresses associated with the network interface.
        /// </summary>
        public readonly ImmutableArray<string> PrivateIps;
        /// <summary>
        /// The ID of the entity that launched the instance on your behalf.
        /// </summary>
        public readonly string RequesterId;
        /// <summary>
        /// The list of security groups for the network interface.
        /// </summary>
        public readonly ImmutableArray<string> SecurityGroups;
        /// <summary>
        /// The ID of the subnet.
        /// </summary>
        public readonly string SubnetId;
        /// <summary>
        /// Any tags assigned to the network interface.
        /// </summary>
        public readonly ImmutableDictionary<string, object> Tags;
        /// <summary>
        /// The ID of the VPC.
        /// </summary>
        public readonly string VpcId;

        [OutputConstructor]
        private GetNetworkInterfaceResult(
            ImmutableArray<Outputs.GetNetworkInterfaceAssociationResult> associations,

            ImmutableArray<Outputs.GetNetworkInterfaceAttachmentResult> attachments,

            string availabilityZone,

            string description,

            ImmutableArray<Outputs.GetNetworkInterfaceFilterResult> filters,

            string id,

            string interfaceType,

            ImmutableArray<string> ipv6Addresses,

            string macAddress,

            string ownerId,

            string privateDnsName,

            string privateIp,

            ImmutableArray<string> privateIps,

            string requesterId,

            ImmutableArray<string> securityGroups,

            string subnetId,

            ImmutableDictionary<string, object> tags,

            string vpcId)
        {
            Associations = associations;
            Attachments = attachments;
            AvailabilityZone = availabilityZone;
            Description = description;
            Filters = filters;
            Id = id;
            InterfaceType = interfaceType;
            Ipv6Addresses = ipv6Addresses;
            MacAddress = macAddress;
            OwnerId = ownerId;
            PrivateDnsName = privateDnsName;
            PrivateIp = privateIp;
            PrivateIps = privateIps;
            RequesterId = requesterId;
            SecurityGroups = securityGroups;
            SubnetId = subnetId;
            Tags = tags;
            VpcId = vpcId;
        }
    }
}
