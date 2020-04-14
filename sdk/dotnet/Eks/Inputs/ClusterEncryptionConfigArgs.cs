// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Eks.Inputs
{

    public sealed class ClusterEncryptionConfigArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Configuration block with provider for encryption. Detailed below.
        /// </summary>
        [Input("provider", required: true)]
        public Input<Inputs.ClusterEncryptionConfigProviderArgs> Provider { get; set; } = null!;

        [Input("resources", required: true)]
        private InputList<string>? _resources;

        /// <summary>
        /// List of strings with resources to be encrypted. Valid values: `secrets`
        /// </summary>
        public InputList<string> Resources
        {
            get => _resources ?? (_resources = new InputList<string>());
            set => _resources = value;
        }

        public ClusterEncryptionConfigArgs()
        {
        }
    }
}
