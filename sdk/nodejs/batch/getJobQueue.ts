// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

/**
 * The Batch Job Queue data source allows access to details of a specific
 * job queue within AWS Batch.
 * 
 * ## Example Usage
 * 
 * 
 * 
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as aws from "@pulumi/aws";
 * 
 * const testQueue = aws.batch.getJobQueue({
 *     name: "tf-test-batch-job-queue",
 * });
 * ```
 *
 * > This content is derived from https://github.com/terraform-providers/terraform-provider-aws/blob/master/website/docs/d/batch_job_queue.html.markdown.
 */
export function getJobQueue(args: GetJobQueueArgs, opts?: pulumi.InvokeOptions): Promise<GetJobQueueResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("aws:batch/getJobQueue:getJobQueue", {
        "name": args.name,
    }, opts);
}

/**
 * A collection of arguments for invoking getJobQueue.
 */
export interface GetJobQueueArgs {
    /**
     * The name of the job queue.
     */
    readonly name: string;
}

/**
 * A collection of values returned by getJobQueue.
 */
export interface GetJobQueueResult {
    /**
     * The ARN of the job queue.
     */
    readonly arn: string;
    /**
     * The compute environments that are attached to the job queue and the order in
     * which job placement is preferred. Compute environments are selected for job placement in ascending order.
     * * `compute_environment_order.#.order` - The order of the compute environment.
     * * `compute_environment_order.#.compute_environment` - The ARN of the compute environment.
     */
    readonly computeEnvironmentOrders: outputs.batch.GetJobQueueComputeEnvironmentOrder[];
    readonly name: string;
    /**
     * The priority of the job queue. Job queues with a higher priority are evaluated first when
     * associated with the same compute environment.
     */
    readonly priority: number;
    /**
     * Describes the ability of the queue to accept new jobs (for example, `ENABLED` or `DISABLED`).
     */
    readonly state: string;
    /**
     * The current status of the job queue (for example, `CREATING` or `VALID`).
     */
    readonly status: string;
    /**
     * A short, human-readable string to provide additional details about the current status
     * of the job queue.
     */
    readonly statusReason: string;
    /**
     * id is the provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
}
