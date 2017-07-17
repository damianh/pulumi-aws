// *** WARNING: this file was generated by the Lumi Terraform Bridge (TFGEN) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as lumi from "@lumi/lumi";
import * as lumirt from "@lumi/lumirt";

export class OriginAccessIdentity extends lumi.NamedResource implements OriginAccessIdentityArgs {
    public /*out*/ readonly callerReference: string;
    public /*out*/ readonly cloudfrontAccessIdentityPath: string;
    public readonly comment?: string;
    public /*out*/ readonly etag: string;
    public /*out*/ readonly iamArn: string;
    public /*out*/ readonly s3CanonicalUserId: string;

    constructor(name: string, args: OriginAccessIdentityArgs) {
        super(name);
        this.comment = args.comment;
    }
}

export interface OriginAccessIdentityArgs {
    readonly comment?: string;
}

