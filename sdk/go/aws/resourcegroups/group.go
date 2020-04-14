// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package resourcegroups

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Provides a Resource Group.
type Group struct {
	pulumi.CustomResourceState

	// The ARN assigned by AWS for this resource group.
	Arn pulumi.StringOutput `pulumi:"arn"`
	// A description of the resource group.
	Description pulumi.StringPtrOutput `pulumi:"description"`
	// The resource group's name. A resource group name can have a maximum of 127 characters, including letters, numbers, hyphens, dots, and underscores. The name cannot start with `AWS` or `aws`.
	Name pulumi.StringOutput `pulumi:"name"`
	// A `resourceQuery` block. Resource queries are documented below.
	ResourceQuery GroupResourceQueryOutput `pulumi:"resourceQuery"`
	// Key-value mapping of resource tags
	Tags pulumi.MapOutput `pulumi:"tags"`
}

// NewGroup registers a new resource with the given unique name, arguments, and options.
func NewGroup(ctx *pulumi.Context,
	name string, args *GroupArgs, opts ...pulumi.ResourceOption) (*Group, error) {
	if args == nil || args.ResourceQuery == nil {
		return nil, errors.New("missing required argument 'ResourceQuery'")
	}
	if args == nil {
		args = &GroupArgs{}
	}
	var resource Group
	err := ctx.RegisterResource("aws:resourcegroups/group:Group", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetGroup gets an existing Group resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetGroup(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *GroupState, opts ...pulumi.ResourceOption) (*Group, error) {
	var resource Group
	err := ctx.ReadResource("aws:resourcegroups/group:Group", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Group resources.
type groupState struct {
	// The ARN assigned by AWS for this resource group.
	Arn *string `pulumi:"arn"`
	// A description of the resource group.
	Description *string `pulumi:"description"`
	// The resource group's name. A resource group name can have a maximum of 127 characters, including letters, numbers, hyphens, dots, and underscores. The name cannot start with `AWS` or `aws`.
	Name *string `pulumi:"name"`
	// A `resourceQuery` block. Resource queries are documented below.
	ResourceQuery *GroupResourceQuery `pulumi:"resourceQuery"`
	// Key-value mapping of resource tags
	Tags map[string]interface{} `pulumi:"tags"`
}

type GroupState struct {
	// The ARN assigned by AWS for this resource group.
	Arn pulumi.StringPtrInput
	// A description of the resource group.
	Description pulumi.StringPtrInput
	// The resource group's name. A resource group name can have a maximum of 127 characters, including letters, numbers, hyphens, dots, and underscores. The name cannot start with `AWS` or `aws`.
	Name pulumi.StringPtrInput
	// A `resourceQuery` block. Resource queries are documented below.
	ResourceQuery GroupResourceQueryPtrInput
	// Key-value mapping of resource tags
	Tags pulumi.MapInput
}

func (GroupState) ElementType() reflect.Type {
	return reflect.TypeOf((*groupState)(nil)).Elem()
}

type groupArgs struct {
	// A description of the resource group.
	Description *string `pulumi:"description"`
	// The resource group's name. A resource group name can have a maximum of 127 characters, including letters, numbers, hyphens, dots, and underscores. The name cannot start with `AWS` or `aws`.
	Name *string `pulumi:"name"`
	// A `resourceQuery` block. Resource queries are documented below.
	ResourceQuery GroupResourceQuery `pulumi:"resourceQuery"`
	// Key-value mapping of resource tags
	Tags map[string]interface{} `pulumi:"tags"`
}

// The set of arguments for constructing a Group resource.
type GroupArgs struct {
	// A description of the resource group.
	Description pulumi.StringPtrInput
	// The resource group's name. A resource group name can have a maximum of 127 characters, including letters, numbers, hyphens, dots, and underscores. The name cannot start with `AWS` or `aws`.
	Name pulumi.StringPtrInput
	// A `resourceQuery` block. Resource queries are documented below.
	ResourceQuery GroupResourceQueryInput
	// Key-value mapping of resource tags
	Tags pulumi.MapInput
}

func (GroupArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*groupArgs)(nil)).Elem()
}
