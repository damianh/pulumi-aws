// *** WARNING: this file was generated by the Lumi Terraform Bridge (TFGEN) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as lumi from "@lumi/lumi";
import * as lumirt from "@lumi/lumirt";

export class KeyPair extends lumi.NamedResource implements KeyPairArgs {
    public /*out*/ readonly fingerprint: string;
    public readonly keyName: string;
    public readonly keyNamePrefix?: string;
    public readonly publicKey: string;

    public static get(id: lumi.ID): KeyPair {
        return <any>undefined; // functionality provided by the runtime
    }

    public static query(q: any): KeyPair[] {
        return <any>undefined; // functionality provided by the runtime
    }

    constructor(urnName: string, args: KeyPairArgs) {
        super(urnName);
        this.keyName = <any>args.keyName;
        this.keyNamePrefix = <any>args.keyNamePrefix;
        if (lumirt.defaultIfComputed(args.publicKey, "") === undefined) {
            throw new Error("Property argument 'publicKey' is required, but was missing");
        }
        this.publicKey = <any>args.publicKey;
    }
}

export interface KeyPairArgs {
    readonly keyName?: string;
    readonly keyNamePrefix?: string;
    readonly publicKey: string;
}
