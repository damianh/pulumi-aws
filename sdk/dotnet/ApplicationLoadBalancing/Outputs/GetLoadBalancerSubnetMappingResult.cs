// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.ApplicationLoadBalancing.Outputs
{

    [OutputType]
    public sealed class GetLoadBalancerSubnetMappingResult
    {
        public readonly string? AllocationId;
        public readonly string SubnetId;

        [OutputConstructor]
        private GetLoadBalancerSubnetMappingResult(
            string? allocationId,

            string subnetId)
        {
            AllocationId = allocationId;
            SubnetId = subnetId;
        }
    }
}
