// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Kinesis.Inputs
{

    public sealed class FirehoseDeliveryStreamExtendedS3ConfigurationDataFormatConversionConfigurationOutputFormatConfigurationSerializerParquetSerDeArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The Hadoop Distributed File System (HDFS) block size. This is useful if you intend to copy the data from Amazon S3 to HDFS before querying. The default is 256 MiB and the minimum is 64 MiB. Kinesis Data Firehose uses this value for padding calculations.
        /// </summary>
        [Input("blockSizeBytes")]
        public Input<int>? BlockSizeBytes { get; set; }

        /// <summary>
        /// The compression code to use over data blocks. The possible values are `UNCOMPRESSED`, `SNAPPY`, and `GZIP`, with the default being `SNAPPY`. Use `SNAPPY` for higher decompression speed. Use `GZIP` if the compression ratio is more important than speed.
        /// </summary>
        [Input("compression")]
        public Input<string>? Compression { get; set; }

        /// <summary>
        /// Indicates whether to enable dictionary compression.
        /// </summary>
        [Input("enableDictionaryCompression")]
        public Input<bool>? EnableDictionaryCompression { get; set; }

        /// <summary>
        /// The maximum amount of padding to apply. This is useful if you intend to copy the data from Amazon S3 to HDFS before querying. The default is `0`.
        /// </summary>
        [Input("maxPaddingBytes")]
        public Input<int>? MaxPaddingBytes { get; set; }

        /// <summary>
        /// The Parquet page size. Column chunks are divided into pages. A page is conceptually an indivisible unit (in terms of compression and encoding). The minimum value is 64 KiB and the default is 1 MiB.
        /// </summary>
        [Input("pageSizeBytes")]
        public Input<int>? PageSizeBytes { get; set; }

        /// <summary>
        /// Indicates the version of row format to output. The possible values are `V1` and `V2`. The default is `V1`.
        /// </summary>
        [Input("writerVersion")]
        public Input<string>? WriterVersion { get; set; }

        public FirehoseDeliveryStreamExtendedS3ConfigurationDataFormatConversionConfigurationOutputFormatConfigurationSerializerParquetSerDeArgs()
        {
        }
    }
}
