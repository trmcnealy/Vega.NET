using Newtonsoft.Json;

namespace Vega.Schema
{
    public sealed class AxeElement
    {
        [JsonProperty("bandPosition", NullValueHandling = NullValueHandling.Ignore)]
        public BandPosition? BandPosition { get; set; }

        [JsonProperty("domain", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Domain { get; set; }

        [JsonProperty("domainColor")]
        public DomainColorUnion? DomainColor { get; set; }

        [JsonProperty("domainDash", NullValueHandling = NullValueHandling.Ignore)]
        public AxeDomainDash? DomainDash { get; set; }

        [JsonProperty("domainDashOffset", NullValueHandling = NullValueHandling.Ignore)]
        public BandPosition? DomainDashOffset { get; set; }

        [JsonProperty("domainOpacity", NullValueHandling = NullValueHandling.Ignore)]
        public BandPosition? DomainOpacity { get; set; }

        [JsonProperty("domainWidth", NullValueHandling = NullValueHandling.Ignore)]
        public BandPosition? DomainWidth { get; set; }

        [JsonProperty("encode", NullValueHandling = NullValueHandling.Ignore)]
        public AxeEncode Encode { get; set; }

        [JsonProperty("format", NullValueHandling = NullValueHandling.Ignore)]
        public AxeFormat? Format { get; set; }

        [JsonProperty("formatType", NullValueHandling = NullValueHandling.Ignore)]
        public FormatTypeUnion? FormatType { get; set; }

        [JsonProperty("grid", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Grid { get; set; }

        [JsonProperty("gridColor")]
        public DomainColorUnion? GridColor { get; set; }

        [JsonProperty("gridDash", NullValueHandling = NullValueHandling.Ignore)]
        public AxeDomainDash? GridDash { get; set; }

        [JsonProperty("gridDashOffset", NullValueHandling = NullValueHandling.Ignore)]
        public BandPosition? GridDashOffset { get; set; }

        [JsonProperty("gridOpacity", NullValueHandling = NullValueHandling.Ignore)]
        public BandPosition? GridOpacity { get; set; }

        [JsonProperty("gridScale", NullValueHandling = NullValueHandling.Ignore)]
        public string GridScale { get; set; }

        [JsonProperty("gridWidth", NullValueHandling = NullValueHandling.Ignore)]
        public BandPosition? GridWidth { get; set; }

        [JsonProperty("labelAlign", NullValueHandling = NullValueHandling.Ignore)]
        public LabelAlignUnion? LabelAlign { get; set; }

        [JsonProperty("labelAngle", NullValueHandling = NullValueHandling.Ignore)]
        public BandPosition? LabelAngle { get; set; }

        [JsonProperty("labelBaseline", NullValueHandling = NullValueHandling.Ignore)]
        public LabelBaselineUnion? LabelBaseline { get; set; }

        [JsonProperty("labelBound", NullValueHandling = NullValueHandling.Ignore)]
        public LabelBound? LabelBound { get; set; }

        [JsonProperty("labelColor")]
        public DomainColorUnion? LabelColor { get; set; }

        [JsonProperty("labelFlush", NullValueHandling = NullValueHandling.Ignore)]
        public LabelBound? LabelFlush { get; set; }

        [JsonProperty("labelFlushOffset", NullValueHandling = NullValueHandling.Ignore)]
        public ColumnsElement? LabelFlushOffset { get; set; }

        [JsonProperty("labelFont", NullValueHandling = NullValueHandling.Ignore)]
        public LabelFont? LabelFont { get; set; }

        [JsonProperty("labelFontSize", NullValueHandling = NullValueHandling.Ignore)]
        public BandPosition? LabelFontSize { get; set; }

        [JsonProperty("labelFontStyle", NullValueHandling = NullValueHandling.Ignore)]
        public LabelFont? LabelFontStyle { get; set; }

        [JsonProperty("labelFontWeight")]
        public LabelFontWeightUnion? LabelFontWeight { get; set; }

        [JsonProperty("labelLimit", NullValueHandling = NullValueHandling.Ignore)]
        public BandPosition? LabelLimit { get; set; }

        [JsonProperty("labelOpacity", NullValueHandling = NullValueHandling.Ignore)]
        public BandPosition? LabelOpacity { get; set; }

        [JsonProperty("labelOverlap", NullValueHandling = NullValueHandling.Ignore)]
        public LabelOverlap? LabelOverlap { get; set; }

        [JsonProperty("labelPadding", NullValueHandling = NullValueHandling.Ignore)]
        public BandPosition? LabelPadding { get; set; }

        [JsonProperty("labels", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Labels { get; set; }

        [JsonProperty("labelSeparation", NullValueHandling = NullValueHandling.Ignore)]
        public ColumnsElement? LabelSeparation { get; set; }

        [JsonProperty("maxExtent", NullValueHandling = NullValueHandling.Ignore)]
        public BandPosition? MaxExtent { get; set; }

        [JsonProperty("minExtent", NullValueHandling = NullValueHandling.Ignore)]
        public BandPosition? MinExtent { get; set; }

        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public BandPosition? Offset { get; set; }

        [JsonProperty("orient", Required = Required.Always)]
        public TitleOrientEnum Orient { get; set; }

        [JsonProperty("position", NullValueHandling = NullValueHandling.Ignore)]
        public BandPosition? Position { get; set; }

        [JsonProperty("scale", Required = Required.Always)]
        public string Scale { get; set; }

        [JsonProperty("tickBand", NullValueHandling = NullValueHandling.Ignore)]
        public TickBand? TickBand { get; set; }

        [JsonProperty("tickColor")]
        public DomainColorUnion? TickColor { get; set; }

        [JsonProperty("tickCount", NullValueHandling = NullValueHandling.Ignore)]
        public TickCount? TickCount { get; set; }

        [JsonProperty("tickDash", NullValueHandling = NullValueHandling.Ignore)]
        public AxeDomainDash? TickDash { get; set; }

        [JsonProperty("tickDashOffset", NullValueHandling = NullValueHandling.Ignore)]
        public BandPosition? TickDashOffset { get; set; }

        [JsonProperty("tickExtra", NullValueHandling = NullValueHandling.Ignore)]
        public TickExtraUnion? TickExtra { get; set; }

        [JsonProperty("tickMinStep", NullValueHandling = NullValueHandling.Ignore)]
        public ColumnsElement? TickMinStep { get; set; }

        [JsonProperty("tickOffset", NullValueHandling = NullValueHandling.Ignore)]
        public BandPosition? TickOffset { get; set; }

        [JsonProperty("tickOpacity", NullValueHandling = NullValueHandling.Ignore)]
        public BandPosition? TickOpacity { get; set; }

        [JsonProperty("tickRound", NullValueHandling = NullValueHandling.Ignore)]
        public TickRound? TickRound { get; set; }

        [JsonProperty("ticks", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Ticks { get; set; }

        [JsonProperty("tickSize", NullValueHandling = NullValueHandling.Ignore)]
        public BandPosition? TickSize { get; set; }

        [JsonProperty("tickWidth", NullValueHandling = NullValueHandling.Ignore)]
        public BandPosition? TickWidth { get; set; }

        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public SubtitleUnion? Title { get; set; }

        [JsonProperty("titleAlign", NullValueHandling = NullValueHandling.Ignore)]
        public LabelAlignUnion? TitleAlign { get; set; }

        [JsonProperty("titleAnchor")]
        public TitleAnchorUnion? TitleAnchor { get; set; }

        [JsonProperty("titleAngle", NullValueHandling = NullValueHandling.Ignore)]
        public BandPosition? TitleAngle { get; set; }

        [JsonProperty("titleBaseline", NullValueHandling = NullValueHandling.Ignore)]
        public LabelBaselineUnion? TitleBaseline { get; set; }

        [JsonProperty("titleColor")]
        public DomainColorUnion? TitleColor { get; set; }

        [JsonProperty("titleFont", NullValueHandling = NullValueHandling.Ignore)]
        public LabelFont? TitleFont { get; set; }

        [JsonProperty("titleFontSize", NullValueHandling = NullValueHandling.Ignore)]
        public BandPosition? TitleFontSize { get; set; }

        [JsonProperty("titleFontStyle", NullValueHandling = NullValueHandling.Ignore)]
        public LabelFont? TitleFontStyle { get; set; }

        [JsonProperty("titleFontWeight")]
        public LabelFontWeightUnion? TitleFontWeight { get; set; }

        [JsonProperty("titleLimit", NullValueHandling = NullValueHandling.Ignore)]
        public BandPosition? TitleLimit { get; set; }

        [JsonProperty("titleLineHeight", NullValueHandling = NullValueHandling.Ignore)]
        public BandPosition? TitleLineHeight { get; set; }

        [JsonProperty("titleOpacity", NullValueHandling = NullValueHandling.Ignore)]
        public BandPosition? TitleOpacity { get; set; }

        [JsonProperty("titlePadding", NullValueHandling = NullValueHandling.Ignore)]
        public BandPosition? TitlePadding { get; set; }

        [JsonProperty("titleX", NullValueHandling = NullValueHandling.Ignore)]
        public BandPosition? TitleX { get; set; }

        [JsonProperty("titleY", NullValueHandling = NullValueHandling.Ignore)]
        public BandPosition? TitleY { get; set; }

        [JsonProperty("translate", NullValueHandling = NullValueHandling.Ignore)]
        public double? Translate { get; set; }

        [JsonProperty("values", NullValueHandling = NullValueHandling.Ignore)]
        public Values? Values { get; set; }

        [JsonProperty("zindex", NullValueHandling = NullValueHandling.Ignore)]
        public double? Zindex { get; set; }
    }
}