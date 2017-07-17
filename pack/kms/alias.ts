// *** WARNING: this file was generated by the Lumi Terraform Bridge (TFGEN) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as lumi from "@lumi/lumi";
import * as lumirt from "@lumi/lumirt";

export class Alias extends lumi.NamedResource implements AliasArgs {
    public /*out*/ readonly arn: string;
    public readonly aliasName?: string;
    public readonly namePrefix?: string;
    public readonly targetKeyId: string;

    constructor(name: string, args: AliasArgs) {
        super(name);
        this.aliasName = args.aliasName;
        this.namePrefix = args.namePrefix;
        if (lumirt.defaultIfComputed(args.targetKeyId, "") === undefined) {
            throw new Error("Property argument 'targetKeyId' is required, but was missing");
        }
        this.targetKeyId = args.targetKeyId;
    }
}

export interface AliasArgs {
    readonly aliasName?: string;
    readonly namePrefix?: string;
    readonly targetKeyId: string;
}

