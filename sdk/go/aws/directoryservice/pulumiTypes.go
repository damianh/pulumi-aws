// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package directoryservice

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

type DirectoryConnectSettings struct {
	// The DNS IP addresses of the domain to connect to.
	CustomerDnsIps []string `pulumi:"customerDnsIps"`
	// The username corresponding to the password provided.
	CustomerUsername string `pulumi:"customerUsername"`
	// The identifiers of the subnets for the directory servers (2 subnets in 2 different AZs).
	SubnetIds []string `pulumi:"subnetIds"`
	// The identifier of the VPC that the directory is in.
	VpcId string `pulumi:"vpcId"`
}

// Construct a concrete instance of DirectoryConnectSettingsInput via:
// 	DirectoryConnectSettingsArgs{...}
type DirectoryConnectSettingsInput interface {
	pulumi.Input

	ToDirectoryConnectSettingsOutput() DirectoryConnectSettingsOutput
	ToDirectoryConnectSettingsOutputWithContext(context.Context) DirectoryConnectSettingsOutput
}

type DirectoryConnectSettingsArgs struct {
	// The DNS IP addresses of the domain to connect to.
	CustomerDnsIps pulumi.StringArrayInput `pulumi:"customerDnsIps"`
	// The username corresponding to the password provided.
	CustomerUsername pulumi.StringInput `pulumi:"customerUsername"`
	// The identifiers of the subnets for the directory servers (2 subnets in 2 different AZs).
	SubnetIds pulumi.StringArrayInput `pulumi:"subnetIds"`
	// The identifier of the VPC that the directory is in.
	VpcId pulumi.StringInput `pulumi:"vpcId"`
}

func (DirectoryConnectSettingsArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*DirectoryConnectSettings)(nil)).Elem()
}

func (i DirectoryConnectSettingsArgs) ToDirectoryConnectSettingsOutput() DirectoryConnectSettingsOutput {
	return i.ToDirectoryConnectSettingsOutputWithContext(context.Background())
}

func (i DirectoryConnectSettingsArgs) ToDirectoryConnectSettingsOutputWithContext(ctx context.Context) DirectoryConnectSettingsOutput {
	return pulumi.ToOutputWithContext(ctx, i).(DirectoryConnectSettingsOutput)
}

func (i DirectoryConnectSettingsArgs) ToDirectoryConnectSettingsPtrOutput() DirectoryConnectSettingsPtrOutput {
	return i.ToDirectoryConnectSettingsPtrOutputWithContext(context.Background())
}

func (i DirectoryConnectSettingsArgs) ToDirectoryConnectSettingsPtrOutputWithContext(ctx context.Context) DirectoryConnectSettingsPtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(DirectoryConnectSettingsOutput).ToDirectoryConnectSettingsPtrOutputWithContext(ctx)
}

// Construct a concrete instance of DirectoryConnectSettingsPtrInput via:
// 	DirectoryConnectSettingsArgs{...}.ToDirectoryConnectSettingsPtrOutput()
type DirectoryConnectSettingsPtrInput interface {
	pulumi.Input

	ToDirectoryConnectSettingsPtrOutput() DirectoryConnectSettingsPtrOutput
	ToDirectoryConnectSettingsPtrOutputWithContext(context.Context) DirectoryConnectSettingsPtrOutput
}

type directoryConnectSettingsPtrType DirectoryConnectSettingsArgs

func DirectoryConnectSettingsPtr(v *DirectoryConnectSettingsArgs) DirectoryConnectSettingsPtrInput {
	return (*directoryConnectSettingsPtrType)(v)
}

func (*directoryConnectSettingsPtrType) ElementType() reflect.Type {
	return reflect.TypeOf((**DirectoryConnectSettings)(nil)).Elem()
}

func (i *directoryConnectSettingsPtrType) ToDirectoryConnectSettingsPtrOutput() DirectoryConnectSettingsPtrOutput {
	return i.ToDirectoryConnectSettingsPtrOutputWithContext(context.Background())
}

func (i *directoryConnectSettingsPtrType) ToDirectoryConnectSettingsPtrOutputWithContext(ctx context.Context) DirectoryConnectSettingsPtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(DirectoryConnectSettingsPtrOutput)
}

type DirectoryConnectSettingsOutput struct{ *pulumi.OutputState }

func (DirectoryConnectSettingsOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*DirectoryConnectSettings)(nil)).Elem()
}

func (o DirectoryConnectSettingsOutput) ToDirectoryConnectSettingsOutput() DirectoryConnectSettingsOutput {
	return o
}

