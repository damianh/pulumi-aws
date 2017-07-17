// *** WARNING: this file was generated by the Lumi Terraform Bridge (TFGEN) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as lumi from "@lumi/lumi";
import * as lumirt from "@lumi/lumirt";

export class Trigger extends lumi.NamedResource implements TriggerArgs {
    public /*out*/ readonly configurationId: string;
    public readonly repositoryName: string;
    public readonly trigger: { branches?: string[], customData?: string, destinationArn: string, events: string[], name: string }[];

    constructor(name: string, args: TriggerArgs) {
        super(name);
        if (lumirt.defaultIfComputed(args.repositoryName, "") === undefined) {
            throw new Error("Property argument 'repositoryName' is required, but was missing");
        }
        this.repositoryName = args.repositoryName;
        if (lumirt.defaultIfComputed(args.trigger, "") === undefined) {
            throw new Error("Property argument 'trigger' is required, but was missing");
        }
        this.trigger = args.trigger;
    }
}

export interface TriggerArgs {
    readonly repositoryName: string;
    readonly trigger: { branches?: string[], customData?: string, destinationArn: string, events: string[], name: string }[];
}

