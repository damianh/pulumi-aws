// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Backup.Inputs
{

    public sealed class PlanRuleGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The amount of time AWS Backup attempts a backup before canceling the job and returning an error.
        /// </summary>
        [Input("completionWindow")]
        public Input<int>? CompletionWindow { get; set; }

        /// <summary>
        /// The lifecycle defines when a protected resource is transitioned to cold storage and when it expires.  Fields documented below.
        /// </summary>
        [Input("lifecycle")]
        public Input<Inputs.PlanRuleLifecycleGetArgs>? Lifecycle { get; set; }

        [Input("recoveryPointTags")]
        private InputMap<object>? _recoveryPointTags;

        /// <summary>
        /// Metadata that you can assign to help organize the resources that you create.
        /// </summary>
        public InputMap<object> RecoveryPointTags
        {
            get => _recoveryPointTags ?? (_recoveryPointTags = new InputMap<object>());
            set => _recoveryPointTags = value;
        }

        /// <summary>
        /// An display name for a backup rule.
        /// </summary>
        [Input("ruleName", required: true)]
        public Input<string> RuleName { get; set; } = null!;

        /// <summary>
        /// A CRON expression specifying when AWS Backup initiates a backup job.
        /// </summary>
        [Input("schedule")]
        public Input<string>? Schedule { get; set; }

        /// <summary>
        /// The amount of time in minutes before beginning a backup.
        /// </summary>
        [Input("startWindow")]
        public Input<int>? StartWindow { get; set; }

        /// <summary>
        /// The name of a logical container where backups are stored.
        /// </summary>
        [Input("targetVaultName", required: true)]
        public Input<string> TargetVaultName { get; set; } = null!;

        public PlanRuleGetArgs()
        {
        }
    }
}