func (o DirectoryConnectSettingsOutput) ToDirectoryConnectSettingsOutputWithContext(ctx context.Context) DirectoryConnectSettingsOutput {
	return o
}

func (o DirectoryConnectSettingsOutput) ToDirectoryConnectSettingsPtrOutput() DirectoryConnectSettingsPtrOutput {
	return o.ToDirectoryConnectSettingsPtrOutputWithContext(context.Background())
}

func (o DirectoryConnectSettingsOutput) ToDirectoryConnectSettingsPtrOutputWithContext(ctx context.Context) DirectoryConnectSettingsPtrOutput {
	return o.ApplyT(func(v DirectoryConnectSettings) *DirectoryConnectSettings {
		return &v
	}).(DirectoryConnectSettingsPtrOutput)
}

// The DNS IP addresses of the domain to connect to.
func (o DirectoryConnectSettingsOutput) CustomerDnsIps() pulumi.StringArrayOutput {
	return o.ApplyT(func(v DirectoryConnectSettings) []string { return v.CustomerDnsIps }).(pulumi.StringArrayOutput)
}

// The username corresponding to the password provided.
func (o DirectoryConnectSettingsOutput) CustomerUsername() pulumi.StringOutput {
	return o.ApplyT(func(v DirectoryConnectSettings) string { return v.CustomerUsername }).(pulumi.StringOutput)
}

// The identifiers of the subnets for the directory servers (2 subnets in 2 different AZs).
func (o DirectoryConnectSettingsOutput) SubnetIds() pulumi.StringArrayOutput {
	return o.ApplyT(func(v DirectoryConnectSettings) []string { return v.SubnetIds }).(pulumi.StringArrayOutput)
}

// The identifier of the VPC that the directory is in.
func (o DirectoryConnectSettingsOutput) VpcId() pulumi.StringOutput {
	return o.ApplyT(func(v DirectoryConnectSettings) string { return v.VpcId }).(pulumi.StringOutput)
}

type DirectoryConnectSettingsPtrOutput struct{ *pulumi.OutputState }

func (DirectoryConnectSettingsPtrOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**DirectoryConnectSettings)(nil)).Elem()
}

func (o DirectoryConnectSettingsPtrOutput) ToDirectoryConnectSettingsPtrOutput() DirectoryConnectSettingsPtrOutput {
	return o
}

func (o DirectoryConnectSettingsPtrOutput) ToDirectoryConnectSettingsPtrOutputWithContext(ctx context.Context) DirectoryConnectSettingsPtrOutput {
	return o
}

func (o DirectoryConnectSettingsPtrOutput) Elem() DirectoryConnectSettingsOutput {
	return o.ApplyT(func(v *DirectoryConnectSettings) DirectoryConnectSettings { return *v }).(DirectoryConnectSettingsOutput)
}

// The DNS IP addresses of the domain to connect to.
func (o DirectoryConnectSettingsPtrOutput) CustomerDnsIps() pulumi.StringArrayOutput {
	return o.ApplyT(func(v DirectoryConnectSettings) []string { return v.CustomerDnsIps }).(pulumi.StringArrayOutput)
}

// The username corresponding to the password provided.
func (o DirectoryConnectSettingsPtrOutput) CustomerUsername() pulumi.StringOutput {
	return o.ApplyT(func(v DirectoryConnectSettings) string { return v.CustomerUsername }).(pulumi.StringOutput)
}

// The identifiers of the subnets for the directory servers (2 subnets in 2 different AZs).
func (o DirectoryConnectSettingsPtrOutput) SubnetIds() pulumi.StringArrayOutput {
	return o.ApplyT(func(v DirectoryConnectSettings) []string { return v.SubnetIds }).(pulumi.StringArrayOutput)
}

// The identifier of the VPC that the directory is in.
func (o DirectoryConnectSettingsPtrOutput) VpcId() pulumi.StringOutput {
	return o.ApplyT(func(v DirectoryConnectSettings) string { return v.VpcId }).(pulumi.StringOutput)
}

type DirectoryVpcSettings struct {
	// The identifiers of the subnets for the directory servers (2 subnets in 2 different AZs).
	SubnetIds []string `pulumi:"subnetIds"`
	// The identifier of the VPC that the directory is in.
	VpcId string `pulumi:"vpcId"`
}

