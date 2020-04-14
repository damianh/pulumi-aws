// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Ssm.Inputs
{

    public sealed class PatchBaselineApprovalRuleArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The number of days after the release date of each patch matched by the rule the patch is marked as approved in the patch baseline. Valid Range: 0 to 100.
        /// </summary>
        [Input("approveAfterDays", required: true)]
        public Input<int> ApproveAfterDays { get; set; } = null!;

        /// <summary>
        /// Defines the compliance level for patches approved by this rule. Valid compliance levels include the following: `CRITICAL`, `HIGH`, `MEDIUM`, `LOW`, `INFORMATIONAL`, `UNSPECIFIED`. The default value is `UNSPECIFIED`.
        /// </summary>
        [Input("complianceLevel")]
        public Input<string>? ComplianceLevel { get; set; }

        /// <summary>
        /// Boolean enabling the application of non-security updates. The default value is 'false'. Valid for Linux instances only.
        /// </summary>
        [Input("enableNonSecurity")]
        public Input<bool>? EnableNonSecurity { get; set; }

        [Input("patchFilters", required: true)]
        private InputList<Inputs.PatchBaselineApprovalRulePatchFilterArgs>? _patchFilters;

        /// <summary>
        /// The patch filter group that defines the criteria for the rule. Up to 5 patch filters can be specified per approval rule using Key/Value pairs. Valid Keys are `PATCH_SET | PRODUCT | CLASSIFICATION | MSRC_SEVERITY | PATCH_ID`.
        /// * `PATCH_SET` defaults to `OS` if unspecified
        /// </summary>
        public InputList<Inputs.PatchBaselineApprovalRulePatchFilterArgs> PatchFilters
        {
            get => _patchFilters ?? (_patchFilters = new InputList<Inputs.PatchBaselineApprovalRulePatchFilterArgs>());
            set => _patchFilters = value;
        }

        public PatchBaselineApprovalRuleArgs()
        {
        }
    }
}
