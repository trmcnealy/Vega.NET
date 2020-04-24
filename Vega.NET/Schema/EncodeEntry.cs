using Newtonsoft.Json;

namespace Vega.Schema
{
    public sealed class EncodeEntry
    {
        [JsonProperty("align", NullValueHandling = NullValueHandling.Ignore)]
        public EncodeAlign? Align { get; set; }

        [JsonProperty("angle", NullValueHandling = NullValueHandling.Ignore)]
        public AngleUnion? Angle { get; set; }

        [JsonProperty("aspect", NullValueHandling = NullValueHandling.Ignore)]
        public Aspect? Aspect { get; set; }

        [JsonProperty("baseline", NullValueHandling = NullValueHandling.Ignore)]
        public EncodeBaseline? Baseline { get; set; }

        [JsonProperty("clip", NullValueHandling = NullValueHandling.Ignore)]
        public Aspect? Clip { get; set; }

        [JsonProperty("cornerRadius", NullValueHandling = NullValueHandling.Ignore)]
        public AngleUnion? CornerRadius { get; set; }

        [JsonProperty("cornerRadiusBottomLeft", NullValueHandling = NullValueHandling.Ignore)]
        public AngleUnion? CornerRadiusBottomLeft { get; set; }

        [JsonProperty("cornerRadiusBottomRight", NullValueHandling = NullValueHandling.Ignore)]
        public AngleUnion? CornerRadiusBottomRight { get; set; }

        [JsonProperty("cornerRadiusTopLeft", NullValueHandling = NullValueHandling.Ignore)]
        public AngleUnion? CornerRadiusTopLeft { get; set; }

        [JsonProperty("cornerRadiusTopRight", NullValueHandling = NullValueHandling.Ignore)]
        public AngleUnion? CornerRadiusTopRight { get; set; }

        [JsonProperty("cursor", NullValueHandling = NullValueHandling.Ignore)]
        public Cursor? Cursor { get; set; }

        [JsonProperty("defined", NullValueHandling = NullValueHandling.Ignore)]
        public Aspect? Defined { get; set; }

        [JsonProperty("dir", NullValueHandling = NullValueHandling.Ignore)]
        public Cursor? Dir { get; set; }

        [JsonProperty("dx", NullValueHandling = NullValueHandling.Ignore)]
        public AngleUnion? Dx { get; set; }

        [JsonProperty("dy", NullValueHandling = NullValueHandling.Ignore)]
        public AngleUnion? Dy { get; set; }

        [JsonProperty("ellipsis", NullValueHandling = NullValueHandling.Ignore)]
        public Cursor? Ellipsis { get; set; }

        [JsonProperty("endAngle", NullValueHandling = NullValueHandling.Ignore)]
        public AngleUnion? EndAngle { get; set; }

        [JsonProperty("fill", NullValueHandling = NullValueHandling.Ignore)]
        public FillUnion? Fill { get; set; }

        [JsonProperty("fillOpacity", NullValueHandling = NullValueHandling.Ignore)]
        public AngleUnion? FillOpacity { get; set; }

        [JsonProperty("font", NullValueHandling = NullValueHandling.Ignore)]
        public Cursor? Font { get; set; }

        [JsonProperty("fontSize", NullValueHandling = NullValueHandling.Ignore)]
        public AngleUnion? FontSize { get; set; }

        [JsonProperty("fontStyle", NullValueHandling = NullValueHandling.Ignore)]
        public Cursor? FontStyle { get; set; }

        [JsonProperty("fontWeight", NullValueHandling = NullValueHandling.Ignore)]
        public EncodeFontWeight? FontWeight { get; set; }

        [JsonProperty("height", NullValueHandling = NullValueHandling.Ignore)]
        public AngleUnion? Height { get; set; }

        [JsonProperty("innerRadius", NullValueHandling = NullValueHandling.Ignore)]
        public AngleUnion? InnerRadius { get; set; }

        [JsonProperty("interpolate", NullValueHandling = NullValueHandling.Ignore)]
        public Cursor? Interpolate { get; set; }

        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public AngleUnion? Limit { get; set; }

        [JsonProperty("lineBreak", NullValueHandling = NullValueHandling.Ignore)]
        public Cursor? LineBreak { get; set; }

        [JsonProperty("lineHeight", NullValueHandling = NullValueHandling.Ignore)]
        public AngleUnion? LineHeight { get; set; }

        [JsonProperty("opacity", NullValueHandling = NullValueHandling.Ignore)]
        public AngleUnion? Opacity { get; set; }

        [JsonProperty("orient", NullValueHandling = NullValueHandling.Ignore)]
        public EncodeOrient? Orient { get; set; }

