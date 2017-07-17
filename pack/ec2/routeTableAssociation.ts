// *** WARNING: this file was generated by the Lumi Terraform Bridge (TFGEN) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as lumi from "@lumi/lumi";
import * as lumirt from "@lumi/lumirt";

export class RouteTableAssociation extends lumi.NamedResource implements RouteTableAssociationArgs {
    public readonly routeTableId: string;
    public readonly subnetId: string;

    constructor(name: string, args: RouteTableAssociationArgs) {
        super(name);
        if (lumirt.defaultIfComputed(args.routeTableId, "") === undefined) {
            throw new Error("Property argument 'routeTableId' is required, but was missing");
        }
        this.routeTableId = args.routeTableId;
        if (lumirt.defaultIfComputed(args.subnetId, "") === undefined) {
            throw new Error("Property argument 'subnetId' is required, but was missing");
        }
        this.subnetId = args.subnetId;
    }
}

export interface RouteTableAssociationArgs {
    readonly routeTableId: string;
    readonly subnetId: string;
}

