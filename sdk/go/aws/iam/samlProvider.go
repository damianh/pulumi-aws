// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package iam

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Provides an IAM SAML provider.
type SamlProvider struct {
	pulumi.CustomResourceState

	// The ARN assigned by AWS for this provider.
	Arn pulumi.StringOutput `pulumi:"arn"`
	// The name of the provider to create.
	Name pulumi.StringOutput `pulumi:"name"`
	// An XML document generated by an identity provider that supports SAML 2.0.
	SamlMetadataDocument pulumi.StringOutput `pulumi:"samlMetadataDocument"`
	// The expiration date and time for the SAML provider in RFC1123 format, e.g. `Mon, 02 Jan 2006 15:04:05 MST`.
	ValidUntil pulumi.StringOutput `pulumi:"validUntil"`
}

// NewSamlProvider registers a new resource with the given unique name, arguments, and options.
func NewSamlProvider(ctx *pulumi.Context,
	name string, args *SamlProviderArgs, opts ...pulumi.ResourceOption) (*SamlProvider, error) {
	if args == nil || args.SamlMetadataDocument == nil {
		return nil, errors.New("missing required argument 'SamlMetadataDocument'")
	}
	if args == nil {
		args = &SamlProviderArgs{}
	}
	var resource SamlProvider
	err := ctx.RegisterResource("aws:iam/samlProvider:SamlProvider", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetSamlProvider gets an existing SamlProvider resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetSamlProvider(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *SamlProviderState, opts ...pulumi.ResourceOption) (*SamlProvider, error) {
	var resource SamlProvider
	err := ctx.ReadResource("aws:iam/samlProvider:SamlProvider", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering SamlProvider resources.
type samlProviderState struct {
	// The ARN assigned by AWS for this provider.
	Arn *string `pulumi:"arn"`
	// The name of the provider to create.
	Name *string `pulumi:"name"`
	// An XML document generated by an identity provider that supports SAML 2.0.
	SamlMetadataDocument *string `pulumi:"samlMetadataDocument"`
	// The expiration date and time for the SAML provider in RFC1123 format, e.g. `Mon, 02 Jan 2006 15:04:05 MST`.
	ValidUntil *string `pulumi:"validUntil"`
}

type SamlProviderState struct {
	// The ARN assigned by AWS for this provider.
	Arn pulumi.StringPtrInput
	// The name of the provider to create.
	Name pulumi.StringPtrInput
	// An XML document generated by an identity provider that supports SAML 2.0.
	SamlMetadataDocument pulumi.StringPtrInput
	// The expiration date and time for the SAML provider in RFC1123 format, e.g. `Mon, 02 Jan 2006 15:04:05 MST`.
	ValidUntil pulumi.StringPtrInput
}

func (SamlProviderState) ElementType() reflect.Type {
	return reflect.TypeOf((*samlProviderState)(nil)).Elem()
}

type samlProviderArgs struct {
	// The name of the provider to create.
	Name *string `pulumi:"name"`
	// An XML document generated by an identity provider that supports SAML 2.0.
	SamlMetadataDocument string `pulumi:"samlMetadataDocument"`
}

// The set of arguments for constructing a SamlProvider resource.
type SamlProviderArgs struct {
	// The name of the provider to create.
	Name pulumi.StringPtrInput
	// An XML document generated by an identity provider that supports SAML 2.0.
	SamlMetadataDocument pulumi.StringInput
}

func (SamlProviderArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*samlProviderArgs)(nil)).Elem()
}
