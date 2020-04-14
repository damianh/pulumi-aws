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
    public sealed class VirtualNodeSpecServiceDiscoveryAwsCloudMap
    {
        /// <summary>
        /// A string map that contains attributes with values that you can use to filter instances by any custom attribute that you specified when you registered the instance. Only instances that match all of the specified key/value pairs will be returned.
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Attributes;
        /// <summary>
        /// The name of the AWS Cloud Map namespace to use.
        /// Use the [`aws.servicediscovery.HttpNamespace`](https://www.terraform.io/docs/providers/aws/r/service_discovery_http_namespace.html) resource to configure a Cloud Map namespace.
        /// </summary>
        public readonly string NamespaceName;
        /// <summary>
        /// The name of the AWS Cloud Map service to use. Use the [`aws.servicediscovery.Service`](https://www.terraform.io/docs/providers/aws/r/service_discovery_service.html) resource to configure a Cloud Map service.
        /// </summary>
        public readonly string ServiceName;

        [OutputConstructor]
        private VirtualNodeSpecServiceDiscoveryAwsCloudMap(
            ImmutableDictionary<string, string>? attributes,

            string namespaceName,

            string serviceName)
        {
            Attributes = attributes;
            NamespaceName = namespaceName;
            ServiceName = serviceName;
        }
    }
}
