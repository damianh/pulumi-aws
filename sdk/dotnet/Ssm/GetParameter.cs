// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Ssm
{
    public static class GetParameter
    {
        /// <summary>
        /// Provides an SSM Parameter data source.
        /// 
        /// {{% examples %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetParameterResult> InvokeAsync(GetParameterArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetParameterResult>("aws:ssm/getParameter:getParameter", args ?? new GetParameterArgs(), options.WithVersion());
    }


    public sealed class GetParameterArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the parameter.
        /// </summary>
        [Input("name", required: true)]
        public string Name { get; set; } = null!;

        /// <summary>
        /// Whether to return decrypted `SecureString` value. Defaults to `true`.
        /// </summary>
        [Input("withDecryption")]
        public bool? WithDecryption { get; set; }

        public GetParameterArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetParameterResult
    {
        public readonly string Arn;
        /// <summary>
        /// id is the provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly string Name;
        public readonly string Type;
        public readonly string Value;
        public readonly int Version;
        public readonly bool? WithDecryption;

        [OutputConstructor]
        private GetParameterResult(
            string arn,

            string id,

            string name,

            string type,

            string value,

            int version,

            bool? withDecryption)
        {
            Arn = arn;
            Id = id;
            Name = name;
            Type = type;
            Value = value;
            Version = version;
            WithDecryption = withDecryption;
        }
    }
}
