# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import pulumi
import pulumi.runtime
from .. import utilities, tables

class GetListenerResult(object):
    """
    A collection of values returned by getListener.
    """
    def __init__(__self__, arn=None, certificate_arn=None, default_actions=None, load_balancer_arn=None, port=None, protocol=None, ssl_policy=None, id=None):
        if arn and not isinstance(arn, str):
            raise TypeError('Expected argument arn to be a str')
        __self__.arn = arn
        if certificate_arn and not isinstance(certificate_arn, str):
            raise TypeError('Expected argument certificate_arn to be a str')
        __self__.certificate_arn = certificate_arn
        if default_actions and not isinstance(default_actions, list):
            raise TypeError('Expected argument default_actions to be a list')
        __self__.default_actions = default_actions
        if load_balancer_arn and not isinstance(load_balancer_arn, str):
            raise TypeError('Expected argument load_balancer_arn to be a str')
        __self__.load_balancer_arn = load_balancer_arn
        if port and not isinstance(port, int):
            raise TypeError('Expected argument port to be a int')
        __self__.port = port
        if protocol and not isinstance(protocol, str):
            raise TypeError('Expected argument protocol to be a str')
        __self__.protocol = protocol
        if ssl_policy and not isinstance(ssl_policy, str):
            raise TypeError('Expected argument ssl_policy to be a str')
        __self__.ssl_policy = ssl_policy
        if id and not isinstance(id, str):
            raise TypeError('Expected argument id to be a str')
        __self__.id = id
        """
        id is the provider-assigned unique ID for this managed resource.
        """

async def get_listener(arn=None, load_balancer_arn=None, port=None):
    """
    > **Note:** `aws_alb_listener` is known as `aws_lb_listener`. The functionality is identical.
    
    Provides information about a Load Balancer Listener.
    
    This data source can prove useful when a module accepts an LB Listener as an
    input variable and needs to know the LB it is attached to, or other
    information specific to the listener in question.
    """
    __args__ = dict()

    __args__['arn'] = arn
    __args__['loadBalancerArn'] = load_balancer_arn
    __args__['port'] = port
    __ret__ = await pulumi.runtime.invoke('aws:elasticloadbalancingv2/getListener:getListener', __args__)

    return GetListenerResult(
        arn=__ret__.get('arn'),
        certificate_arn=__ret__.get('certificateArn'),
        default_actions=__ret__.get('defaultActions'),
        load_balancer_arn=__ret__.get('loadBalancerArn'),
        port=__ret__.get('port'),
        protocol=__ret__.get('protocol'),
        ssl_policy=__ret__.get('sslPolicy'),
        id=__ret__.get('id'))
