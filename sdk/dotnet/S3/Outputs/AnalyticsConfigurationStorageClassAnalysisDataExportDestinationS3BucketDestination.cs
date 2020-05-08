// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.S3.Outputs
{

    [OutputType]
    public sealed class AnalyticsConfigurationStorageClassAnalysisDataExportDestinationS3BucketDestination
    {
        /// <summary>
        /// The account ID that owns the destination bucket.
        /// </summary>
        public readonly string? BucketAccountId;
        /// <summary>
        /// The ARN of the destination bucket.
        /// </summary>
        public readonly string BucketArn;
        /// <summary>
        /// The output format of exported analytics data. Allowed values: `CSV`. Default value: `CSV`.
        /// </summary>
        public readonly string? Format;
        /// <summary>
        /// Object prefix for filtering.
        /// </summary>
        public readonly string? Prefix;

        [OutputConstructor]
        private AnalyticsConfigurationStorageClassAnalysisDataExportDestinationS3BucketDestination(
            string? bucketAccountId,

            string bucketArn,

            string? format,

            string? prefix)
        {
            BucketAccountId = bucketAccountId;
            BucketArn = bucketArn;
            Format = format;
            Prefix = prefix;
        }
    }
}