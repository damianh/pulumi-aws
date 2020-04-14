// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Route53
{
    public static class GetDelegationSet
    {
        /// <summary>
        /// `aws.route53.DelegationSet` provides details about a specific Route 53 Delegation Set.
        /// 
        /// This data source allows to find a list of name servers associated with a specific delegation set.
        /// 
        /// {{% examples %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetDelegationSetResult> InvokeAsync(GetDelegationSetArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetDelegationSetResult>("aws:route53/getDelegationSet:getDelegationSet", args ?? new GetDelegationSetArgs(), options.WithVersion());
    }


    public sealed class GetDelegationSetArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The Hosted Zone id of the desired delegation set.
        /// </summary>
        [Input("id", required: true)]
        public string Id { get; set; } = null!;

        public GetDelegationSetArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetDelegationSetResult
    {
        public readonly string CallerReference;
        public readonly string Id;
        public readonly ImmutableArray<string> NameServers;

        [OutputConstructor]
        private GetDelegationSetResult(
            string callerReference,

            string id,

            ImmutableArray<string> nameServers)
        {
            CallerReference = callerReference;
            Id = id;
            NameServers = nameServers;
        }
    }
}
