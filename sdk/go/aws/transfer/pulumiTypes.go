// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

// nolint: lll
package transfer

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

type ServerEndpointDetails struct {
	// The ID of the VPC endpoint.
	VpcEndpointId string `pulumi:"vpcEndpointId"`
}

type ServerEndpointDetailsInput interface {
	pulumi.Input

	ToServerEndpointDetailsOutput() ServerEndpointDetailsOutput
	ToServerEndpointDetailsOutputWithContext(context.Context) ServerEndpointDetailsOutput
}

type ServerEndpointDetailsArgs struct {
	// The ID of the VPC endpoint.
	VpcEndpointId pulumi.StringInput `pulumi:"vpcEndpointId"`
}

func (ServerEndpointDetailsArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*ServerEndpointDetails)(nil)).Elem()
}

func (i ServerEndpointDetailsArgs) ToServerEndpointDetailsOutput() ServerEndpointDetailsOutput {
	return i.ToServerEndpointDetailsOutputWithContext(context.Background())
}

func (i ServerEndpointDetailsArgs) ToServerEndpointDetailsOutputWithContext(ctx context.Context) ServerEndpointDetailsOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ServerEndpointDetailsOutput)
}

func (i ServerEndpointDetailsArgs) ToServerEndpointDetailsPtrOutput() ServerEndpointDetailsPtrOutput {
	return i.ToServerEndpointDetailsPtrOutputWithContext(context.Background())
}

func (i ServerEndpointDetailsArgs) ToServerEndpointDetailsPtrOutputWithContext(ctx context.Context) ServerEndpointDetailsPtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ServerEndpointDetailsOutput).ToServerEndpointDetailsPtrOutputWithContext(ctx)
}

type ServerEndpointDetailsPtrInput interface {
	pulumi.Input

	ToServerEndpointDetailsPtrOutput() ServerEndpointDetailsPtrOutput
	ToServerEndpointDetailsPtrOutputWithContext(context.Context) ServerEndpointDetailsPtrOutput
}

type serverEndpointDetailsPtrType ServerEndpointDetailsArgs

func ServerEndpointDetailsPtr(v *ServerEndpointDetailsArgs) ServerEndpointDetailsPtrInput {	return (*serverEndpointDetailsPtrType)(v)
}

func (*serverEndpointDetailsPtrType) ElementType() reflect.Type {
	return reflect.TypeOf((**ServerEndpointDetails)(nil)).Elem()
}

func (i *serverEndpointDetailsPtrType) ToServerEndpointDetailsPtrOutput() ServerEndpointDetailsPtrOutput {
	return i.ToServerEndpointDetailsPtrOutputWithContext(context.Background())
}

func (i *serverEndpointDetailsPtrType) ToServerEndpointDetailsPtrOutputWithContext(ctx context.Context) ServerEndpointDetailsPtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ServerEndpointDetailsPtrOutput)
}

type ServerEndpointDetailsOutput struct { *pulumi.OutputState }

func (ServerEndpointDetailsOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*ServerEndpointDetails)(nil)).Elem()
}

func (o ServerEndpointDetailsOutput) ToServerEndpointDetailsOutput() ServerEndpointDetailsOutput {
	return o
}

func (o ServerEndpointDetailsOutput) ToServerEndpointDetailsOutputWithContext(ctx context.Context) ServerEndpointDetailsOutput {
	return o
}

func (o ServerEndpointDetailsOutput) ToServerEndpointDetailsPtrOutput() ServerEndpointDetailsPtrOutput {
	return o.ToServerEndpointDetailsPtrOutputWithContext(context.Background())
}

func (o ServerEndpointDetailsOutput) ToServerEndpointDetailsPtrOutputWithContext(ctx context.Context) ServerEndpointDetailsPtrOutput {
	return o.ApplyT(func(v ServerEndpointDetails) *ServerEndpointDetails {
		return &v
	}).(ServerEndpointDetailsPtrOutput)
}
// The ID of the VPC endpoint.
func (o ServerEndpointDetailsOutput) VpcEndpointId() pulumi.StringOutput {
	return o.ApplyT(func (v ServerEndpointDetails) string { return v.VpcEndpointId }).(pulumi.StringOutput)
}

type ServerEndpointDetailsPtrOutput struct { *pulumi.OutputState}

func (ServerEndpointDetailsPtrOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**ServerEndpointDetails)(nil)).Elem()
}

func (o ServerEndpointDetailsPtrOutput) ToServerEndpointDetailsPtrOutput() ServerEndpointDetailsPtrOutput {
	return o
}

func (o ServerEndpointDetailsPtrOutput) ToServerEndpointDetailsPtrOutputWithContext(ctx context.Context) ServerEndpointDetailsPtrOutput {
	return o
}

func (o ServerEndpointDetailsPtrOutput) Elem() ServerEndpointDetailsOutput {
	return o.ApplyT(func (v *ServerEndpointDetails) ServerEndpointDetails { return *v }).(ServerEndpointDetailsOutput)
}

// The ID of the VPC endpoint.
func (o ServerEndpointDetailsPtrOutput) VpcEndpointId() pulumi.StringOutput {
	return o.ApplyT(func (v ServerEndpointDetails) string { return v.VpcEndpointId }).(pulumi.StringOutput)
}

func init() {
	pulumi.RegisterOutputType(ServerEndpointDetailsOutput{})
	pulumi.RegisterOutputType(ServerEndpointDetailsPtrOutput{})
}