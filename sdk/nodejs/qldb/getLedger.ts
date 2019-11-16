// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * Use this data source to fetch information about a Quantum Ledger Database.
 * 
 * ## Example Usage
 * 
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as aws from "@pulumi/aws";
 * 
 * const example = aws.qldb.getLedger({
 *     name: "anExampleLedger",
 * });
 * ```
 *
 * > This content is derived from https://github.com/terraform-providers/terraform-provider-aws/blob/master/website/docs/d/qldb_ledger.html.markdown.
 */
export function getLedger(args: GetLedgerArgs, opts?: pulumi.InvokeOptions): Promise<GetLedgerResult> & GetLedgerResult {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    const promise: Promise<GetLedgerResult> = pulumi.runtime.invoke("aws:qldb/getLedger:getLedger", {
        "name": args.name,
    }, opts);

    return pulumi.utils.liftProperties(promise, opts);
}

/**
 * A collection of arguments for invoking getLedger.
 */
export interface GetLedgerArgs {
    /**
     * The friendly name of the ledger to match.
     */
    readonly name: string;
}

/**
 * A collection of values returned by getLedger.
 */
export interface GetLedgerResult {
    /**
     * Amazon Resource Name (ARN) of the ledger.
     */
    readonly arn: string;
    /**
     * Deletion protection on the QLDB Ledger instance. Set to `true` by default. 
     */
    readonly deletionProtection: boolean;
    readonly name: string;
    /**
     * id is the provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
}