// Construct a concrete instance of DirectoryVpcSettingsInput via:
// 	DirectoryVpcSettingsArgs{...}
type DirectoryVpcSettingsInput interface {
	pulumi.Input

	ToDirectoryVpcSettingsOutput() DirectoryVpcSettingsOutput
	ToDirectoryVpcSettingsOutputWithContext(context.Context) DirectoryVpcSettingsOutput
}

type DirectoryVpcSettingsArgs struct {
	// The identifiers of the subnets for the directory servers (2 subnets in 2 different AZs).
	SubnetIds pulumi.StringArrayInput `pulumi:"subnetIds"`
	// The identifier of the VPC that the directory is in.
	VpcId pulumi.StringInput `pulumi:"vpcId"`
}

func (DirectoryVpcSettingsArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*DirectoryVpcSettings)(nil)).Elem()
}

func (i DirectoryVpcSettingsArgs) ToDirectoryVpcSettingsOutput() DirectoryVpcSettingsOutput {
	return i.ToDirectoryVpcSettingsOutputWithContext(context.Background())
}

func (i DirectoryVpcSettingsArgs) ToDirectoryVpcSettingsOutputWithContext(ctx context.Context) DirectoryVpcSettingsOutput {
	return pulumi.ToOutputWithContext(ctx, i).(DirectoryVpcSettingsOutput)
}

func (i DirectoryVpcSettingsArgs) ToDirectoryVpcSettingsPtrOutput() DirectoryVpcSettingsPtrOutput {
	return i.ToDirectoryVpcSettingsPtrOutputWithContext(context.Background())
}

func (i DirectoryVpcSettingsArgs) ToDirectoryVpcSettingsPtrOutputWithContext(ctx context.Context) DirectoryVpcSettingsPtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(DirectoryVpcSettingsOutput).ToDirectoryVpcSettingsPtrOutputWithContext(ctx)
}

// Construct a concrete instance of DirectoryVpcSettingsPtrInput via:
// 	DirectoryVpcSettingsArgs{...}.ToDirectoryVpcSettingsPtrOutput()
type DirectoryVpcSettingsPtrInput interface {
	pulumi.Input

	ToDirectoryVpcSettingsPtrOutput() DirectoryVpcSettingsPtrOutput
	ToDirectoryVpcSettingsPtrOutputWithContext(context.Context) DirectoryVpcSettingsPtrOutput
}

type directoryVpcSettingsPtrType DirectoryVpcSettingsArgs

func DirectoryVpcSettingsPtr(v *DirectoryVpcSettingsArgs) DirectoryVpcSettingsPtrInput {
	return (*directoryVpcSettingsPtrType)(v)
}

func (*directoryVpcSettingsPtrType) ElementType() reflect.Type {
	return reflect.TypeOf((**DirectoryVpcSettings)(nil)).Elem()
}

func (i *directoryVpcSettingsPtrType) ToDirectoryVpcSettingsPtrOutput() DirectoryVpcSettingsPtrOutput {
	return i.ToDirectoryVpcSettingsPtrOutputWithContext(context.Background())
}

func (i *directoryVpcSettingsPtrType) ToDirectoryVpcSettingsPtrOutputWithContext(ctx context.Context) DirectoryVpcSettingsPtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(DirectoryVpcSettingsPtrOutput)
}

type DirectoryVpcSettingsOutput struct{ *pulumi.OutputState }

func (DirectoryVpcSettingsOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*DirectoryVpcSettings)(nil)).Elem()
}

func (o DirectoryVpcSettingsOutput) ToDirectoryVpcSettingsOutput() DirectoryVpcSettingsOutput {
	return o
}

func (o DirectoryVpcSettingsOutput) ToDirectoryVpcSettingsOutputWithContext(ctx context.Context) DirectoryVpcSettingsOutput {
	return o
}

func (o DirectoryVpcSettingsOutput) ToDirectoryVpcSettingsPtrOutput() DirectoryVpcSettingsPtrOutput {
	return o.ToDirectoryVpcSettingsPtrOutputWithContext(context.Background())
}

func (o DirectoryVpcSettingsOutput) ToDirectoryVpcSettingsPtrOutputWithContext(ctx context.Context) DirectoryVpcSettingsPtrOutput {
	return o.ApplyT(func(v DirectoryVpcSettings) *DirectoryVpcSettings {
		return &v
	}).(DirectoryVpcSettingsPtrOutput)
}

// The identifiers of the subnets for the directory servers (2 subnets in 2 different AZs).
func (o DirectoryVpcSettingsOutput) SubnetIds() pulumi.StringArrayOutput {
	return o.ApplyT(func(v DirectoryVpcSettings) []string { return v.SubnetIds }).(pulumi.StringArrayOutput)
}

