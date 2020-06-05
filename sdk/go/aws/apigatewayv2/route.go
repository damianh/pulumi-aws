// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package apigatewayv2

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Manages an Amazon API Gateway Version 2 route.
// More information can be found in the [Amazon API Gateway Developer Guide](https://docs.aws.amazon.com/apigateway/latest/developerguide/apigateway-websocket-api.html).
type Route struct {
	pulumi.CustomResourceState

	// The API identifier.
	ApiId pulumi.StringOutput `pulumi:"apiId"`
	// Boolean whether an API key is required for the route. Defaults to `false`.
	ApiKeyRequired pulumi.BoolPtrOutput `pulumi:"apiKeyRequired"`
	// The authorization scopes supported by this route. The scopes are used with a JWT authorizer to authorize the method invocation.
	AuthorizationScopes pulumi.StringArrayOutput `pulumi:"authorizationScopes"`
	// The authorization type for the route.
	// For WebSocket APIs, valid values are `NONE` for open access, `AWS_IAM` for using AWS IAM permissions, and `CUSTOM` for using a Lambda authorizer.
	// For HTTP APIs, valid values are `NONE` for open access, or `JWT` for using JSON Web Tokens.
	// Defaults to `NONE`.
	AuthorizationType pulumi.StringPtrOutput `pulumi:"authorizationType"`
	// The identifier of the `apigatewayv2.Authorizer` resource to be associated with this route, if the authorizationType is `CUSTOM`.
	AuthorizerId pulumi.StringPtrOutput `pulumi:"authorizerId"`
	// The [model selection expression](https://docs.aws.amazon.com/apigateway/latest/developerguide/apigateway-websocket-api-selection-expressions.html#apigateway-websocket-api-model-selection-expressions) for the route.
	ModelSelectionExpression pulumi.StringPtrOutput `pulumi:"modelSelectionExpression"`
	// The operation name for the route.
	OperationName pulumi.StringPtrOutput `pulumi:"operationName"`
	// The request models for the route.
	RequestModels pulumi.StringMapOutput `pulumi:"requestModels"`
	// The route key for the route.
	RouteKey pulumi.StringOutput `pulumi:"routeKey"`
	// The [route response selection expression](https://docs.aws.amazon.com/apigateway/latest/developerguide/apigateway-websocket-api-selection-expressions.html#apigateway-websocket-api-route-response-selection-expressions) for the route.
	RouteResponseSelectionExpression pulumi.StringPtrOutput `pulumi:"routeResponseSelectionExpression"`
	// The target for the route.
	Target pulumi.StringPtrOutput `pulumi:"target"`
}

