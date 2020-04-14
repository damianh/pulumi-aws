// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Pricing
{
    public static class GetProduct
    {
        /// <summary>
        /// Use this data source to get the pricing information of all products in AWS.
        /// This data source is only available in a us-east-1 or ap-south-1 provider.
        /// 
        /// {{% examples %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetProductResult> InvokeAsync(GetProductArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetProductResult>("aws:pricing/getProduct:getProduct", args ?? new GetProductArgs(), options.WithVersion());
    }


    public sealed class GetProductArgs : Pulumi.InvokeArgs
    {
        [Input("filters", required: true)]
        private List<Inputs.GetProductFilterArgs>? _filters;

        /// <summary>
        /// A list of filters. Passed directly to the API (see GetProducts API reference). These filters must describe a single product, this resource will fail if more than one product is returned by the API.
        /// </summary>
        public List<Inputs.GetProductFilterArgs> Filters
        {
            get => _filters ?? (_filters = new List<Inputs.GetProductFilterArgs>());
            set => _filters = value;
        }

        /// <summary>
        /// The code of the service. Available service codes can be fetched using the DescribeServices pricing API call.
        /// </summary>
        [Input("serviceCode", required: true)]
        public string ServiceCode { get; set; } = null!;

        public GetProductArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetProductResult
    {
        public readonly ImmutableArray<Outputs.GetProductFilterResult> Filters;
        /// <summary>
        /// id is the provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// Set to the product returned from the API.
        /// </summary>
        public readonly string Result;
        public readonly string ServiceCode;

        [OutputConstructor]
        private GetProductResult(
            ImmutableArray<Outputs.GetProductFilterResult> filters,

            string id,

            string result,

            string serviceCode)
        {
            Filters = filters;
            Id = id;
            Result = result;
            ServiceCode = serviceCode;
        }
    }
}
