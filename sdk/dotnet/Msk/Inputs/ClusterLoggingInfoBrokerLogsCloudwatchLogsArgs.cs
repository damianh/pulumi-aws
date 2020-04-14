// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Msk.Inputs
{

    public sealed class ClusterLoggingInfoBrokerLogsCloudwatchLogsArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Indicates whether you want to enable or disable streaming broker logs to Cloudwatch Logs. 
        /// </summary>
        [Input("enabled", required: true)]
        public Input<bool> Enabled { get; set; } = null!;

        /// <summary>
        /// Name of the Cloudwatch Log Group to deliver logs to.
        /// </summary>
        [Input("logGroup")]
        public Input<string>? LogGroup { get; set; }

        public ClusterLoggingInfoBrokerLogsCloudwatchLogsArgs()
        {
        }
    }
}
