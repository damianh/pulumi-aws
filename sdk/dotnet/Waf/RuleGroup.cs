// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Waf
{
    /// <summary>
    /// Provides a WAF Rule Group Resource
    /// </summary>
    public partial class RuleGroup : Pulumi.CustomResource
    {
        /// <summary>
        /// A list of activated rules, see below
        /// </summary>
        [Output("activatedRules")]
        public Output<ImmutableArray<Outputs.RuleGroupActivatedRule>> ActivatedRules { get; private set; } = null!;

        /// <summary>
        /// The ARN of the WAF rule group.
        /// </summary>
        [Output("arn")]
        public Output<string> Arn { get; private set; } = null!;

        /// <summary>
        /// A friendly name for the metrics from the rule group
        /// </summary>
        [Output("metricName")]
        public Output<string> MetricName { get; private set; } = null!;

        /// <summary>
        /// A friendly name of the rule group
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// Key-value mapping of resource tags
        /// </summary>
        [Output("tags")]
        public Output<ImmutableDictionary<string, object>?> Tags { get; private set; } = null!;


        /// <summary>
        /// Create a RuleGroup resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public RuleGroup(string name, RuleGroupArgs args, CustomResourceOptions? options = null)
            : base("aws:waf/ruleGroup:RuleGroup", name, args ?? new RuleGroupArgs(), MakeResourceOptions(options, ""))
        {
        }

        private RuleGroup(string name, Input<string> id, RuleGroupState? state = null, CustomResourceOptions? options = null)
            : base("aws:waf/ruleGroup:RuleGroup", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing RuleGroup resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static RuleGroup Get(string name, Input<string> id, RuleGroupState? state = null, CustomResourceOptions? options = null)
        {
            return new RuleGroup(name, id, state, options);
        }
    }

    public sealed class RuleGroupArgs : Pulumi.ResourceArgs
    {
        [Input("activatedRules")]
        private InputList<Inputs.RuleGroupActivatedRuleArgs>? _activatedRules;

        /// <summary>
        /// A list of activated rules, see below
        /// </summary>
        public InputList<Inputs.RuleGroupActivatedRuleArgs> ActivatedRules
        {
            get => _activatedRules ?? (_activatedRules = new InputList<Inputs.RuleGroupActivatedRuleArgs>());
            set => _activatedRules = value;
        }

        /// <summary>
        /// A friendly name for the metrics from the rule group
        /// </summary>
        [Input("metricName", required: true)]
        public Input<string> MetricName { get; set; } = null!;

        /// <summary>
        /// A friendly name of the rule group
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("tags")]
        private InputMap<object>? _tags;

        /// <summary>
        /// Key-value mapping of resource tags
        /// </summary>
        public InputMap<object> Tags
        {
            get => _tags ?? (_tags = new InputMap<object>());
            set => _tags = value;
        }

        public RuleGroupArgs()
        {
        }
    }

    public sealed class RuleGroupState : Pulumi.ResourceArgs
    {
        [Input("activatedRules")]
        private InputList<Inputs.RuleGroupActivatedRuleGetArgs>? _activatedRules;

        /// <summary>
        /// A list of activated rules, see below
        /// </summary>
        public InputList<Inputs.RuleGroupActivatedRuleGetArgs> ActivatedRules
        {
            get => _activatedRules ?? (_activatedRules = new InputList<Inputs.RuleGroupActivatedRuleGetArgs>());
            set => _activatedRules = value;
        }

        /// <summary>
        /// The ARN of the WAF rule group.
        /// </summary>
        [Input("arn")]
        public Input<string>? Arn { get; set; }

        /// <summary>
        /// A friendly name for the metrics from the rule group
        /// </summary>
        [Input("metricName")]
        public Input<string>? MetricName { get; set; }

        /// <summary>
        /// A friendly name of the rule group
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("tags")]
        private InputMap<object>? _tags;

        /// <summary>
        /// Key-value mapping of resource tags
        /// </summary>
        public InputMap<object> Tags
        {
            get => _tags ?? (_tags = new InputMap<object>());
            set => _tags = value;
        }

        public RuleGroupState()
        {
        }
    }
}
