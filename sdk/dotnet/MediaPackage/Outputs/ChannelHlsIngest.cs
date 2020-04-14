// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.MediaPackage.Outputs
{

    [OutputType]
    public sealed class ChannelHlsIngest
    {
        /// <summary>
        /// A list of the ingest endpoints
        /// </summary>
        public readonly ImmutableArray<Outputs.ChannelHlsIngestIngestEndpoint> IngestEndpoints;

        [OutputConstructor]
        private ChannelHlsIngest(ImmutableArray<Outputs.ChannelHlsIngestIngestEndpoint> ingestEndpoints)
        {
            IngestEndpoints = ingestEndpoints;
        }
    }
}
