// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Rds
{
    /// <summary>
    /// Manages a RDS DB Instance association with an IAM Role. Example use cases:
    /// 
    /// * [Amazon RDS Oracle integration with Amazon S3](https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/oracle-s3-integration.html)
    /// * [Importing Amazon S3 Data into an RDS PostgreSQL DB Instance](https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_PostgreSQL.S3Import.html)
    /// 
    /// &gt; To manage the RDS DB Instance IAM Role for [Enhanced Monitoring](https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_Monitoring.OS.html), see the `aws.rds.Instance` resource `monitoring_role_arn` argument instead.
    /// </summary>
    public partial class RoleAssociation : Pulumi.CustomResource
    {
        /// <summary>
        /// DB Instance Identifier to associate with the IAM Role.
        /// </summary>
        [Output("dbInstanceIdentifier")]
        public Output<string> DbInstanceIdentifier { get; private set; } = null!;

        /// <summary>
        /// Name of the feature for association. This can be found in the AWS documentation relevant to the integration or a full list is available in the `SupportedFeatureNames` list returned by [AWS CLI rds describe-db-engine-versions](https://docs.aws.amazon.com/cli/latest/reference/rds/describe-db-engine-versions.html).
        /// </summary>
        [Output("featureName")]
        public Output<string> FeatureName { get; private set; } = null!;

        /// <summary>
        /// Amazon Resource Name (ARN) of the IAM Role to associate with the DB Instance.
        /// </summary>
        [Output("roleArn")]
        public Output<string> RoleArn { get; private set; } = null!;


        /// <summary>
        /// Create a RoleAssociation resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public RoleAssociation(string name, RoleAssociationArgs args, CustomResourceOptions? options = null)
            : base("aws:rds/roleAssociation:RoleAssociation", name, args ?? new RoleAssociationArgs(), MakeResourceOptions(options, ""))
        {
        }

        private RoleAssociation(string name, Input<string> id, RoleAssociationState? state = null, CustomResourceOptions? options = null)
            : base("aws:rds/roleAssociation:RoleAssociation", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing RoleAssociation resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static RoleAssociation Get(string name, Input<string> id, RoleAssociationState? state = null, CustomResourceOptions? options = null)
        {
            return new RoleAssociation(name, id, state, options);
        }
    }

    public sealed class RoleAssociationArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// DB Instance Identifier to associate with the IAM Role.
        /// </summary>
        [Input("dbInstanceIdentifier", required: true)]
        public Input<string> DbInstanceIdentifier { get; set; } = null!;

        /// <summary>
        /// Name of the feature for association. This can be found in the AWS documentation relevant to the integration or a full list is available in the `SupportedFeatureNames` list returned by [AWS CLI rds describe-db-engine-versions](https://docs.aws.amazon.com/cli/latest/reference/rds/describe-db-engine-versions.html).
        /// </summary>
        [Input("featureName", required: true)]
        public Input<string> FeatureName { get; set; } = null!;

        /// <summary>
        /// Amazon Resource Name (ARN) of the IAM Role to associate with the DB Instance.
        /// </summary>
        [Input("roleArn", required: true)]
        public Input<string> RoleArn { get; set; } = null!;

        public RoleAssociationArgs()
        {
        }
    }

    public sealed class RoleAssociationState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// DB Instance Identifier to associate with the IAM Role.
        /// </summary>
        [Input("dbInstanceIdentifier")]
        public Input<string>? DbInstanceIdentifier { get; set; }

        /// <summary>
        /// Name of the feature for association. This can be found in the AWS documentation relevant to the integration or a full list is available in the `SupportedFeatureNames` list returned by [AWS CLI rds describe-db-engine-versions](https://docs.aws.amazon.com/cli/latest/reference/rds/describe-db-engine-versions.html).
        /// </summary>
        [Input("featureName")]
        public Input<string>? FeatureName { get; set; }

        /// <summary>
        /// Amazon Resource Name (ARN) of the IAM Role to associate with the DB Instance.
        /// </summary>
        [Input("roleArn")]
        public Input<string>? RoleArn { get; set; }

        public RoleAssociationState()
        {
        }
    }
}
