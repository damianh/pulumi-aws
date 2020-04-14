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
    /// Provides a Kinesis Firehose Delivery Stream resource. Amazon Kinesis Firehose is a fully managed, elastic service to easily deliver real-time data streams to destinations such as Amazon S3 and Amazon Redshift.
    /// 
    /// For more details, see the [Amazon Kinesis Firehose Documentation][1].
    /// </summary>
    public partial class FirehoseDeliveryStream : Pulumi.CustomResource
    {
        /// <summary>
        /// The Amazon Resource Name (ARN) specifying the Stream
        /// </summary>
        [Output("arn")]
        public Output<string> Arn { get; private set; } = null!;

        /// <summary>
        /// This is the destination to where the data is delivered. The only options are `s3` (Deprecated, use `extended_s3` instead), `extended_s3`, `redshift`, `elasticsearch`, and `splunk`.
        /// </summary>
        [Output("destination")]
        public Output<string> Destination { get; private set; } = null!;

        [Output("destinationId")]
        public Output<string> DestinationId { get; private set; } = null!;

        /// <summary>
        /// Configuration options if elasticsearch is the destination. More details are given below.
        /// </summary>
        [Output("elasticsearchConfiguration")]
        public Output<Outputs.FirehoseDeliveryStreamElasticsearchConfiguration?> ElasticsearchConfiguration { get; private set; } = null!;

        /// <summary>
        /// Enhanced configuration options for the s3 destination. More details are given below.
        /// </summary>
        [Output("extendedS3Configuration")]
        public Output<Outputs.FirehoseDeliveryStreamExtendedS3Configuration?> ExtendedS3Configuration { get; private set; } = null!;

        /// <summary>
        /// Allows the ability to specify the kinesis stream that is used as the source of the firehose delivery stream.
        /// </summary>
        [Output("kinesisSourceConfiguration")]
        public Output<Outputs.FirehoseDeliveryStreamKinesisSourceConfiguration?> KinesisSourceConfiguration { get; private set; } = null!;

        /// <summary>
        /// A name to identify the stream. This is unique to the
        /// AWS account and region the Stream is created in.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// Configuration options if redshift is the destination.
        /// Using `redshift_configuration` requires the user to also specify a
        /// `s3_configuration` block. More details are given below.
        /// </summary>
        [Output("redshiftConfiguration")]
        public Output<Outputs.FirehoseDeliveryStreamRedshiftConfiguration?> RedshiftConfiguration { get; private set; } = null!;

        /// <summary>
        /// Required for non-S3 destinations. For S3 destination, use `extended_s3_configuration` instead. Configuration options for the s3 destination (or the intermediate bucket if the destination
        /// is redshift). More details are given below.
        /// </summary>
        [Output("s3Configuration")]
        public Output<Outputs.FirehoseDeliveryStreamS3Configuration?> S3Configuration { get; private set; } = null!;

        /// <summary>
        /// Encrypt at rest options.
        /// Server-side encryption should not be enabled when a kinesis stream is configured as the source of the firehose delivery stream.
        /// </summary>
        [Output("serverSideEncryption")]
        public Output<Outputs.FirehoseDeliveryStreamServerSideEncryption?> ServerSideEncryption { get; private set; } = null!;

        [Output("splunkConfiguration")]
        public Output<Outputs.FirehoseDeliveryStreamSplunkConfiguration?> SplunkConfiguration { get; private set; } = null!;

        /// <summary>
        /// A mapping of tags to assign to the resource.
        /// </summary>
        [Output("tags")]
        public Output<ImmutableDictionary<string, object>?> Tags { get; private set; } = null!;

        /// <summary>
        /// Specifies the table version for the output data schema. Defaults to `LATEST`.
        /// </summary>
        [Output("versionId")]
        public Output<string> VersionId { get; private set; } = null!;


        /// <summary>
        /// Create a FirehoseDeliveryStream resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public FirehoseDeliveryStream(string name, FirehoseDeliveryStreamArgs args, CustomResourceOptions? options = null)
            : base("aws:kinesis/firehoseDeliveryStream:FirehoseDeliveryStream", name, args ?? new FirehoseDeliveryStreamArgs(), MakeResourceOptions(options, ""))
        {
        }

        private FirehoseDeliveryStream(string name, Input<string> id, FirehoseDeliveryStreamState? state = null, CustomResourceOptions? options = null)
            : base("aws:kinesis/firehoseDeliveryStream:FirehoseDeliveryStream", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing FirehoseDeliveryStream resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static FirehoseDeliveryStream Get(string name, Input<string> id, FirehoseDeliveryStreamState? state = null, CustomResourceOptions? options = null)
        {
            return new FirehoseDeliveryStream(name, id, state, options);
        }
    }

    public sealed class FirehoseDeliveryStreamArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The Amazon Resource Name (ARN) specifying the Stream
        /// </summary>
        [Input("arn")]
        public Input<string>? Arn { get; set; }

        /// <summary>
        /// This is the destination to where the data is delivered. The only options are `s3` (Deprecated, use `extended_s3` instead), `extended_s3`, `redshift`, `elasticsearch`, and `splunk`.
        /// </summary>
        [Input("destination", required: true)]
        public Input<string> Destination { get; set; } = null!;

        [Input("destinationId")]
        public Input<string>? DestinationId { get; set; }

        /// <summary>
        /// Configuration options if elasticsearch is the destination. More details are given below.
        /// </summary>
        [Input("elasticsearchConfiguration")]
        public Input<Inputs.FirehoseDeliveryStreamElasticsearchConfigurationArgs>? ElasticsearchConfiguration { get; set; }

        /// <summary>
        /// Enhanced configuration options for the s3 destination. More details are given below.
        /// </summary>
        [Input("extendedS3Configuration")]
        public Input<Inputs.FirehoseDeliveryStreamExtendedS3ConfigurationArgs>? ExtendedS3Configuration { get; set; }

        /// <summary>
        /// Allows the ability to specify the kinesis stream that is used as the source of the firehose delivery stream.
        /// </summary>
        [Input("kinesisSourceConfiguration")]
        public Input<Inputs.FirehoseDeliveryStreamKinesisSourceConfigurationArgs>? KinesisSourceConfiguration { get; set; }

        /// <summary>
        /// A name to identify the stream. This is unique to the
        /// AWS account and region the Stream is created in.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Configuration options if redshift is the destination.
        /// Using `redshift_configuration` requires the user to also specify a
        /// `s3_configuration` block. More details are given below.
        /// </summary>
        [Input("redshiftConfiguration")]
        public Input<Inputs.FirehoseDeliveryStreamRedshiftConfigurationArgs>? RedshiftConfiguration { get; set; }

        /// <summary>
        /// Required for non-S3 destinations. For S3 destination, use `extended_s3_configuration` instead. Configuration options for the s3 destination (or the intermediate bucket if the destination
        /// is redshift). More details are given below.
        /// </summary>
        [Input("s3Configuration")]
        public Input<Inputs.FirehoseDeliveryStreamS3ConfigurationArgs>? S3Configuration { get; set; }

        /// <summary>
        /// Encrypt at rest options.
        /// Server-side encryption should not be enabled when a kinesis stream is configured as the source of the firehose delivery stream.
        /// </summary>
        [Input("serverSideEncryption")]
        public Input<Inputs.FirehoseDeliveryStreamServerSideEncryptionArgs>? ServerSideEncryption { get; set; }

        [Input("splunkConfiguration")]
        public Input<Inputs.FirehoseDeliveryStreamSplunkConfigurationArgs>? SplunkConfiguration { get; set; }

        [Input("tags")]
        private InputMap<object>? _tags;

        /// <summary>
        /// A mapping of tags to assign to the resource.
        /// </summary>
        public InputMap<object> Tags
        {
            get => _tags ?? (_tags = new InputMap<object>());
            set => _tags = value;
        }

        /// <summary>
        /// Specifies the table version for the output data schema. Defaults to `LATEST`.
        /// </summary>
        [Input("versionId")]
        public Input<string>? VersionId { get; set; }

        public FirehoseDeliveryStreamArgs()
        {
        }
    }

    public sealed class FirehoseDeliveryStreamState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The Amazon Resource Name (ARN) specifying the Stream
        /// </summary>
        [Input("arn")]
        public Input<string>? Arn { get; set; }

        /// <summary>
        /// This is the destination to where the data is delivered. The only options are `s3` (Deprecated, use `extended_s3` instead), `extended_s3`, `redshift`, `elasticsearch`, and `splunk`.
        /// </summary>
        [Input("destination")]
        public Input<string>? Destination { get; set; }

        [Input("destinationId")]
        public Input<string>? DestinationId { get; set; }

        /// <summary>
        /// Configuration options if elasticsearch is the destination. More details are given below.
        /// </summary>
        [Input("elasticsearchConfiguration")]
        public Input<Inputs.FirehoseDeliveryStreamElasticsearchConfigurationGetArgs>? ElasticsearchConfiguration { get; set; }

        /// <summary>
        /// Enhanced configuration options for the s3 destination. More details are given below.
        /// </summary>
        [Input("extendedS3Configuration")]
        public Input<Inputs.FirehoseDeliveryStreamExtendedS3ConfigurationGetArgs>? ExtendedS3Configuration { get; set; }

        /// <summary>
        /// Allows the ability to specify the kinesis stream that is used as the source of the firehose delivery stream.
        /// </summary>
        [Input("kinesisSourceConfiguration")]
        public Input<Inputs.FirehoseDeliveryStreamKinesisSourceConfigurationGetArgs>? KinesisSourceConfiguration { get; set; }

        /// <summary>
        /// A name to identify the stream. This is unique to the
        /// AWS account and region the Stream is created in.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Configuration options if redshift is the destination.
        /// Using `redshift_configuration` requires the user to also specify a
        /// `s3_configuration` block. More details are given below.
        /// </summary>
        [Input("redshiftConfiguration")]
        public Input<Inputs.FirehoseDeliveryStreamRedshiftConfigurationGetArgs>? RedshiftConfiguration { get; set; }

        /// <summary>
        /// Required for non-S3 destinations. For S3 destination, use `extended_s3_configuration` instead. Configuration options for the s3 destination (or the intermediate bucket if the destination
        /// is redshift). More details are given below.
        /// </summary>
        [Input("s3Configuration")]
        public Input<Inputs.FirehoseDeliveryStreamS3ConfigurationGetArgs>? S3Configuration { get; set; }

        /// <summary>
        /// Encrypt at rest options.
        /// Server-side encryption should not be enabled when a kinesis stream is configured as the source of the firehose delivery stream.
        /// </summary>
        [Input("serverSideEncryption")]
        public Input<Inputs.FirehoseDeliveryStreamServerSideEncryptionGetArgs>? ServerSideEncryption { get; set; }

        [Input("splunkConfiguration")]
        public Input<Inputs.FirehoseDeliveryStreamSplunkConfigurationGetArgs>? SplunkConfiguration { get; set; }

        [Input("tags")]
        private InputMap<object>? _tags;

        /// <summary>
        /// A mapping of tags to assign to the resource.
        /// </summary>
        public InputMap<object> Tags
        {
            get => _tags ?? (_tags = new InputMap<object>());
            set => _tags = value;
        }

        /// <summary>
        /// Specifies the table version for the output data schema. Defaults to `LATEST`.
        /// </summary>
        [Input("versionId")]
        public Input<string>? VersionId { get; set; }

        public FirehoseDeliveryStreamState()
        {
        }
    }
}
