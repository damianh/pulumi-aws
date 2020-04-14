// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package pinpoint

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Provides a Pinpoint APNs VoIP Channel resource.
//
// > **Note:** All arguments, including certificates and tokens, will be stored in the raw state as plain-text.
// [Read more about sensitive data in state](https://www.terraform.io/docs/state/sensitive-data.html).
type ApnsVoipChannel struct {
	pulumi.CustomResourceState

	// The application ID.
	ApplicationId pulumi.StringOutput `pulumi:"applicationId"`
	// The ID assigned to your iOS app. To find this value, choose Certificates, IDs & Profiles, choose App IDs in the Identifiers section, and choose your app.
	BundleId pulumi.StringPtrOutput `pulumi:"bundleId"`
	// The pem encoded TLS Certificate from Apple.
	Certificate pulumi.StringPtrOutput `pulumi:"certificate"`
	// The default authentication method used for APNs.
	// __NOTE__: Amazon Pinpoint uses this default for every APNs push notification that you send using the console.
	// You can override the default when you send a message programmatically using the Amazon Pinpoint API, the AWS CLI, or an AWS SDK.
	// If your default authentication type fails, Amazon Pinpoint doesn't attempt to use the other authentication type.
	DefaultAuthenticationMethod pulumi.StringPtrOutput `pulumi:"defaultAuthenticationMethod"`
	// Whether the channel is enabled or disabled. Defaults to `true`.
	Enabled pulumi.BoolPtrOutput `pulumi:"enabled"`
	// The Certificate Private Key file (ie. `.key` file).
	PrivateKey pulumi.StringPtrOutput `pulumi:"privateKey"`
	// The ID assigned to your Apple developer account team. This value is provided on the Membership page.
	TeamId pulumi.StringPtrOutput `pulumi:"teamId"`
	// The `.p8` file that you download from your Apple developer account when you create an authentication key.
	TokenKey pulumi.StringPtrOutput `pulumi:"tokenKey"`
	// The ID assigned to your signing key. To find this value, choose Certificates, IDs & Profiles, and choose your key in the Keys section.
	TokenKeyId pulumi.StringPtrOutput `pulumi:"tokenKeyId"`
}

