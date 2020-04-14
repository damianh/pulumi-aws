// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.CodeBuild.Outputs
{

    [OutputType]
    public sealed class ProjectLogsConfigCloudwatchLogs
    {
        /// <summary>
        /// The group name of the logs in CloudWatch Logs.
        /// </summary>
        public readonly string? GroupName;
        /// <summary>
        /// Current status of logs in S3 for a build project. Valid values: `ENABLED`, `DISABLED`. Defaults to `DISABLED`.
        /// </summary>
        public readonly string? Status;
        /// <summary>
        /// The stream name of the logs in CloudWatch Logs.
        /// </summary>
        public readonly string? StreamName;

        [OutputConstructor]
        private ProjectLogsConfigCloudwatchLogs(
            string? groupName,

            string? status,

            string? streamName)
        {
            GroupName = groupName;
            Status = status;
            StreamName = streamName;
        }
    }
}
