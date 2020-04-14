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
    public sealed class VirtualNodeSpec
    {
        /// <summary>
        /// The backends to which the virtual node is expected to send outbound traffic.
        /// </summary>
        public readonly ImmutableArray<Outputs.VirtualNodeSpecBackend> Backends;
        /// <summary>
        /// The listeners from which the virtual node is expected to receive inbound traffic.
        /// </summary>
        public readonly Outputs.VirtualNodeSpecListener? Listener;
        /// <summary>
        /// The inbound and outbound access logging information for the virtual node.
        /// </summary>
        public readonly Outputs.VirtualNodeSpecLogging? Logging;
        /// <summary>
        /// The service discovery information for the virtual node.
        /// </summary>
        public readonly Outputs.VirtualNodeSpecServiceDiscovery? ServiceDiscovery;

        [OutputConstructor]
        private VirtualNodeSpec(
            ImmutableArray<Outputs.VirtualNodeSpecBackend> backends,

            Outputs.VirtualNodeSpecListener? listener,

            Outputs.VirtualNodeSpecLogging? logging,

            Outputs.VirtualNodeSpecServiceDiscovery? serviceDiscovery)
        {
            Backends = backends;
            Listener = listener;
            Logging = logging;
            ServiceDiscovery = serviceDiscovery;
        }
    }
}
