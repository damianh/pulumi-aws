// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package kms

import (
	"reflect"

	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Manages a KMS Customer Master Key that uses external key material. To instead manage a KMS Customer Master Key where AWS automatically generates and potentially rotates key material, see the [`kms.Key` resource](https://www.terraform.io/docs/providers/aws/r/kms_key.html).
//
// > **Note:** All arguments including the key material will be stored in the raw state as plain-text. [Read more about sensitive data in state](https://www.terraform.io/docs/state/sensitive-data.html).
type ExternalKey struct {
	pulumi.CustomResourceState

	// The Amazon Resource Name (ARN) of the key.
	Arn pulumi.StringOutput `pulumi:"arn"`
	// Duration in days after which the key is deleted after destruction of the resource. Must be between `7` and `30` days. Defaults to `30`.
	DeletionWindowInDays pulumi.IntPtrOutput `pulumi:"deletionWindowInDays"`
	// Description of the key.
	Description pulumi.StringPtrOutput `pulumi:"description"`
	// Specifies whether the key is enabled. Keys pending import can only be `false`. Imported keys default to `true` unless expired.
	Enabled pulumi.BoolOutput `pulumi:"enabled"`
	// Whether the key material expires. Empty when pending key material import, otherwise `KEY_MATERIAL_EXPIRES` or `KEY_MATERIAL_DOES_NOT_EXPIRE`.
	ExpirationModel pulumi.StringOutput `pulumi:"expirationModel"`
	// Base64 encoded 256-bit symmetric encryption key material to import. The CMK is permanently associated with this key material. The same key material can be reimported, but you cannot import different key material.
	KeyMaterialBase64 pulumi.StringPtrOutput `pulumi:"keyMaterialBase64"`
	// The state of the CMK.
	KeyState pulumi.StringOutput `pulumi:"keyState"`
	// The cryptographic operations for which you can use the CMK.
	KeyUsage pulumi.StringOutput `pulumi:"keyUsage"`
	// A key policy JSON document. If you do not provide a key policy, AWS KMS attaches a default key policy to the CMK.
	Policy pulumi.StringOutput `pulumi:"policy"`
	// A key-value map of tags to assign to the key.
	Tags pulumi.MapOutput `pulumi:"tags"`
	// Time at which the imported key material expires. When the key material expires, AWS KMS deletes the key material and the CMK becomes unusable. If not specified, key material does not expire. Valid values: [RFC3339 time string](https://tools.ietf.org/html/rfc3339#section-5.8) (`YYYY-MM-DDTHH:MM:SSZ`)
	ValidTo pulumi.StringPtrOutput `pulumi:"validTo"`
}

// NewExternalKey registers a new resource with the given unique name, arguments, and options.
func NewExternalKey(ctx *pulumi.Context,
	name string, args *ExternalKeyArgs, opts ...pulumi.ResourceOption) (*ExternalKey, error) {
	if args == nil {
		args = &ExternalKeyArgs{}
	}
	var resource ExternalKey
	err := ctx.RegisterResource("aws:kms/externalKey:ExternalKey", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetExternalKey gets an existing ExternalKey resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetExternalKey(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ExternalKeyState, opts ...pulumi.ResourceOption) (*ExternalKey, error) {
	var resource ExternalKey
	err := ctx.ReadResource("aws:kms/externalKey:ExternalKey", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering ExternalKey resources.
type externalKeyState struct {
	// The Amazon Resource Name (ARN) of the key.
	Arn *string `pulumi:"arn"`
	// Duration in days after which the key is deleted after destruction of the resource. Must be between `7` and `30` days. Defaults to `30`.
	DeletionWindowInDays *int `pulumi:"deletionWindowInDays"`
	// Description of the key.
	Description *string `pulumi:"description"`
	// Specifies whether the key is enabled. Keys pending import can only be `false`. Imported keys default to `true` unless expired.
	Enabled *bool `pulumi:"enabled"`
	// Whether the key material expires. Empty when pending key material import, otherwise `KEY_MATERIAL_EXPIRES` or `KEY_MATERIAL_DOES_NOT_EXPIRE`.
	ExpirationModel *string `pulumi:"expirationModel"`
	// Base64 encoded 256-bit symmetric encryption key material to import. The CMK is permanently associated with this key material. The same key material can be reimported, but you cannot import different key material.
	KeyMaterialBase64 *string `pulumi:"keyMaterialBase64"`
	// The state of the CMK.
	KeyState *string `pulumi:"keyState"`
	// The cryptographic operations for which you can use the CMK.
	KeyUsage *string `pulumi:"keyUsage"`
	// A key policy JSON document. If you do not provide a key policy, AWS KMS attaches a default key policy to the CMK.
	Policy *string `pulumi:"policy"`
	// A key-value map of tags to assign to the key.
	Tags map[string]interface{} `pulumi:"tags"`
	// Time at which the imported key material expires. When the key material expires, AWS KMS deletes the key material and the CMK becomes unusable. If not specified, key material does not expire. Valid values: [RFC3339 time string](https://tools.ietf.org/html/rfc3339#section-5.8) (`YYYY-MM-DDTHH:MM:SSZ`)
	ValidTo *string `pulumi:"validTo"`
}

type ExternalKeyState struct {
	// The Amazon Resource Name (ARN) of the key.
	Arn pulumi.StringPtrInput
	// Duration in days after which the key is deleted after destruction of the resource. Must be between `7` and `30` days. Defaults to `30`.
	DeletionWindowInDays pulumi.IntPtrInput
	// Description of the key.
	Description pulumi.StringPtrInput
	// Specifies whether the key is enabled. Keys pending import can only be `false`. Imported keys default to `true` unless expired.
	Enabled pulumi.BoolPtrInput
	// Whether the key material expires. Empty when pending key material import, otherwise `KEY_MATERIAL_EXPIRES` or `KEY_MATERIAL_DOES_NOT_EXPIRE`.
	ExpirationModel pulumi.StringPtrInput
	// Base64 encoded 256-bit symmetric encryption key material to import. The CMK is permanently associated with this key material. The same key material can be reimported, but you cannot import different key material.
	KeyMaterialBase64 pulumi.StringPtrInput
	// The state of the CMK.
	KeyState pulumi.StringPtrInput
	// The cryptographic operations for which you can use the CMK.
	KeyUsage pulumi.StringPtrInput
	// A key policy JSON document. If you do not provide a key policy, AWS KMS attaches a default key policy to the CMK.
	Policy pulumi.StringPtrInput
	// A key-value map of tags to assign to the key.
	Tags pulumi.MapInput
	// Time at which the imported key material expires. When the key material expires, AWS KMS deletes the key material and the CMK becomes unusable. If not specified, key material does not expire. Valid values: [RFC3339 time string](https://tools.ietf.org/html/rfc3339#section-5.8) (`YYYY-MM-DDTHH:MM:SSZ`)
	ValidTo pulumi.StringPtrInput
}

func (ExternalKeyState) ElementType() reflect.Type {
	return reflect.TypeOf((*externalKeyState)(nil)).Elem()
}

type externalKeyArgs struct {
	// Duration in days after which the key is deleted after destruction of the resource. Must be between `7` and `30` days. Defaults to `30`.
	DeletionWindowInDays *int `pulumi:"deletionWindowInDays"`
	// Description of the key.
	Description *string `pulumi:"description"`
	// Specifies whether the key is enabled. Keys pending import can only be `false`. Imported keys default to `true` unless expired.
	Enabled *bool `pulumi:"enabled"`
	// Base64 encoded 256-bit symmetric encryption key material to import. The CMK is permanently associated with this key material. The same key material can be reimported, but you cannot import different key material.
	KeyMaterialBase64 *string `pulumi:"keyMaterialBase64"`
	// A key policy JSON document. If you do not provide a key policy, AWS KMS attaches a default key policy to the CMK.
	Policy *string `pulumi:"policy"`
	// A key-value map of tags to assign to the key.
	Tags map[string]interface{} `pulumi:"tags"`
	// Time at which the imported key material expires. When the key material expires, AWS KMS deletes the key material and the CMK becomes unusable. If not specified, key material does not expire. Valid values: [RFC3339 time string](https://tools.ietf.org/html/rfc3339#section-5.8) (`YYYY-MM-DDTHH:MM:SSZ`)
	ValidTo *string `pulumi:"validTo"`
}

// The set of arguments for constructing a ExternalKey resource.
type ExternalKeyArgs struct {
	// Duration in days after which the key is deleted after destruction of the resource. Must be between `7` and `30` days. Defaults to `30`.
	DeletionWindowInDays pulumi.IntPtrInput
	// Description of the key.
	Description pulumi.StringPtrInput
	// Specifies whether the key is enabled. Keys pending import can only be `false`. Imported keys default to `true` unless expired.
	Enabled pulumi.BoolPtrInput
	// Base64 encoded 256-bit symmetric encryption key material to import. The CMK is permanently associated with this key material. The same key material can be reimported, but you cannot import different key material.
	KeyMaterialBase64 pulumi.StringPtrInput
	// A key policy JSON document. If you do not provide a key policy, AWS KMS attaches a default key policy to the CMK.
	Policy pulumi.StringPtrInput
	// A key-value map of tags to assign to the key.
	Tags pulumi.MapInput
	// Time at which the imported key material expires. When the key material expires, AWS KMS deletes the key material and the CMK becomes unusable. If not specified, key material does not expire. Valid values: [RFC3339 time string](https://tools.ietf.org/html/rfc3339#section-5.8) (`YYYY-MM-DDTHH:MM:SSZ`)
	ValidTo pulumi.StringPtrInput
}

func (ExternalKeyArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*externalKeyArgs)(nil)).Elem()
}
