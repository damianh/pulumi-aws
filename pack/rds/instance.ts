// *** WARNING: this file was generated by the Lumi Terraform Bridge (TFGEN) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as lumi from "@lumi/lumi";
import * as lumirt from "@lumi/lumirt";

export class Instance extends lumi.NamedResource implements InstanceArgs {
    public /*out*/ readonly address: string;
    public readonly allocatedStorage: number;
    public readonly allowMajorVersionUpgrade?: boolean;
    public readonly applyImmediately: boolean;
    public /*out*/ readonly arn: string;
    public readonly autoMinorVersionUpgrade?: boolean;
    public readonly availabilityZone: string;
    public readonly backupRetentionPeriod: number;
    public readonly backupWindow: string;
    public readonly characterSetName: string;
    public readonly copyTagsToSnapshot?: boolean;
    public readonly dbSubnetGroupName: string;
    public /*out*/ readonly endpoint: string;
    public readonly engine: string;
    public readonly engineVersion: string;
    public readonly finalSnapshotIdentifier?: string;
    public /*out*/ readonly hostedZoneId: string;
    public readonly iamDatabaseAuthenticationEnabled?: boolean;
    public readonly identifier: string;
    public readonly identifierPrefix: string;
    public readonly instanceClass: string;
    public readonly iops?: number;
    public readonly kmsKeyId: string;
    public readonly licenseModel: string;
    public readonly maintenanceWindow: string;
    public readonly monitoringInterval?: number;
    public readonly monitoringRoleArn: string;
    public readonly multiAz: boolean;
    public readonly instanceName: string;
    public readonly optionGroupName: string;
    public readonly parameterGroupName: string;
    public readonly password?: string;
    public readonly port: number;
    public readonly publiclyAccessible?: boolean;
    public /*out*/ readonly replicas: string[];
    public readonly replicateSourceDb?: string;
    public /*out*/ readonly resourceId: string;
    public readonly securityGroupNames?: string[];
    public readonly skipFinalSnapshot?: boolean;
    public readonly snapshotIdentifier?: string;
    public /*out*/ readonly status: string;
    public readonly storageEncrypted?: boolean;
    public readonly storageType: string;
    public readonly tags?: {[key: string]: any};
    public readonly timezone: string;
    public readonly username: string;
    public readonly vpcSecurityGroupIds: string[];

    constructor(name: string, args: InstanceArgs) {
        super(name);
        this.allocatedStorage = args.allocatedStorage;
        this.allowMajorVersionUpgrade = args.allowMajorVersionUpgrade;
        this.applyImmediately = args.applyImmediately;
        this.autoMinorVersionUpgrade = args.autoMinorVersionUpgrade;
        this.availabilityZone = args.availabilityZone;
        this.backupRetentionPeriod = args.backupRetentionPeriod;
        this.backupWindow = args.backupWindow;
        this.characterSetName = args.characterSetName;
        this.copyTagsToSnapshot = args.copyTagsToSnapshot;
        this.dbSubnetGroupName = args.dbSubnetGroupName;
        this.engine = args.engine;
        this.engineVersion = args.engineVersion;
        this.finalSnapshotIdentifier = args.finalSnapshotIdentifier;
        this.iamDatabaseAuthenticationEnabled = args.iamDatabaseAuthenticationEnabled;
        this.identifier = args.identifier;
        this.identifierPrefix = args.identifierPrefix;
        if (lumirt.defaultIfComputed(args.instanceClass, "") === undefined) {
            throw new Error("Property argument 'instanceClass' is required, but was missing");
        }
        this.instanceClass = args.instanceClass;
        this.iops = args.iops;
        this.kmsKeyId = args.kmsKeyId;
        this.licenseModel = args.licenseModel;
        this.maintenanceWindow = args.maintenanceWindow;
        this.monitoringInterval = args.monitoringInterval;
        this.monitoringRoleArn = args.monitoringRoleArn;
        this.multiAz = args.multiAz;
        this.instanceName = args.instanceName;
        this.optionGroupName = args.optionGroupName;
        this.parameterGroupName = args.parameterGroupName;
        this.password = args.password;
        this.port = args.port;
        this.publiclyAccessible = args.publiclyAccessible;
        this.replicateSourceDb = args.replicateSourceDb;
        this.securityGroupNames = args.securityGroupNames;
        this.skipFinalSnapshot = args.skipFinalSnapshot;
        this.snapshotIdentifier = args.snapshotIdentifier;
        this.storageEncrypted = args.storageEncrypted;
        this.storageType = args.storageType;
        this.tags = args.tags;
        this.timezone = args.timezone;
        this.username = args.username;
        this.vpcSecurityGroupIds = args.vpcSecurityGroupIds;
    }
}

export interface InstanceArgs {
    readonly allocatedStorage?: number;
    readonly allowMajorVersionUpgrade?: boolean;
    readonly applyImmediately?: boolean;
    readonly autoMinorVersionUpgrade?: boolean;
    readonly availabilityZone?: string;
    readonly backupRetentionPeriod?: number;
    readonly backupWindow?: string;
    readonly characterSetName?: string;
    readonly copyTagsToSnapshot?: boolean;
    readonly dbSubnetGroupName?: string;
    readonly engine?: string;
    readonly engineVersion?: string;
    readonly finalSnapshotIdentifier?: string;
    readonly iamDatabaseAuthenticationEnabled?: boolean;
    readonly identifier?: string;
    readonly identifierPrefix?: string;
    readonly instanceClass: string;
    readonly iops?: number;
    readonly kmsKeyId?: string;
    readonly licenseModel?: string;
    readonly maintenanceWindow?: string;
    readonly monitoringInterval?: number;
    readonly monitoringRoleArn?: string;
    readonly multiAz?: boolean;
    readonly instanceName?: string;
    readonly optionGroupName?: string;
    readonly parameterGroupName?: string;
    readonly password?: string;
    readonly port?: number;
    readonly publiclyAccessible?: boolean;
    readonly replicateSourceDb?: string;
    readonly securityGroupNames?: string[];
    readonly skipFinalSnapshot?: boolean;
    readonly snapshotIdentifier?: string;
    readonly storageEncrypted?: boolean;
    readonly storageType?: string;
    readonly tags?: {[key: string]: any};
    readonly timezone?: string;
    readonly username?: string;
    readonly vpcSecurityGroupIds?: string[];
}

