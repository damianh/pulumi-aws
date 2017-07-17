// *** WARNING: this file was generated by the Lumi Terraform Bridge (TFGEN) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as lumi from "@lumi/lumi";
import * as lumirt from "@lumi/lumirt";

export class Attachment extends lumi.NamedResource implements AttachmentArgs {
    public readonly albTargetGroupArn?: string;
    public readonly autoscalingGroupName: string;
    public readonly elb?: string;

    constructor(name: string, args: AttachmentArgs) {
        super(name);
        this.albTargetGroupArn = args.albTargetGroupArn;
        if (lumirt.defaultIfComputed(args.autoscalingGroupName, "") === undefined) {
            throw new Error("Property argument 'autoscalingGroupName' is required, but was missing");
        }
        this.autoscalingGroupName = args.autoscalingGroupName;
        this.elb = args.elb;
    }
}

export interface AttachmentArgs {
    readonly albTargetGroupArn?: string;
    readonly autoscalingGroupName: string;
    readonly elb?: string;
}

