// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Ec2.Outputs
{

    [OutputType]
    public sealed class LaunchTemplateCpuOptions
    {
        /// <summary>
        /// The number of CPU cores for the instance.
        /// </summary>
        public readonly int? CoreCount;
        /// <summary>
        /// The number of threads per CPU core. To disable Intel Hyper-Threading Technology for the instance, specify a value of 1.
        /// Otherwise, specify the default value of 2.
        /// </summary>
        public readonly int? ThreadsPerCore;

        [OutputConstructor]
        private LaunchTemplateCpuOptions(
            int? coreCount,

            int? threadsPerCore)
        {
            CoreCount = coreCount;
            ThreadsPerCore = threadsPerCore;
        }
    }
}
