# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import pulumi
import pulumi.runtime
from .. import utilities, tables

class Fleet(pulumi.CustomResource):
    """
    Provides a Gamelift Fleet resource.
    """
    def __init__(__self__, __name__, __opts__=None, build_id=None, description=None, ec2_inbound_permissions=None, ec2_instance_type=None, metric_groups=None, name=None, new_game_session_protection_policy=None, resource_creation_limit_policy=None, runtime_configuration=None):
        """Create a Fleet resource with the given unique name, props, and options."""
        if not __name__:
            raise TypeError('Missing resource name argument (for URN creation)')
        if not isinstance(__name__, str):
            raise TypeError('Expected resource name to be a string')
        if __opts__ and not isinstance(__opts__, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')

        __props__ = dict()

        if not build_id:
            raise TypeError('Missing required property build_id')
        __props__['build_id'] = build_id

        __props__['description'] = description

        __props__['ec2_inbound_permissions'] = ec2_inbound_permissions

        if not ec2_instance_type:
            raise TypeError('Missing required property ec2_instance_type')
        __props__['ec2_instance_type'] = ec2_instance_type

        __props__['metric_groups'] = metric_groups

        __props__['name'] = name

        __props__['new_game_session_protection_policy'] = new_game_session_protection_policy

        __props__['resource_creation_limit_policy'] = resource_creation_limit_policy

        __props__['runtime_configuration'] = runtime_configuration

        __props__['arn'] = None
        __props__['log_paths'] = None
        __props__['operating_system'] = None

        super(Fleet, __self__).__init__(
            'aws:gamelift/fleet:Fleet',
            __name__,
            __props__,
            __opts__)


    def translate_output_property(self, prop):
        return tables._CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return tables._SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

