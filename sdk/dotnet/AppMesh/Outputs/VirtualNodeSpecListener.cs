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
    public sealed class VirtualNodeSpecListener
    {
        /// <summary>
        /// The health check information for the listener.
        /// </summary>
        public readonly Outputs.VirtualNodeSpecListenerHealthCheck? HealthCheck;
        /// <summary>
        /// The port mapping information for the listener.
        /// </summary>
        public readonly Outputs.VirtualNodeSpecListenerPortMapping PortMapping;

        [OutputConstructor]
        private VirtualNodeSpecListener(
            Outputs.VirtualNodeSpecListenerHealthCheck? healthCheck,

            Outputs.VirtualNodeSpecListenerPortMapping portMapping)
        {
            HealthCheck = healthCheck;
            PortMapping = portMapping;
        }
    }
}
