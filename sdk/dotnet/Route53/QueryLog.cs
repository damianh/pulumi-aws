// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Route53
{
    /// <summary>
    /// Provides a Route53 query logging configuration resource.
    /// 
    /// &gt; **NOTE:** There are restrictions on the configuration of query logging. Notably,
    /// the CloudWatch log group must be in the `us-east-1` region,
    /// a permissive CloudWatch log resource policy must be in place, and
    /// the Route53 hosted zone must be public.
    /// See [Configuring Logging for DNS Queries](https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/query-logs.html?console_help=true#query-logs-configuring) for additional details.
    /// </summary>
    public partial class QueryLog : Pulumi.CustomResource
    {
        /// <summary>
        /// CloudWatch log group ARN to send query logs.
        /// </summary>
        [Output("cloudwatchLogGroupArn")]
        public Output<string> CloudwatchLogGroupArn { get; private set; } = null!;

        /// <summary>
        /// Route53 hosted zone ID to enable query logs.
        /// </summary>
        [Output("zoneId")]
        public Output<string> ZoneId { get; private set; } = null!;


        /// <summary>
        /// Create a QueryLog resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public QueryLog(string name, QueryLogArgs args, CustomResourceOptions? options = null)
            : base("aws:route53/queryLog:QueryLog", name, args ?? new QueryLogArgs(), MakeResourceOptions(options, ""))
        {
        }

        private QueryLog(string name, Input<string> id, QueryLogState? state = null, CustomResourceOptions? options = null)
            : base("aws:route53/queryLog:QueryLog", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing QueryLog resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static QueryLog Get(string name, Input<string> id, QueryLogState? state = null, CustomResourceOptions? options = null)
        {
            return new QueryLog(name, id, state, options);
        }
    }

    public sealed class QueryLogArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// CloudWatch log group ARN to send query logs.
        /// </summary>
        [Input("cloudwatchLogGroupArn", required: true)]
        public Input<string> CloudwatchLogGroupArn { get; set; } = null!;

        /// <summary>
        /// Route53 hosted zone ID to enable query logs.
        /// </summary>
        [Input("zoneId", required: true)]
        public Input<string> ZoneId { get; set; } = null!;

        public QueryLogArgs()
        {
        }
    }

    public sealed class QueryLogState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// CloudWatch log group ARN to send query logs.
        /// </summary>
        [Input("cloudwatchLogGroupArn")]
        public Input<string>? CloudwatchLogGroupArn { get; set; }

        /// <summary>
        /// Route53 hosted zone ID to enable query logs.
        /// </summary>
        [Input("zoneId")]
        public Input<string>? ZoneId { get; set; }

        public QueryLogState()
        {
        }
    }
}
