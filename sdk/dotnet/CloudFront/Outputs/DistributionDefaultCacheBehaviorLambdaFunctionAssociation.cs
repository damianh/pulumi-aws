// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.CloudFront.Outputs
{

    [OutputType]
    public sealed class DistributionDefaultCacheBehaviorLambdaFunctionAssociation
    {
        /// <summary>
        /// The specific event to trigger this function.
        /// Valid values: `viewer-request`, `origin-request`, `viewer-response`,
        /// `origin-response`
        /// </summary>
        public readonly string EventType;
        /// <summary>
        /// When set to true it exposes the request body to the lambda function. Defaults to false. Valid values: `true`, `false`.
        /// </summary>
        public readonly bool? IncludeBody;
        /// <summary>
        /// ARN of the Lambda function.
        /// </summary>
        public readonly string LambdaArn;

        [OutputConstructor]
        private DistributionDefaultCacheBehaviorLambdaFunctionAssociation(
            string eventType,

            bool? includeBody,

            string lambdaArn)
        {
            EventType = eventType;
            IncludeBody = includeBody;
            LambdaArn = lambdaArn;
        }
    }
}
