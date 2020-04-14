// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.AppSync.Inputs
{

    public sealed class GraphQLApiAdditionalAuthenticationProviderGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The authentication type. Valid values: `API_KEY`, `AWS_IAM`, `AMAZON_COGNITO_USER_POOLS`, `OPENID_CONNECT`
        /// </summary>
        [Input("authenticationType", required: true)]
        public Input<string> AuthenticationType { get; set; } = null!;

        /// <summary>
        /// Nested argument containing OpenID Connect configuration. Defined below.
        /// </summary>
        [Input("openidConnectConfig")]
        public Input<Inputs.GraphQLApiAdditionalAuthenticationProviderOpenidConnectConfigGetArgs>? OpenidConnectConfig { get; set; }

        /// <summary>
        /// The Amazon Cognito User Pool configuration. Defined below.
        /// </summary>
        [Input("userPoolConfig")]
        public Input<Inputs.GraphQLApiAdditionalAuthenticationProviderUserPoolConfigGetArgs>? UserPoolConfig { get; set; }

        public GraphQLApiAdditionalAuthenticationProviderGetArgs()
        {
        }
    }
}
