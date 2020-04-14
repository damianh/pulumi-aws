// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Dms.Inputs
{

    public sealed class EndpointS3SettingsGetArgs : Pulumi.ResourceArgs
    {
        [Input("bucketFolder")]
        public Input<string>? BucketFolder { get; set; }

        [Input("bucketName")]
        public Input<string>? BucketName { get; set; }

        [Input("compressionType")]
        public Input<string>? CompressionType { get; set; }

        [Input("csvDelimiter")]
        public Input<string>? CsvDelimiter { get; set; }

        [Input("csvRowDelimiter")]
        public Input<string>? CsvRowDelimiter { get; set; }

        [Input("externalTableDefinition")]
        public Input<string>? ExternalTableDefinition { get; set; }

        [Input("serviceAccessRoleArn")]
        public Input<string>? ServiceAccessRoleArn { get; set; }

        public EndpointS3SettingsGetArgs()
        {
        }
    }
}
