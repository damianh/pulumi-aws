# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import pulumi
import pulumi.runtime
from .. import utilities, tables

class Pipeline(pulumi.CustomResource):
    """
    Provides a CodePipeline.
    
    > **NOTE on `aws_codepipeline`:** - the `GITHUB_TOKEN` environment variable must be set if the GitHub provider is specified.
    """
    def __init__(__self__, __name__, __opts__=None, artifact_store=None, name=None, role_arn=None, stages=None):
        """Create a Pipeline resource with the given unique name, props, and options."""
        if not __name__:
            raise TypeError('Missing resource name argument (for URN creation)')
        if not isinstance(__name__, str):
            raise TypeError('Expected resource name to be a string')
        if __opts__ and not isinstance(__opts__, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')

        __props__ = dict()

        if not artifact_store:
            raise TypeError('Missing required property artifact_store')
        __props__['artifact_store'] = artifact_store

        __props__['name'] = name

        if not role_arn:
            raise TypeError('Missing required property role_arn')
        __props__['role_arn'] = role_arn

        if not stages:
            raise TypeError('Missing required property stages')
        __props__['stages'] = stages

        __props__['arn'] = None

        super(Pipeline, __self__).__init__(
            'aws:codepipeline/pipeline:Pipeline',
            __name__,
            __props__,
            __opts__)


    def translate_output_property(self, prop):
        return tables._CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return tables._SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

