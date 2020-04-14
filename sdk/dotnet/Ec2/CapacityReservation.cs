// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Ec2
{
    /// <summary>
    /// Provides an EC2 Capacity Reservation. This allows you to reserve capacity for your Amazon EC2 instances in a specific Availability Zone for any duration.
    /// </summary>
    public partial class CapacityReservation : Pulumi.CustomResource
    {
        /// <summary>
        /// The Availability Zone in which to create the Capacity Reservation.
        /// </summary>
        [Output("availabilityZone")]
        public Output<string> AvailabilityZone { get; private set; } = null!;

        /// <summary>
        /// Indicates whether the Capacity Reservation supports EBS-optimized instances.
        /// </summary>
        [Output("ebsOptimized")]
        public Output<bool?> EbsOptimized { get; private set; } = null!;

        /// <summary>
        /// The date and time at which the Capacity Reservation expires. When a Capacity Reservation expires, the reserved capacity is released and you can no longer launch instances into it. Valid values: [RFC3339 time string](https://tools.ietf.org/html/rfc3339#section-5.8) (`YYYY-MM-DDTHH:MM:SSZ`)
        /// </summary>
        [Output("endDate")]
        public Output<string?> EndDate { get; private set; } = null!;

        /// <summary>
        /// Indicates the way in which the Capacity Reservation ends. Specify either `unlimited` or `limited`.
        /// </summary>
        [Output("endDateType")]
        public Output<string?> EndDateType { get; private set; } = null!;

        /// <summary>
        /// Indicates whether the Capacity Reservation supports instances with temporary, block-level storage.
        /// </summary>
        [Output("ephemeralStorage")]
        public Output<bool?> EphemeralStorage { get; private set; } = null!;

        /// <summary>
        /// The number of instances for which to reserve capacity.
        /// </summary>
        [Output("instanceCount")]
        public Output<int> InstanceCount { get; private set; } = null!;

        /// <summary>
        /// Indicates the type of instance launches that the Capacity Reservation accepts. Specify either `open` or `targeted`.
        /// </summary>
        [Output("instanceMatchCriteria")]
        public Output<string?> InstanceMatchCriteria { get; private set; } = null!;

        /// <summary>
        /// The type of operating system for which to reserve capacity. Valid options are `Linux/UNIX`, `Red Hat Enterprise Linux`, `SUSE Linux`, `Windows`, `Windows with SQL Server`, `Windows with SQL Server Enterprise`, `Windows with SQL Server Standard` or `Windows with SQL Server Web`.
        /// </summary>
        [Output("instancePlatform")]
        public Output<string> InstancePlatform { get; private set; } = null!;

        /// <summary>
        /// The instance type for which to reserve capacity.
        /// </summary>
        [Output("instanceType")]
        public Output<string> InstanceType { get; private set; } = null!;

        /// <summary>
        /// A mapping of tags to assign to the resource.
        /// </summary>
        [Output("tags")]
        public Output<ImmutableDictionary<string, object>?> Tags { get; private set; } = null!;

        /// <summary>
        /// Indicates the tenancy of the Capacity Reservation. Specify either `default` or `dedicated`.
        /// </summary>
        [Output("tenancy")]
        public Output<string?> Tenancy { get; private set; } = null!;


        /// <summary>
        /// Create a CapacityReservation resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public CapacityReservation(string name, CapacityReservationArgs args, CustomResourceOptions? options = null)
            : base("aws:ec2/capacityReservation:CapacityReservation", name, args ?? new CapacityReservationArgs(), MakeResourceOptions(options, ""))
        {
        }

        private CapacityReservation(string name, Input<string> id, CapacityReservationState? state = null, CustomResourceOptions? options = null)
            : base("aws:ec2/capacityReservation:CapacityReservation", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing CapacityReservation resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static CapacityReservation Get(string name, Input<string> id, CapacityReservationState? state = null, CustomResourceOptions? options = null)
        {
            return new CapacityReservation(name, id, state, options);
        }
    }

    public sealed class CapacityReservationArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The Availability Zone in which to create the Capacity Reservation.
        /// </summary>
        [Input("availabilityZone", required: true)]
        public Input<string> AvailabilityZone { get; set; } = null!;

        /// <summary>
        /// Indicates whether the Capacity Reservation supports EBS-optimized instances.
        /// </summary>
        [Input("ebsOptimized")]
        public Input<bool>? EbsOptimized { get; set; }

        /// <summary>
        /// The date and time at which the Capacity Reservation expires. When a Capacity Reservation expires, the reserved capacity is released and you can no longer launch instances into it. Valid values: [RFC3339 time string](https://tools.ietf.org/html/rfc3339#section-5.8) (`YYYY-MM-DDTHH:MM:SSZ`)
        /// </summary>
        [Input("endDate")]
        public Input<string>? EndDate { get; set; }

        /// <summary>
        /// Indicates the way in which the Capacity Reservation ends. Specify either `unlimited` or `limited`.
        /// </summary>
        [Input("endDateType")]
        public Input<string>? EndDateType { get; set; }

        /// <summary>
        /// Indicates whether the Capacity Reservation supports instances with temporary, block-level storage.
        /// </summary>
        [Input("ephemeralStorage")]
        public Input<bool>? EphemeralStorage { get; set; }

        /// <summary>
        /// The number of instances for which to reserve capacity.
        /// </summary>
        [Input("instanceCount", required: true)]
        public Input<int> InstanceCount { get; set; } = null!;

        /// <summary>
        /// Indicates the type of instance launches that the Capacity Reservation accepts. Specify either `open` or `targeted`.
        /// </summary>
        [Input("instanceMatchCriteria")]
        public Input<string>? InstanceMatchCriteria { get; set; }

        /// <summary>
        /// The type of operating system for which to reserve capacity. Valid options are `Linux/UNIX`, `Red Hat Enterprise Linux`, `SUSE Linux`, `Windows`, `Windows with SQL Server`, `Windows with SQL Server Enterprise`, `Windows with SQL Server Standard` or `Windows with SQL Server Web`.
        /// </summary>
        [Input("instancePlatform", required: true)]
        public Input<string> InstancePlatform { get; set; } = null!;

        /// <summary>
        /// The instance type for which to reserve capacity.
        /// </summary>
        [Input("instanceType", required: true)]
        public Input<string> InstanceType { get; set; } = null!;

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

        /// <summary>
        /// Indicates the tenancy of the Capacity Reservation. Specify either `default` or `dedicated`.
        /// </summary>
        [Input("tenancy")]
        public Input<string>? Tenancy { get; set; }

        public CapacityReservationArgs()
        {
        }
    }

    public sealed class CapacityReservationState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The Availability Zone in which to create the Capacity Reservation.
        /// </summary>
        [Input("availabilityZone")]
        public Input<string>? AvailabilityZone { get; set; }

        /// <summary>
        /// Indicates whether the Capacity Reservation supports EBS-optimized instances.
        /// </summary>
        [Input("ebsOptimized")]
        public Input<bool>? EbsOptimized { get; set; }

        /// <summary>
        /// The date and time at which the Capacity Reservation expires. When a Capacity Reservation expires, the reserved capacity is released and you can no longer launch instances into it. Valid values: [RFC3339 time string](https://tools.ietf.org/html/rfc3339#section-5.8) (`YYYY-MM-DDTHH:MM:SSZ`)
        /// </summary>
        [Input("endDate")]
        public Input<string>? EndDate { get; set; }

        /// <summary>
        /// Indicates the way in which the Capacity Reservation ends. Specify either `unlimited` or `limited`.
        /// </summary>
        [Input("endDateType")]
        public Input<string>? EndDateType { get; set; }

        /// <summary>
        /// Indicates whether the Capacity Reservation supports instances with temporary, block-level storage.
        /// </summary>
        [Input("ephemeralStorage")]
        public Input<bool>? EphemeralStorage { get; set; }

        /// <summary>
        /// The number of instances for which to reserve capacity.
        /// </summary>
        [Input("instanceCount")]
        public Input<int>? InstanceCount { get; set; }

        /// <summary>
        /// Indicates the type of instance launches that the Capacity Reservation accepts. Specify either `open` or `targeted`.
        /// </summary>
        [Input("instanceMatchCriteria")]
        public Input<string>? InstanceMatchCriteria { get; set; }

        /// <summary>
        /// The type of operating system for which to reserve capacity. Valid options are `Linux/UNIX`, `Red Hat Enterprise Linux`, `SUSE Linux`, `Windows`, `Windows with SQL Server`, `Windows with SQL Server Enterprise`, `Windows with SQL Server Standard` or `Windows with SQL Server Web`.
        /// </summary>
        [Input("instancePlatform")]
        public Input<string>? InstancePlatform { get; set; }

        /// <summary>
        /// The instance type for which to reserve capacity.
        /// </summary>
        [Input("instanceType")]
        public Input<string>? InstanceType { get; set; }

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

        /// <summary>
        /// Indicates the tenancy of the Capacity Reservation. Specify either `default` or `dedicated`.
        /// </summary>
        [Input("tenancy")]
        public Input<string>? Tenancy { get; set; }

        public CapacityReservationState()
        {
        }
    }
}
