// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Ec2
{
    /// <summary>
    /// Provides an AWS EBS Volume Attachment as a top level resource, to attach and
    /// detach volumes from AWS Instances.
    /// 
    /// &gt; **NOTE on EBS block devices:** If you use `ebs_block_device` on an `aws.ec2.Instance`, this provider will assume management over the full set of non-root EBS block devices for the instance, and treats additional block devices as drift. For this reason, `ebs_block_device` cannot be mixed with external `aws.ebs.Volume` + `aws_ebs_volume_attachment` resources for a given instance.
    /// </summary>
    public partial class VolumeAttachment : Pulumi.CustomResource
    {
        /// <summary>
        /// The device name to expose to the instance (for
        /// example, `/dev/sdh` or `xvdh`).  See [Device Naming on Linux Instances][1] and [Device Naming on Windows Instances][2] for more information.
        /// </summary>
        [Output("deviceName")]
        public Output<string> DeviceName { get; private set; } = null!;

        /// <summary>
        /// Set to `true` if you want to force the
        /// volume to detach. Useful if previous attempts failed, but use this option only
        /// as a last resort, as this can result in **data loss**. See
        /// [Detaching an Amazon EBS Volume from an Instance][3] for more information.
        /// </summary>
        [Output("forceDetach")]
        public Output<bool?> ForceDetach { get; private set; } = null!;

        /// <summary>
        /// ID of the Instance to attach to
        /// </summary>
        [Output("instanceId")]
        public Output<string> InstanceId { get; private set; } = null!;

        /// <summary>
        /// Set this to true if you do not wish
        /// to detach the volume from the instance to which it is attached at destroy
        /// time, and instead just remove the attachment from this provider state. This is
        /// useful when destroying an instance which has volumes created by some other
        /// means attached.
        /// </summary>
        [Output("skipDestroy")]
        public Output<bool?> SkipDestroy { get; private set; } = null!;

        /// <summary>
        /// ID of the Volume to be attached
        /// </summary>
        [Output("volumeId")]
        public Output<string> VolumeId { get; private set; } = null!;


        /// <summary>
        /// Create a VolumeAttachment resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public VolumeAttachment(string name, VolumeAttachmentArgs args, CustomResourceOptions? options = null)
            : base("aws:ec2/volumeAttachment:VolumeAttachment", name, args ?? new VolumeAttachmentArgs(), MakeResourceOptions(options, ""))
        {
        }

        private VolumeAttachment(string name, Input<string> id, VolumeAttachmentState? state = null, CustomResourceOptions? options = null)
            : base("aws:ec2/volumeAttachment:VolumeAttachment", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing VolumeAttachment resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static VolumeAttachment Get(string name, Input<string> id, VolumeAttachmentState? state = null, CustomResourceOptions? options = null)
        {
            return new VolumeAttachment(name, id, state, options);
        }
    }

    public sealed class VolumeAttachmentArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The device name to expose to the instance (for
        /// example, `/dev/sdh` or `xvdh`).  See [Device Naming on Linux Instances][1] and [Device Naming on Windows Instances][2] for more information.
        /// </summary>
        [Input("deviceName", required: true)]
        public Input<string> DeviceName { get; set; } = null!;

        /// <summary>
        /// Set to `true` if you want to force the
        /// volume to detach. Useful if previous attempts failed, but use this option only
        /// as a last resort, as this can result in **data loss**. See
        /// [Detaching an Amazon EBS Volume from an Instance][3] for more information.
        /// </summary>
        [Input("forceDetach")]
        public Input<bool>? ForceDetach { get; set; }

        /// <summary>
        /// ID of the Instance to attach to
        /// </summary>
        [Input("instanceId", required: true)]
        public Input<string> InstanceId { get; set; } = null!;

        /// <summary>
        /// Set this to true if you do not wish
        /// to detach the volume from the instance to which it is attached at destroy
        /// time, and instead just remove the attachment from this provider state. This is
        /// useful when destroying an instance which has volumes created by some other
        /// means attached.
        /// </summary>
        [Input("skipDestroy")]
        public Input<bool>? SkipDestroy { get; set; }

        /// <summary>
        /// ID of the Volume to be attached
        /// </summary>
        [Input("volumeId", required: true)]
        public Input<string> VolumeId { get; set; } = null!;

        public VolumeAttachmentArgs()
        {
        }
    }

    public sealed class VolumeAttachmentState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The device name to expose to the instance (for
        /// example, `/dev/sdh` or `xvdh`).  See [Device Naming on Linux Instances][1] and [Device Naming on Windows Instances][2] for more information.
        /// </summary>
        [Input("deviceName")]
        public Input<string>? DeviceName { get; set; }

        /// <summary>
        /// Set to `true` if you want to force the
        /// volume to detach. Useful if previous attempts failed, but use this option only
        /// as a last resort, as this can result in **data loss**. See
        /// [Detaching an Amazon EBS Volume from an Instance][3] for more information.
        /// </summary>
        [Input("forceDetach")]
        public Input<bool>? ForceDetach { get; set; }

        /// <summary>
        /// ID of the Instance to attach to
        /// </summary>
        [Input("instanceId")]
        public Input<string>? InstanceId { get; set; }

        /// <summary>
        /// Set this to true if you do not wish
        /// to detach the volume from the instance to which it is attached at destroy
        /// time, and instead just remove the attachment from this provider state. This is
        /// useful when destroying an instance which has volumes created by some other
        /// means attached.
        /// </summary>
        [Input("skipDestroy")]
        public Input<bool>? SkipDestroy { get; set; }

        /// <summary>
        /// ID of the Volume to be attached
        /// </summary>
        [Input("volumeId")]
        public Input<string>? VolumeId { get; set; }

        public VolumeAttachmentState()
        {
        }
    }
}
