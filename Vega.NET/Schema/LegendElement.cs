using Newtonsoft.Json;

namespace Vega.Schema
{
    public sealed class LegendElement
    {
        [JsonProperty("clipHeight", NullValueHandling = NullValueHandling.Ignore)]
        public ColumnsElement? ClipHeight { get; set; }

        [JsonProperty("columnPadding", NullValueHandling = NullValueHandling.Ignore)]
        public ColumnsElement? ColumnPadding { get; set; }

        [JsonProperty("columns", NullValueHandling = NullValueHandling.Ignore)]
        public ColumnsElement? Columns { get; set; }

        [JsonProperty("cornerRadius", NullValueHandling = NullValueHandling.Ignore)]
        public BandPosition? CornerRadius { get; set; }

        [JsonProperty("direction", NullValueHandling = NullValueHandling.Ignore)]
        public DirectionEnum? Direction { get; set; }

        [JsonProperty("encode", NullValueHandling = NullValueHandling.Ignore)]
        public LegendEncode Encode { get; set; }

        [JsonProperty("fill", NullValueHandling = NullValueHandling.Ignore)]
        public string Fill { get; set; }

        [JsonProperty("fillColor")]
        public DomainColorUnion? FillColor { get; set; }

        [JsonProperty("format", NullValueHandling = NullValueHandling.Ignore)]
        public LegendFormat? Format { get; set; }

        [JsonProperty("formatType", NullValueHandling = NullValueHandling.Ignore)]
        public FormatTypeUnion? FormatType { get; set; }

        [JsonProperty("gradientLength", NullValueHandling = NullValueHandling.Ignore)]
        public ColumnsElement? GradientLength { get; set; }

        [JsonProperty("gradientOpacity", NullValueHandling = NullValueHandling.Ignore)]
        public BandPosition? GradientOpacity { get; set; }

        [JsonProperty("gradientStrokeColor")]
        public DomainColorUnion? GradientStrokeColor { get; set; }

        [JsonProperty("gradientStrokeWidth", NullValueHandling = NullValueHandling.Ignore)]
        public BandPosition? GradientStrokeWidth { get; set; }

        [JsonProperty("gradientThickness", NullValueHandling = NullValueHandling.Ignore)]
        public ColumnsElement? GradientThickness { get; set; }

        [JsonProperty("gridAlign", NullValueHandling = NullValueHandling.Ignore)]
        public GridAlignUnion? GridAlign { get; set; }

        [JsonProperty("labelAlign", NullValueHandling = NullValueHandling.Ignore)]
        public LabelAlignUnion? LabelAlign { get; set; }

        [JsonProperty("labelBaseline", NullValueHandling = NullValueHandling.Ignore)]
        public LabelBaselineUnion? LabelBaseline { get; set; }

        [JsonProperty("labelColor")]
        public DomainColorUnion? LabelColor { get; set; }

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

        [JsonProperty("labelOffset", NullValueHandling = NullValueHandling.Ignore)]
        public BandPosition? LabelOffset { get; set; }

        [JsonProperty("labelOpacity", NullValueHandling = NullValueHandling.Ignore)]
        public BandPosition? LabelOpacity { get; set; }

        [JsonProperty("labelOverlap", NullValueHandling = NullValueHandling.Ignore)]
        public LabelOverlap? LabelOverlap { get; set; }

        [JsonProperty("labelSeparation", NullValueHandling = NullValueHandling.Ignore)]
        public ColumnsElement? LabelSeparation { get; set; }

        [JsonProperty("legendX", NullValueHandling = NullValueHandling.Ignore)]
        public BandPosition? LegendX { get; set; }

        [JsonProperty("legendY", NullValueHandling = NullValueHandling.Ignore)]
        public BandPosition? LegendY { get; set; }

        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public BandPosition? Offset { get; set; }

        [JsonProperty("opacity", NullValueHandling = NullValueHandling.Ignore)]
        public string Opacity { get; set; }

