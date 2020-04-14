// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Ecs
{
    /// <summary>
    /// Provides an ECS cluster capacity provider. More information can be found on the [ECS Developer Guide](https://docs.aws.amazon.com/AmazonECS/latest/developerguide/cluster-capacity-providers.html).
    /// 
    /// &gt; **NOTE:** The AWS API does not currently support deleting ECS cluster capacity providers. Removing this resource will only remove the state for it.
    /// 
    /// 
    /// ## auto_scaling_group_provider
    /// 
    /// The `auto_scaling_group_provider` block supports the following:
    /// 
    /// * `auto_scaling_group_arn` - (Required) - The Amazon Resource Name (ARN) of the associated auto scaling group.
    /// * `managed_scaling` - (Optional) - Nested argument defining the parameters of the auto scaling. Defined below.
    /// * `managed_termination_protection` - (Optional) - Enables or disables container-aware termination of instances in the auto scaling group when scale-in happens. Valid values are `ENABLED` and `DISABLED`.
    /// 
    /// ## managed_scaling
    /// 
    /// The `managed_scaling` block supports the following:
    /// 
    /// * `maximum_scaling_step_size` - (Optional) The maximum step adjustment size. A number between 1 and 10,000.
    /// * `minimum_scaling_step_size` - (Optional) The minimum step adjustment size. A number between 1 and 10,000.
    /// * `status` - (Optional) Whether auto scaling is managed by ECS. Valid values are `ENABLED` and `DISABLED`.
    /// * `target_capacity` - (Optional) The target utilization for the capacity provider. A number between 1 and 100.
    /// </summary>
    public partial class CapacityProvider : Pulumi.CustomResource
    {
        /// <summary>
        /// The Amazon Resource Name (ARN) that identifies the capacity provider.
        /// </summary>
        [Output("arn")]
        public Output<string> Arn { get; private set; } = null!;

        /// <summary>
        /// Nested argument defining the provider for the ECS auto scaling group. Defined below.
        /// </summary>
        [Output("autoScalingGroupProvider")]
        public Output<Outputs.CapacityProviderAutoScalingGroupProvider> AutoScalingGroupProvider { get; private set; } = null!;

        /// <summary>
        /// The name of the capacity provider.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// Key-value mapping of resource tags.
        /// </summary>
        [Output("tags")]
        public Output<ImmutableDictionary<string, object>?> Tags { get; private set; } = null!;


        /// <summary>
        /// Create a CapacityProvider resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public CapacityProvider(string name, CapacityProviderArgs args, CustomResourceOptions? options = null)
            : base("aws:ecs/capacityProvider:CapacityProvider", name, args ?? new CapacityProviderArgs(), MakeResourceOptions(options, ""))
        {
        }

        private CapacityProvider(string name, Input<string> id, CapacityProviderState? state = null, CustomResourceOptions? options = null)
            : base("aws:ecs/capacityProvider:CapacityProvider", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing CapacityProvider resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static CapacityProvider Get(string name, Input<string> id, CapacityProviderState? state = null, CustomResourceOptions? options = null)
        {
            return new CapacityProvider(name, id, state, options);
        }
    }

    public sealed class CapacityProviderArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Nested argument defining the provider for the ECS auto scaling group. Defined below.
        /// </summary>
        [Input("autoScalingGroupProvider", required: true)]
        public Input<Inputs.CapacityProviderAutoScalingGroupProviderArgs> AutoScalingGroupProvider { get; set; } = null!;

        /// <summary>
        /// The name of the capacity provider.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("tags")]
        private InputMap<object>? _tags;

        /// <summary>
        /// Key-value mapping of resource tags.
        /// </summary>
        public InputMap<object> Tags
        {
            get => _tags ?? (_tags = new InputMap<object>());
            set => _tags = value;
        }

        public CapacityProviderArgs()
        {
        }
    }

    public sealed class CapacityProviderState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The Amazon Resource Name (ARN) that identifies the capacity provider.
        /// </summary>
        [Input("arn")]
        public Input<string>? Arn { get; set; }

        /// <summary>
        /// Nested argument defining the provider for the ECS auto scaling group. Defined below.
        /// </summary>
        [Input("autoScalingGroupProvider")]
        public Input<Inputs.CapacityProviderAutoScalingGroupProviderGetArgs>? AutoScalingGroupProvider { get; set; }

        /// <summary>
        /// The name of the capacity provider.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("tags")]
        private InputMap<object>? _tags;

        /// <summary>
        /// Key-value mapping of resource tags.
        /// </summary>
        public InputMap<object> Tags
        {
            get => _tags ?? (_tags = new InputMap<object>());
            set => _tags = value;
        }

        public CapacityProviderState()
        {
        }
    }
}
