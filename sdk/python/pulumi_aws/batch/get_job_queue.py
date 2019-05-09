# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import json
import warnings
import pulumi
import pulumi.runtime
from .. import utilities, tables

class GetJobQueueResult:
    """
    A collection of values returned by getJobQueue.
    """
    def __init__(__self__, arn=None, compute_environment_orders=None, name=None, priority=None, state=None, status=None, status_reason=None, id=None):
        if arn and not isinstance(arn, str):
            raise TypeError("Expected argument 'arn' to be a str")
        __self__.arn = arn
        """
        The ARN of the job queue.
        """
        if compute_environment_orders and not isinstance(compute_environment_orders, list):
            raise TypeError("Expected argument 'compute_environment_orders' to be a list")
        __self__.compute_environment_orders = compute_environment_orders
        """
        The compute environments that are attached to the job queue and the order in
        which job placement is preferred. Compute environments are selected for job placement in ascending order.
        * `compute_environment_order.#.order` - The order of the compute environment.
        * `compute_environment_order.#.compute_environment` - The ARN of the compute environment.
        """
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        __self__.name = name
        if priority and not isinstance(priority, float):
            raise TypeError("Expected argument 'priority' to be a float")
        __self__.priority = priority
        """
        The priority of the job queue. Job queues with a higher priority are evaluated first when
        associated with the same compute environment.
        """
        if state and not isinstance(state, str):
            raise TypeError("Expected argument 'state' to be a str")
        __self__.state = state
        """
        Describes the ability of the queue to accept new jobs (for example, `ENABLED` or `DISABLED`).
        """
        if status and not isinstance(status, str):
            raise TypeError("Expected argument 'status' to be a str")
        __self__.status = status
        """
        The current status of the job queue (for example, `CREATING` or `VALID`).
        """
        if status_reason and not isinstance(status_reason, str):
            raise TypeError("Expected argument 'status_reason' to be a str")
        __self__.status_reason = status_reason
        """
        A short, human-readable string to provide additional details about the current status
        of the job queue.
        """
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        __self__.id = id
        """
        id is the provider-assigned unique ID for this managed resource.
        """

async def get_job_queue(name=None,opts=None):
    """
    The Batch Job Queue data source allows access to details of a specific
    job queue within AWS Batch.
    """
    __args__ = dict()

    __args__['name'] = name
    if opts is None:
        opts = pulumi.ResourceOptions()
    if opts.version is None:
        opts.version = utilities.get_version()
    __ret__ = await pulumi.runtime.invoke('aws:batch/getJobQueue:getJobQueue', __args__, opts=opts)

    return GetJobQueueResult(
        arn=__ret__.get('arn'),
        compute_environment_orders=__ret__.get('computeEnvironmentOrders'),
        name=__ret__.get('name'),
        priority=__ret__.get('priority'),
        state=__ret__.get('state'),
        status=__ret__.get('status'),
        status_reason=__ret__.get('statusReason'),
        id=__ret__.get('id'))
