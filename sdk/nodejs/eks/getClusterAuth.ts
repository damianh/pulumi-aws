// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

/**
 * Get an authentication token to communicate with an EKS cluster.
 * 
 * Uses IAM credentials from the AWS provider to generate a temporary token that is compatible with
 * [AWS IAM Authenticator](https://github.com/kubernetes-sigs/aws-iam-authenticator) authentication.
 * This can be used to authenticate to an EKS cluster or to a cluster that has the AWS IAM Authenticator
 * server configured.
 * 
 *
 * > This content is derived from https://github.com/terraform-providers/terraform-provider-aws/blob/master/website/docs/d/eks_cluster_auth.html.markdown.
 */
export function getClusterAuth(args: GetClusterAuthArgs, opts?: pulumi.InvokeOptions): Promise<GetClusterAuthResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("aws:eks/getClusterAuth:getClusterAuth", {
        "name": args.name,
    }, opts);
}

/**
 * A collection of arguments for invoking getClusterAuth.
 */
export interface GetClusterAuthArgs {
    /**
     * The name of the cluster
     */
    readonly name: string;
}

/**
 * A collection of values returned by getClusterAuth.
 */
export interface GetClusterAuthResult {
    readonly name: string;
    /**
     * The token to use to authenticate with the cluster.
     */
    readonly token: string;
    /**
     * id is the provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
}
