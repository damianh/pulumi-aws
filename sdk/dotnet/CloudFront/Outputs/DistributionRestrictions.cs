// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.CloudFront.Outputs
{

    [OutputType]
    public sealed class DistributionRestrictions
    {
        public readonly Outputs.DistributionRestrictionsGeoRestriction GeoRestriction;

        [OutputConstructor]
        private DistributionRestrictions(Outputs.DistributionRestrictionsGeoRestriction geoRestriction)
        {
            GeoRestriction = geoRestriction;
        }
    }
}