// The identifier of the VPC that the directory is in.
func (o DirectoryVpcSettingsOutput) VpcId() pulumi.StringOutput {
	return o.ApplyT(func(v DirectoryVpcSettings) string { return v.VpcId }).(pulumi.StringOutput)
}

type DirectoryVpcSettingsPtrOutput struct{ *pulumi.OutputState }

func (DirectoryVpcSettingsPtrOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**DirectoryVpcSettings)(nil)).Elem()
}

func (o DirectoryVpcSettingsPtrOutput) ToDirectoryVpcSettingsPtrOutput() DirectoryVpcSettingsPtrOutput {
	return o
}

func (o DirectoryVpcSettingsPtrOutput) ToDirectoryVpcSettingsPtrOutputWithContext(ctx context.Context) DirectoryVpcSettingsPtrOutput {
	return o
}

func (o DirectoryVpcSettingsPtrOutput) Elem() DirectoryVpcSettingsOutput {
	return o.ApplyT(func(v *DirectoryVpcSettings) DirectoryVpcSettings { return *v }).(DirectoryVpcSettingsOutput)
}

// The identifiers of the subnets for the directory servers (2 subnets in 2 different AZs).
func (o DirectoryVpcSettingsPtrOutput) SubnetIds() pulumi.StringArrayOutput {
	return o.ApplyT(func(v DirectoryVpcSettings) []string { return v.SubnetIds }).(pulumi.StringArrayOutput)
}

// The identifier of the VPC that the directory is in.
func (o DirectoryVpcSettingsPtrOutput) VpcId() pulumi.StringOutput {
	return o.ApplyT(func(v DirectoryVpcSettings) string { return v.VpcId }).(pulumi.StringOutput)
}

type GetDirectoryConnectSetting struct {
	// The DNS IP addresses of the domain to connect to.
	CustomerDnsIps []string `pulumi:"customerDnsIps"`
	// The username corresponding to the password provided.
	CustomerUsername string `pulumi:"customerUsername"`
	// The identifiers of the subnets for the connector servers (2 subnets in 2 different AZs).
	SubnetIds []string `pulumi:"subnetIds"`
	// The ID of the VPC that the connector is in.
	VpcId string `pulumi:"vpcId"`
}

// Construct a concrete instance of GetDirectoryConnectSettingInput via:
// 	GetDirectoryConnectSettingArgs{...}
type GetDirectoryConnectSettingInput interface {
	pulumi.Input

	ToGetDirectoryConnectSettingOutput() GetDirectoryConnectSettingOutput
	ToGetDirectoryConnectSettingOutputWithContext(context.Context) GetDirectoryConnectSettingOutput
}

type GetDirectoryConnectSettingArgs struct {
	// The DNS IP addresses of the domain to connect to.
	CustomerDnsIps pulumi.StringArrayInput `pulumi:"customerDnsIps"`
	// The username corresponding to the password provided.
	CustomerUsername pulumi.StringInput `pulumi:"customerUsername"`
	// The identifiers of the subnets for the connector servers (2 subnets in 2 different AZs).
	SubnetIds pulumi.StringArrayInput `pulumi:"subnetIds"`
	// The ID of the VPC that the connector is in.
	VpcId pulumi.StringInput `pulumi:"vpcId"`
}

func (GetDirectoryConnectSettingArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*GetDirectoryConnectSetting)(nil)).Elem()
}

func (i GetDirectoryConnectSettingArgs) ToGetDirectoryConnectSettingOutput() GetDirectoryConnectSettingOutput {
	return i.ToGetDirectoryConnectSettingOutputWithContext(context.Background())
}

func (i GetDirectoryConnectSettingArgs) ToGetDirectoryConnectSettingOutputWithContext(ctx context.Context) GetDirectoryConnectSettingOutput {
	return pulumi.ToOutputWithContext(ctx, i).(GetDirectoryConnectSettingOutput)
}

// Construct a concrete instance of GetDirectoryConnectSettingArrayInput via:
// 	GetDirectoryConnectSettingArray{ GetDirectoryConnectSettingArgs{...} }
type GetDirectoryConnectSettingArrayInput interface {
	pulumi.Input

	ToGetDirectoryConnectSettingArrayOutput() GetDirectoryConnectSettingArrayOutput
	ToGetDirectoryConnectSettingArrayOutputWithContext(context.Context) GetDirectoryConnectSettingArrayOutput
}

