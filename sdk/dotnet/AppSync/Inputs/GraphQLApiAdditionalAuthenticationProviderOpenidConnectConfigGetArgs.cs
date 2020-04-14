// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.AppSync.Inputs
{

    public sealed class GraphQLApiAdditionalAuthenticationProviderOpenidConnectConfigGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Number of milliseconds a token is valid after being authenticated.
        /// </summary>
        [Input("authTtl")]
        public Input<int>? AuthTtl { get; set; }

        /// <summary>
        /// Client identifier of the Relying party at the OpenID identity provider. This identifier is typically obtained when the Relying party is registered with the OpenID identity provider. You can specify a regular expression so the AWS AppSync can validate against multiple client identifiers at a time.
        /// </summary>
        [Input("clientId")]
        public Input<string>? ClientId { get; set; }

        /// <summary>
        /// Number of milliseconds a token is valid after being issued to a user.
        /// </summary>
        [Input("iatTtl")]
        public Input<int>? IatTtl { get; set; }

        /// <summary>
        /// Issuer for the OpenID Connect configuration. The issuer returned by discovery MUST exactly match the value of iss in the ID Token.
        /// </summary>
        [Input("issuer", required: true)]
        public Input<string> Issuer { get; set; } = null!;

        public GraphQLApiAdditionalAuthenticationProviderOpenidConnectConfigGetArgs()
        {
        }
    }
}
