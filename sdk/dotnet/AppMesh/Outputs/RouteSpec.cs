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
    public sealed class RouteSpec
    {
        /// <summary>
        /// The HTTP routing information for the route.
        /// </summary>
        public readonly Outputs.RouteSpecHttpRoute? HttpRoute;
        /// <summary>
        /// The priority for the route, between `0` and `1000`.
        /// Routes are matched based on the specified value, where `0` is the highest priority.
        /// </summary>
        public readonly int? Priority;
        /// <summary>
        /// The TCP routing information for the route.
        /// </summary>
        public readonly Outputs.RouteSpecTcpRoute? TcpRoute;

        [OutputConstructor]
        private RouteSpec(
            Outputs.RouteSpecHttpRoute? httpRoute,

            int? priority,

            Outputs.RouteSpecTcpRoute? tcpRoute)
        {
            HttpRoute = httpRoute;
            Priority = priority;
            TcpRoute = tcpRoute;
        }
    }
}
