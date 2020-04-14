// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Eks
{
    public static class GetCluster
    {
        /// <summary>
        /// Retrieve information about an EKS Cluster.
        /// 
        /// {{% examples %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetClusterResult> InvokeAsync(GetClusterArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetClusterResult>("aws:eks/getCluster:getCluster", args ?? new GetClusterArgs(), options.WithVersion());
    }


    public sealed class GetClusterArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the cluster
        /// </summary>
        [Input("name", required: true)]
        public string Name { get; set; } = null!;

        [Input("tags")]
        private Dictionary<string, object>? _tags;

        /// <summary>
        /// Key-value mapping of resource tags.
        /// </summary>
        public Dictionary<string, object> Tags
        {
            get => _tags ?? (_tags = new Dictionary<string, object>());
            set => _tags = value;
        }

        public GetClusterArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetClusterResult
    {
        /// <summary>
        /// The Amazon Resource Name (ARN) of the cluster.
        /// </summary>
        public readonly string Arn;
        /// <summary>
        /// Nested attribute containing `certificate-authority-data` for your cluster.
        /// </summary>
        public readonly Outputs.GetClusterCertificateAuthorityResult CertificateAuthority;
        /// <summary>
        /// The Unix epoch time stamp in seconds for when the cluster was created.
        /// </summary>
        public readonly string CreatedAt;
        /// <summary>
        /// The enabled control plane logs.
        /// </summary>
        public readonly ImmutableArray<string> EnabledClusterLogTypes;
        /// <summary>
        /// The endpoint for your Kubernetes API server.
        /// </summary>
        public readonly string Endpoint;
        /// <summary>
        /// id is the provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// Nested attribute containing identity provider information for your cluster. Only available on Kubernetes version 1.13 and 1.14 clusters created or upgraded on or after September 3, 2019. For an example using this information to enable IAM Roles for Service Accounts, see the [`aws.eks.Cluster` resource documentation](https://www.terraform.io/docs/providers/aws/r/eks_cluster.html).
        /// </summary>
        public readonly ImmutableArray<Outputs.GetClusterIdentityResult> Identities;
        public readonly string Name;
        /// <summary>
        /// The platform version for the cluster.
        /// </summary>
        public readonly string PlatformVersion;
        /// <summary>
        /// The Amazon Resource Name (ARN) of the IAM role that provides permissions for the Kubernetes control plane to make calls to AWS API operations on your behalf.
        /// </summary>
        public readonly string RoleArn;
        /// <summary>
        /// The status of the EKS cluster. One of `CREATING`, `ACTIVE`, `DELETING`, `FAILED`.
        /// </summary>
        public readonly string Status;
        /// <summary>
        /// Key-value mapping of resource tags.
        /// </summary>
        public readonly ImmutableDictionary<string, object> Tags;
        /// <summary>
        /// The Kubernetes server version for the cluster.
        /// </summary>
        public readonly string Version;
        /// <summary>
        /// Nested list containing VPC configuration for the cluster.
        /// </summary>
        public readonly Outputs.GetClusterVpcConfigResult VpcConfig;

        [OutputConstructor]
        private GetClusterResult(
            string arn,

            Outputs.GetClusterCertificateAuthorityResult certificateAuthority,

            string createdAt,

            ImmutableArray<string> enabledClusterLogTypes,

            string endpoint,

            string id,

            ImmutableArray<Outputs.GetClusterIdentityResult> identities,

            string name,

            string platformVersion,

            string roleArn,

            string status,

            ImmutableDictionary<string, object> tags,

            string version,

            Outputs.GetClusterVpcConfigResult vpcConfig)
        {
            Arn = arn;
            CertificateAuthority = certificateAuthority;
            CreatedAt = createdAt;
            EnabledClusterLogTypes = enabledClusterLogTypes;
            Endpoint = endpoint;
            Id = id;
            Identities = identities;
            Name = name;
            PlatformVersion = platformVersion;
            RoleArn = roleArn;
            Status = status;
            Tags = tags;
            Version = version;
            VpcConfig = vpcConfig;
        }
    }
}
