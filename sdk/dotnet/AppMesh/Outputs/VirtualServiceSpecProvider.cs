// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.AppMesh.Outputs
{

    [OutputType]
    public sealed class VirtualServiceSpecProvider
    {
        /// <summary>
        /// The virtual node associated with a virtual service.
        /// </summary>
        public readonly Outputs.VirtualServiceSpecProviderVirtualNode? VirtualNode;
        /// <summary>
        /// The virtual router associated with a virtual service.
        /// </summary>
        public readonly Outputs.VirtualServiceSpecProviderVirtualRouter? VirtualRouter;

        [OutputConstructor]
        private VirtualServiceSpecProvider(
            Outputs.VirtualServiceSpecProviderVirtualNode? virtualNode,

            Outputs.VirtualServiceSpecProviderVirtualRouter? virtualRouter)
        {
            VirtualNode = virtualNode;
            VirtualRouter = virtualRouter;
        }
    }
}
