// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package ec2

import (
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Use this data source to get IDs and VPC membership of Security Groups that are created
// outside of this provider.
func GetSecurityGroups(ctx *pulumi.Context, args *GetSecurityGroupsArgs, opts ...pulumi.InvokeOption) (*GetSecurityGroupsResult, error) {
	var rv GetSecurityGroupsResult
	err := ctx.Invoke("aws:ec2/getSecurityGroups:getSecurityGroups", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getSecurityGroups.
type GetSecurityGroupsArgs struct {
	// One or more name/value pairs to use as filters. There are
	// several valid keys, for a full reference, check out
	// [describe-security-groups in the AWS CLI reference][1].
	Filters []GetSecurityGroupsFilter `pulumi:"filters"`
	// A mapping of tags, each pair of which must exactly match for
	// desired security groups.
	Tags map[string]interface{} `pulumi:"tags"`
}

// A collection of values returned by getSecurityGroups.
type GetSecurityGroupsResult struct {
	Filters []GetSecurityGroupsFilter `pulumi:"filters"`
	// id is the provider-assigned unique ID for this managed resource.
	Id string `pulumi:"id"`
	// IDs of the matches security groups.
	Ids  []string               `pulumi:"ids"`
	Tags map[string]interface{} `pulumi:"tags"`
	// The VPC IDs of the matched security groups. The data source's tag or filter *will span VPCs*
	// unless the `vpc-id` filter is also used.
	VpcIds []string `pulumi:"vpcIds"`
}
