// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.OpsWorks.Outputs
{

    [OutputType]
    public sealed class MysqlLayerEbsVolume
    {
        public readonly bool? Encrypted;
        /// <summary>
        /// For PIOPS volumes, the IOPS per disk.
        /// </summary>
        public readonly int? Iops;
        /// <summary>
        /// The path to mount the EBS volume on the layer's instances.
        /// </summary>
        public readonly string MountPoint;
        /// <summary>
        /// The number of disks to use for the EBS volume.
        /// </summary>
        public readonly int NumberOfDisks;
        /// <summary>
        /// The RAID level to use for the volume.
        /// </summary>
        public readonly string? RaidLevel;
        /// <summary>
        /// The size of the volume in gigabytes.
        /// </summary>
        public readonly int Size;
        /// <summary>
        /// The type of volume to create. This may be `standard` (the default), `io1` or `gp2`.
        /// </summary>
        public readonly string? Type;

        [OutputConstructor]
        private MysqlLayerEbsVolume(
            bool? encrypted,

            int? iops,

            string mountPoint,

            int numberOfDisks,

            string? raidLevel,

            int size,

            string? type)
        {
            Encrypted = encrypted;
            Iops = iops;
            MountPoint = mountPoint;
            NumberOfDisks = numberOfDisks;
            RaidLevel = raidLevel;
            Size = size;
            Type = type;
        }
    }
}
