// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Ec2.Inputs
{

    public sealed class SpotFleetRequestLaunchSpecificationGetArgs : Pulumi.ResourceArgs
    {
        [Input("ami", required: true)]
        public Input<string> Ami { get; set; } = null!;

        [Input("associatePublicIpAddress")]
        public Input<bool>? AssociatePublicIpAddress { get; set; }

        [Input("availabilityZone")]
        public Input<string>? AvailabilityZone { get; set; }

        [Input("ebsBlockDevices")]
        private InputList<Inputs.SpotFleetRequestLaunchSpecificationEbsBlockDeviceGetArgs>? _ebsBlockDevices;
        public InputList<Inputs.SpotFleetRequestLaunchSpecificationEbsBlockDeviceGetArgs> EbsBlockDevices
        {
            get => _ebsBlockDevices ?? (_ebsBlockDevices = new InputList<Inputs.SpotFleetRequestLaunchSpecificationEbsBlockDeviceGetArgs>());
            set => _ebsBlockDevices = value;
        }

        [Input("ebsOptimized")]
        public Input<bool>? EbsOptimized { get; set; }

        [Input("ephemeralBlockDevices")]
        private InputList<Inputs.SpotFleetRequestLaunchSpecificationEphemeralBlockDeviceGetArgs>? _ephemeralBlockDevices;
        public InputList<Inputs.SpotFleetRequestLaunchSpecificationEphemeralBlockDeviceGetArgs> EphemeralBlockDevices
        {
            get => _ephemeralBlockDevices ?? (_ephemeralBlockDevices = new InputList<Inputs.SpotFleetRequestLaunchSpecificationEphemeralBlockDeviceGetArgs>());
            set => _ephemeralBlockDevices = value;
        }

        [Input("iamInstanceProfile")]
        public Input<string>? IamInstanceProfile { get; set; }

        [Input("iamInstanceProfileArn")]
        public Input<string>? IamInstanceProfileArn { get; set; }

        [Input("instanceType", required: true)]
        public Input<string> InstanceType { get; set; } = null!;

        [Input("keyName")]
        public Input<string>? KeyName { get; set; }

        [Input("monitoring")]
        public Input<bool>? Monitoring { get; set; }

        [Input("placementGroup")]
        public Input<string>? PlacementGroup { get; set; }

        [Input("placementTenancy")]
        public Input<string>? PlacementTenancy { get; set; }

        [Input("rootBlockDevices")]
        private InputList<Inputs.SpotFleetRequestLaunchSpecificationRootBlockDeviceGetArgs>? _rootBlockDevices;
        public InputList<Inputs.SpotFleetRequestLaunchSpecificationRootBlockDeviceGetArgs> RootBlockDevices
        {
            get => _rootBlockDevices ?? (_rootBlockDevices = new InputList<Inputs.SpotFleetRequestLaunchSpecificationRootBlockDeviceGetArgs>());
            set => _rootBlockDevices = value;
        }

        /// <summary>
        /// The maximum bid price per unit hour.
        /// </summary>
        [Input("spotPrice")]
        public Input<string>? SpotPrice { get; set; }

        [Input("subnetId")]
        public Input<string>? SubnetId { get; set; }

        [Input("tags")]
        private InputMap<object>? _tags;

        /// <summary>
        /// A mapping of tags to assign to the resource.
        /// </summary>
        public InputMap<object> Tags
        {
            get => _tags ?? (_tags = new InputMap<object>());
            set => _tags = value;
        }

        [Input("userData")]
        public Input<string>? UserData { get; set; }

        [Input("vpcSecurityGroupIds")]
        private InputList<string>? _vpcSecurityGroupIds;
        public InputList<string> VpcSecurityGroupIds
        {
            get => _vpcSecurityGroupIds ?? (_vpcSecurityGroupIds = new InputList<string>());
            set => _vpcSecurityGroupIds = value;
        }

        [Input("weightedCapacity")]
        public Input<string>? WeightedCapacity { get; set; }

        public SpotFleetRequestLaunchSpecificationGetArgs()
        {
        }
    }
}
