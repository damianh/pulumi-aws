// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Backup.Outputs
{

    [OutputType]
    public sealed class PlanRule
    {
        /// <summary>
        /// The amount of time AWS Backup attempts a backup before canceling the job and returning an error.
        /// </summary>
        public readonly int? CompletionWindow;
        /// <summary>
        /// The lifecycle defines when a protected resource is transitioned to cold storage and when it expires.  Fields documented below.
        /// </summary>
        public readonly Outputs.PlanRuleLifecycle? Lifecycle;
        /// <summary>
        /// Metadata that you can assign to help organize the resources that you create.
        /// </summary>
        public readonly ImmutableDictionary<string, object>? RecoveryPointTags;
        /// <summary>
        /// An display name for a backup rule.
        /// </summary>
        public readonly string RuleName;
        /// <summary>
        /// A CRON expression specifying when AWS Backup initiates a backup job.
        /// </summary>
        public readonly string? Schedule;
        /// <summary>
        /// The amount of time in minutes before beginning a backup.
        /// </summary>
        public readonly int? StartWindow;
        /// <summary>
        /// The name of a logical container where backups are stored.
        /// </summary>
        public readonly string TargetVaultName;

        [OutputConstructor]
        private PlanRule(
            int? completionWindow,

            Outputs.PlanRuleLifecycle? lifecycle,

            ImmutableDictionary<string, object>? recoveryPointTags,

            string ruleName,

            string? schedule,

            int? startWindow,

            string targetVaultName)
        {
            CompletionWindow = completionWindow;
            Lifecycle = lifecycle;
            RecoveryPointTags = recoveryPointTags;
            RuleName = ruleName;
            Schedule = schedule;
            StartWindow = startWindow;
            TargetVaultName = targetVaultName;
        }
    }
}
