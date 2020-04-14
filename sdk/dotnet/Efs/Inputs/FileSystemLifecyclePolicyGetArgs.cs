// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Efs.Inputs
{

    public sealed class FileSystemLifecyclePolicyGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Indicates how long it takes to transition files to the IA storage class. Valid values: `AFTER_7_DAYS`, `AFTER_14_DAYS`, `AFTER_30_DAYS`, `AFTER_60_DAYS`, or `AFTER_90_DAYS`.
        /// </summary>
        [Input("transitionToIa")]
        public Input<string>? TransitionToIa { get; set; }

        public FileSystemLifecyclePolicyGetArgs()
        {
        }
    }
}
