// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws
{
    public static class GetAmiIds
    {
        /// <summary>
        /// Use this data source to get a list of AMI IDs matching the specified criteria.
        /// 
        /// {{% examples %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetAmiIdsResult> InvokeAsync(GetAmiIdsArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetAmiIdsResult>("aws:index/getAmiIds:getAmiIds", args ?? new GetAmiIdsArgs(), options.WithVersion());
    }


    public sealed class GetAmiIdsArgs : Pulumi.InvokeArgs
    {
        [Input("executableUsers")]
        private List<string>? _executableUsers;

        /// <summary>
        /// Limit search to users with *explicit* launch
        /// permission on  the image. Valid items are the numeric account ID or `self`.
        /// </summary>
        public List<string> ExecutableUsers
        {
            get => _executableUsers ?? (_executableUsers = new List<string>());
            set => _executableUsers = value;
        }

        [Input("filters")]
        private List<Inputs.GetAmiIdsFilterArgs>? _filters;

        /// <summary>
        /// One or more name/value pairs to filter off of. There
        /// are several valid keys, for a full reference, check out
        /// [describe-images in the AWS CLI reference][1].
        /// </summary>
        public List<Inputs.GetAmiIdsFilterArgs> Filters
        {
            get => _filters ?? (_filters = new List<Inputs.GetAmiIdsFilterArgs>());
            set => _filters = value;
        }

        /// <summary>
        /// A regex string to apply to the AMI list returned
        /// by AWS. This allows more advanced filtering not supported from the AWS API.
        /// This filtering is done locally on what AWS returns, and could have a performance
        /// impact if the result is large. It is recommended to combine this with other
        /// options to narrow down the list AWS returns.
        /// </summary>
        [Input("nameRegex")]
        public string? NameRegex { get; set; }

        [Input("owners", required: true)]
        private List<string>? _owners;

        /// <summary>
        /// List of AMI owners to limit search. At least 1 value must be specified. Valid values: an AWS account ID, `self` (the current account), or an AWS owner alias (e.g. `amazon`, `aws-marketplace`, `microsoft`).
        /// </summary>
        public List<string> Owners
        {
            get => _owners ?? (_owners = new List<string>());
            set => _owners = value;
        }

        /// <summary>
        /// Used to sort AMIs by creation time.
        /// </summary>
        [Input("sortAscending")]
        public bool? SortAscending { get; set; }

        public GetAmiIdsArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetAmiIdsResult
    {
        public readonly ImmutableArray<string> ExecutableUsers;
        public readonly ImmutableArray<Outputs.GetAmiIdsFilterResult> Filters;
        /// <summary>
        /// id is the provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly ImmutableArray<string> Ids;
        public readonly string? NameRegex;
        public readonly ImmutableArray<string> Owners;
        public readonly bool? SortAscending;

        [OutputConstructor]
        private GetAmiIdsResult(
            ImmutableArray<string> executableUsers,

            ImmutableArray<Outputs.GetAmiIdsFilterResult> filters,

            string id,

            ImmutableArray<string> ids,

            string? nameRegex,

            ImmutableArray<string> owners,

            bool? sortAscending)
        {
            ExecutableUsers = executableUsers;
            Filters = filters;
            Id = id;
            Ids = ids;
            NameRegex = nameRegex;
            Owners = owners;
            SortAscending = sortAscending;
        }
    }
}
