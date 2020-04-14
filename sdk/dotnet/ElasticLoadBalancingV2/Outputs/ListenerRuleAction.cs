// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.ElasticLoadBalancingV2.Outputs
{

    [OutputType]
    public sealed class ListenerRuleAction
    {
        /// <summary>
        /// Information for creating an authenticate action using Cognito. Required if `type` is `authenticate-cognito`.
        /// </summary>
        public readonly Outputs.ListenerRuleActionAuthenticateCognito? AuthenticateCognito;
        /// <summary>
        /// Information for creating an authenticate action using OIDC. Required if `type` is `authenticate-oidc`.
        /// </summary>
        public readonly Outputs.ListenerRuleActionAuthenticateOidc? AuthenticateOidc;
        /// <summary>
        /// Information for creating an action that returns a custom HTTP response. Required if `type` is `fixed-response`.
        /// </summary>
        public readonly Outputs.ListenerRuleActionFixedResponse? FixedResponse;
        public readonly int? Order;
        /// <summary>
        /// Information for creating a redirect action. Required if `type` is `redirect`.
        /// </summary>
        public readonly Outputs.ListenerRuleActionRedirect? Redirect;
        /// <summary>
        /// The ARN of the Target Group to which to route traffic. Required if `type` is `forward`.
        /// </summary>
        public readonly string? TargetGroupArn;
        /// <summary>
        /// The type of routing action. Valid values are `forward`, `redirect`, `fixed-response`, `authenticate-cognito` and `authenticate-oidc`.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private ListenerRuleAction(
            Outputs.ListenerRuleActionAuthenticateCognito? authenticateCognito,

            Outputs.ListenerRuleActionAuthenticateOidc? authenticateOidc,

            Outputs.ListenerRuleActionFixedResponse? fixedResponse,

            int? order,

            Outputs.ListenerRuleActionRedirect? redirect,

            string? targetGroupArn,

            string type)
        {
            AuthenticateCognito = authenticateCognito;
            AuthenticateOidc = authenticateOidc;
            FixedResponse = fixedResponse;
            Order = order;
            Redirect = redirect;
            TargetGroupArn = targetGroupArn;
            Type = type;
        }
    }
}
