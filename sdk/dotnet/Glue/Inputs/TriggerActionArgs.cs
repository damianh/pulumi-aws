// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Glue.Inputs
{

    public sealed class TriggerActionArgs : Pulumi.ResourceArgs
    {
        [Input("arguments")]
        private InputMap<object>? _arguments;

        /// <summary>
        /// Arguments to be passed to the job. You can specify arguments here that your own job-execution script consumes, as well as arguments that AWS Glue itself consumes.
        /// </summary>
        public InputMap<object> Arguments
        {
            get => _arguments ?? (_arguments = new InputMap<object>());
            set => _arguments = value;
        }

        /// <summary>
        /// The name of the crawler to be executed. Conflicts with `job_name`.
        /// </summary>
        [Input("crawlerName")]
        public Input<string>? CrawlerName { get; set; }

        /// <summary>
        /// The name of a job to be executed. Conflicts with `crawler_name`.
        /// </summary>
        [Input("jobName")]
        public Input<string>? JobName { get; set; }

        /// <summary>
        /// The job run timeout in minutes. It overrides the timeout value of the job.
        /// </summary>
        [Input("timeout")]
        public Input<int>? Timeout { get; set; }

        public TriggerActionArgs()
        {
        }
    }
}
