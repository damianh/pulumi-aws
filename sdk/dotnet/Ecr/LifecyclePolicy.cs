// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Ecr
{
    /// <summary>
    /// Manages an ECR repository lifecycle policy.
    /// 
    /// &gt; **NOTE:** Only one `aws.ecr.LifecyclePolicy` resource can be used with the same ECR repository. To apply multiple rules, they must be combined in the `policy` JSON.
    /// 
    /// &gt; **NOTE:** The AWS ECR API seems to reorder rules based on `rulePriority`. If you define multiple rules that are not sorted in ascending `rulePriority` order in the this provider code, the resource will be flagged for recreation every deployment.
    /// </summary>
    public partial class LifecyclePolicy : Pulumi.CustomResource
    {
        /// <summary>
        /// The policy document. This is a JSON formatted string. See more details about [Policy Parameters](http://docs.aws.amazon.com/AmazonECR/latest/userguide/LifecyclePolicies.html#lifecycle_policy_parameters) in the official AWS docs.
        /// </summary>
        [Output("policy")]
        public Output<string> Policy { get; private set; } = null!;

        /// <summary>
        /// The registry ID where the repository was created.
        /// </summary>
        [Output("registryId")]
        public Output<string> RegistryId { get; private set; } = null!;

        /// <summary>
        /// Name of the repository to apply the policy.
        /// </summary>
        [Output("repository")]
        public Output<string> Repository { get; private set; } = null!;


        /// <summary>
        /// Create a LifecyclePolicy resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public LifecyclePolicy(string name, LifecyclePolicyArgs args, CustomResourceOptions? options = null)
            : base("aws:ecr/lifecyclePolicy:LifecyclePolicy", name, args ?? new LifecyclePolicyArgs(), MakeResourceOptions(options, ""))
        {
        }

        private LifecyclePolicy(string name, Input<string> id, LifecyclePolicyState? state = null, CustomResourceOptions? options = null)
            : base("aws:ecr/lifecyclePolicy:LifecyclePolicy", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing LifecyclePolicy resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static LifecyclePolicy Get(string name, Input<string> id, LifecyclePolicyState? state = null, CustomResourceOptions? options = null)
        {
            return new LifecyclePolicy(name, id, state, options);
        }
    }

    public sealed class LifecyclePolicyArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The policy document. This is a JSON formatted string. See more details about [Policy Parameters](http://docs.aws.amazon.com/AmazonECR/latest/userguide/LifecyclePolicies.html#lifecycle_policy_parameters) in the official AWS docs.
        /// </summary>
        [Input("policy", required: true)]
        public Input<string> Policy { get; set; } = null!;

        /// <summary>
        /// Name of the repository to apply the policy.
        /// </summary>
        [Input("repository", required: true)]
        public Input<string> Repository { get; set; } = null!;

        public LifecyclePolicyArgs()
        {
        }
    }

    public sealed class LifecyclePolicyState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The policy document. This is a JSON formatted string. See more details about [Policy Parameters](http://docs.aws.amazon.com/AmazonECR/latest/userguide/LifecyclePolicies.html#lifecycle_policy_parameters) in the official AWS docs.
        /// </summary>
        [Input("policy")]
        public Input<string>? Policy { get; set; }

        /// <summary>
        /// The registry ID where the repository was created.
        /// </summary>
        [Input("registryId")]
        public Input<string>? RegistryId { get; set; }

        /// <summary>
        /// Name of the repository to apply the policy.
        /// </summary>
        [Input("repository")]
        public Input<string>? Repository { get; set; }

        public LifecyclePolicyState()
        {
        }
    }
}
