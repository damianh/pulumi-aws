// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Waf.Inputs
{

    public sealed class RuleGroupActivatedRuleArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Specifies the action that CloudFront or AWS WAF takes when a web request matches the conditions in the rule.
        /// </summary>
        [Input("action", required: true)]
        public Input<Inputs.RuleGroupActivatedRuleActionArgs> Action { get; set; } = null!;

        /// <summary>
        /// Specifies the order in which the rules are evaluated. Rules with a lower value are evaluated before rules with a higher value.
        /// </summary>
        [Input("priority", required: true)]
        public Input<int> Priority { get; set; } = null!;

        /// <summary>
        /// The ID of a [rule](https://www.terraform.io/docs/providers/aws/r/waf_rule.html)
        /// </summary>
        [Input("ruleId", required: true)]
        public Input<string> RuleId { get; set; } = null!;

        /// <summary>
        /// The rule type, either [`REGULAR`](https://www.terraform.io/docs/providers/aws/r/waf_rule.html), [`RATE_BASED`](https://www.terraform.io/docs/providers/aws/r/waf_rate_based_rule.html), or `GROUP`. Defaults to `REGULAR`.
        /// </summary>
        [Input("type")]
        public Input<string>? Type { get; set; }

        public RuleGroupActivatedRuleArgs()
        {
        }
    }
}