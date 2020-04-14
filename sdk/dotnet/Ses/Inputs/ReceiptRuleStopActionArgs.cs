// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Ses.Inputs
{

    public sealed class ReceiptRuleStopActionArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The position of the action in the receipt rule
        /// </summary>
        [Input("position", required: true)]
        public Input<int> Position { get; set; } = null!;

        /// <summary>
        /// The scope to apply
        /// </summary>
        [Input("scope", required: true)]
        public Input<string> Scope { get; set; } = null!;

        /// <summary>
        /// The ARN of an SNS topic to notify
        /// </summary>
        [Input("topicArn")]
        public Input<string>? TopicArn { get; set; }

        public ReceiptRuleStopActionArgs()
        {
        }
    }
}
