// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Ec2ClientVpn.Inputs
{

    public sealed class EndpointAuthenticationOptionsGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The ID of the Active Directory to be used for authentication if type is `directory-service-authentication`.
        /// </summary>
        [Input("activeDirectoryId")]
        public Input<string>? ActiveDirectoryId { get; set; }

        /// <summary>
        /// The ARN of the client certificate. The certificate must be signed by a certificate authority (CA) and it must be provisioned in AWS Certificate Manager (ACM). Only necessary when type is set to `certificate-authentication`.
        /// </summary>
        [Input("rootCertificateChainArn")]
        public Input<string>? RootCertificateChainArn { get; set; }

        /// <summary>
        /// The type of client authentication to be used. Specify `certificate-authentication` to use certificate-based authentication, or `directory-service-authentication` to use Active Directory authentication.
        /// </summary>
        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        public EndpointAuthenticationOptionsGetArgs()
        {
        }
    }
}
