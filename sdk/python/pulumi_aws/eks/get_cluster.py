# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import json
import warnings
import pulumi
import pulumi.runtime
from typing import Union
from .. import utilities, tables

class GetClusterResult:
    """
    A collection of values returned by getCluster.
    """
    def __init__(__self__, arn=None, certificate_authority=None, created_at=None, enabled_cluster_log_types=None, endpoint=None, id=None, identities=None, name=None, platform_version=None, role_arn=None, status=None, tags=None, version=None, vpc_config=None):
        if arn and not isinstance(arn, str):
            raise TypeError("Expected argument 'arn' to be a str")
        __self__.arn = arn
        """
        The Amazon Resource Name (ARN) of the cluster.
        """
        if certificate_authority and not isinstance(certificate_authority, dict):
            raise TypeError("Expected argument 'certificate_authority' to be a dict")
        __self__.certificate_authority = certificate_authority
        """
        Nested attribute containing `certificate-authority-data` for your cluster.
        """
        if created_at and not isinstance(created_at, str):
            raise TypeError("Expected argument 'created_at' to be a str")
        __self__.created_at = created_at
        """
        The Unix epoch time stamp in seconds for when the cluster was created.
        """
        if enabled_cluster_log_types and not isinstance(enabled_cluster_log_types, list):
            raise TypeError("Expected argument 'enabled_cluster_log_types' to be a list")
        __self__.enabled_cluster_log_types = enabled_cluster_log_types
        """
        The enabled control plane logs.
        """
        if endpoint and not isinstance(endpoint, str):
            raise TypeError("Expected argument 'endpoint' to be a str")
        __self__.endpoint = endpoint
        """
        The endpoint for your Kubernetes API server.
        """
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        __self__.id = id
        """
        The provider-assigned unique ID for this managed resource.
        """
        if identities and not isinstance(identities, list):
            raise TypeError("Expected argument 'identities' to be a list")
        __self__.identities = identities
        """
        Nested attribute containing identity provider information for your cluster. Only available on Kubernetes version 1.13 and 1.14 clusters created or upgraded on or after September 3, 2019. For an example using this information to enable IAM Roles for Service Accounts, see the `eks.Cluster` resource documentation.
        """
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        __self__.name = name
        if platform_version and not isinstance(platform_version, str):
            raise TypeError("Expected argument 'platform_version' to be a str")
        __self__.platform_version = platform_version
        """
        The platform version for the cluster.
        """
        if role_arn and not isinstance(role_arn, str):
            raise TypeError("Expected argument 'role_arn' to be a str")
        __self__.role_arn = role_arn
        """
        The Amazon Resource Name (ARN) of the IAM role that provides permissions for the Kubernetes control plane to make calls to AWS API operations on your behalf.
        """
        if status and not isinstance(status, str):
            raise TypeError("Expected argument 'status' to be a str")
        __self__.status = status
        """
        The status of the EKS cluster. One of `CREATING`, `ACTIVE`, `DELETING`, `FAILED`.
        """
        if tags and not isinstance(tags, dict):
            raise TypeError("Expected argument 'tags' to be a dict")
        __self__.tags = tags
        """
        Key-value map of resource tags.
        """
        if version and not isinstance(version, str):
            raise TypeError("Expected argument 'version' to be a str")
        __self__.version = version
        """
        The Kubernetes server version for the cluster.
        """
        if vpc_config and not isinstance(vpc_config, dict):
            raise TypeError("Expected argument 'vpc_config' to be a dict")
        __self__.vpc_config = vpc_config
        """
        Nested list containing VPC configuration for the cluster.
        """
class AwaitableGetClusterResult(GetClusterResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetClusterResult(
            arn=self.arn,
            certificate_authority=self.certificate_authority,
            created_at=self.created_at,
            enabled_cluster_log_types=self.enabled_cluster_log_types,
            endpoint=self.endpoint,
            id=self.id,
            identities=self.identities,
            name=self.name,
            platform_version=self.platform_version,
            role_arn=self.role_arn,
            status=self.status,
            tags=self.tags,
            version=self.version,
            vpc_config=self.vpc_config)

def get_cluster(name=None,tags=None,opts=None):
    """
    Retrieve information about an EKS Cluster.




    :param str name: The name of the cluster
    :param dict tags: Key-value map of resource tags.
    """
    __args__ = dict()


    __args__['name'] = name
    __args__['tags'] = tags
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = utilities.get_version()
    __ret__ = pulumi.runtime.invoke('aws:eks/getCluster:getCluster', __args__, opts=opts).value

    return AwaitableGetClusterResult(
        arn=__ret__.get('arn'),
        certificate_authority=__ret__.get('certificateAuthority'),
        created_at=__ret__.get('createdAt'),
        enabled_cluster_log_types=__ret__.get('enabledClusterLogTypes'),
        endpoint=__ret__.get('endpoint'),
        id=__ret__.get('id'),
        identities=__ret__.get('identities'),
        name=__ret__.get('name'),
        platform_version=__ret__.get('platformVersion'),
        role_arn=__ret__.get('roleArn'),
        status=__ret__.get('status'),
        tags=__ret__.get('tags'),
        version=__ret__.get('version'),
        vpc_config=__ret__.get('vpcConfig'))
