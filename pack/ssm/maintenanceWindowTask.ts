// *** WARNING: this file was generated by the Lumi Terraform Bridge (TFGEN) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as lumi from "@lumi/lumi";
import * as lumirt from "@lumi/lumirt";

export class MaintenanceWindowTask extends lumi.NamedResource implements MaintenanceWindowTaskArgs {
    public readonly loggingInfo?: { s3BucketName: string, s3BucketPrefix?: string, s3Region: string }[];
    public readonly maxConcurrency: string;
    public readonly maxErrors: string;
    public readonly priority?: number;
    public readonly serviceRoleArn: string;
    public readonly targets: { key: string, values: string[] }[];
    public readonly taskArn: string;
    public readonly taskParameters?: { name: string, values: string[] }[];
    public readonly taskType: string;
    public readonly windowId: string;

    constructor(name: string, args: MaintenanceWindowTaskArgs) {
        super(name);
        this.loggingInfo = args.loggingInfo;
        if (lumirt.defaultIfComputed(args.maxConcurrency, "") === undefined) {
            throw new Error("Property argument 'maxConcurrency' is required, but was missing");
        }
        this.maxConcurrency = args.maxConcurrency;
        if (lumirt.defaultIfComputed(args.maxErrors, "") === undefined) {
            throw new Error("Property argument 'maxErrors' is required, but was missing");
        }
        this.maxErrors = args.maxErrors;
        this.priority = args.priority;
        if (lumirt.defaultIfComputed(args.serviceRoleArn, "") === undefined) {
            throw new Error("Property argument 'serviceRoleArn' is required, but was missing");
        }
        this.serviceRoleArn = args.serviceRoleArn;
        if (lumirt.defaultIfComputed(args.targets, "") === undefined) {
            throw new Error("Property argument 'targets' is required, but was missing");
        }
        this.targets = args.targets;
        if (lumirt.defaultIfComputed(args.taskArn, "") === undefined) {
            throw new Error("Property argument 'taskArn' is required, but was missing");
        }
        this.taskArn = args.taskArn;
        this.taskParameters = args.taskParameters;
        if (lumirt.defaultIfComputed(args.taskType, "") === undefined) {
            throw new Error("Property argument 'taskType' is required, but was missing");
        }
        this.taskType = args.taskType;
        if (lumirt.defaultIfComputed(args.windowId, "") === undefined) {
            throw new Error("Property argument 'windowId' is required, but was missing");
        }
        this.windowId = args.windowId;
    }
}

export interface MaintenanceWindowTaskArgs {
    readonly loggingInfo?: { s3BucketName: string, s3BucketPrefix?: string, s3Region: string }[];
    readonly maxConcurrency: string;
    readonly maxErrors: string;
    readonly priority?: number;
    readonly serviceRoleArn: string;
    readonly targets: { key: string, values: string[] }[];
    readonly taskArn: string;
    readonly taskParameters?: { name: string, values: string[] }[];
    readonly taskType: string;
    readonly windowId: string;
}

