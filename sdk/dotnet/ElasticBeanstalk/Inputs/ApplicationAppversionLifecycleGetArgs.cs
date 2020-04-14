// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.ElasticBeanstalk.Inputs
{

    public sealed class ApplicationAppversionLifecycleGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Set to `true` to delete a version's source bundle from S3 when the application version is deleted.
        /// </summary>
        [Input("deleteSourceFromS3")]
        public Input<bool>? DeleteSourceFromS3 { get; set; }

        /// <summary>
        /// The number of days to retain an application version ('max_age_in_days' and 'max_count' cannot be enabled simultaneously.).
        /// </summary>
        [Input("maxAgeInDays")]
        public Input<int>? MaxAgeInDays { get; set; }

        /// <summary>
        /// The maximum number of application versions to retain ('max_age_in_days' and 'max_count' cannot be enabled simultaneously.).
        /// </summary>
        [Input("maxCount")]
        public Input<int>? MaxCount { get; set; }

        /// <summary>
        /// The ARN of an IAM service role under which the application version is deleted.  Elastic Beanstalk must have permission to assume this role.
        /// </summary>
        [Input("serviceRole", required: true)]
        public Input<string> ServiceRole { get; set; } = null!;

        public ApplicationAppversionLifecycleGetArgs()
        {
        }
    }
}
