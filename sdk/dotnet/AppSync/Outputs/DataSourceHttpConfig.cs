// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.AppSync.Outputs
{

    [OutputType]
    public sealed class DataSourceHttpConfig
    {
        /// <summary>
        /// HTTP URL.
        /// </summary>
        public readonly string Endpoint;

        [OutputConstructor]
        private DataSourceHttpConfig(string endpoint)
        {
            Endpoint = endpoint;
        }
    }
}
