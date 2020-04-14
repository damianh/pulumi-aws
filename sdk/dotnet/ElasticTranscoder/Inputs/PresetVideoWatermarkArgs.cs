// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.ElasticTranscoder.Inputs
{

    public sealed class PresetVideoWatermarkArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The horizontal position of the watermark unless you specify a nonzero value for `horzontal_offset`.
        /// </summary>
        [Input("horizontalAlign")]
        public Input<string>? HorizontalAlign { get; set; }

        /// <summary>
        /// The amount by which you want the horizontal position of the watermark to be offset from the position specified by `horizontal_align`.
        /// </summary>
        [Input("horizontalOffset")]
        public Input<string>? HorizontalOffset { get; set; }

        /// <summary>
        /// A unique identifier for the settings for one watermark. The value of Id can be up to 40 characters long. You can specify settings for up to four watermarks.
        /// </summary>
        [Input("id")]
        public Input<string>? Id { get; set; }

        /// <summary>
        /// The maximum height of the watermark.
        /// </summary>
        [Input("maxHeight")]
        public Input<string>? MaxHeight { get; set; }

        /// <summary>
        /// The maximum width of the watermark.
        /// </summary>
        [Input("maxWidth")]
        public Input<string>? MaxWidth { get; set; }

        /// <summary>
        /// A percentage that indicates how much you want a watermark to obscure the video in the location where it appears.
        /// </summary>
        [Input("opacity")]
        public Input<string>? Opacity { get; set; }

        /// <summary>
        /// A value that controls scaling of the watermark. Valid values are: `Fit`, `Stretch`, `ShrinkToFit`
        /// </summary>
        [Input("sizingPolicy")]
        public Input<string>? SizingPolicy { get; set; }

        /// <summary>
        /// A value that determines how Elastic Transcoder interprets values that you specified for `video_watermarks.horizontal_offset`, `video_watermarks.vertical_offset`, `video_watermarks.max_width`, and `video_watermarks.max_height`. Valid values are `Content` and `Frame`.
        /// </summary>
        [Input("target")]
        public Input<string>? Target { get; set; }

        /// <summary>
        /// The vertical position of the watermark unless you specify a nonzero value for `vertical_align`. Valid values are `Top`, `Bottom`, `Center`.
        /// </summary>
        [Input("verticalAlign")]
        public Input<string>? VerticalAlign { get; set; }

        /// <summary>
        /// The amount by which you want the vertical position of the watermark to be offset from the position specified by `vertical_align`
        /// </summary>
        [Input("verticalOffset")]
        public Input<string>? VerticalOffset { get; set; }

        public PresetVideoWatermarkArgs()
        {
        }
    }
}
