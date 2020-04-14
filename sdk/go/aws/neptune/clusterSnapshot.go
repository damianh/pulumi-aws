// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package neptune

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Manages a Neptune database cluster snapshot.
type ClusterSnapshot struct {
	pulumi.CustomResourceState

	// Specifies the allocated storage size in gigabytes (GB).
	AllocatedStorage pulumi.IntOutput `pulumi:"allocatedStorage"`
	// List of EC2 Availability Zones that instances in the DB cluster snapshot can be restored in.
	AvailabilityZones pulumi.StringArrayOutput `pulumi:"availabilityZones"`
	// The DB Cluster Identifier from which to take the snapshot.
	DbClusterIdentifier pulumi.StringOutput `pulumi:"dbClusterIdentifier"`
	// The Amazon Resource Name (ARN) for the DB Cluster Snapshot.
	DbClusterSnapshotArn pulumi.StringOutput `pulumi:"dbClusterSnapshotArn"`
	// The Identifier for the snapshot.
	DbClusterSnapshotIdentifier pulumi.StringOutput `pulumi:"dbClusterSnapshotIdentifier"`
	// Specifies the name of the database engine.
	Engine pulumi.StringOutput `pulumi:"engine"`
	// Version of the database engine for this DB cluster snapshot.
	EngineVersion pulumi.StringOutput `pulumi:"engineVersion"`
	// If storageEncrypted is true, the AWS KMS key identifier for the encrypted DB cluster snapshot.
	KmsKeyId pulumi.StringOutput `pulumi:"kmsKeyId"`
	// License model information for the restored DB cluster.
	LicenseModel pulumi.StringOutput `pulumi:"licenseModel"`
	// Port that the DB cluster was listening on at the time of the snapshot.
	Port                       pulumi.IntOutput    `pulumi:"port"`
	SnapshotType               pulumi.StringOutput `pulumi:"snapshotType"`
	SourceDbClusterSnapshotArn pulumi.StringOutput `pulumi:"sourceDbClusterSnapshotArn"`
	// The status of this DB Cluster Snapshot.
	Status pulumi.StringOutput `pulumi:"status"`
	// Specifies whether the DB cluster snapshot is encrypted.
	StorageEncrypted pulumi.BoolOutput `pulumi:"storageEncrypted"`
	// The VPC ID associated with the DB cluster snapshot.
	VpcId pulumi.StringOutput `pulumi:"vpcId"`
}

