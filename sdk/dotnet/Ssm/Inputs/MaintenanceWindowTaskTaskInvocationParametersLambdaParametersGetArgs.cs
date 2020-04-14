// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Ssm.Inputs
{

    public sealed class MaintenanceWindowTaskTaskInvocationParametersLambdaParametersGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Pass client-specific information to the Lambda function that you are invoking.
        /// </summary>
        [Input("clientContext")]
        public Input<string>? ClientContext { get; set; }

        /// <summary>
        /// JSON to provide to your Lambda function as input.
        /// </summary>
        [Input("payload")]
        public Input<string>? Payload { get; set; }

        /// <summary>
        /// Specify a Lambda function version or alias name.
        /// </summary>
        [Input("qualifier")]
        public Input<string>? Qualifier { get; set; }

        public MaintenanceWindowTaskTaskInvocationParametersLambdaParametersGetArgs()
        {
        }
    }
}
