// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Backup
{
    /// <summary>
    /// Provides an AWS Backup plan resource.
    /// 
    /// &gt; This content is derived from https://github.com/terraform-providers/terraform-provider-aws/blob/master/website/docs/r/backup_plan.html.markdown.
    /// </summary>
    public partial class Plan : Pulumi.CustomResource
    {
        /// <summary>
        /// The ARN of the backup plan.
        /// </summary>
        [Output("arn")]
        public Output<string> Arn { get; private set; } = null!;

        /// <summary>
        /// The display name of a backup plan.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// A rule object that specifies a scheduled task that is used to back up a selection of resources.
        /// </summary>
        [Output("rules")]
        public Output<ImmutableArray<Outputs.PlanRules>> Rules { get; private set; } = null!;

        /// <summary>
        /// Metadata that you can assign to help organize the plans you create.
        /// </summary>
        [Output("tags")]
        public Output<ImmutableDictionary<string, object>?> Tags { get; private set; } = null!;

        /// <summary>
        /// Unique, randomly generated, Unicode, UTF-8 encoded string that serves as the version ID of the backup plan.
        /// </summary>
        [Output("version")]
        public Output<string> Version { get; private set; } = null!;


        /// <summary>
        /// Create a Plan resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Plan(string name, PlanArgs args, CustomResourceOptions? options = null)
            : base("aws:backup/plan:Plan", name, args, MakeResourceOptions(options, ""))
        {
        }

        private Plan(string name, Input<string> id, PlanState? state = null, CustomResourceOptions? options = null)
            : base("aws:backup/plan:Plan", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing Plan resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Plan Get(string name, Input<string> id, PlanState? state = null, CustomResourceOptions? options = null)
        {
            return new Plan(name, id, state, options);
        }
    }

    public sealed class PlanArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The display name of a backup plan.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("rules", required: true)]
        private InputList<Inputs.PlanRulesArgs>? _rules;

        /// <summary>
        /// A rule object that specifies a scheduled task that is used to back up a selection of resources.
        /// </summary>
        public InputList<Inputs.PlanRulesArgs> Rules
        {
            get => _rules ?? (_rules = new InputList<Inputs.PlanRulesArgs>());
            set => _rules = value;
        }

        [Input("tags")]
        private InputMap<object>? _tags;

        /// <summary>
        /// Metadata that you can assign to help organize the plans you create.
        /// </summary>
        public InputMap<object> Tags
        {
            get => _tags ?? (_tags = new InputMap<object>());
            set => _tags = value;
        }

        public PlanArgs()
        {
        }
    }

    public sealed class PlanState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The ARN of the backup plan.
        /// </summary>
        [Input("arn")]
        public Input<string>? Arn { get; set; }

        /// <summary>
        /// The display name of a backup plan.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("rules")]
        private InputList<Inputs.PlanRulesGetArgs>? _rules;

        /// <summary>
        /// A rule object that specifies a scheduled task that is used to back up a selection of resources.
        /// </summary>
        public InputList<Inputs.PlanRulesGetArgs> Rules
        {
            get => _rules ?? (_rules = new InputList<Inputs.PlanRulesGetArgs>());
            set => _rules = value;
        }

        [Input("tags")]
        private InputMap<object>? _tags;

        /// <summary>
        /// Metadata that you can assign to help organize the plans you create.
        /// </summary>
        public InputMap<object> Tags
        {
            get => _tags ?? (_tags = new InputMap<object>());
            set => _tags = value;
        }

        /// <summary>
        /// Unique, randomly generated, Unicode, UTF-8 encoded string that serves as the version ID of the backup plan.
        /// </summary>
        [Input("version")]
        public Input<string>? Version { get; set; }

        public PlanState()
        {
        }
    }

    namespace Inputs
    {

    public sealed class PlanRulesArgs : Pulumi.ResourceArgs
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
        public Input<PlanRulesLifecycleArgs>? Lifecycle { get; set; }

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

        public PlanRulesArgs()
        {
        }
    }

    public sealed class PlanRulesGetArgs : Pulumi.ResourceArgs
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
        public Input<PlanRulesLifecycleGetArgs>? Lifecycle { get; set; }

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

        public PlanRulesGetArgs()
        {
        }
    }

    public sealed class PlanRulesLifecycleArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Specifies the number of days after creation that a recovery point is moved to cold storage.
        /// </summary>
        [Input("coldStorageAfter")]
        public Input<int>? ColdStorageAfter { get; set; }

        /// <summary>
        /// Specifies the number of days after creation that a recovery point is deleted. Must be 90 days greater than `cold_storage_after`.
        /// </summary>
        [Input("deleteAfter")]
        public Input<int>? DeleteAfter { get; set; }

        public PlanRulesLifecycleArgs()
        {
        }
    }

    public sealed class PlanRulesLifecycleGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Specifies the number of days after creation that a recovery point is moved to cold storage.
        /// </summary>
        [Input("coldStorageAfter")]
        public Input<int>? ColdStorageAfter { get; set; }

        /// <summary>
        /// Specifies the number of days after creation that a recovery point is deleted. Must be 90 days greater than `cold_storage_after`.
        /// </summary>
        [Input("deleteAfter")]
        public Input<int>? DeleteAfter { get; set; }

        public PlanRulesLifecycleGetArgs()
        {
        }
    }
    }

    namespace Outputs
    {

    [OutputType]
    public sealed class PlanRules
    {
        /// <summary>
        /// The amount of time AWS Backup attempts a backup before canceling the job and returning an error.
        /// </summary>
        public readonly int? CompletionWindow;
        /// <summary>
        /// The lifecycle defines when a protected resource is transitioned to cold storage and when it expires.  Fields documented below.
        /// </summary>
        public readonly PlanRulesLifecycle? Lifecycle;
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
        private PlanRules(
            int? completionWindow,
            PlanRulesLifecycle? lifecycle,
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

    [OutputType]
    public sealed class PlanRulesLifecycle
    {
        /// <summary>
        /// Specifies the number of days after creation that a recovery point is moved to cold storage.
        /// </summary>
        public readonly int? ColdStorageAfter;
        /// <summary>
        /// Specifies the number of days after creation that a recovery point is deleted. Must be 90 days greater than `cold_storage_after`.
        /// </summary>
        public readonly int? DeleteAfter;

        [OutputConstructor]
        private PlanRulesLifecycle(
            int? coldStorageAfter,
            int? deleteAfter)
        {
            ColdStorageAfter = coldStorageAfter;
            DeleteAfter = deleteAfter;
        }
    }
    }
}
