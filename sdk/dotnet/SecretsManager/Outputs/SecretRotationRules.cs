// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.SecretsManager.Outputs
{

    [OutputType]
    public sealed class SecretRotationRules
    {
        /// <summary>
        /// Specifies the number of days between automatic scheduled rotations of the secret.
        /// </summary>
        public readonly int AutomaticallyAfterDays;

        [OutputConstructor]
        private SecretRotationRules(int automaticallyAfterDays)
        {
            AutomaticallyAfterDays = automaticallyAfterDays;
        }
    }
}
