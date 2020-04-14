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
    /// Provides an RDS DB option group resource. Documentation of the available options for various RDS engines can be found at:
    /// 
    /// * [MariaDB Options](https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/Appendix.MariaDB.Options.html)
    /// * [Microsoft SQL Server Options](https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/Appendix.SQLServer.Options.html)
    /// * [MySQL Options](https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/Appendix.MySQL.Options.html)
    /// * [Oracle Options](https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/Appendix.Oracle.Options.html)
    /// </summary>
    public partial class OptionGroup : Pulumi.CustomResource
    {
        /// <summary>
        /// The ARN of the db option group.
        /// </summary>
        [Output("arn")]
        public Output<string> Arn { get; private set; } = null!;

        /// <summary>
        /// Specifies the name of the engine that this option group should be associated with.
        /// </summary>
        [Output("engineName")]
        public Output<string> EngineName { get; private set; } = null!;

        /// <summary>
        /// Specifies the major version of the engine that this option group should be associated with.
        /// </summary>
        [Output("majorEngineVersion")]
        public Output<string> MajorEngineVersion { get; private set; } = null!;

        /// <summary>
        /// The Name of the setting.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// Creates a unique name beginning with the specified prefix. Conflicts with `name`. Must be lowercase, to match as it is stored in AWS.
        /// </summary>
        [Output("namePrefix")]
        public Output<string> NamePrefix { get; private set; } = null!;

        /// <summary>
        /// The description of the option group. Defaults to "Managed by Pulumi".
        /// </summary>
        [Output("optionGroupDescription")]
        public Output<string> OptionGroupDescription { get; private set; } = null!;

        /// <summary>
        /// A list of Options to apply.
        /// </summary>
        [Output("options")]
        public Output<ImmutableArray<Outputs.OptionGroupOption>> Options { get; private set; } = null!;

        /// <summary>
        /// A mapping of tags to assign to the resource.
        /// </summary>
        [Output("tags")]
        public Output<ImmutableDictionary<string, object>?> Tags { get; private set; } = null!;


        /// <summary>
        /// Create a OptionGroup resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public OptionGroup(string name, OptionGroupArgs args, CustomResourceOptions? options = null)
            : base("aws:rds/optionGroup:OptionGroup", name, args ?? new OptionGroupArgs(), MakeResourceOptions(options, ""))
        {
        }

        private OptionGroup(string name, Input<string> id, OptionGroupState? state = null, CustomResourceOptions? options = null)
            : base("aws:rds/optionGroup:OptionGroup", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing OptionGroup resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static OptionGroup Get(string name, Input<string> id, OptionGroupState? state = null, CustomResourceOptions? options = null)
        {
            return new OptionGroup(name, id, state, options);
        }
    }

    public sealed class OptionGroupArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Specifies the name of the engine that this option group should be associated with.
        /// </summary>
        [Input("engineName", required: true)]
        public Input<string> EngineName { get; set; } = null!;

        /// <summary>
        /// Specifies the major version of the engine that this option group should be associated with.
        /// </summary>
        [Input("majorEngineVersion", required: true)]
        public Input<string> MajorEngineVersion { get; set; } = null!;

        /// <summary>
        /// The Name of the setting.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Creates a unique name beginning with the specified prefix. Conflicts with `name`. Must be lowercase, to match as it is stored in AWS.
        /// </summary>
        [Input("namePrefix")]
        public Input<string>? NamePrefix { get; set; }

        /// <summary>
        /// The description of the option group. Defaults to "Managed by Pulumi".
        /// </summary>
        [Input("optionGroupDescription")]
        public Input<string>? OptionGroupDescription { get; set; }

        [Input("options")]
        private InputList<Inputs.OptionGroupOptionArgs>? _options;

        /// <summary>
        /// A list of Options to apply.
        /// </summary>
        public InputList<Inputs.OptionGroupOptionArgs> Options
        {
            get => _options ?? (_options = new InputList<Inputs.OptionGroupOptionArgs>());
            set => _options = value;
        }

        [Input("tags")]
        private InputMap<object>? _tags;

        /// <summary>
        /// A mapping of tags to assign to the resource.
        /// </summary>
        public InputMap<object> Tags
        {
            get => _tags ?? (_tags = new InputMap<object>());
            set => _tags = value;
        }

        public OptionGroupArgs()
        {
            OptionGroupDescription = "Managed by Pulumi";
        }
    }

    public sealed class OptionGroupState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The ARN of the db option group.
        /// </summary>
        [Input("arn")]
        public Input<string>? Arn { get; set; }

        /// <summary>
        /// Specifies the name of the engine that this option group should be associated with.
        /// </summary>
        [Input("engineName")]
        public Input<string>? EngineName { get; set; }

        /// <summary>
        /// Specifies the major version of the engine that this option group should be associated with.
        /// </summary>
        [Input("majorEngineVersion")]
        public Input<string>? MajorEngineVersion { get; set; }

        /// <summary>
        /// The Name of the setting.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Creates a unique name beginning with the specified prefix. Conflicts with `name`. Must be lowercase, to match as it is stored in AWS.
        /// </summary>
        [Input("namePrefix")]
        public Input<string>? NamePrefix { get; set; }

        /// <summary>
        /// The description of the option group. Defaults to "Managed by Pulumi".
        /// </summary>
        [Input("optionGroupDescription")]
        public Input<string>? OptionGroupDescription { get; set; }

        [Input("options")]
        private InputList<Inputs.OptionGroupOptionGetArgs>? _options;

        /// <summary>
        /// A list of Options to apply.
        /// </summary>
        public InputList<Inputs.OptionGroupOptionGetArgs> Options
        {
            get => _options ?? (_options = new InputList<Inputs.OptionGroupOptionGetArgs>());
            set => _options = value;
        }

        [Input("tags")]
        private InputMap<object>? _tags;

        /// <summary>
        /// A mapping of tags to assign to the resource.
        /// </summary>
        public InputMap<object> Tags
        {
            get => _tags ?? (_tags = new InputMap<object>());
            set => _tags = value;
        }

        public OptionGroupState()
        {
            OptionGroupDescription = "Managed by Pulumi";
        }
    }
}
