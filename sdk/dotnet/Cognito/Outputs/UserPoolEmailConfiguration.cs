// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Cognito.Outputs
{

    [OutputType]
    public sealed class UserPoolEmailConfiguration
    {
        /// <summary>
        /// Instruct Cognito to either use its built-in functional or Amazon SES to send out emails.
        /// </summary>
        public readonly string? EmailSendingAccount;
        /// <summary>
        /// Sender’s email address or sender’s name with their email address (e.g. "john@smith.com" or "John Smith &lt;john@smith.com&gt;")
        /// </summary>
        public readonly string? FromEmailAddress;
        /// <summary>
        /// The REPLY-TO email address.
        /// </summary>
        public readonly string? ReplyToEmailAddress;
        /// <summary>
        /// The ARN of the email source.
        /// </summary>
        public readonly string? SourceArn;

        [OutputConstructor]
        private UserPoolEmailConfiguration(
            string? emailSendingAccount,

            string? fromEmailAddress,

            string? replyToEmailAddress,

            string? sourceArn)
        {
            EmailSendingAccount = emailSendingAccount;
            FromEmailAddress = fromEmailAddress;
            ReplyToEmailAddress = replyToEmailAddress;
            SourceArn = sourceArn;
        }
    }
}
