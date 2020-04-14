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
    public sealed class GetInstanceRootBlockDeviceResult
    {
        /// <summary>
        /// If the root block device will be deleted on termination.
        /// </summary>
        public readonly bool DeleteOnTermination;
        /// <summary>
        /// If the EBS volume is encrypted.
        /// </summary>
        public readonly bool Encrypted;
        /// <summary>
        /// `0` If the volume is not a provisioned IOPS image, otherwise the supported IOPS count.
        /// </summary>
        public readonly int Iops;
        public readonly string KmsKeyId;
        public readonly string VolumeId;
        /// <summary>
        /// The size of the volume, in GiB.
        /// </summary>
        public readonly int VolumeSize;
        /// <summary>
        /// The type of the volume.
        /// </summary>
        public readonly string VolumeType;

        [OutputConstructor]
        private GetInstanceRootBlockDeviceResult(
            bool deleteOnTermination,

            bool encrypted,

            int iops,

            string kmsKeyId,

            string volumeId,

            int volumeSize,

            string volumeType)
        {
            DeleteOnTermination = deleteOnTermination;
            Encrypted = encrypted;
            Iops = iops;
            KmsKeyId = kmsKeyId;
            VolumeId = volumeId;
            VolumeSize = volumeSize;
            VolumeType = volumeType;
        }
    }
}
