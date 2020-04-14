// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Kinesis.Inputs
{

    public sealed class FirehoseDeliveryStreamExtendedS3ConfigurationProcessingConfigurationGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Enables or disables data processing.
        /// </summary>
        [Input("enabled")]
        public Input<bool>? Enabled { get; set; }

        [Input("processors")]
        private InputList<Inputs.FirehoseDeliveryStreamExtendedS3ConfigurationProcessingConfigurationProcessorGetArgs>? _processors;

        /// <summary>
        /// Array of data processors. More details are given below
        /// </summary>
        public InputList<Inputs.FirehoseDeliveryStreamExtendedS3ConfigurationProcessingConfigurationProcessorGetArgs> Processors
        {
            get => _processors ?? (_processors = new InputList<Inputs.FirehoseDeliveryStreamExtendedS3ConfigurationProcessingConfigurationProcessorGetArgs>());
            set => _processors = value;
        }

        public FirehoseDeliveryStreamExtendedS3ConfigurationProcessingConfigurationGetArgs()
        {
        }
    }
}
