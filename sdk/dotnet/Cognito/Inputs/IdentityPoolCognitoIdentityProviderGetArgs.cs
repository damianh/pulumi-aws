// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Cognito.Inputs
{

    public sealed class IdentityPoolCognitoIdentityProviderGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The client ID for the Amazon Cognito Identity User Pool.
        /// </summary>
        [Input("clientId")]
        public Input<string>? ClientId { get; set; }

        /// <summary>
        /// The provider name for an Amazon Cognito Identity User Pool.
        /// </summary>
        [Input("providerName")]
        public Input<string>? ProviderName { get; set; }

        /// <summary>
        /// Whether server-side token validation is enabled for the identity provider’s token or not.
        /// </summary>
        [Input("serverSideTokenCheck")]
        public Input<bool>? ServerSideTokenCheck { get; set; }

        public IdentityPoolCognitoIdentityProviderGetArgs()
        {
        }
    }
}
