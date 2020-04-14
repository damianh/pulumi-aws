// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Ssm.Inputs
{

    public sealed class MaintenanceWindowTaskTaskInvocationParametersArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The parameters for an AUTOMATION task type. Documented below.
        /// </summary>
        [Input("automationParameters")]
        public Input<Inputs.MaintenanceWindowTaskTaskInvocationParametersAutomationParametersArgs>? AutomationParameters { get; set; }

        /// <summary>
        /// The parameters for a LAMBDA task type. Documented below.
        /// </summary>
        [Input("lambdaParameters")]
        public Input<Inputs.MaintenanceWindowTaskTaskInvocationParametersLambdaParametersArgs>? LambdaParameters { get; set; }

        /// <summary>
        /// The parameters for a RUN_COMMAND task type. Documented below.
        /// </summary>
        [Input("runCommandParameters")]
        public Input<Inputs.MaintenanceWindowTaskTaskInvocationParametersRunCommandParametersArgs>? RunCommandParameters { get; set; }

        /// <summary>
        /// The parameters for a STEP_FUNCTIONS task type. Documented below.
        /// </summary>
        [Input("stepFunctionsParameters")]
        public Input<Inputs.MaintenanceWindowTaskTaskInvocationParametersStepFunctionsParametersArgs>? StepFunctionsParameters { get; set; }

        public MaintenanceWindowTaskTaskInvocationParametersArgs()
        {
        }
    }
}
