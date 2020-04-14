// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Ec2.Outputs
{

    [OutputType]
    public sealed class LaunchTemplatePlacement
    {
        /// <summary>
        /// The affinity setting for an instance on a Dedicated Host.
        /// </summary>
        public readonly string? Affinity;
        /// <summary>
        /// The Availability Zone for the instance.
        /// </summary>
        public readonly string? AvailabilityZone;
        /// <summary>
        /// The name of the placement group for the instance.
        /// </summary>
        public readonly string? GroupName;
        /// <summary>
        /// The ID of the Dedicated Host for the instance.
        /// </summary>
        public readonly string? HostId;
        /// <summary>
        /// Reserved for future use.
        /// </summary>
        public readonly string? SpreadDomain;
        /// <summary>
        /// The tenancy of the instance (if the instance is running in a VPC). Can be `default`, `dedicated`, or `host`.
        /// </summary>
        public readonly string? Tenancy;

        [OutputConstructor]
        private LaunchTemplatePlacement(
            string? affinity,

            string? availabilityZone,

            string? groupName,

            string? hostId,

            string? spreadDomain,

            string? tenancy)
        {
            Affinity = affinity;
            AvailabilityZone = availabilityZone;
            GroupName = groupName;
            HostId = hostId;
            SpreadDomain = spreadDomain;
            Tenancy = tenancy;
        }
    }
}
