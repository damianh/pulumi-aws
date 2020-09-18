// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.StorageGateway.Outputs
{

    [OutputType]
    public sealed class NfsFileShareCacheAttributes
    {
        /// <summary>
        /// Refreshes a file share's cache by using Time To Live (TTL).
        /// TTL is the length of time since the last refresh after which access to the directory would cause the file gateway
        /// to first refresh that directory's contents from the Amazon S3 bucket. Valid Values: 300 to 2,592,000 seconds (5 minutes to 30 days)
        /// </summary>
        public readonly int? CacheStaleTimeoutInSeconds;

        [OutputConstructor]
        private NfsFileShareCacheAttributes(int? cacheStaleTimeoutInSeconds)
        {
            CacheStaleTimeoutInSeconds = cacheStaleTimeoutInSeconds;
        }
    }
}
