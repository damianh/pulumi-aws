// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package ses

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Manages a SES Identity Policy. More information about SES Sending Authorization Policies can be found in the [SES Developer Guide](https://docs.aws.amazon.com/ses/latest/DeveloperGuide/sending-authorization-policies.html).
type IdentityPolicy struct {
	pulumi.CustomResourceState

	// Name or Amazon Resource Name (ARN) of the SES Identity.
	Identity pulumi.StringOutput `pulumi:"identity"`
	// Name of the policy.
	Name pulumi.StringOutput `pulumi:"name"`
	// JSON string of the policy.
	Policy pulumi.StringOutput `pulumi:"policy"`
}

// NewIdentityPolicy registers a new resource with the given unique name, arguments, and options.
func NewIdentityPolicy(ctx *pulumi.Context,
	name string, args *IdentityPolicyArgs, opts ...pulumi.ResourceOption) (*IdentityPolicy, error) {
	if args == nil || args.Identity == nil {
		return nil, errors.New("missing required argument 'Identity'")
	}
	if args == nil || args.Policy == nil {
		return nil, errors.New("missing required argument 'Policy'")
	}
	if args == nil {
		args = &IdentityPolicyArgs{}
	}
	var resource IdentityPolicy
	err := ctx.RegisterResource("aws:ses/identityPolicy:IdentityPolicy", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetIdentityPolicy gets an existing IdentityPolicy resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetIdentityPolicy(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *IdentityPolicyState, opts ...pulumi.ResourceOption) (*IdentityPolicy, error) {
	var resource IdentityPolicy
	err := ctx.ReadResource("aws:ses/identityPolicy:IdentityPolicy", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering IdentityPolicy resources.
type identityPolicyState struct {
	// Name or Amazon Resource Name (ARN) of the SES Identity.
	Identity *string `pulumi:"identity"`
	// Name of the policy.
	Name *string `pulumi:"name"`
	// JSON string of the policy.
	Policy *string `pulumi:"policy"`
}

type IdentityPolicyState struct {
	// Name or Amazon Resource Name (ARN) of the SES Identity.
	Identity pulumi.StringPtrInput
	// Name of the policy.
	Name pulumi.StringPtrInput
	// JSON string of the policy.
	Policy pulumi.StringPtrInput
}

func (IdentityPolicyState) ElementType() reflect.Type {
	return reflect.TypeOf((*identityPolicyState)(nil)).Elem()
}

type identityPolicyArgs struct {
	// Name or Amazon Resource Name (ARN) of the SES Identity.
	Identity string `pulumi:"identity"`
	// Name of the policy.
	Name *string `pulumi:"name"`
	// JSON string of the policy.
	Policy string `pulumi:"policy"`
}

// The set of arguments for constructing a IdentityPolicy resource.
type IdentityPolicyArgs struct {
	// Name or Amazon Resource Name (ARN) of the SES Identity.
	Identity pulumi.StringInput
	// Name of the policy.
	Name pulumi.StringPtrInput
	// JSON string of the policy.
	Policy pulumi.StringInput
}

func (IdentityPolicyArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*identityPolicyArgs)(nil)).Elem()
}
