// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.AppSync.Inputs
{

    public sealed class GraphQLApiAdditionalAuthenticationProviderUserPoolConfigGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// A regular expression for validating the incoming Amazon Cognito User Pool app client ID.
        /// </summary>
        [Input("appIdClientRegex")]
        public Input<string>? AppIdClientRegex { get; set; }

        /// <summary>
        /// The AWS region in which the user pool was created.
        /// </summary>
        [Input("awsRegion")]
        public Input<string>? AwsRegion { get; set; }

        /// <summary>
        /// The user pool ID.
        /// </summary>
        [Input("userPoolId", required: true)]
        public Input<string> UserPoolId { get; set; } = null!;

        public GraphQLApiAdditionalAuthenticationProviderUserPoolConfigGetArgs()
        {
        }
    }
}
