// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Iam.Outputs
{

    [OutputType]
    public sealed class GetPolicyDocumentStatementConditionResult
    {
        /// <summary>
        /// The name of the
        /// [IAM condition operator](https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_policies_elements_condition_operators.html)
        /// to evaluate.
        /// </summary>
        public readonly string Test;
        /// <summary>
        /// The values to evaluate the condition against. If multiple
        /// values are provided, the condition matches if at least one of them applies.
        /// (That is, the tests are combined with the "OR" boolean operation.)
        /// </summary>
        public readonly ImmutableArray<string> Values;
        /// <summary>
        /// The name of a
        /// [Context Variable](http://docs.aws.amazon.com/IAM/latest/UserGuide/reference_policies_elements.html#AvailableKeys)
        /// to apply the condition to. Context variables may either be standard AWS
        /// variables starting with `aws:`, or service-specific variables prefixed with
        /// the service name.
        /// </summary>
        public readonly string Variable;

        [OutputConstructor]
        private GetPolicyDocumentStatementConditionResult(
            string test,

            ImmutableArray<string> values,

            string variable)
        {
            Test = test;
            Values = values;
            Variable = variable;
        }
    }
}