// NewRoute registers a new resource with the given unique name, arguments, and options.
func NewRoute(ctx *pulumi.Context,
	name string, args *RouteArgs, opts ...pulumi.ResourceOption) (*Route, error) {
	if args == nil || args.ApiId == nil {
		return nil, errors.New("missing required argument 'ApiId'")
	}
	if args == nil || args.RouteKey == nil {
		return nil, errors.New("missing required argument 'RouteKey'")
	}
	if args == nil {
		args = &RouteArgs{}
	}
	var resource Route
	err := ctx.RegisterResource("aws:apigatewayv2/route:Route", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetRoute gets an existing Route resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetRoute(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *RouteState, opts ...pulumi.ResourceOption) (*Route, error) {
	var resource Route
	err := ctx.ReadResource("aws:apigatewayv2/route:Route", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Route resources.
type routeState struct {
	// The API identifier.
	ApiId *string `pulumi:"apiId"`
	// Boolean whether an API key is required for the route. Defaults to `false`.
	ApiKeyRequired *bool `pulumi:"apiKeyRequired"`
	// The authorization scopes supported by this route. The scopes are used with a JWT authorizer to authorize the method invocation.
	AuthorizationScopes []string `pulumi:"authorizationScopes"`
	// The authorization type for the route.
	// For WebSocket APIs, valid values are `NONE` for open access, `AWS_IAM` for using AWS IAM permissions, and `CUSTOM` for using a Lambda authorizer.
	// For HTTP APIs, valid values are `NONE` for open access, or `JWT` for using JSON Web Tokens.
	// Defaults to `NONE`.
	AuthorizationType *string `pulumi:"authorizationType"`
	// The identifier of the `apigatewayv2.Authorizer` resource to be associated with this route, if the authorizationType is `CUSTOM`.
	AuthorizerId *string `pulumi:"authorizerId"`
	// The [model selection expression](https://docs.aws.amazon.com/apigateway/latest/developerguide/apigateway-websocket-api-selection-expressions.html#apigateway-websocket-api-model-selection-expressions) for the route.
	ModelSelectionExpression *string `pulumi:"modelSelectionExpression"`
	// The operation name for the route.
	OperationName *string `pulumi:"operationName"`
	// The request models for the route.
	RequestModels map[string]string `pulumi:"requestModels"`
	// The route key for the route.
	RouteKey *string `pulumi:"routeKey"`
	// The [route response selection expression](https://docs.aws.amazon.com/apigateway/latest/developerguide/apigateway-websocket-api-selection-expressions.html#apigateway-websocket-api-route-response-selection-expressions) for the route.
	RouteResponseSelectionExpression *string `pulumi:"routeResponseSelectionExpression"`
	// The target for the route.
	Target *string `pulumi:"target"`
}

type RouteState struct {
	// The API identifier.
	ApiId pulumi.StringPtrInput
	// Boolean whether an API key is required for the route. Defaults to `false`.
	ApiKeyRequired pulumi.BoolPtrInput
	// The authorization scopes supported by this route. The scopes are used with a JWT authorizer to authorize the method invocation.
	AuthorizationScopes pulumi.StringArrayInput
	// The authorization type for the route.
	// For WebSocket APIs, valid values are `NONE` for open access, `AWS_IAM` for using AWS IAM permissions, and `CUSTOM` for using a Lambda authorizer.
	// For HTTP APIs, valid values are `NONE` for open access, or `JWT` for using JSON Web Tokens.
	// Defaults to `NONE`.
	AuthorizationType pulumi.StringPtrInput
	// The identifier of the `apigatewayv2.Authorizer` resource to be associated with this route, if the authorizationType is `CUSTOM`.
	AuthorizerId pulumi.StringPtrInput
	// The [model selection expression](https://docs.aws.amazon.com/apigateway/latest/developerguide/apigateway-websocket-api-selection-expressions.html#apigateway-websocket-api-model-selection-expressions) for the route.
	ModelSelectionExpression pulumi.StringPtrInput
	// The operation name for the route.
	OperationName pulumi.StringPtrInput
	// The request models for the route.
	RequestModels pulumi.StringMapInput
	// The route key for the route.
	RouteKey pulumi.StringPtrInput
	// The [route response selection expression](https://docs.aws.amazon.com/apigateway/latest/developerguide/apigateway-websocket-api-selection-expressions.html#apigateway-websocket-api-route-response-selection-expressions) for the route.
	RouteResponseSelectionExpression pulumi.StringPtrInput
	// The target for the route.
	Target pulumi.StringPtrInput
}

func (RouteState) ElementType() reflect.Type {
	return reflect.TypeOf((*routeState)(nil)).Elem()
}

type routeArgs struct {
	// The API identifier.
	ApiId string `pulumi:"apiId"`
	// Boolean whether an API key is required for the route. Defaults to `false`.
	ApiKeyRequired *bool `pulumi:"apiKeyRequired"`
	// The authorization scopes supported by this route. The scopes are used with a JWT authorizer to authorize the method invocation.
	AuthorizationScopes []string `pulumi:"authorizationScopes"`
	// The authorization type for the route.
	// For WebSocket APIs, valid values are `NONE` for open access, `AWS_IAM` for using AWS IAM permissions, and `CUSTOM` for using a Lambda authorizer.
	// For HTTP APIs, valid values are `NONE` for open access, or `JWT` for using JSON Web Tokens.
	// Defaults to `NONE`.
	AuthorizationType *string `pulumi:"authorizationType"`
	// The identifier of the `apigatewayv2.Authorizer` resource to be associated with this route, if the authorizationType is `CUSTOM`.
	AuthorizerId *string `pulumi:"authorizerId"`
	// The [model selection expression](https://docs.aws.amazon.com/apigateway/latest/developerguide/apigateway-websocket-api-selection-expressions.html#apigateway-websocket-api-model-selection-expressions) for the route.
	ModelSelectionExpression *string `pulumi:"modelSelectionExpression"`
	// The operation name for the route.
	OperationName *string `pulumi:"operationName"`
	// The request models for the route.
	RequestModels map[string]string `pulumi:"requestModels"`
	// The route key for the route.
	RouteKey string `pulumi:"routeKey"`
	// The [route response selection expression](https://docs.aws.amazon.com/apigateway/latest/developerguide/apigateway-websocket-api-selection-expressions.html#apigateway-websocket-api-route-response-selection-expressions) for the route.
	RouteResponseSelectionExpression *string `pulumi:"routeResponseSelectionExpression"`
	// The target for the route.
	Target *string `pulumi:"target"`
}

// The set of arguments for constructing a Route resource.
type RouteArgs struct {
	// The API identifier.
	ApiId pulumi.StringInput
	// Boolean whether an API key is required for the route. Defaults to `false`.
	ApiKeyRequired pulumi.BoolPtrInput
	// The authorization scopes supported by this route. The scopes are used with a JWT authorizer to authorize the method invocation.
	AuthorizationScopes pulumi.StringArrayInput
	// The authorization type for the route.
	// For WebSocket APIs, valid values are `NONE` for open access, `AWS_IAM` for using AWS IAM permissions, and `CUSTOM` for using a Lambda authorizer.
	// For HTTP APIs, valid values are `NONE` for open access, or `JWT` for using JSON Web Tokens.
	// Defaults to `NONE`.
	AuthorizationType pulumi.StringPtrInput
	// The identifier of the `apigatewayv2.Authorizer` resource to be associated with this route, if the authorizationType is `CUSTOM`.
	AuthorizerId pulumi.StringPtrInput
	// The [model selection expression](https://docs.aws.amazon.com/apigateway/latest/developerguide/apigateway-websocket-api-selection-expressions.html#apigateway-websocket-api-model-selection-expressions) for the route.
	ModelSelectionExpression pulumi.StringPtrInput
	// The operation name for the route.
	OperationName pulumi.StringPtrInput
	// The request models for the route.
	RequestModels pulumi.StringMapInput
	// The route key for the route.
	RouteKey pulumi.StringInput
	// The [route response selection expression](https://docs.aws.amazon.com/apigateway/latest/developerguide/apigateway-websocket-api-selection-expressions.html#apigateway-websocket-api-route-response-selection-expressions) for the route.
	RouteResponseSelectionExpression pulumi.StringPtrInput
	// The target for the route.
	Target pulumi.StringPtrInput
}

func (RouteArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*routeArgs)(nil)).Elem()
}
