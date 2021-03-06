// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package codeartifact

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Provides a CodeArtifact Repository Resource.
//
// ## Example Usage
//
// ```go
// package main
//
// import (
// 	"github.com/pulumi/pulumi-aws/sdk/v3/go/aws/codeartifact"
// 	"github.com/pulumi/pulumi-aws/sdk/v3/go/aws/kms"
// 	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
// )
//
// func main() {
// 	pulumi.Run(func(ctx *pulumi.Context) error {
// 		exampleKey, err := kms.NewKey(ctx, "exampleKey", &kms.KeyArgs{
// 			Description: pulumi.String("domain key"),
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		exampleDomain, err := codeartifact.NewDomain(ctx, "exampleDomain", &codeartifact.DomainArgs{
// 			Domain:        pulumi.String("example"),
// 			EncryptionKey: exampleKey.Arn,
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		_, err = codeartifact.NewRepository(ctx, "test", &codeartifact.RepositoryArgs{
// 			Repository: pulumi.String("example"),
// 			Domain:     exampleDomain.Domain,
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		return nil
// 	})
// }
// ```
// ### With Upstream Repository
//
// ```go
// package main
//
// import (
// 	"github.com/pulumi/pulumi-aws/sdk/v3/go/aws/codeartifact"
// 	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
// )
//
// func main() {
// 	pulumi.Run(func(ctx *pulumi.Context) error {
// 		upstream, err := codeartifact.NewRepository(ctx, "upstream", &codeartifact.RepositoryArgs{
// 			Repository: pulumi.String("upstream"),
// 			Domain:     pulumi.Any(aws_codeartifact_domain.Test.Domain),
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		_, err = codeartifact.NewRepository(ctx, "test", &codeartifact.RepositoryArgs{
// 			Repository: pulumi.String("example"),
// 			Domain:     pulumi.Any(aws_codeartifact_domain.Example.Domain),
// 			Upstreams: codeartifact.RepositoryUpstreamArray{
// 				&codeartifact.RepositoryUpstreamArgs{
// 					RepositoryName: upstream.Repository,
// 				},
// 			},
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		return nil
// 	})
// }
// ```
type Repository struct {
	pulumi.CustomResourceState

	// The account number of the AWS account that manages the repository.
	AdministratorAccount pulumi.StringOutput `pulumi:"administratorAccount"`
	// The ARN of the repository.
	Arn pulumi.StringOutput `pulumi:"arn"`
	// The description of the repository.
	Description pulumi.StringPtrOutput `pulumi:"description"`
	// The domain that contains the created repository.
	Domain pulumi.StringOutput `pulumi:"domain"`
	// The account number of the AWS account that owns the domain.
	DomainOwner pulumi.StringOutput `pulumi:"domainOwner"`
	// An array of external connections associated with the repository. see External Connections
	ExternalConnections RepositoryExternalConnectionArrayOutput `pulumi:"externalConnections"`
	// The name of the repository to create.
	Repository pulumi.StringOutput `pulumi:"repository"`
	// A list of upstream repositories to associate with the repository. The order of the upstream repositories in the list determines their priority order when AWS CodeArtifact looks for a requested package version. see Upstream
	Upstreams RepositoryUpstreamArrayOutput `pulumi:"upstreams"`
}

// NewRepository registers a new resource with the given unique name, arguments, and options.
func NewRepository(ctx *pulumi.Context,
	name string, args *RepositoryArgs, opts ...pulumi.ResourceOption) (*Repository, error) {
	if args == nil || args.Domain == nil {
		return nil, errors.New("missing required argument 'Domain'")
	}
	if args == nil || args.Repository == nil {
		return nil, errors.New("missing required argument 'Repository'")
	}
	if args == nil {
		args = &RepositoryArgs{}
	}
	var resource Repository
	err := ctx.RegisterResource("aws:codeartifact/repository:Repository", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetRepository gets an existing Repository resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetRepository(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *RepositoryState, opts ...pulumi.ResourceOption) (*Repository, error) {
	var resource Repository
	err := ctx.ReadResource("aws:codeartifact/repository:Repository", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Repository resources.
type repositoryState struct {
	// The account number of the AWS account that manages the repository.
	AdministratorAccount *string `pulumi:"administratorAccount"`
	// The ARN of the repository.
	Arn *string `pulumi:"arn"`
	// The description of the repository.
	Description *string `pulumi:"description"`
	// The domain that contains the created repository.
	Domain *string `pulumi:"domain"`
	// The account number of the AWS account that owns the domain.
	DomainOwner *string `pulumi:"domainOwner"`
	// An array of external connections associated with the repository. see External Connections
	ExternalConnections []RepositoryExternalConnection `pulumi:"externalConnections"`
	// The name of the repository to create.
	Repository *string `pulumi:"repository"`
	// A list of upstream repositories to associate with the repository. The order of the upstream repositories in the list determines their priority order when AWS CodeArtifact looks for a requested package version. see Upstream
	Upstreams []RepositoryUpstream `pulumi:"upstreams"`
}

type RepositoryState struct {
	// The account number of the AWS account that manages the repository.
	AdministratorAccount pulumi.StringPtrInput
	// The ARN of the repository.
	Arn pulumi.StringPtrInput
	// The description of the repository.
	Description pulumi.StringPtrInput
	// The domain that contains the created repository.
	Domain pulumi.StringPtrInput
	// The account number of the AWS account that owns the domain.
	DomainOwner pulumi.StringPtrInput
	// An array of external connections associated with the repository. see External Connections
	ExternalConnections RepositoryExternalConnectionArrayInput
	// The name of the repository to create.
	Repository pulumi.StringPtrInput
	// A list of upstream repositories to associate with the repository. The order of the upstream repositories in the list determines their priority order when AWS CodeArtifact looks for a requested package version. see Upstream
	Upstreams RepositoryUpstreamArrayInput
}

func (RepositoryState) ElementType() reflect.Type {
	return reflect.TypeOf((*repositoryState)(nil)).Elem()
}

type repositoryArgs struct {
	// The description of the repository.
	Description *string `pulumi:"description"`
	// The domain that contains the created repository.
	Domain string `pulumi:"domain"`
	// The account number of the AWS account that owns the domain.
	DomainOwner *string `pulumi:"domainOwner"`
	// The name of the repository to create.
	Repository string `pulumi:"repository"`
	// A list of upstream repositories to associate with the repository. The order of the upstream repositories in the list determines their priority order when AWS CodeArtifact looks for a requested package version. see Upstream
	Upstreams []RepositoryUpstream `pulumi:"upstreams"`
}

// The set of arguments for constructing a Repository resource.
type RepositoryArgs struct {
	// The description of the repository.
	Description pulumi.StringPtrInput
	// The domain that contains the created repository.
	Domain pulumi.StringInput
	// The account number of the AWS account that owns the domain.
	DomainOwner pulumi.StringPtrInput
	// The name of the repository to create.
	Repository pulumi.StringInput
	// A list of upstream repositories to associate with the repository. The order of the upstream repositories in the list determines their priority order when AWS CodeArtifact looks for a requested package version. see Upstream
	Upstreams RepositoryUpstreamArrayInput
}

func (RepositoryArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*repositoryArgs)(nil)).Elem()
}
