// *** WARNING: this file was generated by the Lumi Terraform Bridge (TFGEN) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as lumi from "@lumi/lumi";
import * as lumirt from "@lumi/lumirt";

export class NatGateway extends lumi.NamedResource implements NatGatewayArgs {
    public readonly allocationId: string;
    public readonly networkInterfaceId: string;
    public readonly privateIp: string;
    public readonly publicIp: string;
    public readonly subnetId: string;

    constructor(name: string, args: NatGatewayArgs) {
        super(name);
        if (lumirt.defaultIfComputed(args.allocationId, "") === undefined) {
            throw new Error("Property argument 'allocationId' is required, but was missing");
        }
        this.allocationId = args.allocationId;
        this.networkInterfaceId = args.networkInterfaceId;
        this.privateIp = args.privateIp;
        this.publicIp = args.publicIp;
        if (lumirt.defaultIfComputed(args.subnetId, "") === undefined) {
            throw new Error("Property argument 'subnetId' is required, but was missing");
        }
        this.subnetId = args.subnetId;
    }
}

export interface NatGatewayArgs {
    readonly allocationId: string;
    readonly networkInterfaceId?: string;
    readonly privateIp?: string;
    readonly publicIp?: string;
    readonly subnetId: string;
}

