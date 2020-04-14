// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package sagemaker

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Provides a SageMaker Endpoint resource.
type Endpoint struct {
	pulumi.CustomResourceState

	// The Amazon Resource Name (ARN) assigned by AWS to this endpoint.
	Arn pulumi.StringOutput `pulumi:"arn"`
	// The name of the endpoint configuration to use.
	EndpointConfigName pulumi.StringOutput `pulumi:"endpointConfigName"`
	// The name of the endpoint. If omitted, this provider will assign a random, unique name.
	Name pulumi.StringOutput `pulumi:"name"`
	// A mapping of tags to assign to the resource.
	Tags pulumi.MapOutput `pulumi:"tags"`
}

// NewEndpoint registers a new resource with the given unique name, arguments, and options.
func NewEndpoint(ctx *pulumi.Context,
	name string, args *EndpointArgs, opts ...pulumi.ResourceOption) (*Endpoint, error) {
	if args == nil || args.EndpointConfigName == nil {
		return nil, errors.New("missing required argument 'EndpointConfigName'")
	}
	if args == nil {
		args = &EndpointArgs{}
	}
	var resource Endpoint
	err := ctx.RegisterResource("aws:sagemaker/endpoint:Endpoint", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetEndpoint gets an existing Endpoint resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetEndpoint(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *EndpointState, opts ...pulumi.ResourceOption) (*Endpoint, error) {
	var resource Endpoint
	err := ctx.ReadResource("aws:sagemaker/endpoint:Endpoint", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Endpoint resources.
type endpointState struct {
	// The Amazon Resource Name (ARN) assigned by AWS to this endpoint.
	Arn *string `pulumi:"arn"`
	// The name of the endpoint configuration to use.
	EndpointConfigName *string `pulumi:"endpointConfigName"`
	// The name of the endpoint. If omitted, this provider will assign a random, unique name.
	Name *string `pulumi:"name"`
	// A mapping of tags to assign to the resource.
	Tags map[string]interface{} `pulumi:"tags"`
}

type EndpointState struct {
	// The Amazon Resource Name (ARN) assigned by AWS to this endpoint.
	Arn pulumi.StringPtrInput
	// The name of the endpoint configuration to use.
	EndpointConfigName pulumi.StringPtrInput
	// The name of the endpoint. If omitted, this provider will assign a random, unique name.
	Name pulumi.StringPtrInput
	// A mapping of tags to assign to the resource.
	Tags pulumi.MapInput
}

func (EndpointState) ElementType() reflect.Type {
	return reflect.TypeOf((*endpointState)(nil)).Elem()
}

type endpointArgs struct {
	// The name of the endpoint configuration to use.
	EndpointConfigName string `pulumi:"endpointConfigName"`
	// The name of the endpoint. If omitted, this provider will assign a random, unique name.
	Name *string `pulumi:"name"`
	// A mapping of tags to assign to the resource.
	Tags map[string]interface{} `pulumi:"tags"`
}

// The set of arguments for constructing a Endpoint resource.
type EndpointArgs struct {
	// The name of the endpoint configuration to use.
	EndpointConfigName pulumi.StringInput
	// The name of the endpoint. If omitted, this provider will assign a random, unique name.
	Name pulumi.StringPtrInput
	// A mapping of tags to assign to the resource.
	Tags pulumi.MapInput
}

func (EndpointArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*endpointArgs)(nil)).Elem()
}
