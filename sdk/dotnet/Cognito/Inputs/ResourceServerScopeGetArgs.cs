// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Cognito.Inputs
{

    public sealed class ResourceServerScopeGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The scope description.
        /// </summary>
        [Input("scopeDescription", required: true)]
        public Input<string> ScopeDescription { get; set; } = null!;

        /// <summary>
        /// The scope name.
        /// </summary>
        [Input("scopeName", required: true)]
        public Input<string> ScopeName { get; set; } = null!;

        public ResourceServerScopeGetArgs()
        {
        }
    }
}
