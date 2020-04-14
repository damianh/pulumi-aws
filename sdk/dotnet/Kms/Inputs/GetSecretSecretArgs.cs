// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Kms.Inputs
{

    public sealed class GetSecretSecretArgs : Pulumi.InvokeArgs
    {
        [Input("context")]
        private Dictionary<string, string>? _context;
        public Dictionary<string, string> Context
        {
            get => _context ?? (_context = new Dictionary<string, string>());
            set => _context = value;
        }

        [Input("grantTokens")]
        private List<string>? _grantTokens;
        public List<string> GrantTokens
        {
            get => _grantTokens ?? (_grantTokens = new List<string>());
            set => _grantTokens = value;
        }

        [Input("name", required: true)]
        public string Name { get; set; } = null!;

        [Input("payload", required: true)]
        public string Payload { get; set; } = null!;

        public GetSecretSecretArgs()
        {
        }
    }
}
