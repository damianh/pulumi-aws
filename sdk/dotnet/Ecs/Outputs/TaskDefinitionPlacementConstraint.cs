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
    public sealed class TaskDefinitionPlacementConstraint
    {
        /// <summary>
        /// Cluster Query Language expression to apply to the constraint.
        /// For more information, see [Cluster Query Language in the Amazon EC2 Container
        /// Service Developer
        /// Guide](http://docs.aws.amazon.com/AmazonECS/latest/developerguide/cluster-query-language.html).
        /// </summary>
        public readonly string? Expression;
        /// <summary>
        /// The proxy type. The default value is `APPMESH`. The only supported value is `APPMESH`.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private TaskDefinitionPlacementConstraint(
            string? expression,

            string type)
        {
            Expression = expression;
            Type = type;
        }
    }
}
