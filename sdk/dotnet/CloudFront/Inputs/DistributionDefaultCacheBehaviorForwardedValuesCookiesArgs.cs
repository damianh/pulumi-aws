// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.CloudFront.Inputs
{

    public sealed class DistributionDefaultCacheBehaviorForwardedValuesCookiesArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Specifies whether you want CloudFront to forward
        /// cookies to the origin that is associated with this cache behavior. You can
        /// specify `all`, `none` or `whitelist`. If `whitelist`, you must include the
        /// subsequent `whitelisted_names`
        /// </summary>
        [Input("forward", required: true)]
        public Input<string> Forward { get; set; } = null!;

        [Input("whitelistedNames")]
        private InputList<string>? _whitelistedNames;

        /// <summary>
        /// If you have specified `whitelist` to
        /// `forward`, the whitelisted cookies that you want CloudFront to forward to
        /// your origin.
        /// </summary>
        public InputList<string> WhitelistedNames
        {
            get => _whitelistedNames ?? (_whitelistedNames = new InputList<string>());
            set => _whitelistedNames = value;
        }

        public DistributionDefaultCacheBehaviorForwardedValuesCookiesArgs()
        {
        }
    }
}
