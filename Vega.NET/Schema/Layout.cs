using Newtonsoft.Json;

namespace Vega.Schema
{
    public sealed class Layout
    {
        [JsonProperty("align", NullValueHandling = NullValueHandling.Ignore)]
        public LayoutAlign? Align { get; set; }

        [JsonProperty("bounds", NullValueHandling = NullValueHandling.Ignore)]
        public BoundsUnion? Bounds { get; set; }

        [JsonProperty("center", NullValueHandling = NullValueHandling.Ignore)]
        public Center? Center { get; set; }

        [JsonProperty("columns", NullValueHandling = NullValueHandling.Ignore)]
        public ColumnsElement? Columns { get; set; }

        [JsonProperty("footerBand")]
        public FooterBand? FooterBand { get; set; }

        [JsonProperty("headerBand")]
        public HeaderBand? HeaderBand { get; set; }

        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public LayoutOffset? Offset { get; set; }

        [JsonProperty("padding", NullValueHandling = NullValueHandling.Ignore)]
        public LayoutPadding? Padding { get; set; }

        [JsonProperty("titleAnchor", NullValueHandling = NullValueHandling.Ignore)]
        public TitleAnchor? TitleAnchor { get; set; }

        [JsonProperty("titleBand")]
        public TitleBand? TitleBand { get; set; }

        [JsonProperty("signal", NullValueHandling = NullValueHandling.Ignore)]
        public string Signal { get; set; }
    }
}