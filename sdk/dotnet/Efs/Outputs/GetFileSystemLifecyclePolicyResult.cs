// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Efs.Outputs
{

    [OutputType]
    public sealed class GetFileSystemLifecyclePolicyResult
    {
        public readonly string TransitionToIa;

        [OutputConstructor]
        private GetFileSystemLifecyclePolicyResult(string transitionToIa)
        {
            TransitionToIa = transitionToIa;
        }
    }
}
