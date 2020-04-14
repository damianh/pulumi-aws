// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.CodeBuild.Inputs
{

    public sealed class WebhookFilterGroupFilterArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// If set to `true`, the specified filter does *not* trigger a build. Defaults to `false`.
        /// </summary>
        [Input("excludeMatchedPattern")]
        public Input<bool>? ExcludeMatchedPattern { get; set; }

        /// <summary>
        /// For a filter that uses `EVENT` type, a comma-separated string that specifies one event: `PUSH`, `PULL_REQUEST_CREATED`, `PULL_REQUEST_UPDATED`, `PULL_REQUEST_REOPENED`. `PULL_REQUEST_MERGED` works with GitHub &amp; GitHub Enterprise only. For a filter that uses any of the other filter types, a regular expression.
        /// </summary>
        [Input("pattern", required: true)]
        public Input<string> Pattern { get; set; } = null!;

        /// <summary>
        /// The webhook filter group's type. Valid values for this parameter are: `EVENT`, `BASE_REF`, `HEAD_REF`, `ACTOR_ACCOUNT_ID`, `FILE_PATH`. At least one filter group must specify `EVENT` as its type.
        /// </summary>
        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        public WebhookFilterGroupFilterArgs()
        {
        }
    }
}
