// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.LB.Outputs
{

    [OutputType]
    public sealed class ListenerRuleConditionHttpHeader
    {
        /// <summary>
        /// Name of HTTP header to search. The maximum size is 40 characters. Comparison is case insensitive. Only RFC7240 characters are supported. Wildcards are not supported. You cannot use HTTP header condition to specify the host header, use a `host-header` condition instead.
        /// </summary>
        public readonly string HttpHeaderName;
        /// <summary>
        /// List of header value patterns to match. Maximum size of each pattern is 128 characters. Comparison is case insensitive. Wildcard characters supported: * (matches 0 or more characters) and ? (matches exactly 1 character). If the same header appears multiple times in the request they will be searched in order until a match is found. Only one pattern needs to match for the condition to be satisfied. To require that all of the strings are a match, create one condition block per string.
        /// </summary>
        public readonly ImmutableArray<string> Values;

        [OutputConstructor]
        private ListenerRuleConditionHttpHeader(
            string httpHeaderName,

            ImmutableArray<string> values)
        {
            HttpHeaderName = httpHeaderName;
            Values = values;
        }
    }
}