// NewApnsVoipChannel registers a new resource with the given unique name, arguments, and options.
func NewApnsVoipChannel(ctx *pulumi.Context,
	name string, args *ApnsVoipChannelArgs, opts ...pulumi.ResourceOption) (*ApnsVoipChannel, error) {
	if args == nil || args.ApplicationId == nil {
		return nil, errors.New("missing required argument 'ApplicationId'")
	}
	if args == nil {
		args = &ApnsVoipChannelArgs{}
	}
	var resource ApnsVoipChannel
	err := ctx.RegisterResource("aws:pinpoint/apnsVoipChannel:ApnsVoipChannel", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetApnsVoipChannel gets an existing ApnsVoipChannel resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetApnsVoipChannel(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ApnsVoipChannelState, opts ...pulumi.ResourceOption) (*ApnsVoipChannel, error) {
	var resource ApnsVoipChannel
	err := ctx.ReadResource("aws:pinpoint/apnsVoipChannel:ApnsVoipChannel", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering ApnsVoipChannel resources.
type apnsVoipChannelState struct {
	// The application ID.
	ApplicationId *string `pulumi:"applicationId"`
	// The ID assigned to your iOS app. To find this value, choose Certificates, IDs & Profiles, choose App IDs in the Identifiers section, and choose your app.
	BundleId *string `pulumi:"bundleId"`
	// The pem encoded TLS Certificate from Apple.
	Certificate *string `pulumi:"certificate"`
	// The default authentication method used for APNs.
	// __NOTE__: Amazon Pinpoint uses this default for every APNs push notification that you send using the console.
	// You can override the default when you send a message programmatically using the Amazon Pinpoint API, the AWS CLI, or an AWS SDK.
	// If your default authentication type fails, Amazon Pinpoint doesn't attempt to use the other authentication type.
	DefaultAuthenticationMethod *string `pulumi:"defaultAuthenticationMethod"`
	// Whether the channel is enabled or disabled. Defaults to `true`.
	Enabled *bool `pulumi:"enabled"`
	// The Certificate Private Key file (ie. `.key` file).
	PrivateKey *string `pulumi:"privateKey"`
	// The ID assigned to your Apple developer account team. This value is provided on the Membership page.
	TeamId *string `pulumi:"teamId"`
	// The `.p8` file that you download from your Apple developer account when you create an authentication key.
	TokenKey *string `pulumi:"tokenKey"`
	// The ID assigned to your signing key. To find this value, choose Certificates, IDs & Profiles, and choose your key in the Keys section.
	TokenKeyId *string `pulumi:"tokenKeyId"`
}

type ApnsVoipChannelState struct {
	// The application ID.
	ApplicationId pulumi.StringPtrInput
	// The ID assigned to your iOS app. To find this value, choose Certificates, IDs & Profiles, choose App IDs in the Identifiers section, and choose your app.
	BundleId pulumi.StringPtrInput
	// The pem encoded TLS Certificate from Apple.
	Certificate pulumi.StringPtrInput
	// The default authentication method used for APNs.
	// __NOTE__: Amazon Pinpoint uses this default for every APNs push notification that you send using the console.
	// You can override the default when you send a message programmatically using the Amazon Pinpoint API, the AWS CLI, or an AWS SDK.
	// If your default authentication type fails, Amazon Pinpoint doesn't attempt to use the other authentication type.
	DefaultAuthenticationMethod pulumi.StringPtrInput
	// Whether the channel is enabled or disabled. Defaults to `true`.
	Enabled pulumi.BoolPtrInput
	// The Certificate Private Key file (ie. `.key` file).
	PrivateKey pulumi.StringPtrInput
	// The ID assigned to your Apple developer account team. This value is provided on the Membership page.
	TeamId pulumi.StringPtrInput
	// The `.p8` file that you download from your Apple developer account when you create an authentication key.
	TokenKey pulumi.StringPtrInput
	// The ID assigned to your signing key. To find this value, choose Certificates, IDs & Profiles, and choose your key in the Keys section.
	TokenKeyId pulumi.StringPtrInput
}

func (ApnsVoipChannelState) ElementType() reflect.Type {
	return reflect.TypeOf((*apnsVoipChannelState)(nil)).Elem()
}

type apnsVoipChannelArgs struct {
	// The application ID.
	ApplicationId string `pulumi:"applicationId"`
	// The ID assigned to your iOS app. To find this value, choose Certificates, IDs & Profiles, choose App IDs in the Identifiers section, and choose your app.
	BundleId *string `pulumi:"bundleId"`
	// The pem encoded TLS Certificate from Apple.
	Certificate *string `pulumi:"certificate"`
	// The default authentication method used for APNs.
	// __NOTE__: Amazon Pinpoint uses this default for every APNs push notification that you send using the console.
	// You can override the default when you send a message programmatically using the Amazon Pinpoint API, the AWS CLI, or an AWS SDK.
	// If your default authentication type fails, Amazon Pinpoint doesn't attempt to use the other authentication type.
	DefaultAuthenticationMethod *string `pulumi:"defaultAuthenticationMethod"`
	// Whether the channel is enabled or disabled. Defaults to `true`.
	Enabled *bool `pulumi:"enabled"`
	// The Certificate Private Key file (ie. `.key` file).
	PrivateKey *string `pulumi:"privateKey"`
	// The ID assigned to your Apple developer account team. This value is provided on the Membership page.
	TeamId *string `pulumi:"teamId"`
	// The `.p8` file that you download from your Apple developer account when you create an authentication key.
	TokenKey *string `pulumi:"tokenKey"`
	// The ID assigned to your signing key. To find this value, choose Certificates, IDs & Profiles, and choose your key in the Keys section.
	TokenKeyId *string `pulumi:"tokenKeyId"`
}

// The set of arguments for constructing a ApnsVoipChannel resource.
type ApnsVoipChannelArgs struct {
	// The application ID.
	ApplicationId pulumi.StringInput
	// The ID assigned to your iOS app. To find this value, choose Certificates, IDs & Profiles, choose App IDs in the Identifiers section, and choose your app.
	BundleId pulumi.StringPtrInput
	// The pem encoded TLS Certificate from Apple.
	Certificate pulumi.StringPtrInput
	// The default authentication method used for APNs.
	// __NOTE__: Amazon Pinpoint uses this default for every APNs push notification that you send using the console.
	// You can override the default when you send a message programmatically using the Amazon Pinpoint API, the AWS CLI, or an AWS SDK.
	// If your default authentication type fails, Amazon Pinpoint doesn't attempt to use the other authentication type.
	DefaultAuthenticationMethod pulumi.StringPtrInput
	// Whether the channel is enabled or disabled. Defaults to `true`.
	Enabled pulumi.BoolPtrInput
	// The Certificate Private Key file (ie. `.key` file).
	PrivateKey pulumi.StringPtrInput
	// The ID assigned to your Apple developer account team. This value is provided on the Membership page.
	TeamId pulumi.StringPtrInput
	// The `.p8` file that you download from your Apple developer account when you create an authentication key.
	TokenKey pulumi.StringPtrInput
	// The ID assigned to your signing key. To find this value, choose Certificates, IDs & Profiles, and choose your key in the Keys section.
	TokenKeyId pulumi.StringPtrInput
}

func (ApnsVoipChannelArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*apnsVoipChannelArgs)(nil)).Elem()
}
