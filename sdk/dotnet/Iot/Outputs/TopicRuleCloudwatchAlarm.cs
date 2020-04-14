// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Iot.Outputs
{

    [OutputType]
    public sealed class TopicRuleCloudwatchAlarm
    {
        /// <summary>
        /// The CloudWatch alarm name.
        /// </summary>
        public readonly string AlarmName;
        /// <summary>
        /// The IAM role ARN that allows access to the CloudWatch alarm.
        /// </summary>
        public readonly string RoleArn;
        /// <summary>
        /// The reason for the alarm change.
        /// </summary>
        public readonly string StateReason;
        /// <summary>
        /// The value of the alarm state. Acceptable values are: OK, ALARM, INSUFFICIENT_DATA.
        /// </summary>
        public readonly string StateValue;

        [OutputConstructor]
        private TopicRuleCloudwatchAlarm(
            string alarmName,

            string roleArn,

            string stateReason,

            string stateValue)
        {
            AlarmName = alarmName;
            RoleArn = roleArn;
            StateReason = stateReason;
            StateValue = stateValue;
        }
    }
}
