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
    public sealed class GetLaunchConfigurationEbsBlockDeviceResult
    {
        /// <summary>
        /// Whether the EBS Volume will be deleted on instance termination.
        /// </summary>
        public readonly bool DeleteOnTermination;
        /// <summary>
        /// The Name of the device.
        /// </summary>
        public readonly string DeviceName;
        /// <summary>
        /// Whether the volume is Encrypted.
        /// </summary>
        public readonly bool Encrypted;
        /// <summary>
        /// The provisioned IOPs of the volume.
        /// </summary>
        public readonly int Iops;
        /// <summary>
        /// The Snapshot ID of the mount.
        /// </summary>
        public readonly string SnapshotId;
        /// <summary>
        /// The Size of the volume.
        /// </summary>
        public readonly int VolumeSize;
        /// <summary>
        /// The Type of the volume.
        /// </summary>
        public readonly string VolumeType;

        [OutputConstructor]
        private GetLaunchConfigurationEbsBlockDeviceResult(
            bool deleteOnTermination,

            string deviceName,

            bool encrypted,

            int iops,

            string snapshotId,

            int volumeSize,

            string volumeType)
        {
            DeleteOnTermination = deleteOnTermination;
            DeviceName = deviceName;
            Encrypted = encrypted;
            Iops = iops;
            SnapshotId = snapshotId;
            VolumeSize = volumeSize;
            VolumeType = volumeType;
        }
    }
}
