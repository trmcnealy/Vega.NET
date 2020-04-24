using Newtonsoft.Json;

namespace Vega.Schema
{
    public sealed class Title
    {
        [JsonProperty("align", NullValueHandling = NullValueHandling.Ignore)]
        public LabelAlignUnion? Align { get; set; }

        [JsonProperty("anchor")]
        public TitleAnchorUnion? Anchor { get; set; }

        [JsonProperty("angle", NullValueHandling = NullValueHandling.Ignore)]
        public BandPosition? Angle { get; set; }

        [JsonProperty("baseline", NullValueHandling = NullValueHandling.Ignore)]
        public LabelBaselineUnion? Baseline { get; set; }

        [JsonProperty("color")]
        public DomainColorUnion? Color { get; set; }

        [JsonProperty("dx", NullValueHandling = NullValueHandling.Ignore)]
        public BandPosition? Dx { get; set; }

        [JsonProperty("dy", NullValueHandling = NullValueHandling.Ignore)]
        public BandPosition? Dy { get; set; }

        [JsonProperty("encode", NullValueHandling = NullValueHandling.Ignore)]
        public TitleEncode Encode { get; set; }

        [JsonProperty("font", NullValueHandling = NullValueHandling.Ignore)]
        public LabelFont? Font { get; set; }

        [JsonProperty("fontSize", NullValueHandling = NullValueHandling.Ignore)]
        public BandPosition? FontSize { get; set; }

        [JsonProperty("fontStyle", NullValueHandling = NullValueHandling.Ignore)]
        public LabelFont? FontStyle { get; set; }

        [JsonProperty("fontWeight")]
        public LabelFontWeightUnion? FontWeight { get; set; }

        [JsonProperty("frame", NullValueHandling = NullValueHandling.Ignore)]
        public TitleFrame? Frame { get; set; }

        [JsonProperty("interactive", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Interactive { get; set; }

        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public BandPosition? Limit { get; set; }

        [JsonProperty("lineHeight", NullValueHandling = NullValueHandling.Ignore)]
        public BandPosition? LineHeight { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public BandPosition? Offset { get; set; }

        [JsonProperty("orient", NullValueHandling = NullValueHandling.Ignore)]
        public TitleOrient? Orient { get; set; }

        [JsonProperty("style", NullValueHandling = NullValueHandling.Ignore)]
        public Value? Style { get; set; }

        [JsonProperty("subtitle", NullValueHandling = NullValueHandling.Ignore)]
        public SubtitleUnion? Subtitle { get; set; }

        [JsonProperty("subtitleColor")]
        public DomainColorUnion? SubtitleColor { get; set; }

        [JsonProperty("subtitleFont", NullValueHandling = NullValueHandling.Ignore)]
        public LabelFont? SubtitleFont { get; set; }

        [JsonProperty("subtitleFontSize", NullValueHandling = NullValueHandling.Ignore)]
        public BandPosition? SubtitleFontSize { get; set; }

        [JsonProperty("subtitleFontStyle", NullValueHandling = NullValueHandling.Ignore)]
        public LabelFont? SubtitleFontStyle { get; set; }

        [JsonProperty("subtitleFontWeight")]
        public LabelFontWeightUnion? SubtitleFontWeight { get; set; }

        [JsonProperty("subtitleLineHeight", NullValueHandling = NullValueHandling.Ignore)]
        public BandPosition? SubtitleLineHeight { get; set; }

        [JsonProperty("subtitlePadding", NullValueHandling = NullValueHandling.Ignore)]
        public ColumnsElement? SubtitlePadding { get; set; }

        [JsonProperty("text", NullValueHandling = NullValueHandling.Ignore)]
        public SubtitleUnion? Text { get; set; }

        [JsonProperty("zindex", NullValueHandling = NullValueHandling.Ignore)]
        public double? Zindex { get; set; }
    }
}