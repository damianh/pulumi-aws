// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.S3.Inputs
{

    public sealed class AnalyticsConfigurationStorageClassAnalysisDataExportDestinationGetArgs : Pulumi.ResourceArgs
    {
        [Input("s3BucketDestination", required: true)]
        public Input<Inputs.AnalyticsConfigurationStorageClassAnalysisDataExportDestinationS3BucketDestinationGetArgs> S3BucketDestination { get; set; } = null!;

        public AnalyticsConfigurationStorageClassAnalysisDataExportDestinationGetArgs()
        {
        }
    }
}
