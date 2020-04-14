// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.CloudWatch.Inputs
{

    public sealed class MetricAlarmMetricQueryMetricGetArgs : Pulumi.ResourceArgs
    {
        [Input("dimensions")]
        private InputMap<object>? _dimensions;

        /// <summary>
        /// The dimensions for this metric.  For the list of available dimensions see the AWS documentation [here](http://docs.aws.amazon.com/AmazonCloudWatch/latest/DeveloperGuide/CW_Support_For_AWS.html).
        /// </summary>
        public InputMap<object> Dimensions
        {
            get => _dimensions ?? (_dimensions = new InputMap<object>());
            set => _dimensions = value;
        }

        /// <summary>
        /// The name for this metric.
        /// See docs for [supported metrics](https://docs.aws.amazon.com/AmazonCloudWatch/latest/DeveloperGuide/CW_Support_For_AWS.html).
        /// </summary>
        [Input("metricName", required: true)]
        public Input<string> MetricName { get; set; } = null!;

        /// <summary>
        /// The namespace for this metric. See docs for the [list of namespaces](https://docs.aws.amazon.com/AmazonCloudWatch/latest/DeveloperGuide/aws-namespaces.html).
        /// See docs for [supported metrics](https://docs.aws.amazon.com/AmazonCloudWatch/latest/DeveloperGuide/CW_Support_For_AWS.html).
        /// </summary>
        [Input("namespace")]
        public Input<string>? Namespace { get; set; }

        /// <summary>
        /// The period in seconds over which the specified `stat` is applied.
        /// </summary>
        [Input("period", required: true)]
        public Input<int> Period { get; set; } = null!;

        /// <summary>
        /// The statistic to apply to this metric.
        /// Either of the following is supported: `SampleCount`, `Average`, `Sum`, `Minimum`, `Maximum`
        /// </summary>
        [Input("stat", required: true)]
        public Input<string> Stat { get; set; } = null!;

        /// <summary>
        /// The unit for this metric.
        /// </summary>
        [Input("unit")]
        public Input<string>? Unit { get; set; }

        public MetricAlarmMetricQueryMetricGetArgs()
        {
        }
    }
}
