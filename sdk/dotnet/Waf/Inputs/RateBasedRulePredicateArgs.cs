// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Waf.Inputs
{

    public sealed class RateBasedRulePredicateArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// A unique identifier for a predicate in the rule, such as Byte Match Set ID or IPSet ID.
        /// </summary>
        [Input("dataId", required: true)]
        public Input<string> DataId { get; set; } = null!;

        /// <summary>
        /// Set this to `false` if you want to allow, block, or count requests
        /// based on the settings in the specified `ByteMatchSet`, `IPSet`, `SqlInjectionMatchSet`, `XssMatchSet`, or `SizeConstraintSet`.
        /// For example, if an IPSet includes the IP address `192.0.2.44`, AWS WAF will allow or block requests based on that IP address.
        /// If set to `true`, AWS WAF will allow, block, or count requests based on all IP addresses _except_ `192.0.2.44`.
        /// </summary>
        [Input("negated", required: true)]
        public Input<bool> Negated { get; set; } = null!;

        /// <summary>
        /// The type of predicate in a rule. Valid values: `ByteMatch`, `GeoMatch`, `IPMatch`, `RegexMatch`, `SizeConstraint`, `SqlInjectionMatch`, or `XssMatch`.
        /// </summary>
        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        public RateBasedRulePredicateArgs()
        {
        }
    }
}
