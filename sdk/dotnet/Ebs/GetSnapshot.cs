// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Ebs
{
    public static class GetSnapshot
    {
        /// <summary>
        /// Use this data source to get information about an EBS Snapshot for use when provisioning EBS Volumes
        /// 
        /// {{% examples %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetSnapshotResult> InvokeAsync(GetSnapshotArgs? args = null, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetSnapshotResult>("aws:ebs/getSnapshot:getSnapshot", args ?? new GetSnapshotArgs(), options.WithVersion());
    }


    public sealed class GetSnapshotArgs : Pulumi.InvokeArgs
    {
        [Input("filters")]
        private List<Inputs.GetSnapshotFilterArgs>? _filters;

        /// <summary>
        /// One or more name/value pairs to filter off of. There are
        /// several valid keys, for a full reference, check out
        /// [describe-snapshots in the AWS CLI reference][1].
        /// </summary>
        public List<Inputs.GetSnapshotFilterArgs> Filters
        {
            get => _filters ?? (_filters = new List<Inputs.GetSnapshotFilterArgs>());
            set => _filters = value;
        }

        /// <summary>
        /// If more than one result is returned, use the most recent snapshot.
        /// </summary>
        [Input("mostRecent")]
        public bool? MostRecent { get; set; }

        [Input("owners")]
        private List<string>? _owners;

        /// <summary>
        /// Returns the snapshots owned by the specified owner id. Multiple owners can be specified.
        /// </summary>
        public List<string> Owners
        {
            get => _owners ?? (_owners = new List<string>());
            set => _owners = value;
        }

        [Input("restorableByUserIds")]
        private List<string>? _restorableByUserIds;

        /// <summary>
        /// One or more AWS accounts IDs that can create volumes from the snapshot.
        /// </summary>
        public List<string> RestorableByUserIds
        {
            get => _restorableByUserIds ?? (_restorableByUserIds = new List<string>());
            set => _restorableByUserIds = value;
        }

        [Input("snapshotIds")]
        private List<string>? _snapshotIds;

        /// <summary>
        /// Returns information on a specific snapshot_id.
        /// </summary>
        public List<string> SnapshotIds
        {
            get => _snapshotIds ?? (_snapshotIds = new List<string>());
            set => _snapshotIds = value;
        }

        [Input("tags")]
        private Dictionary<string, object>? _tags;

        /// <summary>
        /// A mapping of tags for the resource.
        /// </summary>
        public Dictionary<string, object> Tags
        {
            get => _tags ?? (_tags = new Dictionary<string, object>());
            set => _tags = value;
        }

        public GetSnapshotArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetSnapshotResult
    {
        /// <summary>
        /// The data encryption key identifier for the snapshot.
        /// </summary>
        public readonly string DataEncryptionKeyId;
        /// <summary>
        /// A description for the snapshot
        /// </summary>
        public readonly string Description;
        /// <summary>
        /// Whether the snapshot is encrypted.
        /// </summary>
        public readonly bool Encrypted;
        public readonly ImmutableArray<Outputs.GetSnapshotFilterResult> Filters;
        /// <summary>
        /// id is the provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// The ARN for the KMS encryption key.
        /// </summary>
        public readonly string KmsKeyId;
        public readonly bool? MostRecent;
        /// <summary>
        /// Value from an Amazon-maintained list (`amazon`, `aws-marketplace`, `microsoft`) of snapshot owners.
        /// </summary>
        public readonly string OwnerAlias;
        /// <summary>
        /// The AWS account ID of the EBS snapshot owner.
        /// </summary>
        public readonly string OwnerId;
        public readonly ImmutableArray<string> Owners;
        public readonly ImmutableArray<string> RestorableByUserIds;
        /// <summary>
        /// The snapshot ID (e.g. snap-59fcb34e).
        /// </summary>
        public readonly string SnapshotId;
        public readonly ImmutableArray<string> SnapshotIds;
        /// <summary>
        /// The snapshot state.
        /// </summary>
        public readonly string State;
        /// <summary>
        /// A mapping of tags for the resource.
        /// </summary>
        public readonly ImmutableDictionary<string, object> Tags;
        /// <summary>
        /// The volume ID (e.g. vol-59fcb34e).
        /// </summary>
        public readonly string VolumeId;
        /// <summary>
        /// The size of the drive in GiBs.
        /// </summary>
        public readonly int VolumeSize;

        [OutputConstructor]
        private GetSnapshotResult(
            string dataEncryptionKeyId,

            string description,

            bool encrypted,

            ImmutableArray<Outputs.GetSnapshotFilterResult> filters,

            string id,

            string kmsKeyId,

            bool? mostRecent,

            string ownerAlias,

            string ownerId,

            ImmutableArray<string> owners,

            ImmutableArray<string> restorableByUserIds,

            string snapshotId,

            ImmutableArray<string> snapshotIds,

            string state,

            ImmutableDictionary<string, object> tags,

            string volumeId,

            int volumeSize)
        {
            DataEncryptionKeyId = dataEncryptionKeyId;
            Description = description;
            Encrypted = encrypted;
            Filters = filters;
            Id = id;
            KmsKeyId = kmsKeyId;
            MostRecent = mostRecent;
            OwnerAlias = ownerAlias;
            OwnerId = ownerId;
            Owners = owners;
            RestorableByUserIds = restorableByUserIds;
            SnapshotId = snapshotId;
            SnapshotIds = snapshotIds;
            State = state;
            Tags = tags;
            VolumeId = volumeId;
            VolumeSize = volumeSize;
        }
    }
}