        [JsonProperty("outerRadius", NullValueHandling = NullValueHandling.Ignore)]
        public AngleUnion? OuterRadius { get; set; }

        [JsonProperty("padAngle", NullValueHandling = NullValueHandling.Ignore)]
        public AngleUnion? PadAngle { get; set; }

        [JsonProperty("path", NullValueHandling = NullValueHandling.Ignore)]
        public Cursor? Path { get; set; }

        [JsonProperty("radius", NullValueHandling = NullValueHandling.Ignore)]
        public AngleUnion? Radius { get; set; }

        [JsonProperty("scaleX", NullValueHandling = NullValueHandling.Ignore)]
        public AngleUnion? ScaleX { get; set; }

        [JsonProperty("scaleY", NullValueHandling = NullValueHandling.Ignore)]
        public AngleUnion? ScaleY { get; set; }

        [JsonProperty("shape", NullValueHandling = NullValueHandling.Ignore)]
        public Cursor? Shape { get; set; }

        [JsonProperty("size", NullValueHandling = NullValueHandling.Ignore)]
        public AngleUnion? Size { get; set; }

        [JsonProperty("smooth", NullValueHandling = NullValueHandling.Ignore)]
        public Aspect? Smooth { get; set; }

        [JsonProperty("startAngle", NullValueHandling = NullValueHandling.Ignore)]
        public AngleUnion? StartAngle { get; set; }

        [JsonProperty("stroke", NullValueHandling = NullValueHandling.Ignore)]
        public FillUnion? Stroke { get; set; }

        [JsonProperty("strokeCap", NullValueHandling = NullValueHandling.Ignore)]
        public StrokeCap? StrokeCap { get; set; }

        [JsonProperty("strokeDash", NullValueHandling = NullValueHandling.Ignore)]
        public StrokeDashUnion? StrokeDash { get; set; }

        [JsonProperty("strokeDashOffset", NullValueHandling = NullValueHandling.Ignore)]
        public AngleUnion? StrokeDashOffset { get; set; }

        [JsonProperty("strokeForeground", NullValueHandling = NullValueHandling.Ignore)]
        public Aspect? StrokeForeground { get; set; }

        [JsonProperty("strokeJoin", NullValueHandling = NullValueHandling.Ignore)]
        public StrokeJoin? StrokeJoin { get; set; }

        [JsonProperty("strokeMiterLimit", NullValueHandling = NullValueHandling.Ignore)]
        public AngleUnion? StrokeMiterLimit { get; set; }

        [JsonProperty("strokeOffset", NullValueHandling = NullValueHandling.Ignore)]
        public AngleUnion? StrokeOffset { get; set; }

        [JsonProperty("strokeOpacity", NullValueHandling = NullValueHandling.Ignore)]
        public AngleUnion? StrokeOpacity { get; set; }

        [JsonProperty("strokeWidth", NullValueHandling = NullValueHandling.Ignore)]
        public AngleUnion? StrokeWidth { get; set; }

        [JsonProperty("tension", NullValueHandling = NullValueHandling.Ignore)]
        public AngleUnion? Tension { get; set; }

        [JsonProperty("text", NullValueHandling = NullValueHandling.Ignore)]
        public Text? Text { get; set; }

        [JsonProperty("theta", NullValueHandling = NullValueHandling.Ignore)]
        public AngleUnion? Theta { get; set; }

        [JsonProperty("tooltip", NullValueHandling = NullValueHandling.Ignore)]
        public Tooltip? Tooltip { get; set; }

        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public Cursor? Url { get; set; }

        [JsonProperty("width", NullValueHandling = NullValueHandling.Ignore)]
        public AngleUnion? Width { get; set; }

        [JsonProperty("x", NullValueHandling = NullValueHandling.Ignore)]
        public AngleUnion? X { get; set; }

        [JsonProperty("x2", NullValueHandling = NullValueHandling.Ignore)]
        public AngleUnion? X2 { get; set; }

        [JsonProperty("xc", NullValueHandling = NullValueHandling.Ignore)]
        public AngleUnion? Xc { get; set; }

        [JsonProperty("y", NullValueHandling = NullValueHandling.Ignore)]
        public AngleUnion? Y { get; set; }

        [JsonProperty("y2", NullValueHandling = NullValueHandling.Ignore)]
        public AngleUnion? Y2 { get; set; }

        [JsonProperty("yc", NullValueHandling = NullValueHandling.Ignore)]
        public AngleUnion? Yc { get; set; }

        [JsonProperty("zindex", NullValueHandling = NullValueHandling.Ignore)]
        public AngleUnion? Zindex { get; set; }
    }
}