type GetDirectoryConnectSettingArray []GetDirectoryConnectSettingInput

func (GetDirectoryConnectSettingArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]GetDirectoryConnectSetting)(nil)).Elem()
}

func (i GetDirectoryConnectSettingArray) ToGetDirectoryConnectSettingArrayOutput() GetDirectoryConnectSettingArrayOutput {
	return i.ToGetDirectoryConnectSettingArrayOutputWithContext(context.Background())
}

func (i GetDirectoryConnectSettingArray) ToGetDirectoryConnectSettingArrayOutputWithContext(ctx context.Context) GetDirectoryConnectSettingArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(GetDirectoryConnectSettingArrayOutput)
}

type GetDirectoryConnectSettingOutput struct{ *pulumi.OutputState }

func (GetDirectoryConnectSettingOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*GetDirectoryConnectSetting)(nil)).Elem()
}

func (o GetDirectoryConnectSettingOutput) ToGetDirectoryConnectSettingOutput() GetDirectoryConnectSettingOutput {
	return o
}

func (o GetDirectoryConnectSettingOutput) ToGetDirectoryConnectSettingOutputWithContext(ctx context.Context) GetDirectoryConnectSettingOutput {
	return o
}

// The DNS IP addresses of the domain to connect to.
func (o GetDirectoryConnectSettingOutput) CustomerDnsIps() pulumi.StringArrayOutput {
	return o.ApplyT(func(v GetDirectoryConnectSetting) []string { return v.CustomerDnsIps }).(pulumi.StringArrayOutput)
}

// The username corresponding to the password provided.
func (o GetDirectoryConnectSettingOutput) CustomerUsername() pulumi.StringOutput {
	return o.ApplyT(func(v GetDirectoryConnectSetting) string { return v.CustomerUsername }).(pulumi.StringOutput)
}

// The identifiers of the subnets for the connector servers (2 subnets in 2 different AZs).
func (o GetDirectoryConnectSettingOutput) SubnetIds() pulumi.StringArrayOutput {
	return o.ApplyT(func(v GetDirectoryConnectSetting) []string { return v.SubnetIds }).(pulumi.StringArrayOutput)
}

// The ID of the VPC that the connector is in.
func (o GetDirectoryConnectSettingOutput) VpcId() pulumi.StringOutput {
	return o.ApplyT(func(v GetDirectoryConnectSetting) string { return v.VpcId }).(pulumi.StringOutput)
}

type GetDirectoryConnectSettingArrayOutput struct{ *pulumi.OutputState }

func (GetDirectoryConnectSettingArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]GetDirectoryConnectSetting)(nil)).Elem()
}

func (o GetDirectoryConnectSettingArrayOutput) ToGetDirectoryConnectSettingArrayOutput() GetDirectoryConnectSettingArrayOutput {
	return o
}

func (o GetDirectoryConnectSettingArrayOutput) ToGetDirectoryConnectSettingArrayOutputWithContext(ctx context.Context) GetDirectoryConnectSettingArrayOutput {
	return o
}

func (o GetDirectoryConnectSettingArrayOutput) Index(i pulumi.IntInput) GetDirectoryConnectSettingOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) GetDirectoryConnectSetting {
		return vs[0].([]GetDirectoryConnectSetting)[vs[1].(int)]
	}).(GetDirectoryConnectSettingOutput)
}

type GetDirectoryVpcSetting struct {
	// The identifiers of the subnets for the connector servers (2 subnets in 2 different AZs).
	SubnetIds []string `pulumi:"subnetIds"`
	// The ID of the VPC that the connector is in.
	VpcId string `pulumi:"vpcId"`
}

// Construct a concrete instance of GetDirectoryVpcSettingInput via:
// 	GetDirectoryVpcSettingArgs{...}
type GetDirectoryVpcSettingInput interface {
	pulumi.Input

	ToGetDirectoryVpcSettingOutput() GetDirectoryVpcSettingOutput
	ToGetDirectoryVpcSettingOutputWithContext(context.Context) GetDirectoryVpcSettingOutput
}

type GetDirectoryVpcSettingArgs struct {
	// The identifiers of the subnets for the connector servers (2 subnets in 2 different AZs).
	SubnetIds pulumi.StringArrayInput `pulumi:"subnetIds"`
	// The ID of the VPC that the connector is in.
	VpcId pulumi.StringInput `pulumi:"vpcId"`
}

func (GetDirectoryVpcSettingArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*GetDirectoryVpcSetting)(nil)).Elem()
}