        [JsonProperty("orient", NullValueHandling = NullValueHandling.Ignore)]
        public LegendOrient? Orient { get; set; }

        [JsonProperty("padding", NullValueHandling = NullValueHandling.Ignore)]
        public BandPosition? Padding { get; set; }

        [JsonProperty("rowPadding", NullValueHandling = NullValueHandling.Ignore)]
        public ColumnsElement? RowPadding { get; set; }

        [JsonProperty("shape", NullValueHandling = NullValueHandling.Ignore)]
        public string Shape { get; set; }

        [JsonProperty("size", NullValueHandling = NullValueHandling.Ignore)]
        public string Size { get; set; }

        [JsonProperty("stroke", NullValueHandling = NullValueHandling.Ignore)]
        public string Stroke { get; set; }

        [JsonProperty("strokeColor")]
        public DomainColorUnion? StrokeColor { get; set; }

        [JsonProperty("strokeDash", NullValueHandling = NullValueHandling.Ignore)]
        public string StrokeDash { get; set; }

        [JsonProperty("strokeWidth", NullValueHandling = NullValueHandling.Ignore)]
        public string StrokeWidth { get; set; }

        [JsonProperty("symbolDash", NullValueHandling = NullValueHandling.Ignore)]
        public AxeDomainDash? SymbolDash { get; set; }

        [JsonProperty("symbolDashOffset", NullValueHandling = NullValueHandling.Ignore)]
        public BandPosition? SymbolDashOffset { get; set; }

        [JsonProperty("symbolFillColor")]
        public DomainColorUnion? SymbolFillColor { get; set; }

        [JsonProperty("symbolLimit", NullValueHandling = NullValueHandling.Ignore)]
        public ColumnsElement? SymbolLimit { get; set; }

        [JsonProperty("symbolOffset", NullValueHandling = NullValueHandling.Ignore)]
        public BandPosition? SymbolOffset { get; set; }

        [JsonProperty("symbolOpacity", NullValueHandling = NullValueHandling.Ignore)]
        public BandPosition? SymbolOpacity { get; set; }

        [JsonProperty("symbolSize", NullValueHandling = NullValueHandling.Ignore)]
        public BandPosition? SymbolSize { get; set; }

        [JsonProperty("symbolStrokeColor")]
        public DomainColorUnion? SymbolStrokeColor { get; set; }

        [JsonProperty("symbolStrokeWidth", NullValueHandling = NullValueHandling.Ignore)]
        public BandPosition? SymbolStrokeWidth { get; set; }

        [JsonProperty("symbolType", NullValueHandling = NullValueHandling.Ignore)]
        public LabelFont? SymbolType { get; set; }

        [JsonProperty("tickCount", NullValueHandling = NullValueHandling.Ignore)]
        public TickCount? TickCount { get; set; }

        [JsonProperty("tickMinStep", NullValueHandling = NullValueHandling.Ignore)]
        public ColumnsElement? TickMinStep { get; set; }

        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public SubtitleUnion? Title { get; set; }

        [JsonProperty("titleAlign", NullValueHandling = NullValueHandling.Ignore)]
        public LabelAlignUnion? TitleAlign { get; set; }

        [JsonProperty("titleAnchor")]
        public TitleAnchorUnion? TitleAnchor { get; set; }

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

        [JsonProperty("titleOrient", NullValueHandling = NullValueHandling.Ignore)]
        public TitleOrientUnion? TitleOrient { get; set; }

        [JsonProperty("titlePadding", NullValueHandling = NullValueHandling.Ignore)]
        public BandPosition? TitlePadding { get; set; }

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public LegendTypeEnum? Type { get; set; }

        [JsonProperty("values", NullValueHandling = NullValueHandling.Ignore)]
        public Values? Values { get; set; }

        [JsonProperty("zindex", NullValueHandling = NullValueHandling.Ignore)]
        public double? Zindex { get; set; }
    }
}