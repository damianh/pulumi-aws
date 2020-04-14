// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.CodeDeploy.Inputs
{

    public sealed class DeploymentGroupAlarmConfigurationGetArgs : Pulumi.ResourceArgs
    {
        [Input("alarms")]
        private InputList<string>? _alarms;

        /// <summary>
        /// A list of alarms configured for the deployment group. _A maximum of 10 alarms can be added to a deployment group_.
        /// </summary>
        public InputList<string> Alarms
        {
            get => _alarms ?? (_alarms = new InputList<string>());
            set => _alarms = value;
        }

        /// <summary>
        /// Indicates whether the alarm configuration is enabled. This option is useful when you want to temporarily deactivate alarm monitoring for a deployment group without having to add the same alarms again later.
        /// </summary>
        [Input("enabled")]
        public Input<bool>? Enabled { get; set; }

        /// <summary>
        /// Indicates whether a deployment should continue if information about the current state of alarms cannot be retrieved from CloudWatch. The default value is `false`.
        /// * `true`: The deployment will proceed even if alarm status information can't be retrieved.
        /// * `false`: The deployment will stop if alarm status information can't be retrieved.
        /// </summary>
        [Input("ignorePollAlarmFailure")]
        public Input<bool>? IgnorePollAlarmFailure { get; set; }

        public DeploymentGroupAlarmConfigurationGetArgs()
        {
        }
    }
}
