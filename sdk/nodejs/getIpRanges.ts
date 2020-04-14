// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

/**
 * Use this data source to get the IP ranges of various AWS products and services. For more information about the contents of this data source and required JSON syntax if referencing a custom URL, see the [AWS IP Address Ranges documention][1].
 * 
 *
 * > This content is derived from https://github.com/terraform-providers/terraform-provider-aws/blob/master/website/docs/d/ip_ranges.html.markdown.
 */
export function getIpRanges(args: GetIpRangesArgs, opts?: pulumi.InvokeOptions): Promise<GetIpRangesResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("aws:index/getIpRanges:getIpRanges", {
        "regions": args.regions,
        "services": args.services,
        "url": args.url,
    }, opts);
}

/**
 * A collection of arguments for invoking getIpRanges.
 */
export interface GetIpRangesArgs {
    /**
     * Filter IP ranges by regions (or include all regions, if
     * omitted). Valid items are `global` (for `cloudfront`) as well as all AWS regions
     * (e.g. `eu-central-1`)
     */
    readonly regions?: string[];
    /**
     * Filter IP ranges by services. Valid items are `amazon`
     * (for amazon.com), `amazonConnect`, `apiGateway`, `cloud9`, `cloudfront`,
     * `codebuild`, `dynamodb`, `ec2`, `ec2InstanceConnect`, `globalaccelerator`,
     * `route53`, `route53Healthchecks`, `s3` and `workspacesGateways`. See the
     * [`service` attribute][2] documentation for other possible values.
     */
    readonly services: string[];
    /**
     * Custom URL for source JSON file. Syntax must match [AWS IP Address Ranges documention][1]. Defaults to `https://ip-ranges.amazonaws.com/ip-ranges.json`.
     */
    readonly url?: string;
}

/**
 * A collection of values returned by getIpRanges.
 */
export interface GetIpRangesResult {
    /**
     * The lexically ordered list of CIDR blocks.
     */
    readonly cidrBlocks: string[];
    /**
     * The publication time of the IP ranges (e.g. `2016-08-03-23-46-05`).
     */
    readonly createDate: string;
    /**
     * The lexically ordered list of IPv6 CIDR blocks.
     */
    readonly ipv6CidrBlocks: string[];
    readonly regions?: string[];
    readonly services: string[];
    /**
     * The publication time of the IP ranges, in Unix epoch time format
     * (e.g. `1470267965`).
     */
    readonly syncToken: number;
    readonly url?: string;
    /**
     * id is the provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
}
