// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.LB.Inputs
{

    public sealed class ListenerRuleConditionHostHeaderGetArgs : Pulumi.ResourceArgs
    {
        [Input("values")]
        private InputList<string>? _values;

        /// <summary>
        /// List of exactly one pattern to match. Required when `field` is set.
        /// </summary>
        public InputList<string> Values
        {
            get => _values ?? (_values = new InputList<string>());
            set => _values = value;
        }

        public ListenerRuleConditionHostHeaderGetArgs()
        {
        }
    }
}
