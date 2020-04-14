// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.LB.Outputs
{

    [OutputType]
    public sealed class ListenerRuleActionAuthenticateCognito
    {
        /// <summary>
        /// The query parameters to include in the redirect request to the authorization endpoint. Max: 10.
        /// </summary>
        public readonly ImmutableDictionary<string, object>? AuthenticationRequestExtraParams;
        /// <summary>
        /// The behavior if the user is not authenticated. Valid values: `deny`, `allow` and `authenticate`
        /// </summary>
        public readonly string? OnUnauthenticatedRequest;
        /// <summary>
        /// The set of user claims to be requested from the IdP.
        /// </summary>
        public readonly string? Scope;
        /// <summary>
        /// The name of the cookie used to maintain session information.
        /// </summary>
        public readonly string? SessionCookieName;
        /// <summary>
        /// The maximum duration of the authentication session, in seconds.
        /// </summary>
        public readonly int? SessionTimeout;
        /// <summary>
        /// The ARN of the Cognito user pool.
        /// </summary>
        public readonly string UserPoolArn;
        /// <summary>
        /// The ID of the Cognito user pool client.
        /// </summary>
        public readonly string UserPoolClientId;
        /// <summary>
        /// The domain prefix or fully-qualified domain name of the Cognito user pool.
        /// </summary>
        public readonly string UserPoolDomain;

        [OutputConstructor]
        private ListenerRuleActionAuthenticateCognito(
            ImmutableDictionary<string, object>? authenticationRequestExtraParams,

            string? onUnauthenticatedRequest,

            string? scope,

            string? sessionCookieName,

            int? sessionTimeout,

            string userPoolArn,

            string userPoolClientId,

            string userPoolDomain)
        {
            AuthenticationRequestExtraParams = authenticationRequestExtraParams;
            OnUnauthenticatedRequest = onUnauthenticatedRequest;
            Scope = scope;
            SessionCookieName = sessionCookieName;
            SessionTimeout = sessionTimeout;
            UserPoolArn = userPoolArn;
            UserPoolClientId = userPoolClientId;
            UserPoolDomain = userPoolDomain;
        }
    }
}
