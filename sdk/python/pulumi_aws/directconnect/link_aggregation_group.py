# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import json
import warnings
import pulumi
import pulumi.runtime
from typing import Union
from .. import utilities, tables

class LinkAggregationGroup(pulumi.CustomResource):
    arn: pulumi.Output[str]
    """
    The ARN of the LAG.
    * `jumbo_frame_capable` -Indicates whether jumbo frames (9001 MTU) are supported.
    """
    connections_bandwidth: pulumi.Output[str]
    """
    The bandwidth of the individual physical connections bundled by the LAG. Valid values: 50Mbps, 100Mbps, 200Mbps, 300Mbps, 400Mbps, 500Mbps, 1Gbps, 2Gbps, 5Gbps and 10Gbps. Case sensitive.
    """
    force_destroy: pulumi.Output[bool]
    """
    A boolean that indicates all connections associated with the LAG should be deleted so that the LAG can be destroyed without error. These objects are *not* recoverable.
    """
    has_logical_redundancy: pulumi.Output[str]
    """
    Indicates whether the LAG supports a secondary BGP peer in the same address family (IPv4/IPv6).
    """
    jumbo_frame_capable: pulumi.Output[bool]
    location: pulumi.Output[str]
    """
    The AWS Direct Connect location in which the LAG should be allocated. See [DescribeLocations](https://docs.aws.amazon.com/directconnect/latest/APIReference/API_DescribeLocations.html) for the list of AWS Direct Connect locations. Use `locationCode`.
    """
    name: pulumi.Output[str]
    """
    The name of the LAG.
    """
    tags: pulumi.Output[dict]
    """
    A map of tags to assign to the resource.
    """
    def __init__(__self__, resource_name, opts=None, connections_bandwidth=None, force_destroy=None, location=None, name=None, tags=None, __props__=None, __name__=None, __opts__=None):
        """
        Provides a Direct Connect LAG. Connections can be added to the LAG via the `directconnect.Connection` and `directconnect.ConnectionAssociation` resources.

        > *NOTE:* When creating a LAG, Direct Connect requires creating a Connection. This provider will remove this unmanaged connection during resource creation.

        ## Example Usage



        ```python
        import pulumi
        import pulumi_aws as aws

        hoge = aws.directconnect.LinkAggregationGroup("hoge",
            connections_bandwidth="1Gbps",
            force_destroy=True,
            location="EqDC2")
        ```


        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] connections_bandwidth: The bandwidth of the individual physical connections bundled by the LAG. Valid values: 50Mbps, 100Mbps, 200Mbps, 300Mbps, 400Mbps, 500Mbps, 1Gbps, 2Gbps, 5Gbps and 10Gbps. Case sensitive.
        :param pulumi.Input[bool] force_destroy: A boolean that indicates all connections associated with the LAG should be deleted so that the LAG can be destroyed without error. These objects are *not* recoverable.
        :param pulumi.Input[str] location: The AWS Direct Connect location in which the LAG should be allocated. See [DescribeLocations](https://docs.aws.amazon.com/directconnect/latest/APIReference/API_DescribeLocations.html) for the list of AWS Direct Connect locations. Use `locationCode`.
        :param pulumi.Input[str] name: The name of the LAG.
        :param pulumi.Input[dict] tags: A map of tags to assign to the resource.
        """
        if __name__ is not None:
            warnings.warn("explicit use of __name__ is deprecated", DeprecationWarning)
            resource_name = __name__
        if __opts__ is not None:
            warnings.warn("explicit use of __opts__ is deprecated, use 'opts' instead", DeprecationWarning)
            opts = __opts__
        if opts is None:
            opts = pulumi.ResourceOptions()
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.version is None:
            opts.version = utilities.get_version()
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = dict()

            if connections_bandwidth is None:
                raise TypeError("Missing required property 'connections_bandwidth'")
            __props__['connections_bandwidth'] = connections_bandwidth
            __props__['force_destroy'] = force_destroy
            if location is None:
                raise TypeError("Missing required property 'location'")
            __props__['location'] = location
            __props__['name'] = name
            __props__['tags'] = tags
            __props__['arn'] = None
            __props__['has_logical_redundancy'] = None
            __props__['jumbo_frame_capable'] = None
        super(LinkAggregationGroup, __self__).__init__(
            'aws:directconnect/linkAggregationGroup:LinkAggregationGroup',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name, id, opts=None, arn=None, connections_bandwidth=None, force_destroy=None, has_logical_redundancy=None, jumbo_frame_capable=None, location=None, name=None, tags=None):
        """
        Get an existing LinkAggregationGroup resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param str id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] arn: The ARN of the LAG.
               * `jumbo_frame_capable` -Indicates whether jumbo frames (9001 MTU) are supported.
        :param pulumi.Input[str] connections_bandwidth: The bandwidth of the individual physical connections bundled by the LAG. Valid values: 50Mbps, 100Mbps, 200Mbps, 300Mbps, 400Mbps, 500Mbps, 1Gbps, 2Gbps, 5Gbps and 10Gbps. Case sensitive.
        :param pulumi.Input[bool] force_destroy: A boolean that indicates all connections associated with the LAG should be deleted so that the LAG can be destroyed without error. These objects are *not* recoverable.
        :param pulumi.Input[str] has_logical_redundancy: Indicates whether the LAG supports a secondary BGP peer in the same address family (IPv4/IPv6).
        :param pulumi.Input[str] location: The AWS Direct Connect location in which the LAG should be allocated. See [DescribeLocations](https://docs.aws.amazon.com/directconnect/latest/APIReference/API_DescribeLocations.html) for the list of AWS Direct Connect locations. Use `locationCode`.
        :param pulumi.Input[str] name: The name of the LAG.
        :param pulumi.Input[dict] tags: A map of tags to assign to the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        __props__["arn"] = arn
        __props__["connections_bandwidth"] = connections_bandwidth
        __props__["force_destroy"] = force_destroy
        __props__["has_logical_redundancy"] = has_logical_redundancy
        __props__["jumbo_frame_capable"] = jumbo_frame_capable
        __props__["location"] = location
        __props__["name"] = name
        __props__["tags"] = tags
        return LinkAggregationGroup(resource_name, opts=opts, __props__=__props__)
    def translate_output_property(self, prop):
        return tables._CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return tables._SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

