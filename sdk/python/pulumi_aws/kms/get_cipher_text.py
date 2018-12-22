# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import pulumi
import pulumi.runtime
from .. import utilities, tables

class GetCipherTextResult(object):
    """
    A collection of values returned by getCipherText.
    """
    def __init__(__self__, ciphertext_blob=None, id=None):
        if ciphertext_blob and not isinstance(ciphertext_blob, str):
            raise TypeError('Expected argument ciphertext_blob to be a str')
        __self__.ciphertext_blob = ciphertext_blob
        """
        Base64 encoded ciphertext
        """
        if id and not isinstance(id, str):
            raise TypeError('Expected argument id to be a str')
        __self__.id = id
        """
        id is the provider-assigned unique ID for this managed resource.
        """

async def get_cipher_text(context=None, key_id=None, plaintext=None):
    """
    The KMS ciphertext data source allows you to encrypt plaintext into ciphertext
    by using an AWS KMS customer master key.
    
    > **Note:** All arguments including the plaintext be stored in the raw state as plain-text.
    [Read more about sensitive data in state](https://www.terraform.io/docs/state/sensitive-data.html).
    """
    __args__ = dict()

    __args__['context'] = context
    __args__['keyId'] = key_id
    __args__['plaintext'] = plaintext
    __ret__ = await pulumi.runtime.invoke('aws:kms/getCipherText:getCipherText', __args__)

    return GetCipherTextResult(
        ciphertext_blob=__ret__.get('ciphertextBlob'),
        id=__ret__.get('id'))
