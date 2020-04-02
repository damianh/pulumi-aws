// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package cloudhsmv2

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

type ClusterClusterCertificate struct {
	AwsHardwareCertificate          *string `pulumi:"awsHardwareCertificate"`
	ClusterCertificate              *string `pulumi:"clusterCertificate"`
	ClusterCsr                      *string `pulumi:"clusterCsr"`
	HsmCertificate                  *string `pulumi:"hsmCertificate"`
	ManufacturerHardwareCertificate *string `pulumi:"manufacturerHardwareCertificate"`
}

// Construct a concrete instance of ClusterClusterCertificateInput via:
// 	ClusterClusterCertificateArgs{...}
type ClusterClusterCertificateInput interface {
	pulumi.Input

	ToClusterClusterCertificateOutput() ClusterClusterCertificateOutput
	ToClusterClusterCertificateOutputWithContext(context.Context) ClusterClusterCertificateOutput
}

type ClusterClusterCertificateArgs struct {
	AwsHardwareCertificate          pulumi.StringPtrInput `pulumi:"awsHardwareCertificate"`
	ClusterCertificate              pulumi.StringPtrInput `pulumi:"clusterCertificate"`
	ClusterCsr                      pulumi.StringPtrInput `pulumi:"clusterCsr"`
	HsmCertificate                  pulumi.StringPtrInput `pulumi:"hsmCertificate"`
	ManufacturerHardwareCertificate pulumi.StringPtrInput `pulumi:"manufacturerHardwareCertificate"`
}

func (ClusterClusterCertificateArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*ClusterClusterCertificate)(nil)).Elem()
}

func (i ClusterClusterCertificateArgs) ToClusterClusterCertificateOutput() ClusterClusterCertificateOutput {
	return i.ToClusterClusterCertificateOutputWithContext(context.Background())
}

func (i ClusterClusterCertificateArgs) ToClusterClusterCertificateOutputWithContext(ctx context.Context) ClusterClusterCertificateOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ClusterClusterCertificateOutput)
}

// Construct a concrete instance of ClusterClusterCertificateArrayInput via:
// 	ClusterClusterCertificateArray{ ClusterClusterCertificateArgs{...} }
type ClusterClusterCertificateArrayInput interface {
	pulumi.Input

	ToClusterClusterCertificateArrayOutput() ClusterClusterCertificateArrayOutput
	ToClusterClusterCertificateArrayOutputWithContext(context.Context) ClusterClusterCertificateArrayOutput
}

type ClusterClusterCertificateArray []ClusterClusterCertificateInput

func (ClusterClusterCertificateArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]ClusterClusterCertificate)(nil)).Elem()
}

func (i ClusterClusterCertificateArray) ToClusterClusterCertificateArrayOutput() ClusterClusterCertificateArrayOutput {
	return i.ToClusterClusterCertificateArrayOutputWithContext(context.Background())
}

func (i ClusterClusterCertificateArray) ToClusterClusterCertificateArrayOutputWithContext(ctx context.Context) ClusterClusterCertificateArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ClusterClusterCertificateArrayOutput)
}

type ClusterClusterCertificateOutput struct{ *pulumi.OutputState }

func (ClusterClusterCertificateOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*ClusterClusterCertificate)(nil)).Elem()
}

func (o ClusterClusterCertificateOutput) ToClusterClusterCertificateOutput() ClusterClusterCertificateOutput {
	return o
}

func (o ClusterClusterCertificateOutput) ToClusterClusterCertificateOutputWithContext(ctx context.Context) ClusterClusterCertificateOutput {
	return o
}

func (o ClusterClusterCertificateOutput) AwsHardwareCertificate() pulumi.StringPtrOutput {
	return o.ApplyT(func(v ClusterClusterCertificate) *string { return v.AwsHardwareCertificate }).(pulumi.StringPtrOutput)
}

func (o ClusterClusterCertificateOutput) ClusterCertificate() pulumi.StringPtrOutput {
	return o.ApplyT(func(v ClusterClusterCertificate) *string { return v.ClusterCertificate }).(pulumi.StringPtrOutput)
}

func (o ClusterClusterCertificateOutput) ClusterCsr() pulumi.StringPtrOutput {
	return o.ApplyT(func(v ClusterClusterCertificate) *string { return v.ClusterCsr }).(pulumi.StringPtrOutput)
}

func (o ClusterClusterCertificateOutput) HsmCertificate() pulumi.StringPtrOutput {
	return o.ApplyT(func(v ClusterClusterCertificate) *string { return v.HsmCertificate }).(pulumi.StringPtrOutput)
}

func (o ClusterClusterCertificateOutput) ManufacturerHardwareCertificate() pulumi.StringPtrOutput {
	return o.ApplyT(func(v ClusterClusterCertificate) *string { return v.ManufacturerHardwareCertificate }).(pulumi.StringPtrOutput)
}

