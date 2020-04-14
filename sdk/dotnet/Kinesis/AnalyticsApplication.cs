// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Kinesis
{
    /// <summary>
    /// Provides a Kinesis Analytics Application resource. Kinesis Analytics is a managed service that
    /// allows processing and analyzing streaming data using standard SQL.
    /// 
    /// For more details, see the [Amazon Kinesis Analytics Documentation][1].
    /// </summary>
    public partial class AnalyticsApplication : Pulumi.CustomResource
    {
        /// <summary>
        /// The ARN of the Kinesis Analytics Appliation.
        /// </summary>
        [Output("arn")]
        public Output<string> Arn { get; private set; } = null!;

        /// <summary>
        /// The CloudWatch log stream options to monitor application errors.
        /// See CloudWatch Logging Options below for more details.
        /// </summary>
        [Output("cloudwatchLoggingOptions")]
        public Output<Outputs.AnalyticsApplicationCloudwatchLoggingOptions?> CloudwatchLoggingOptions { get; private set; } = null!;

        /// <summary>
        /// SQL Code to transform input data, and generate output.
        /// </summary>
        [Output("code")]
        public Output<string?> Code { get; private set; } = null!;

        /// <summary>
        /// The Timestamp when the application version was created.
        /// </summary>
        [Output("createTimestamp")]
        public Output<string> CreateTimestamp { get; private set; } = null!;

        /// <summary>
        /// Description of the application.
        /// </summary>
        [Output("description")]
        public Output<string?> Description { get; private set; } = null!;

        /// <summary>
        /// Input configuration of the application. See Inputs below for more details.
        /// </summary>
        [Output("inputs")]
        public Output<Outputs.AnalyticsApplicationInputs?> Inputs { get; private set; } = null!;

        /// <summary>
        /// The Timestamp when the application was last updated.
        /// </summary>
        [Output("lastUpdateTimestamp")]
        public Output<string> LastUpdateTimestamp { get; private set; } = null!;

        /// <summary>
        /// Name of the Kinesis Analytics Application.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// Output destination configuration of the application. See Outputs below for more details.
        /// </summary>
        [Output("outputs")]
        public Output<ImmutableArray<Outputs.AnalyticsApplicationOutput>> Outputs { get; private set; } = null!;

        /// <summary>
        /// An S3 Reference Data Source for the application.
        /// See Reference Data Sources below for more details.
        /// </summary>
        [Output("referenceDataSources")]
        public Output<Outputs.AnalyticsApplicationReferenceDataSources?> ReferenceDataSources { get; private set; } = null!;

        /// <summary>
        /// The Status of the application.
        /// </summary>
        [Output("status")]
        public Output<string> Status { get; private set; } = null!;

        /// <summary>
        /// Key-value mapping of tags for the Kinesis Analytics Application.
        /// </summary>
        [Output("tags")]
        public Output<ImmutableDictionary<string, object>?> Tags { get; private set; } = null!;

        /// <summary>
        /// The Version of the application.
        /// </summary>
        [Output("version")]
        public Output<int> Version { get; private set; } = null!;


        /// <summary>
        /// Create a AnalyticsApplication resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public AnalyticsApplication(string name, AnalyticsApplicationArgs? args = null, CustomResourceOptions? options = null)
            : base("aws:kinesis/analyticsApplication:AnalyticsApplication", name, args ?? new AnalyticsApplicationArgs(), MakeResourceOptions(options, ""))
        {
        }

        private AnalyticsApplication(string name, Input<string> id, AnalyticsApplicationState? state = null, CustomResourceOptions? options = null)
            : base("aws:kinesis/analyticsApplication:AnalyticsApplication", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing AnalyticsApplication resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static AnalyticsApplication Get(string name, Input<string> id, AnalyticsApplicationState? state = null, CustomResourceOptions? options = null)
        {
            return new AnalyticsApplication(name, id, state, options);
        }
    }

    public sealed class AnalyticsApplicationArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The CloudWatch log stream options to monitor application errors.
        /// See CloudWatch Logging Options below for more details.
        /// </summary>
        [Input("cloudwatchLoggingOptions")]
        public Input<Inputs.AnalyticsApplicationCloudwatchLoggingOptionsArgs>? CloudwatchLoggingOptions { get; set; }

        /// <summary>
        /// SQL Code to transform input data, and generate output.
        /// </summary>
        [Input("code")]
        public Input<string>? Code { get; set; }

        /// <summary>
        /// Description of the application.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// Input configuration of the application. See Inputs below for more details.
        /// </summary>
        [Input("inputs")]
        public Input<Inputs.AnalyticsApplicationInputsArgs>? Inputs { get; set; }

        /// <summary>
        /// Name of the Kinesis Analytics Application.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("outputs")]
        private InputList<Inputs.AnalyticsApplicationOutputArgs>? _outputs;

        /// <summary>
        /// Output destination configuration of the application. See Outputs below for more details.
        /// </summary>
        public InputList<Inputs.AnalyticsApplicationOutputArgs> Outputs
        {
            get => _outputs ?? (_outputs = new InputList<Inputs.AnalyticsApplicationOutputArgs>());
            set => _outputs = value;
        }

        /// <summary>
        /// An S3 Reference Data Source for the application.
        /// See Reference Data Sources below for more details.
        /// </summary>
        [Input("referenceDataSources")]
        public Input<Inputs.AnalyticsApplicationReferenceDataSourcesArgs>? ReferenceDataSources { get; set; }

        [Input("tags")]
        private InputMap<object>? _tags;

        /// <summary>
        /// Key-value mapping of tags for the Kinesis Analytics Application.
        /// </summary>
        public InputMap<object> Tags
        {
            get => _tags ?? (_tags = new InputMap<object>());
            set => _tags = value;
        }

        public AnalyticsApplicationArgs()
        {
        }
    }

    public sealed class AnalyticsApplicationState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The ARN of the Kinesis Analytics Appliation.
        /// </summary>
        [Input("arn")]
        public Input<string>? Arn { get; set; }

        /// <summary>
        /// The CloudWatch log stream options to monitor application errors.
        /// See CloudWatch Logging Options below for more details.
        /// </summary>
        [Input("cloudwatchLoggingOptions")]
        public Input<Inputs.AnalyticsApplicationCloudwatchLoggingOptionsGetArgs>? CloudwatchLoggingOptions { get; set; }

        /// <summary>
        /// SQL Code to transform input data, and generate output.
        /// </summary>
        [Input("code")]
        public Input<string>? Code { get; set; }

        /// <summary>
        /// The Timestamp when the application version was created.
        /// </summary>
        [Input("createTimestamp")]
        public Input<string>? CreateTimestamp { get; set; }

        /// <summary>
        /// Description of the application.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// Input configuration of the application. See Inputs below for more details.
        /// </summary>
        [Input("inputs")]
        public Input<Inputs.AnalyticsApplicationInputsGetArgs>? Inputs { get; set; }

        /// <summary>
        /// The Timestamp when the application was last updated.
        /// </summary>
        [Input("lastUpdateTimestamp")]
        public Input<string>? LastUpdateTimestamp { get; set; }

        /// <summary>
        /// Name of the Kinesis Analytics Application.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("outputs")]
        private InputList<Inputs.AnalyticsApplicationOutputGetArgs>? _outputs;

        /// <summary>
        /// Output destination configuration of the application. See Outputs below for more details.
        /// </summary>
        public InputList<Inputs.AnalyticsApplicationOutputGetArgs> Outputs
        {
            get => _outputs ?? (_outputs = new InputList<Inputs.AnalyticsApplicationOutputGetArgs>());
            set => _outputs = value;
        }

        /// <summary>
        /// An S3 Reference Data Source for the application.
        /// See Reference Data Sources below for more details.
        /// </summary>
        [Input("referenceDataSources")]
        public Input<Inputs.AnalyticsApplicationReferenceDataSourcesGetArgs>? ReferenceDataSources { get; set; }

        /// <summary>
        /// The Status of the application.
        /// </summary>
        [Input("status")]
        public Input<string>? Status { get; set; }

        [Input("tags")]
        private InputMap<object>? _tags;

        /// <summary>
        /// Key-value mapping of tags for the Kinesis Analytics Application.
        /// </summary>
        public InputMap<object> Tags
        {
            get => _tags ?? (_tags = new InputMap<object>());
            set => _tags = value;
        }

        /// <summary>
        /// The Version of the application.
        /// </summary>
        [Input("version")]
        public Input<int>? Version { get; set; }

        public AnalyticsApplicationState()
        {
        }
    }
}
