// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.ApiGatewayV2
{
    /// <summary>
    /// Manages an Amazon API Gateway Version 2 route.
    /// More information can be found in the [Amazon API Gateway Developer Guide](https://docs.aws.amazon.com/apigateway/latest/developerguide/apigateway-websocket-api.html).
    /// 
    /// ## Example Usage
    /// 
    /// ### Basic
    /// 
    /// ```csharp
    /// using Pulumi;
    /// using Aws = Pulumi.Aws;
    /// 
    /// class MyStack : Stack
    /// {
    ///     public MyStack()
    ///     {
    ///         var example = new Aws.ApiGatewayV2.Route("example", new Aws.ApiGatewayV2.RouteArgs
    ///         {
    ///             ApiId = aws_apigatewayv2_api.Example.Id,
    ///             RouteKey = "$$default",
    ///         });
    ///     }
    /// 
    /// }
    /// ```
    /// </summary>
    public partial class Route : Pulumi.CustomResource
    {
        /// <summary>
        /// The API identifier.
        /// </summary>
        [Output("apiId")]
        public Output<string> ApiId { get; private set; } = null!;

        /// <summary>
        /// Boolean whether an API key is required for the route. Defaults to `false`.
        /// </summary>
        [Output("apiKeyRequired")]
        public Output<bool?> ApiKeyRequired { get; private set; } = null!;

        /// <summary>
        /// The authorization scopes supported by this route. The scopes are used with a JWT authorizer to authorize the method invocation.
        /// </summary>
        [Output("authorizationScopes")]
        public Output<ImmutableArray<string>> AuthorizationScopes { get; private set; } = null!;

        /// <summary>
        /// The authorization type for the route.
        /// For WebSocket APIs, valid values are `NONE` for open access, `AWS_IAM` for using AWS IAM permissions, and `CUSTOM` for using a Lambda authorizer.
        /// For HTTP APIs, valid values are `NONE` for open access, or `JWT` for using JSON Web Tokens.
        /// Defaults to `NONE`.
        /// </summary>
        [Output("authorizationType")]
        public Output<string?> AuthorizationType { get; private set; } = null!;

        /// <summary>
        /// The identifier of the `aws.apigatewayv2.Authorizer` resource to be associated with this route, if the authorizationType is `CUSTOM`.
        /// </summary>
        [Output("authorizerId")]
        public Output<string?> AuthorizerId { get; private set; } = null!;

        /// <summary>
        /// The [model selection expression](https://docs.aws.amazon.com/apigateway/latest/developerguide/apigateway-websocket-api-selection-expressions.html#apigateway-websocket-api-model-selection-expressions) for the route.
        /// </summary>
        [Output("modelSelectionExpression")]
        public Output<string?> ModelSelectionExpression { get; private set; } = null!;

        /// <summary>
        /// The operation name for the route.
        /// </summary>
        [Output("operationName")]
        public Output<string?> OperationName { get; private set; } = null!;

        /// <summary>
        /// The request models for the route.
        /// </summary>
        [Output("requestModels")]
        public Output<ImmutableDictionary<string, string>?> RequestModels { get; private set; } = null!;

        /// <summary>
        /// The route key for the route.
        /// </summary>
        [Output("routeKey")]
        public Output<string> RouteKey { get; private set; } = null!;

        /// <summary>
        /// The [route response selection expression](https://docs.aws.amazon.com/apigateway/latest/developerguide/apigateway-websocket-api-selection-expressions.html#apigateway-websocket-api-route-response-selection-expressions) for the route.
        /// </summary>
        [Output("routeResponseSelectionExpression")]
        public Output<string?> RouteResponseSelectionExpression { get; private set; } = null!;

        /// <summary>
        /// The target for the route.
        /// </summary>
        [Output("target")]
        public Output<string?> Target { get; private set; } = null!;


        /// <summary>
        /// Create a Route resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Route(string name, RouteArgs args, CustomResourceOptions? options = null)
            : base("aws:apigatewayv2/route:Route", name, args ?? new RouteArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Route(string name, Input<string> id, RouteState? state = null, CustomResourceOptions? options = null)
            : base("aws:apigatewayv2/route:Route", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing Route resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Route Get(string name, Input<string> id, RouteState? state = null, CustomResourceOptions? options = null)
        {
            return new Route(name, id, state, options);
        }
    }

    public sealed class RouteArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The API identifier.
        /// </summary>
        [Input("apiId", required: true)]
        public Input<string> ApiId { get; set; } = null!;

        /// <summary>
        /// Boolean whether an API key is required for the route. Defaults to `false`.
        /// </summary>
        [Input("apiKeyRequired")]
        public Input<bool>? ApiKeyRequired { get; set; }

        [Input("authorizationScopes")]
        private InputList<string>? _authorizationScopes;

        /// <summary>
        /// The authorization scopes supported by this route. The scopes are used with a JWT authorizer to authorize the method invocation.
        /// </summary>
        public InputList<string> AuthorizationScopes
        {
            get => _authorizationScopes ?? (_authorizationScopes = new InputList<string>());
            set => _authorizationScopes = value;
        }

        /// <summary>
        /// The authorization type for the route.
        /// For WebSocket APIs, valid values are `NONE` for open access, `AWS_IAM` for using AWS IAM permissions, and `CUSTOM` for using a Lambda authorizer.
        /// For HTTP APIs, valid values are `NONE` for open access, or `JWT` for using JSON Web Tokens.
        /// Defaults to `NONE`.
        /// </summary>
        [Input("authorizationType")]
        public Input<string>? AuthorizationType { get; set; }

        /// <summary>
        /// The identifier of the `aws.apigatewayv2.Authorizer` resource to be associated with this route, if the authorizationType is `CUSTOM`.
        /// </summary>
        [Input("authorizerId")]
        public Input<string>? AuthorizerId { get; set; }

        /// <summary>
        /// The [model selection expression](https://docs.aws.amazon.com/apigateway/latest/developerguide/apigateway-websocket-api-selection-expressions.html#apigateway-websocket-api-model-selection-expressions) for the route.
        /// </summary>
        [Input("modelSelectionExpression")]
        public Input<string>? ModelSelectionExpression { get; set; }

        /// <summary>
        /// The operation name for the route.
        /// </summary>
        [Input("operationName")]
        public Input<string>? OperationName { get; set; }

        [Input("requestModels")]
        private InputMap<string>? _requestModels;

        /// <summary>
        /// The request models for the route.
        /// </summary>
        public InputMap<string> RequestModels
        {
            get => _requestModels ?? (_requestModels = new InputMap<string>());
            set => _requestModels = value;
        }

        /// <summary>
        /// The route key for the route.
        /// </summary>
        [Input("routeKey", required: true)]
        public Input<string> RouteKey { get; set; } = null!;

        /// <summary>
        /// The [route response selection expression](https://docs.aws.amazon.com/apigateway/latest/developerguide/apigateway-websocket-api-selection-expressions.html#apigateway-websocket-api-route-response-selection-expressions) for the route.
        /// </summary>
        [Input("routeResponseSelectionExpression")]
        public Input<string>? RouteResponseSelectionExpression { get; set; }

        /// <summary>
        /// The target for the route.
        /// </summary>
        [Input("target")]
        public Input<string>? Target { get; set; }

        public RouteArgs()
        {
        }
    }

    public sealed class RouteState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The API identifier.
        /// </summary>
        [Input("apiId")]
        public Input<string>? ApiId { get; set; }

        /// <summary>
        /// Boolean whether an API key is required for the route. Defaults to `false`.
        /// </summary>
        [Input("apiKeyRequired")]
        public Input<bool>? ApiKeyRequired { get; set; }

        [Input("authorizationScopes")]
        private InputList<string>? _authorizationScopes;

        /// <summary>
        /// The authorization scopes supported by this route. The scopes are used with a JWT authorizer to authorize the method invocation.
        /// </summary>
        public InputList<string> AuthorizationScopes
        {
            get => _authorizationScopes ?? (_authorizationScopes = new InputList<string>());
            set => _authorizationScopes = value;
        }

        /// <summary>
        /// The authorization type for the route.
        /// For WebSocket APIs, valid values are `NONE` for open access, `AWS_IAM` for using AWS IAM permissions, and `CUSTOM` for using a Lambda authorizer.
        /// For HTTP APIs, valid values are `NONE` for open access, or `JWT` for using JSON Web Tokens.
        /// Defaults to `NONE`.
        /// </summary>
        [Input("authorizationType")]
        public Input<string>? AuthorizationType { get; set; }

        /// <summary>
        /// The identifier of the `aws.apigatewayv2.Authorizer` resource to be associated with this route, if the authorizationType is `CUSTOM`.
        /// </summary>
        [Input("authorizerId")]
        public Input<string>? AuthorizerId { get; set; }

        /// <summary>
        /// The [model selection expression](https://docs.aws.amazon.com/apigateway/latest/developerguide/apigateway-websocket-api-selection-expressions.html#apigateway-websocket-api-model-selection-expressions) for the route.
        /// </summary>
        [Input("modelSelectionExpression")]
        public Input<string>? ModelSelectionExpression { get; set; }

        /// <summary>
        /// The operation name for the route.
        /// </summary>
        [Input("operationName")]
        public Input<string>? OperationName { get; set; }

        [Input("requestModels")]
        private InputMap<string>? _requestModels;

        /// <summary>
        /// The request models for the route.
        /// </summary>
        public InputMap<string> RequestModels
        {
            get => _requestModels ?? (_requestModels = new InputMap<string>());
            set => _requestModels = value;
        }

        /// <summary>
        /// The route key for the route.
        /// </summary>
        [Input("routeKey")]
        public Input<string>? RouteKey { get; set; }

        /// <summary>
        /// The [route response selection expression](https://docs.aws.amazon.com/apigateway/latest/developerguide/apigateway-websocket-api-selection-expressions.html#apigateway-websocket-api-route-response-selection-expressions) for the route.
        /// </summary>
        [Input("routeResponseSelectionExpression")]
        public Input<string>? RouteResponseSelectionExpression { get; set; }

        /// <summary>
        /// The target for the route.
        /// </summary>
        [Input("target")]
        public Input<string>? Target { get; set; }

        public RouteState()
        {
        }
    }
}