type ClusterClusterCertificateArrayOutput struct{ *pulumi.OutputState }

func (ClusterClusterCertificateArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]ClusterClusterCertificate)(nil)).Elem()
}

func (o ClusterClusterCertificateArrayOutput) ToClusterClusterCertificateArrayOutput() ClusterClusterCertificateArrayOutput {
	return o
}

func (o ClusterClusterCertificateArrayOutput) ToClusterClusterCertificateArrayOutputWithContext(ctx context.Context) ClusterClusterCertificateArrayOutput {
	return o
}

func (o ClusterClusterCertificateArrayOutput) Index(i pulumi.IntInput) ClusterClusterCertificateOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) ClusterClusterCertificate {
		return vs[0].([]ClusterClusterCertificate)[vs[1].(int)]
	}).(ClusterClusterCertificateOutput)
}

type GetClusterClusterCertificates struct {
	AwsHardwareCertificate          string `pulumi:"awsHardwareCertificate"`
	ClusterCertificate              string `pulumi:"clusterCertificate"`
	ClusterCsr                      string `pulumi:"clusterCsr"`
	HsmCertificate                  string `pulumi:"hsmCertificate"`
	ManufacturerHardwareCertificate string `pulumi:"manufacturerHardwareCertificate"`
}

// Construct a concrete instance of GetClusterClusterCertificatesInput via:
// 	GetClusterClusterCertificatesArgs{...}
type GetClusterClusterCertificatesInput interface {
	pulumi.Input

	ToGetClusterClusterCertificatesOutput() GetClusterClusterCertificatesOutput
	ToGetClusterClusterCertificatesOutputWithContext(context.Context) GetClusterClusterCertificatesOutput
}

type GetClusterClusterCertificatesArgs struct {
	AwsHardwareCertificate          pulumi.StringInput `pulumi:"awsHardwareCertificate"`
	ClusterCertificate              pulumi.StringInput `pulumi:"clusterCertificate"`
	ClusterCsr                      pulumi.StringInput `pulumi:"clusterCsr"`
	HsmCertificate                  pulumi.StringInput `pulumi:"hsmCertificate"`
	ManufacturerHardwareCertificate pulumi.StringInput `pulumi:"manufacturerHardwareCertificate"`
}

func (GetClusterClusterCertificatesArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*GetClusterClusterCertificates)(nil)).Elem()
}

func (i GetClusterClusterCertificatesArgs) ToGetClusterClusterCertificatesOutput() GetClusterClusterCertificatesOutput {
	return i.ToGetClusterClusterCertificatesOutputWithContext(context.Background())
}

func (i GetClusterClusterCertificatesArgs) ToGetClusterClusterCertificatesOutputWithContext(ctx context.Context) GetClusterClusterCertificatesOutput {
	return pulumi.ToOutputWithContext(ctx, i).(GetClusterClusterCertificatesOutput)
}

type GetClusterClusterCertificatesOutput struct{ *pulumi.OutputState }

func (GetClusterClusterCertificatesOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*GetClusterClusterCertificates)(nil)).Elem()
}

func (o GetClusterClusterCertificatesOutput) ToGetClusterClusterCertificatesOutput() GetClusterClusterCertificatesOutput {
	return o
}

func (o GetClusterClusterCertificatesOutput) ToGetClusterClusterCertificatesOutputWithContext(ctx context.Context) GetClusterClusterCertificatesOutput {
	return o
}

func (o GetClusterClusterCertificatesOutput) AwsHardwareCertificate() pulumi.StringOutput {
	return o.ApplyT(func(v GetClusterClusterCertificates) string { return v.AwsHardwareCertificate }).(pulumi.StringOutput)
}

func (o GetClusterClusterCertificatesOutput) ClusterCertificate() pulumi.StringOutput {
	return o.ApplyT(func(v GetClusterClusterCertificates) string { return v.ClusterCertificate }).(pulumi.StringOutput)
}

func (o GetClusterClusterCertificatesOutput) ClusterCsr() pulumi.StringOutput {
	return o.ApplyT(func(v GetClusterClusterCertificates) string { return v.ClusterCsr }).(pulumi.StringOutput)
}

func (o GetClusterClusterCertificatesOutput) HsmCertificate() pulumi.StringOutput {
	return o.ApplyT(func(v GetClusterClusterCertificates) string { return v.HsmCertificate }).(pulumi.StringOutput)
}

func (o GetClusterClusterCertificatesOutput) ManufacturerHardwareCertificate() pulumi.StringOutput {
	return o.ApplyT(func(v GetClusterClusterCertificates) string { return v.ManufacturerHardwareCertificate }).(pulumi.StringOutput)
}

func init() {
	pulumi.RegisterOutputType(ClusterClusterCertificateOutput{})
	pulumi.RegisterOutputType(ClusterClusterCertificateArrayOutput{})
	pulumi.RegisterOutputType(GetClusterClusterCertificatesOutput{})
}
