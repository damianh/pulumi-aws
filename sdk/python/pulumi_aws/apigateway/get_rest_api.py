# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import json
import warnings
import pulumi
import pulumi.runtime
from .. import utilities, tables

class GetRestApiResult:
    """
    A collection of values returned by getRestApi.
    """
    def __init__(__self__, name=None, root_resource_id=None, id=None):
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        __self__.name = name
        if root_resource_id and not isinstance(root_resource_id, str):
            raise TypeError("Expected argument 'root_resource_id' to be a str")
        __self__.root_resource_id = root_resource_id
        """
        Set to the ID of the API Gateway Resource on the found REST API where the route matches '/'.
        """
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        __self__.id = id
        """
        id is the provider-assigned unique ID for this managed resource.
        """

async def get_rest_api(name=None,opts=None):
    """
    Use this data source to get the id and root_resource_id of a REST API in
    API Gateway. To fetch the REST API you must provide a name to match against. 
    As there is no unique name constraint on REST APIs this data source will 
    error if there is more than one match.
    """
    __args__ = dict()

    __args__['name'] = name
    if opts is None:
        opts = pulumi.ResourceOptions()
    if opts.version is None:
        opts.version = utilities.get_version()
    __ret__ = await pulumi.runtime.invoke('aws:apigateway/getRestApi:getRestApi', __args__, opts=opts)

    return GetRestApiResult(
        name=__ret__.get('name'),
        root_resource_id=__ret__.get('rootResourceId'),
        id=__ret__.get('id'))
