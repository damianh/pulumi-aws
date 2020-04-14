// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.WafRegional.Outputs
{

    [OutputType]
    public sealed class WebAclLoggingConfigurationRedactedFields
    {
        /// <summary>
        /// Set of configuration blocks for fields to redact. Detailed below.
        /// </summary>
        public readonly ImmutableArray<Outputs.WebAclLoggingConfigurationRedactedFieldsFieldToMatch> FieldToMatches;

        [OutputConstructor]
        private WebAclLoggingConfigurationRedactedFields(ImmutableArray<Outputs.WebAclLoggingConfigurationRedactedFieldsFieldToMatch> fieldToMatches)
        {
            FieldToMatches = fieldToMatches;
        }
    }
}
