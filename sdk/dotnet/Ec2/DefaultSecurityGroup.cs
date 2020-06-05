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
    /// Provides a resource to manage the default AWS Security Group.
    /// 
    /// For EC2 Classic accounts, each region comes with a Default Security Group.
    /// Additionally, each VPC created in AWS comes with a Default Security Group that can be managed, but not
    /// destroyed. **This is an advanced resource**, and has special caveats to be aware
    /// of when using it. Please read this document in its entirety before using this
    /// resource.
    /// 
    /// The `aws.ec2.DefaultSecurityGroup` behaves differently from normal resources, in that
    /// this provider does not _create_ this resource, but instead "adopts" it
    /// into management. We can do this because these default security groups cannot be
    /// destroyed, and are created with a known set of default ingress/egress rules.
    /// 
    /// When this provider first adopts the Default Security Group, it **immediately removes all
    /// ingress and egress rules in the Security Group**. It then proceeds to create any rules specified in the
    /// configuration. This step is required so that only the rules specified in the
    /// configuration are created.
    /// 
    /// This resource treats its inline rules as absolute; only the rules defined
    /// inline are created, and any additions/removals external to this resource will
    /// result in diff shown. For these reasons, this resource is incompatible with the
    /// `aws.ec2.SecurityGroupRule` resource.
    /// 
    /// For more information about Default Security Groups, see the AWS Documentation on
    /// [Default Security Groups][aws-default-security-groups].
    /// 
    /// ## Basic Example Usage, with default rules
    /// 
    /// The following config gives the Default Security Group the same rules that AWS
    /// provides by default, but pulls the resource under management by this provider. This means that
    /// any ingress or egress rules added or changed will be detected as drift.
    /// 
    /// ```csharp
    /// using Pulumi;
    /// using Aws = Pulumi.Aws;
    /// 
    /// class MyStack : Stack
    /// {
    ///     public MyStack()
    ///     {
    ///         var mainvpc = new Aws.Ec2.Vpc("mainvpc", new Aws.Ec2.VpcArgs
    ///         {
    ///             CidrBlock = "10.1.0.0/16",
    ///         });
    ///         var @default = new Aws.Ec2.DefaultSecurityGroup("default", new Aws.Ec2.DefaultSecurityGroupArgs
    ///         {
    ///             Egress = 
    ///             {
    ///                 new Aws.Ec2.Inputs.DefaultSecurityGroupEgressArgs
    ///                 {
    ///                     CidrBlocks = 
    ///                     {
    ///                         "0.0.0.0/0",
    ///                     },
    ///                     FromPort = 0,
    ///                     Protocol = "-1",
    ///                     ToPort = 0,
    ///                 },
    ///             },
    ///             Ingress = 
    ///             {
    ///                 new Aws.Ec2.Inputs.DefaultSecurityGroupIngressArgs
    ///                 {
    ///                     FromPort = 0,
    ///                     Protocol = -1,
    ///                     Self = true,
    ///                     ToPort = 0,
    ///                 },
    ///             },
    ///             VpcId = mainvpc.Id,
    ///         });
    ///     }
    /// 
    /// }
    /// ```
    /// 
    /// ## Example config to deny all Egress traffic, allowing Ingress
    /// 
    /// The following denies all Egress traffic by omitting any `egress` rules, while
    /// including the default `ingress` rule to allow all traffic.
    /// 
    /// ```csharp
    /// using Pulumi;
    /// using Aws = Pulumi.Aws;
    /// 
    /// class MyStack : Stack
    /// {
    ///     public MyStack()
    ///     {
    ///         var mainvpc = new Aws.Ec2.Vpc("mainvpc", new Aws.Ec2.VpcArgs
    ///         {
    ///             CidrBlock = "10.1.0.0/16",
    ///         });
    ///         var @default = new Aws.Ec2.DefaultSecurityGroup("default", new Aws.Ec2.DefaultSecurityGroupArgs
    ///         {
    ///             Ingress = 
    ///             {
    ///                 new Aws.Ec2.Inputs.DefaultSecurityGroupIngressArgs
    ///                 {
    ///                     FromPort = 0,
    ///                     Protocol = -1,
    ///                     Self = true,
    ///                     ToPort = 0,
    ///                 },
    ///             },
    ///             VpcId = mainvpc.Id,
    ///         });
    ///     }
    /// 
    /// }
    /// ```
    /// 
    /// ## Usage
    /// 
    /// With the exceptions mentioned above, `aws.ec2.DefaultSecurityGroup` should
    /// identical behavior to `aws.ec2.SecurityGroup`. Please consult `AWS_SECURITY_GROUP`
    /// for further usage documentation.
    /// 
    /// ### Removing `aws.ec2.DefaultSecurityGroup` from your configuration
    /// 
    /// Each AWS VPC (or region, if using EC2 Classic) comes with a Default Security
    /// Group that cannot be deleted. The `aws.ec2.DefaultSecurityGroup` allows you to
    /// manage this Security Group, but this provider cannot destroy it. Removing this resource
    /// from your configuration will remove it from your statefile and management, but
    /// will not destroy the Security Group. All ingress or egress rules will be left as
    /// they are at the time of removal. You can resume managing them via the AWS Console.
    /// </summary>
    public partial class DefaultSecurityGroup : Pulumi.CustomResource
    {
        [Output("arn")]
        public Output<string> Arn { get; private set; } = null!;

        /// <summary>
        /// The description of the security group
        /// </summary>
        [Output("description")]
        public Output<string> Description { get; private set; } = null!;

        /// <summary>
        /// Can be specified multiple times for each
        /// egress rule. Each egress block supports fields documented below.
        /// </summary>
        [Output("egress")]
        public Output<ImmutableArray<Outputs.DefaultSecurityGroupEgress>> Egress { get; private set; } = null!;

        /// <summary>
        /// Can be specified multiple times for each
        /// ingress rule. Each ingress block supports fields documented below.
        /// </summary>
        [Output("ingress")]
        public Output<ImmutableArray<Outputs.DefaultSecurityGroupIngress>> Ingress { get; private set; } = null!;

        /// <summary>
        /// The name of the security group
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// The owner ID.
        /// </summary>
        [Output("ownerId")]
        public Output<string> OwnerId { get; private set; } = null!;

        [Output("revokeRulesOnDelete")]
        public Output<bool?> RevokeRulesOnDelete { get; private set; } = null!;

        /// <summary>
        /// A map of tags to assign to the resource.
        /// </summary>
        [Output("tags")]
        public Output<ImmutableDictionary<string, object>?> Tags { get; private set; } = null!;

        /// <summary>
        /// The VPC ID. **Note that changing
        /// the `vpc_id` will _not_ restore any default security group rules that were
        /// modified, added, or removed.** It will be left in its current state
        /// </summary>
        [Output("vpcId")]
        public Output<string> VpcId { get; private set; } = null!;


        /// <summary>
        /// Create a DefaultSecurityGroup resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public DefaultSecurityGroup(string name, DefaultSecurityGroupArgs? args = null, CustomResourceOptions? options = null)
            : base("aws:ec2/defaultSecurityGroup:DefaultSecurityGroup", name, args ?? new DefaultSecurityGroupArgs(), MakeResourceOptions(options, ""))
        {
        }

        private DefaultSecurityGroup(string name, Input<string> id, DefaultSecurityGroupState? state = null, CustomResourceOptions? options = null)
            : base("aws:ec2/defaultSecurityGroup:DefaultSecurityGroup", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing DefaultSecurityGroup resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static DefaultSecurityGroup Get(string name, Input<string> id, DefaultSecurityGroupState? state = null, CustomResourceOptions? options = null)
        {
            return new DefaultSecurityGroup(name, id, state, options);
        }
    }

    public sealed class DefaultSecurityGroupArgs : Pulumi.ResourceArgs
    {
        [Input("egress")]
        private InputList<Inputs.DefaultSecurityGroupEgressArgs>? _egress;

        /// <summary>
        /// Can be specified multiple times for each
        /// egress rule. Each egress block supports fields documented below.
        /// </summary>
        public InputList<Inputs.DefaultSecurityGroupEgressArgs> Egress
        {
            get => _egress ?? (_egress = new InputList<Inputs.DefaultSecurityGroupEgressArgs>());
            set => _egress = value;
        }

        [Input("ingress")]
        private InputList<Inputs.DefaultSecurityGroupIngressArgs>? _ingress;

        /// <summary>
        /// Can be specified multiple times for each
        /// ingress rule. Each ingress block supports fields documented below.
        /// </summary>
        public InputList<Inputs.DefaultSecurityGroupIngressArgs> Ingress
        {
            get => _ingress ?? (_ingress = new InputList<Inputs.DefaultSecurityGroupIngressArgs>());
            set => _ingress = value;
        }

        [Input("revokeRulesOnDelete")]
        public Input<bool>? RevokeRulesOnDelete { get; set; }

        [Input("tags")]
        private InputMap<object>? _tags;

        /// <summary>
        /// A map of tags to assign to the resource.
        /// </summary>
        public InputMap<object> Tags
        {
            get => _tags ?? (_tags = new InputMap<object>());
            set => _tags = value;
        }

        /// <summary>
        /// The VPC ID. **Note that changing
        /// the `vpc_id` will _not_ restore any default security group rules that were
        /// modified, added, or removed.** It will be left in its current state
        /// </summary>
        [Input("vpcId")]
        public Input<string>? VpcId { get; set; }

        public DefaultSecurityGroupArgs()
        {
        }
    }

    public sealed class DefaultSecurityGroupState : Pulumi.ResourceArgs
    {
        [Input("arn")]
        public Input<string>? Arn { get; set; }

        /// <summary>
        /// The description of the security group
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        [Input("egress")]
        private InputList<Inputs.DefaultSecurityGroupEgressGetArgs>? _egress;

        /// <summary>
        /// Can be specified multiple times for each
        /// egress rule. Each egress block supports fields documented below.
        /// </summary>
        public InputList<Inputs.DefaultSecurityGroupEgressGetArgs> Egress
        {
            get => _egress ?? (_egress = new InputList<Inputs.DefaultSecurityGroupEgressGetArgs>());
            set => _egress = value;
        }

        [Input("ingress")]
        private InputList<Inputs.DefaultSecurityGroupIngressGetArgs>? _ingress;

        /// <summary>
        /// Can be specified multiple times for each
        /// ingress rule. Each ingress block supports fields documented below.
        /// </summary>
        public InputList<Inputs.DefaultSecurityGroupIngressGetArgs> Ingress
        {
            get => _ingress ?? (_ingress = new InputList<Inputs.DefaultSecurityGroupIngressGetArgs>());
            set => _ingress = value;
        }

        /// <summary>
        /// The name of the security group
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The owner ID.
        /// </summary>
        [Input("ownerId")]
        public Input<string>? OwnerId { get; set; }

        [Input("revokeRulesOnDelete")]
        public Input<bool>? RevokeRulesOnDelete { get; set; }

        [Input("tags")]
        private InputMap<object>? _tags;

        /// <summary>
        /// A map of tags to assign to the resource.
        /// </summary>
        public InputMap<object> Tags
        {
            get => _tags ?? (_tags = new InputMap<object>());
            set => _tags = value;
        }

        /// <summary>
        /// The VPC ID. **Note that changing
        /// the `vpc_id` will _not_ restore any default security group rules that were
        /// modified, added, or removed.** It will be left in its current state
        /// </summary>
        [Input("vpcId")]
        public Input<string>? VpcId { get; set; }

        public DefaultSecurityGroupState()
        {
        }
    }
}
