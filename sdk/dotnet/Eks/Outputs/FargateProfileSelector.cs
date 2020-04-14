// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Eks.Outputs
{

    [OutputType]
    public sealed class FargateProfileSelector
    {
        /// <summary>
        /// Key-value mapping of Kubernetes labels for selection.
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Labels;
        /// <summary>
        /// Kubernetes namespace for selection.
        /// </summary>
        public readonly string Namespace;

        [OutputConstructor]
        private FargateProfileSelector(
            ImmutableDictionary<string, string>? labels,

            string @namespace)
        {
            Labels = labels;
            Namespace = @namespace;
        }
    }
}
