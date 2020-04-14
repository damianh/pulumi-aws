// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.S3.Outputs
{

    [OutputType]
    public sealed class BucketNotificationLambdaFunction
    {
        /// <summary>
        /// Specifies [event](http://docs.aws.amazon.com/AmazonS3/latest/dev/NotificationHowTo.html#notification-how-to-event-types-and-destinations) for which to send notifications.
        /// </summary>
        public readonly ImmutableArray<string> Events;
        /// <summary>
        /// Specifies object key name prefix.
        /// </summary>
        public readonly string? FilterPrefix;
        /// <summary>
        /// Specifies object key name suffix.
        /// </summary>
        public readonly string? FilterSuffix;
        /// <summary>
        /// Specifies unique identifier for each of the notification configurations.
        /// </summary>
        public readonly string? Id;
        /// <summary>
        /// Specifies Amazon Lambda function ARN.
        /// </summary>
        public readonly string? LambdaFunctionArn;

        [OutputConstructor]
        private BucketNotificationLambdaFunction(
            ImmutableArray<string> events,

            string? filterPrefix,

            string? filterSuffix,

            string? id,

            string? lambdaFunctionArn)
        {
            Events = events;
            FilterPrefix = filterPrefix;
            FilterSuffix = filterSuffix;
            Id = id;
            LambdaFunctionArn = lambdaFunctionArn;
        }
    }
}
