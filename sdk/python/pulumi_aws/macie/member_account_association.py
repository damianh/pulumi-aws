# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import pulumi
import pulumi.runtime
from .. import utilities, tables

class MemberAccountAssociation(pulumi.CustomResource):
    """
    Associates an AWS account with Amazon Macie as a member account.
    
    > **NOTE:** Before using Amazon Macie for the first time it must be enabled manually. Instructions are [here](https://docs.aws.amazon.com/macie/latest/userguide/macie-setting-up.html#macie-setting-up-enable).
    """
    def __init__(__self__, __name__, __opts__=None, member_account_id=None):
        """Create a MemberAccountAssociation resource with the given unique name, props, and options."""
        if not __name__:
            raise TypeError('Missing resource name argument (for URN creation)')
        if not isinstance(__name__, str):
            raise TypeError('Expected resource name to be a string')
        if __opts__ and not isinstance(__opts__, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')

        __props__ = dict()

        if not member_account_id:
            raise TypeError('Missing required property member_account_id')
        __props__['member_account_id'] = member_account_id

        super(MemberAccountAssociation, __self__).__init__(
            'aws:macie/memberAccountAssociation:MemberAccountAssociation',
            __name__,
            __props__,
            __opts__)


    def translate_output_property(self, prop):
        return tables._CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return tables._SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

