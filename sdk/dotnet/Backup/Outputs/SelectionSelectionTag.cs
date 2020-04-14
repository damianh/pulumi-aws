// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Backup.Outputs
{

    [OutputType]
    public sealed class SelectionSelectionTag
    {
        /// <summary>
        /// The key in a key-value pair.
        /// </summary>
        public readonly string Key;
        /// <summary>
        /// An operation, such as `StringEquals`, that is applied to a key-value pair used to filter resources in a selection.
        /// </summary>
        public readonly string Type;
        /// <summary>
        /// The value in a key-value pair.
        /// </summary>
        public readonly string Value;

        [OutputConstructor]
        private SelectionSelectionTag(
            string key,

            string type,

            string value)
        {
            Key = key;
            Type = type;
            Value = value;
        }
    }
}
