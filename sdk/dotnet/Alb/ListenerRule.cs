// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Alb
{
    /// <summary>
    /// Provides a Load Balancer Listener Rule resource.
    /// 
    /// &gt; **Note:** `aws.alb.ListenerRule` is known as `aws.lb.ListenerRule`. The functionality is identical.
    /// 
    /// ## Example Usage
    /// 
    /// 
    /// 
    /// ```csharp
    /// using Pulumi;
    /// using Aws = Pulumi.Aws;
    /// 
    /// class MyStack : Stack
    /// {
    ///     public MyStack()
    ///     {
    ///         var frontEndLoadBalancer = new Aws.LB.LoadBalancer("frontEndLoadBalancer", new Aws.LB.LoadBalancerArgs
    ///         {
    ///         });
    ///         var frontEndListener = new Aws.LB.Listener("frontEndListener", new Aws.LB.ListenerArgs
    ///         {
    ///         });
    ///         var @static = new Aws.LB.ListenerRule("static", new Aws.LB.ListenerRuleArgs
    ///         {
    ///             Actions = 
    ///             {
    ///                 new Aws.LB.Inputs.ListenerRuleActionArgs
    ///                 {
    ///                     TargetGroupArn = aws_lb_target_group.Static.Arn,
    ///                     Type = "forward",
    ///                 },
    ///             },
    ///             Conditions = 
    ///             {
    ///                 new Aws.LB.Inputs.ListenerRuleConditionArgs
    ///                 {
    ///                     PathPattern = new Aws.LB.Inputs.ListenerRuleConditionPathPatternArgs
    ///                     {
    ///                         Values = 
    ///                         {
    ///                             "/static/*",
    ///                         },
    ///                     },
    ///                 },
    ///                 new Aws.LB.Inputs.ListenerRuleConditionArgs
    ///                 {
    ///                     HostHeader = new Aws.LB.Inputs.ListenerRuleConditionHostHeaderArgs
    ///                     {
    ///                         Values = 
    ///                         {
    ///                             "example.com",
    ///                         },
    ///                     },
    ///                 },
    ///             },
    ///             ListenerArn = frontEndListener.Arn,
    ///             Priority = 100,
    ///         });
    ///         var hostBasedRouting = new Aws.LB.ListenerRule("hostBasedRouting", new Aws.LB.ListenerRuleArgs
    ///         {
    ///             Actions = 
    ///             {
    ///                 new Aws.LB.Inputs.ListenerRuleActionArgs
    ///                 {
    ///                     Forward = new Aws.LB.Inputs.ListenerRuleActionForwardArgs
    ///                     {
    ///                         Stickiness = new Aws.LB.Inputs.ListenerRuleActionForwardStickinessArgs
    ///                         {
    ///                             Duration = 600,
    ///                             Enabled = true,
    ///                         },
    ///                         TargetGroup = 
    ///                         {
    ///                             
    ///                             {
    ///                                 { "arn", aws_lb_target_group.Main.Arn },
    ///                                 { "weight", 80 },
    ///                             },
    ///                             
    ///                             {
    ///                                 { "arn", aws_lb_target_group.Canary.Arn },
    ///                                 { "weight", 20 },
    ///                             },
    ///                         },
    ///                     },
    ///                     Type = "forward",
    ///                 },
    ///             },
    ///             Conditions = 
    ///             {
    ///                 new Aws.LB.Inputs.ListenerRuleConditionArgs
    ///                 {
    ///                     HostHeader = new Aws.LB.Inputs.ListenerRuleConditionHostHeaderArgs
    ///                     {
    ///                         Values = 
    ///                         {
    ///                             "my-service.*.mycompany.io",
    ///                         },
    ///                     },
    ///                 },
    ///             },
    ///             ListenerArn = frontEndListener.Arn,
    ///             Priority = 99,
    ///         });
    ///         var hostBasedWeightedRouting = new Aws.LB.ListenerRule("hostBasedWeightedRouting", new Aws.LB.ListenerRuleArgs
    ///         {
    ///             Actions = 
    ///             {
    ///                 new Aws.LB.Inputs.ListenerRuleActionArgs
    ///                 {
    ///                     TargetGroupArn = aws_lb_target_group.Static.Arn,
    ///                     Type = "forward",
    ///                 },
    ///             },
    ///             Conditions = 
    ///             {
    ///                 new Aws.LB.Inputs.ListenerRuleConditionArgs
    ///                 {
    ///                     HostHeader = new Aws.LB.Inputs.ListenerRuleConditionHostHeaderArgs
    ///                     {
    ///                         Values = 
    ///                         {
    ///                             "my-service.*.mydomain.io",
    ///                         },
    ///                     },
    ///                 },
    ///             },
    ///             ListenerArn = frontEndListener.Arn,
    ///             Priority = 99,
    ///         });
    ///         var redirectHttpToHttps = new Aws.LB.ListenerRule("redirectHttpToHttps", new Aws.LB.ListenerRuleArgs
    ///         {
    ///             Actions = 
    ///             {
    ///                 new Aws.LB.Inputs.ListenerRuleActionArgs
    ///                 {
    ///                     Redirect = new Aws.LB.Inputs.ListenerRuleActionRedirectArgs
    ///                     {
    ///                         Port = "443",
    ///                         Protocol = "HTTPS",
    ///                         StatusCode = "HTTP_301",
    ///                     },
    ///                     Type = "redirect",
    ///                 },
    ///             },
    ///             Conditions = 
    ///             {
    ///                 new Aws.LB.Inputs.ListenerRuleConditionArgs
    ///                 {
    ///                     HttpHeader = new Aws.LB.Inputs.ListenerRuleConditionHttpHeaderArgs
    ///                     {
    ///                         HttpHeaderName = "X-Forwarded-For",
    ///                         Values = 
    ///                         {
    ///                             "192.168.1.*",
    ///                         },
    ///                     },
    ///                 },
    ///             },
    ///             ListenerArn = frontEndListener.Arn,
    ///         });
    ///         var healthCheck = new Aws.LB.ListenerRule("healthCheck", new Aws.LB.ListenerRuleArgs
    ///         {
    ///             Actions = 
    ///             {
    ///                 new Aws.LB.Inputs.ListenerRuleActionArgs
    ///                 {
    ///                     FixedResponse = new Aws.LB.Inputs.ListenerRuleActionFixedResponseArgs
    ///                     {
    ///                         ContentType = "text/plain",
    ///                         MessageBody = "HEALTHY",
    ///                         StatusCode = "200",
    ///                     },
    ///                     Type = "fixed-response",
    ///                 },
    ///             },
    ///             Conditions = 
    ///             {
    ///                 new Aws.LB.Inputs.ListenerRuleConditionArgs
    ///                 {
    ///                     QueryString = 
    ///                     {
    ///                         
    ///                         {
    ///                             { "key", "health" },
    ///                             { "value", "check" },
    ///                         },
    ///                         
    ///                         {
    ///                             { "value", "bar" },
    ///                         },
    ///                     },
    ///                 },
    ///             },
    ///             ListenerArn = frontEndListener.Arn,
    ///         });
    ///         var pool = new Aws.Cognito.UserPool("pool", new Aws.Cognito.UserPoolArgs
    ///         {
    ///         });
    ///         var client = new Aws.Cognito.UserPoolClient("client", new Aws.Cognito.UserPoolClientArgs
    ///         {
    ///         });
    ///         var domain = new Aws.Cognito.UserPoolDomain("domain", new Aws.Cognito.UserPoolDomainArgs
    ///         {
    ///         });
    ///         var admin = new Aws.LB.ListenerRule("admin", new Aws.LB.ListenerRuleArgs
    ///         {
    ///             Actions = 
    ///             {
    ///                 new Aws.LB.Inputs.ListenerRuleActionArgs
    ///                 {
    ///                     AuthenticateOidc = new Aws.LB.Inputs.ListenerRuleActionAuthenticateOidcArgs
    ///                     {
    ///                         AuthorizationEndpoint = "https://example.com/authorization_endpoint",
    ///                         ClientId = "client_id",
    ///                         ClientSecret = "client_secret",
    ///                         Issuer = "https://example.com",
    ///                         TokenEndpoint = "https://example.com/token_endpoint",
    ///                         UserInfoEndpoint = "https://example.com/user_info_endpoint",
    ///                     },
    ///                     Type = "authenticate-oidc",
    ///                 },
    ///                 new Aws.LB.Inputs.ListenerRuleActionArgs
    ///                 {
    ///                     TargetGroupArn = aws_lb_target_group.Static.Arn,
    ///                     Type = "forward",
    ///                 },
    ///             },
    ///             ListenerArn = frontEndListener.Arn,
    ///         });
    ///     }
    /// 
    /// }
    /// ```
    /// </summary>
    public partial class ListenerRule : Pulumi.CustomResource
    {
        /// <summary>
        /// An Action block. Action blocks are documented below.
        /// </summary>
        [Output("actions")]
        public Output<ImmutableArray<Outputs.ListenerRuleAction>> Actions { get; private set; } = null!;

        /// <summary>
        /// The Amazon Resource Name (ARN) of the target group.
        /// </summary>
        [Output("arn")]
        public Output<string> Arn { get; private set; } = null!;

        /// <summary>
        /// A Condition block. Multiple condition blocks of different types can be set and all must be satisfied for the rule to match. Condition blocks are documented below.
        /// </summary>
        [Output("conditions")]
        public Output<ImmutableArray<Outputs.ListenerRuleCondition>> Conditions { get; private set; } = null!;

        /// <summary>
        /// The ARN of the listener to which to attach the rule.
        /// </summary>
        [Output("listenerArn")]
        public Output<string> ListenerArn { get; private set; } = null!;

        /// <summary>
        /// The priority for the rule between `1` and `50000`. Leaving it unset will automatically set the rule with next available priority after currently existing highest rule. A listener can't have multiple rules with the same priority.
        /// </summary>
        [Output("priority")]
        public Output<int> Priority { get; private set; } = null!;


        /// <summary>
        /// Create a ListenerRule resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public ListenerRule(string name, ListenerRuleArgs args, CustomResourceOptions? options = null)
            : base("aws:alb/listenerRule:ListenerRule", name, args ?? new ListenerRuleArgs(), MakeResourceOptions(options, ""))
        {
        }

        private ListenerRule(string name, Input<string> id, ListenerRuleState? state = null, CustomResourceOptions? options = null)
            : base("aws:alb/listenerRule:ListenerRule", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Alias { Type = "aws:applicationloadbalancing/listenerRule:ListenerRule"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing ListenerRule resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static ListenerRule Get(string name, Input<string> id, ListenerRuleState? state = null, CustomResourceOptions? options = null)
        {
            return new ListenerRule(name, id, state, options);
        }
    }

    public sealed class ListenerRuleArgs : Pulumi.ResourceArgs
    {
        [Input("actions", required: true)]
        private InputList<Inputs.ListenerRuleActionArgs>? _actions;

        /// <summary>
        /// An Action block. Action blocks are documented below.
        /// </summary>
        public InputList<Inputs.ListenerRuleActionArgs> Actions
        {
            get => _actions ?? (_actions = new InputList<Inputs.ListenerRuleActionArgs>());
            set => _actions = value;
        }

        [Input("conditions", required: true)]
        private InputList<Inputs.ListenerRuleConditionArgs>? _conditions;

        /// <summary>
        /// A Condition block. Multiple condition blocks of different types can be set and all must be satisfied for the rule to match. Condition blocks are documented below.
        /// </summary>
        public InputList<Inputs.ListenerRuleConditionArgs> Conditions
        {
            get => _conditions ?? (_conditions = new InputList<Inputs.ListenerRuleConditionArgs>());
            set => _conditions = value;
        }

        /// <summary>
        /// The ARN of the listener to which to attach the rule.
        /// </summary>
        [Input("listenerArn", required: true)]
        public Input<string> ListenerArn { get; set; } = null!;

        /// <summary>
        /// The priority for the rule between `1` and `50000`. Leaving it unset will automatically set the rule with next available priority after currently existing highest rule. A listener can't have multiple rules with the same priority.
        /// </summary>
        [Input("priority")]
        public Input<int>? Priority { get; set; }

        public ListenerRuleArgs()
        {
        }
    }

    public sealed class ListenerRuleState : Pulumi.ResourceArgs
    {
        [Input("actions")]
        private InputList<Inputs.ListenerRuleActionGetArgs>? _actions;

        /// <summary>
        /// An Action block. Action blocks are documented below.
        /// </summary>
        public InputList<Inputs.ListenerRuleActionGetArgs> Actions
        {
            get => _actions ?? (_actions = new InputList<Inputs.ListenerRuleActionGetArgs>());
            set => _actions = value;
        }

        /// <summary>
        /// The Amazon Resource Name (ARN) of the target group.
        /// </summary>
        [Input("arn")]
        public Input<string>? Arn { get; set; }

        [Input("conditions")]
        private InputList<Inputs.ListenerRuleConditionGetArgs>? _conditions;

        /// <summary>
        /// A Condition block. Multiple condition blocks of different types can be set and all must be satisfied for the rule to match. Condition blocks are documented below.
        /// </summary>
        public InputList<Inputs.ListenerRuleConditionGetArgs> Conditions
        {
            get => _conditions ?? (_conditions = new InputList<Inputs.ListenerRuleConditionGetArgs>());
            set => _conditions = value;
        }

        /// <summary>
        /// The ARN of the listener to which to attach the rule.
        /// </summary>
        [Input("listenerArn")]
        public Input<string>? ListenerArn { get; set; }

        /// <summary>
        /// The priority for the rule between `1` and `50000`. Leaving it unset will automatically set the rule with next available priority after currently existing highest rule. A listener can't have multiple rules with the same priority.
        /// </summary>
        [Input("priority")]
        public Input<int>? Priority { get; set; }

        public ListenerRuleState()
        {
        }
    }
}
