// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.CodeDeploy.Outputs
{

    [OutputType]
    public sealed class DeploymentGroupLoadBalancerInfoTargetGroupPairInfoTargetGroup
    {
        /// <summary>
        /// Name of the target group.
        /// </summary>
        public readonly string Name;

        [OutputConstructor]
        private DeploymentGroupLoadBalancerInfoTargetGroupPairInfoTargetGroup(string name)
        {
            Name = name;
        }
    }
}
