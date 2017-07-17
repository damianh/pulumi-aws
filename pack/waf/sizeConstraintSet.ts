// *** WARNING: this file was generated by the Lumi Terraform Bridge (TFGEN) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as lumi from "@lumi/lumi";
import * as lumirt from "@lumi/lumirt";

export class SizeConstraintSet extends lumi.NamedResource implements SizeConstraintSetArgs {
    public readonly sizeConstraintSetName?: string;
    public readonly sizeConstraints?: { comparisonOperator: string, fieldToMatch: { data?: string, type: string }[], size: number, textTransformation: string }[];

    constructor(name: string, args: SizeConstraintSetArgs) {
        super(name);
        this.sizeConstraintSetName = args.sizeConstraintSetName;
        this.sizeConstraints = args.sizeConstraints;
    }
}

export interface SizeConstraintSetArgs {
    readonly sizeConstraintSetName?: string;
    readonly sizeConstraints?: { comparisonOperator: string, fieldToMatch: { data?: string, type: string }[], size: number, textTransformation: string }[];
}

