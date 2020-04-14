// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.CloudWatch.Outputs
{

    [OutputType]
    public sealed class EventTargetBatchTarget
    {
        /// <summary>
        /// The size of the array, if this is an array batch job. Valid values are integers between 2 and 10,000.
        /// </summary>
        public readonly int? ArraySize;
        /// <summary>
        /// The number of times to attempt to retry, if the job fails. Valid values are 1 to 10.
        /// </summary>
        public readonly int? JobAttempts;
        /// <summary>
        /// The ARN or name of the job definition to use if the event target is an AWS Batch job. This job definition must already exist.
        /// </summary>
        public readonly string JobDefinition;
        /// <summary>
        /// The name to use for this execution of the job, if the target is an AWS Batch job.
        /// </summary>
        public readonly string JobName;

        [OutputConstructor]
        private EventTargetBatchTarget(
            int? arraySize,

            int? jobAttempts,

            string jobDefinition,

            string jobName)
        {
            ArraySize = arraySize;
            JobAttempts = jobAttempts;
            JobDefinition = jobDefinition;
            JobName = jobName;
        }
    }
}
