// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.CloudFront.Inputs
{

    public sealed class DistributionRestrictionsGeoRestrictionGetArgs : Pulumi.ResourceArgs
    {
        [Input("locations")]
        private InputList<string>? _locations;

        /// <summary>
        /// The [ISO 3166-1-alpha-2 codes][4] for which you
        /// want CloudFront either to distribute your content (`whitelist`) or not
        /// distribute your content (`blacklist`).
        /// </summary>
        public InputList<string> Locations
        {
            get => _locations ?? (_locations = new InputList<string>());
            set => _locations = value;
        }

        /// <summary>
        /// The method that you want to use to restrict
        /// distribution of your content by country: `none`, `whitelist`, or
        /// `blacklist`.
        /// </summary>
        [Input("restrictionType", required: true)]
        public Input<string> RestrictionType { get; set; } = null!;

        public DistributionRestrictionsGeoRestrictionGetArgs()
        {
        }
    }
}