// NewClusterSnapshot registers a new resource with the given unique name, arguments, and options.
func NewClusterSnapshot(ctx *pulumi.Context,
	name string, args *ClusterSnapshotArgs, opts ...pulumi.ResourceOption) (*ClusterSnapshot, error) {
	if args == nil || args.DbClusterIdentifier == nil {
		return nil, errors.New("missing required argument 'DbClusterIdentifier'")
	}
	if args == nil || args.DbClusterSnapshotIdentifier == nil {
		return nil, errors.New("missing required argument 'DbClusterSnapshotIdentifier'")
	}
	if args == nil {
		args = &ClusterSnapshotArgs{}
	}
	var resource ClusterSnapshot
	err := ctx.RegisterResource("aws:neptune/clusterSnapshot:ClusterSnapshot", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetClusterSnapshot gets an existing ClusterSnapshot resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetClusterSnapshot(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ClusterSnapshotState, opts ...pulumi.ResourceOption) (*ClusterSnapshot, error) {
	var resource ClusterSnapshot
	err := ctx.ReadResource("aws:neptune/clusterSnapshot:ClusterSnapshot", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering ClusterSnapshot resources.
type clusterSnapshotState struct {
	// Specifies the allocated storage size in gigabytes (GB).
	AllocatedStorage *int `pulumi:"allocatedStorage"`
	// List of EC2 Availability Zones that instances in the DB cluster snapshot can be restored in.
	AvailabilityZones []string `pulumi:"availabilityZones"`
	// The DB Cluster Identifier from which to take the snapshot.
	DbClusterIdentifier *string `pulumi:"dbClusterIdentifier"`
	// The Amazon Resource Name (ARN) for the DB Cluster Snapshot.
	DbClusterSnapshotArn *string `pulumi:"dbClusterSnapshotArn"`
	// The Identifier for the snapshot.
	DbClusterSnapshotIdentifier *string `pulumi:"dbClusterSnapshotIdentifier"`
	// Specifies the name of the database engine.
	Engine *string `pulumi:"engine"`
	// Version of the database engine for this DB cluster snapshot.
	EngineVersion *string `pulumi:"engineVersion"`
	// If storageEncrypted is true, the AWS KMS key identifier for the encrypted DB cluster snapshot.
	KmsKeyId *string `pulumi:"kmsKeyId"`
	// License model information for the restored DB cluster.
	LicenseModel *string `pulumi:"licenseModel"`
	// Port that the DB cluster was listening on at the time of the snapshot.
	Port                       *int    `pulumi:"port"`
	SnapshotType               *string `pulumi:"snapshotType"`
	SourceDbClusterSnapshotArn *string `pulumi:"sourceDbClusterSnapshotArn"`
	// The status of this DB Cluster Snapshot.
	Status *string `pulumi:"status"`
	// Specifies whether the DB cluster snapshot is encrypted.
	StorageEncrypted *bool `pulumi:"storageEncrypted"`
	// The VPC ID associated with the DB cluster snapshot.
	VpcId *string `pulumi:"vpcId"`
}

type ClusterSnapshotState struct {
	// Specifies the allocated storage size in gigabytes (GB).
	AllocatedStorage pulumi.IntPtrInput
	// List of EC2 Availability Zones that instances in the DB cluster snapshot can be restored in.
	AvailabilityZones pulumi.StringArrayInput
	// The DB Cluster Identifier from which to take the snapshot.
	DbClusterIdentifier pulumi.StringPtrInput
	// The Amazon Resource Name (ARN) for the DB Cluster Snapshot.
	DbClusterSnapshotArn pulumi.StringPtrInput
	// The Identifier for the snapshot.
	DbClusterSnapshotIdentifier pulumi.StringPtrInput
	// Specifies the name of the database engine.
	Engine pulumi.StringPtrInput
	// Version of the database engine for this DB cluster snapshot.
	EngineVersion pulumi.StringPtrInput
	// If storageEncrypted is true, the AWS KMS key identifier for the encrypted DB cluster snapshot.
	KmsKeyId pulumi.StringPtrInput
	// License model information for the restored DB cluster.
	LicenseModel pulumi.StringPtrInput
	// Port that the DB cluster was listening on at the time of the snapshot.
	Port                       pulumi.IntPtrInput
	SnapshotType               pulumi.StringPtrInput
	SourceDbClusterSnapshotArn pulumi.StringPtrInput
	// The status of this DB Cluster Snapshot.
	Status pulumi.StringPtrInput
	// Specifies whether the DB cluster snapshot is encrypted.
	StorageEncrypted pulumi.BoolPtrInput
	// The VPC ID associated with the DB cluster snapshot.
	VpcId pulumi.StringPtrInput
}

func (ClusterSnapshotState) ElementType() reflect.Type {
	return reflect.TypeOf((*clusterSnapshotState)(nil)).Elem()
}

type clusterSnapshotArgs struct {
	// The DB Cluster Identifier from which to take the snapshot.
	DbClusterIdentifier string `pulumi:"dbClusterIdentifier"`
	// The Identifier for the snapshot.
	DbClusterSnapshotIdentifier string `pulumi:"dbClusterSnapshotIdentifier"`
}

// The set of arguments for constructing a ClusterSnapshot resource.
type ClusterSnapshotArgs struct {
	// The DB Cluster Identifier from which to take the snapshot.
	DbClusterIdentifier pulumi.StringInput
	// The Identifier for the snapshot.
	DbClusterSnapshotIdentifier pulumi.StringInput
}

func (ClusterSnapshotArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*clusterSnapshotArgs)(nil)).Elem()
}