func (i GetDirectoryVpcSettingArgs) ToGetDirectoryVpcSettingOutput() GetDirectoryVpcSettingOutput {
	return i.ToGetDirectoryVpcSettingOutputWithContext(context.Background())
}

func (i GetDirectoryVpcSettingArgs) ToGetDirectoryVpcSettingOutputWithContext(ctx context.Context) GetDirectoryVpcSettingOutput {
	return pulumi.ToOutputWithContext(ctx, i).(GetDirectoryVpcSettingOutput)
}

// Construct a concrete instance of GetDirectoryVpcSettingArrayInput via:
// 	GetDirectoryVpcSettingArray{ GetDirectoryVpcSettingArgs{...} }
type GetDirectoryVpcSettingArrayInput interface {
	pulumi.Input

	ToGetDirectoryVpcSettingArrayOutput() GetDirectoryVpcSettingArrayOutput
	ToGetDirectoryVpcSettingArrayOutputWithContext(context.Context) GetDirectoryVpcSettingArrayOutput
}

type GetDirectoryVpcSettingArray []GetDirectoryVpcSettingInput

func (GetDirectoryVpcSettingArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]GetDirectoryVpcSetting)(nil)).Elem()
}

func (i GetDirectoryVpcSettingArray) ToGetDirectoryVpcSettingArrayOutput() GetDirectoryVpcSettingArrayOutput {
	return i.ToGetDirectoryVpcSettingArrayOutputWithContext(context.Background())
}

func (i GetDirectoryVpcSettingArray) ToGetDirectoryVpcSettingArrayOutputWithContext(ctx context.Context) GetDirectoryVpcSettingArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(GetDirectoryVpcSettingArrayOutput)
}

type GetDirectoryVpcSettingOutput struct{ *pulumi.OutputState }

func (GetDirectoryVpcSettingOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*GetDirectoryVpcSetting)(nil)).Elem()
}

func (o GetDirectoryVpcSettingOutput) ToGetDirectoryVpcSettingOutput() GetDirectoryVpcSettingOutput {
	return o
}

func (o GetDirectoryVpcSettingOutput) ToGetDirectoryVpcSettingOutputWithContext(ctx context.Context) GetDirectoryVpcSettingOutput {
	return o
}

// The identifiers of the subnets for the connector servers (2 subnets in 2 different AZs).
func (o GetDirectoryVpcSettingOutput) SubnetIds() pulumi.StringArrayOutput {
	return o.ApplyT(func(v GetDirectoryVpcSetting) []string { return v.SubnetIds }).(pulumi.StringArrayOutput)
}

// The ID of the VPC that the connector is in.
func (o GetDirectoryVpcSettingOutput) VpcId() pulumi.StringOutput {
	return o.ApplyT(func(v GetDirectoryVpcSetting) string { return v.VpcId }).(pulumi.StringOutput)
}

type GetDirectoryVpcSettingArrayOutput struct{ *pulumi.OutputState }

func (GetDirectoryVpcSettingArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]GetDirectoryVpcSetting)(nil)).Elem()
}

func (o GetDirectoryVpcSettingArrayOutput) ToGetDirectoryVpcSettingArrayOutput() GetDirectoryVpcSettingArrayOutput {
	return o
}

func (o GetDirectoryVpcSettingArrayOutput) ToGetDirectoryVpcSettingArrayOutputWithContext(ctx context.Context) GetDirectoryVpcSettingArrayOutput {
	return o
}

func (o GetDirectoryVpcSettingArrayOutput) Index(i pulumi.IntInput) GetDirectoryVpcSettingOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) GetDirectoryVpcSetting {
		return vs[0].([]GetDirectoryVpcSetting)[vs[1].(int)]
	}).(GetDirectoryVpcSettingOutput)
}

func init() {
	pulumi.RegisterOutputType(DirectoryConnectSettingsOutput{})
	pulumi.RegisterOutputType(DirectoryConnectSettingsPtrOutput{})
	pulumi.RegisterOutputType(DirectoryVpcSettingsOutput{})
	pulumi.RegisterOutputType(DirectoryVpcSettingsPtrOutput{})
	pulumi.RegisterOutputType(GetDirectoryConnectSettingOutput{})
	pulumi.RegisterOutputType(GetDirectoryConnectSettingArrayOutput{})
	pulumi.RegisterOutputType(GetDirectoryVpcSettingOutput{})
	pulumi.RegisterOutputType(GetDirectoryVpcSettingArrayOutput{})
}
