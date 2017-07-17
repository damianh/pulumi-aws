// *** WARNING: this file was generated by the Lumi Terraform Bridge (TFGEN) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as lumi from "@lumi/lumi";
import * as lumirt from "@lumi/lumirt";

export class VpnConnection extends lumi.NamedResource implements VpnConnectionArgs {
    public readonly customerGatewayConfiguration: string;
    public readonly customerGatewayId: string;
    public readonly routes: { destinationCidrBlock: string, source: string, state: string }[];
    public readonly staticRoutesOnly: boolean;
    public readonly tags?: {[key: string]: any};
    public /*out*/ readonly tunnel1Address: string;
    public /*out*/ readonly tunnel1BgpAsn: string;
    public /*out*/ readonly tunnel1BgpHoldtime: number;
    public /*out*/ readonly tunnel1CgwInsideAddress: string;
    public /*out*/ readonly tunnel1PresharedKey: string;
    public /*out*/ readonly tunnel1VgwInsideAddress: string;
    public /*out*/ readonly tunnel2Address: string;
    public /*out*/ readonly tunnel2BgpAsn: string;
    public /*out*/ readonly tunnel2BgpHoldtime: number;
    public /*out*/ readonly tunnel2CgwInsideAddress: string;
    public /*out*/ readonly tunnel2PresharedKey: string;
    public /*out*/ readonly tunnel2VgwInsideAddress: string;
    public readonly type: string;
    public readonly vgwTelemetry: { acceptedRouteCount: number, lastStatusChange: string, outsideIpAddress: string, status: string, statusMessage: string }[];
    public readonly vpnGatewayId: string;

    constructor(name: string, args: VpnConnectionArgs) {
        super(name);
        this.customerGatewayConfiguration = args.customerGatewayConfiguration;
        if (lumirt.defaultIfComputed(args.customerGatewayId, "") === undefined) {
            throw new Error("Property argument 'customerGatewayId' is required, but was missing");
        }
        this.customerGatewayId = args.customerGatewayId;
        this.routes = args.routes;
        this.staticRoutesOnly = args.staticRoutesOnly;
        this.tags = args.tags;
        if (lumirt.defaultIfComputed(args.type, "") === undefined) {
            throw new Error("Property argument 'type' is required, but was missing");
        }
        this.type = args.type;
        this.vgwTelemetry = args.vgwTelemetry;
        if (lumirt.defaultIfComputed(args.vpnGatewayId, "") === undefined) {
            throw new Error("Property argument 'vpnGatewayId' is required, but was missing");
        }
        this.vpnGatewayId = args.vpnGatewayId;
    }
}

export interface VpnConnectionArgs {
    readonly customerGatewayConfiguration?: string;
    readonly customerGatewayId: string;
    readonly routes?: { destinationCidrBlock: string, source: string, state: string }[];
    readonly staticRoutesOnly?: boolean;
    readonly tags?: {[key: string]: any};
    readonly type: string;
    readonly vgwTelemetry?: { acceptedRouteCount: number, lastStatusChange: string, outsideIpAddress: string, status: string, statusMessage: string }[];
    readonly vpnGatewayId: string;
}

