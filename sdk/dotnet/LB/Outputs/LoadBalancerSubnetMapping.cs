// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.LB.Outputs
{

    [OutputType]
    public sealed class LoadBalancerSubnetMapping
    {
        /// <summary>
        /// The allocation ID of the Elastic IP address.
        /// </summary>
        public readonly string? AllocationId;
        /// <summary>
        /// The id of the subnet of which to attach to the load balancer. You can specify only one subnet per Availability Zone.
        /// </summary>
        public readonly string SubnetId;

        [OutputConstructor]
        private LoadBalancerSubnetMapping(
            string? allocationId,

            string subnetId)
        {
            AllocationId = allocationId;
            SubnetId = subnetId;
        }
    }
}
