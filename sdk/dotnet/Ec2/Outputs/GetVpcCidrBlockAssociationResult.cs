// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Ec2.Outputs
{

    [OutputType]
    public sealed class GetVpcCidrBlockAssociationResult
    {
        /// <summary>
        /// The association ID for the the IPv4 CIDR block.
        /// </summary>
        public readonly string AssociationId;
        /// <summary>
        /// The cidr block of the desired VPC.
        /// </summary>
        public readonly string CidrBlock;
        /// <summary>
        /// The current state of the desired VPC.
        /// Can be either `"pending"` or `"available"`.
        /// </summary>
        public readonly string State;

        [OutputConstructor]
        private GetVpcCidrBlockAssociationResult(
            string associationId,

            string cidrBlock,

            string state)
        {
            AssociationId = associationId;
            CidrBlock = cidrBlock;
            State = state;
        }
    }
}
