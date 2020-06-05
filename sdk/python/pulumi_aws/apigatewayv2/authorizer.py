# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import json
import warnings
import pulumi
import pulumi.runtime
from typing import Union
from .. import utilities, tables

class Authorizer(pulumi.CustomResource):
    api_id: pulumi.Output[str]
    """
    The API identifier.
    """
    authorizer_credentials_arn: pulumi.Output[str]
    """
    The required credentials as an IAM role for API Gateway to invoke the authorizer.
    Supported only for `REQUEST` authorizers.
    """
    authorizer_type: pulumi.Output[str]
    """
    The authorizer type. Valid values: `JWT`, `REQUEST`.
    For WebSocket APIs, specify `REQUEST` for a Lambda function using incoming request parameters.
    For HTTP APIs, specify `JWT` to use JSON Web Tokens.
    """
    authorizer_uri: pulumi.Output[str]
    """
    The authorizer's Uniform Resource Identifier (URI).
    For `REQUEST` authorizers this must be a well-formed Lambda function URI, such as the `invoke_arn` attribute of the `lambda.Function` resource.
    Supported only for `REQUEST` authorizers.
    """
    identity_sources: pulumi.Output[list]
    """
    The identity sources for which authorization is requested.
    For `REQUEST` authorizers the value is a list of one or more mapping expressions of the specified request parameters.
    For `JWT` authorizers the single entry specifies where to extract the JSON Web Token (JWT) from inbound requests.
    """
    jwt_configuration: pulumi.Output[dict]
    """
    The configuration of a JWT authorizer. Required for the `JWT` authorizer type.
    Supported only for HTTP APIs.

      * `audiences` (`list`) - A list of the intended recipients of the JWT. A valid JWT must provide an aud that matches at least one entry in this list.
      * `issuer` (`str`) - The base domain of the identity provider that issues JSON Web Tokens, such as the `endpoint` attribute of the `cognito.UserPool` resource.
    """
    name: pulumi.Output[str]
    """
    The name of the authorizer.
    """
    def __init__(__self__, resource_name, opts=None, api_id=None, authorizer_credentials_arn=None, authorizer_type=None, authorizer_uri=None, identity_sources=None, jwt_configuration=None, name=None, __props__=None, __name__=None, __opts__=None):
        """
        Manages an Amazon API Gateway Version 2 authorizer.
        More information can be found in the [Amazon API Gateway Developer Guide](https://docs.aws.amazon.com/apigateway/latest/developerguide/apigateway-websocket-api.html).

        ## Example Usage

        ### Basic WebSocket API

        ```python
        import pulumi
        import pulumi_aws as aws

        example = aws.apigatewayv2.Authorizer("example",
            api_id=aws_apigatewayv2_api["example"]["id"],
            authorizer_type="REQUEST",
            authorizer_uri=aws_lambda_function["example"]["invoke_arn"],
            identity_sources=["route.request.header.Auth"])
        ```

        ### Basic HTTP API

        ```python
        import pulumi
        import pulumi_aws as aws

        example = aws.apigatewayv2.Authorizer("example",
            api_id=aws_apigatewayv2_api["example"]["id"],
            authorizer_type="JWT",
            identity_sources=["$$request.header.Authorization"],
            jwt_configuration={
                "audience": ["example"],
                "issuer": f"https://{aws_cognito_user_pool['example']['endpoint']}",
            })
        ```


        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] api_id: The API identifier.
        :param pulumi.Input[str] authorizer_credentials_arn: The required credentials as an IAM role for API Gateway to invoke the authorizer.
               Supported only for `REQUEST` authorizers.
        :param pulumi.Input[str] authorizer_type: The authorizer type. Valid values: `JWT`, `REQUEST`.
               For WebSocket APIs, specify `REQUEST` for a Lambda function using incoming request parameters.
               For HTTP APIs, specify `JWT` to use JSON Web Tokens.
        :param pulumi.Input[str] authorizer_uri: The authorizer's Uniform Resource Identifier (URI).
               For `REQUEST` authorizers this must be a well-formed Lambda function URI, such as the `invoke_arn` attribute of the `lambda.Function` resource.
               Supported only for `REQUEST` authorizers.
        :param pulumi.Input[list] identity_sources: The identity sources for which authorization is requested.
               For `REQUEST` authorizers the value is a list of one or more mapping expressions of the specified request parameters.
               For `JWT` authorizers the single entry specifies where to extract the JSON Web Token (JWT) from inbound requests.
        :param pulumi.Input[dict] jwt_configuration: The configuration of a JWT authorizer. Required for the `JWT` authorizer type.
               Supported only for HTTP APIs.
        :param pulumi.Input[str] name: The name of the authorizer.

        The **jwt_configuration** object supports the following:

          * `audiences` (`pulumi.Input[list]`) - A list of the intended recipients of the JWT. A valid JWT must provide an aud that matches at least one entry in this list.
          * `issuer` (`pulumi.Input[str]`) - The base domain of the identity provider that issues JSON Web Tokens, such as the `endpoint` attribute of the `cognito.UserPool` resource.
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

            if api_id is None:
                raise TypeError("Missing required property 'api_id'")
            __props__['api_id'] = api_id
            __props__['authorizer_credentials_arn'] = authorizer_credentials_arn
            if authorizer_type is None:
                raise TypeError("Missing required property 'authorizer_type'")
            __props__['authorizer_type'] = authorizer_type
            __props__['authorizer_uri'] = authorizer_uri
            if identity_sources is None:
                raise TypeError("Missing required property 'identity_sources'")
            __props__['identity_sources'] = identity_sources
            __props__['jwt_configuration'] = jwt_configuration
            __props__['name'] = name
        super(Authorizer, __self__).__init__(
            'aws:apigatewayv2/authorizer:Authorizer',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name, id, opts=None, api_id=None, authorizer_credentials_arn=None, authorizer_type=None, authorizer_uri=None, identity_sources=None, jwt_configuration=None, name=None):
        """
        Get an existing Authorizer resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param str id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] api_id: The API identifier.
        :param pulumi.Input[str] authorizer_credentials_arn: The required credentials as an IAM role for API Gateway to invoke the authorizer.
               Supported only for `REQUEST` authorizers.
        :param pulumi.Input[str] authorizer_type: The authorizer type. Valid values: `JWT`, `REQUEST`.
               For WebSocket APIs, specify `REQUEST` for a Lambda function using incoming request parameters.
               For HTTP APIs, specify `JWT` to use JSON Web Tokens.
        :param pulumi.Input[str] authorizer_uri: The authorizer's Uniform Resource Identifier (URI).
               For `REQUEST` authorizers this must be a well-formed Lambda function URI, such as the `invoke_arn` attribute of the `lambda.Function` resource.
               Supported only for `REQUEST` authorizers.
        :param pulumi.Input[list] identity_sources: The identity sources for which authorization is requested.
               For `REQUEST` authorizers the value is a list of one or more mapping expressions of the specified request parameters.
               For `JWT` authorizers the single entry specifies where to extract the JSON Web Token (JWT) from inbound requests.
        :param pulumi.Input[dict] jwt_configuration: The configuration of a JWT authorizer. Required for the `JWT` authorizer type.
               Supported only for HTTP APIs.
        :param pulumi.Input[str] name: The name of the authorizer.

        The **jwt_configuration** object supports the following:

          * `audiences` (`pulumi.Input[list]`) - A list of the intended recipients of the JWT. A valid JWT must provide an aud that matches at least one entry in this list.
          * `issuer` (`pulumi.Input[str]`) - The base domain of the identity provider that issues JSON Web Tokens, such as the `endpoint` attribute of the `cognito.UserPool` resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        __props__["api_id"] = api_id
        __props__["authorizer_credentials_arn"] = authorizer_credentials_arn
        __props__["authorizer_type"] = authorizer_type
        __props__["authorizer_uri"] = authorizer_uri
        __props__["identity_sources"] = identity_sources
        __props__["jwt_configuration"] = jwt_configuration
        __props__["name"] = name
        return Authorizer(resource_name, opts=opts, __props__=__props__)
    def translate_output_property(self, prop):
        return tables._CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return tables._SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

