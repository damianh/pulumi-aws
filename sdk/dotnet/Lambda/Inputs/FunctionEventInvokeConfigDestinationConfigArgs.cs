// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Lambda.Inputs
{

    public sealed class FunctionEventInvokeConfigDestinationConfigArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Configuration block with destination configuration for failed asynchronous invocations. See below for details.
        /// </summary>
        [Input("onFailure")]
        public Input<Inputs.FunctionEventInvokeConfigDestinationConfigOnFailureArgs>? OnFailure { get; set; }

        /// <summary>
        /// Configuration block with destination configuration for successful asynchronous invocations. See below for details.
        /// </summary>
        [Input("onSuccess")]
        public Input<Inputs.FunctionEventInvokeConfigDestinationConfigOnSuccessArgs>? OnSuccess { get; set; }

        public FunctionEventInvokeConfigDestinationConfigArgs()
        {
        }
    }
}
