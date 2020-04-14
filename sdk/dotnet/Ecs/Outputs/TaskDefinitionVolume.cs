// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Ecs.Outputs
{

    [OutputType]
    public sealed class TaskDefinitionVolume
    {
        /// <summary>
        /// Used to configure a docker volume
        /// </summary>
        public readonly Outputs.TaskDefinitionVolumeDockerVolumeConfiguration? DockerVolumeConfiguration;
        /// <summary>
        /// Used to configure a EFS volume. Can be used only with an EC2 type task.
        /// </summary>
        public readonly Outputs.TaskDefinitionVolumeEfsVolumeConfiguration? EfsVolumeConfiguration;
        /// <summary>
        /// The path on the host container instance that is presented to the container. If not set, ECS will create a nonpersistent data volume that starts empty and is deleted after the task has finished.
        /// </summary>
        public readonly string? HostPath;
        /// <summary>
        /// The name of the volume. This name is referenced in the `sourceVolume`
        /// parameter of container definition in the `mountPoints` section.
        /// </summary>
        public readonly string Name;

        [OutputConstructor]
        private TaskDefinitionVolume(
            Outputs.TaskDefinitionVolumeDockerVolumeConfiguration? dockerVolumeConfiguration,

            Outputs.TaskDefinitionVolumeEfsVolumeConfiguration? efsVolumeConfiguration,

            string? hostPath,

            string name)
        {
            DockerVolumeConfiguration = dockerVolumeConfiguration;
            EfsVolumeConfiguration = efsVolumeConfiguration;
            HostPath = hostPath;
            Name = name;
        }
    }
}
