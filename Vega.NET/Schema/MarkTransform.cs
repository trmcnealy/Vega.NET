using System.Collections.Generic;

using Newtonsoft.Json;

namespace Vega.Schema
{
    public sealed class MarkTransform
    {
        [JsonProperty("fields", NullValueHandling = NullValueHandling.Ignore)]
        public FieldsUnion? Fields { get; set; }

        [JsonProperty("query", NullValueHandling = NullValueHandling.Ignore)]
        public Values? Query { get; set; }

        [JsonProperty("signal", NullValueHandling = NullValueHandling.Ignore)]
        public string Signal { get; set; }

        [JsonProperty("type", Required = Required.Always)]
        public MarkTransformEnum TypeEnum { get; set; }

        [JsonProperty("filter")]
        public object Filter { get; set; }

        [JsonProperty("ignore", NullValueHandling = NullValueHandling.Ignore)]
        public ColumnsElement? Ignore { get; set; }

        [JsonProperty("as", NullValueHandling = NullValueHandling.Ignore)]
        public MarkTransformAs? As { get; set; }

        [JsonProperty("orient", NullValueHandling = NullValueHandling.Ignore)]
        public TransformOrient? Orient { get; set; }

        [JsonProperty("require", NullValueHandling = NullValueHandling.Ignore)]
        public BoundsType Require { get; set; }

        [JsonProperty("shape", NullValueHandling = NullValueHandling.Ignore)]
        public ShapeUnion? Shape { get; set; }

        [JsonProperty("sourceX", NullValueHandling = NullValueHandling.Ignore)]
        public ColorElement? SourceX { get; set; }

        [JsonProperty("sourceY", NullValueHandling = NullValueHandling.Ignore)]
        public ColorElement? SourceY { get; set; }

        [JsonProperty("targetX", NullValueHandling = NullValueHandling.Ignore)]
        public ColorElement? TargetX { get; set; }

        [JsonProperty("targetY", NullValueHandling = NullValueHandling.Ignore)]
        public ColorElement? TargetY { get; set; }

        [JsonProperty("endAngle", NullValueHandling = NullValueHandling.Ignore)]
        public ColumnsElement? EndAngle { get; set; }

        [JsonProperty("field", NullValueHandling = NullValueHandling.Ignore)]
        public ColorElement? Field { get; set; }

        [JsonProperty("sort", NullValueHandling = NullValueHandling.Ignore)]
        public SortUnion? Sort { get; set; }

        [JsonProperty("startAngle", NullValueHandling = NullValueHandling.Ignore)]
        public ColumnsElement? StartAngle { get; set; }

        [JsonProperty("groupby", NullValueHandling = NullValueHandling.Ignore)]
        public GroupbyUnion? Groupby { get; set; }

        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public TransformOffset? Offset { get; set; }

        [JsonProperty("alpha", NullValueHandling = NullValueHandling.Ignore)]
        public ColumnsElement? Alpha { get; set; }

        [JsonProperty("alphaMin", NullValueHandling = NullValueHandling.Ignore)]
        public ColumnsElement? AlphaMin { get; set; }

        [JsonProperty("alphaTarget", NullValueHandling = NullValueHandling.Ignore)]
        public ColumnsElement? AlphaTarget { get; set; }

        [JsonProperty("forces", NullValueHandling = NullValueHandling.Ignore)]
        public List<ForceElement> Forces { get; set; }

        [JsonProperty("iterations", NullValueHandling = NullValueHandling.Ignore)]
        public ColumnsElement? Iterations { get; set; }

        [JsonProperty("restart", NullValueHandling = NullValueHandling.Ignore)]
        public TickExtraUnion? Restart { get; set; }

        [JsonProperty("static", NullValueHandling = NullValueHandling.Ignore)]
        public TickExtraUnion? Static { get; set; }

        [JsonProperty("velocityDecay", NullValueHandling = NullValueHandling.Ignore)]
        public ColumnsElement? VelocityDecay { get; set; }

        [JsonProperty("geojson", NullValueHandling = NullValueHandling.Ignore)]
        public ColorElement? Geojson { get; set; }

        [JsonProperty("pointRadius", NullValueHandling = NullValueHandling.Ignore)]
        public Radius? PointRadius { get; set; }

        [JsonProperty("projection", NullValueHandling = NullValueHandling.Ignore)]
        public string Projection { get; set; }

        [JsonProperty("color", NullValueHandling = NullValueHandling.Ignore)]
        public ColorElement? Color { get; set; }

        [JsonProperty("opacity", NullValueHandling = NullValueHandling.Ignore)]
        public Radius? Opacity { get; set; }

        [JsonProperty("resolve", NullValueHandling = NullValueHandling.Ignore)]
        public ResolveUnion? Resolve { get; set; }

        [JsonProperty("padding", NullValueHandling = NullValueHandling.Ignore)]
        public StrengthUnion? Padding { get; set; }

        [JsonProperty("radius", NullValueHandling = NullValueHandling.Ignore)]
        public ColorElement? Radius { get; set; }

        [JsonProperty("size", NullValueHandling = NullValueHandling.Ignore)]
        public BandwidthUnion? Size { get; set; }

        [JsonProperty("round", NullValueHandling = NullValueHandling.Ignore)]
        public TickExtraUnion? Round { get; set; }

        [JsonProperty("key", NullValueHandling = NullValueHandling.Ignore)]
        public ColorElement? Key { get; set; }

        [JsonProperty("parentKey", NullValueHandling = NullValueHandling.Ignore)]
        public ColorElement? ParentKey { get; set; }

        [JsonProperty("method", NullValueHandling = NullValueHandling.Ignore)]
        public MethodUnion? Method { get; set; }

        [JsonProperty("nodeSize", NullValueHandling = NullValueHandling.Ignore)]
        public CenterElement? NodeSize { get; set; }

        [JsonProperty("separation", NullValueHandling = NullValueHandling.Ignore)]
        public TickExtraUnion? Separation { get; set; }

        [JsonProperty("paddingBottom", NullValueHandling = NullValueHandling.Ignore)]
        public ColumnsElement? PaddingBottom { get; set; }

        [JsonProperty("paddingInner", NullValueHandling = NullValueHandling.Ignore)]
        public ColumnsElement? PaddingInner { get; set; }

        [JsonProperty("paddingLeft", NullValueHandling = NullValueHandling.Ignore)]
        public ColumnsElement? PaddingLeft { get; set; }

        [JsonProperty("paddingOuter", NullValueHandling = NullValueHandling.Ignore)]
        public ColumnsElement? PaddingOuter { get; set; }

        [JsonProperty("paddingRight", NullValueHandling = NullValueHandling.Ignore)]
        public ColumnsElement? PaddingRight { get; set; }

        [JsonProperty("paddingTop", NullValueHandling = NullValueHandling.Ignore)]
        public ColumnsElement? PaddingTop { get; set; }

        [JsonProperty("ratio", NullValueHandling = NullValueHandling.Ignore)]
        public ColumnsElement? Ratio { get; set; }

        [JsonProperty("anchor", NullValueHandling = NullValueHandling.Ignore)]
        public ColumnsElement? Anchor { get; set; }

        [JsonProperty("base", NullValueHandling = NullValueHandling.Ignore)]
        public ColumnsElement? Base { get; set; }

        [JsonProperty("divide", NullValueHandling = NullValueHandling.Ignore)]
        public CenterElement? Divide { get; set; }

        [JsonProperty("extent", NullValueHandling = NullValueHandling.Ignore)]
        public Values? Extent { get; set; }

        [JsonProperty("interval", NullValueHandling = NullValueHandling.Ignore)]
        public TickExtraUnion? Interval { get; set; }

        [JsonProperty("maxbins", NullValueHandling = NullValueHandling.Ignore)]
        public ColumnsElement? Maxbins { get; set; }

        [JsonProperty("minstep", NullValueHandling = NullValueHandling.Ignore)]
        public ColumnsElement? Minstep { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public TypeElement? Name { get; set; }

        [JsonProperty("nice", NullValueHandling = NullValueHandling.Ignore)]
        public TickExtraUnion? Nice { get; set; }

        [JsonProperty("span", NullValueHandling = NullValueHandling.Ignore)]
        public ColumnsElement? Span { get; set; }

        [JsonProperty("step", NullValueHandling = NullValueHandling.Ignore)]
        public ColumnsElement? Step { get; set; }

        [JsonProperty("steps", NullValueHandling = NullValueHandling.Ignore)]
        public CenterElement? Steps { get; set; }

        [JsonProperty("smooth", NullValueHandling = NullValueHandling.Ignore)]
        public TickExtraUnion? Smooth { get; set; }

        [JsonProperty("expr", NullValueHandling = NullValueHandling.Ignore)]
        public string Expr { get; set; }

        [JsonProperty("initonly", NullValueHandling = NullValueHandling.Ignore)]
        public TickExtraUnion? Initonly { get; set; }

        [JsonProperty("ops", NullValueHandling = NullValueHandling.Ignore)]
        public Ops? Ops { get; set; }

        [JsonProperty("default")]
        public object Default { get; set; }

        [JsonProperty("from", NullValueHandling = NullValueHandling.Ignore)]
        public string From { get; set; }

        [JsonProperty("values", NullValueHandling = NullValueHandling.Ignore)]
        public GroupbyUnion? Values { get; set; }

        [JsonProperty("timezone", NullValueHandling = NullValueHandling.Ignore)]
        public TimezoneUnion? Timezone { get; set; }

        [JsonProperty("units", NullValueHandling = NullValueHandling.Ignore)]
        public UnitsUnion? Units { get; set; }

        [JsonProperty("frame", NullValueHandling = NullValueHandling.Ignore)]
        public FrameUnion? Frame { get; set; }

        [JsonProperty("ignorePeers", NullValueHandling = NullValueHandling.Ignore)]
        public TickExtraUnion? IgnorePeers { get; set; }

        [JsonProperty("params", NullValueHandling = NullValueHandling.Ignore)]
        public FrameUnion? Params { get; set; }

        [JsonProperty("x", NullValueHandling = NullValueHandling.Ignore)]
        public ColorElement? X { get; set; }

        [JsonProperty("y", NullValueHandling = NullValueHandling.Ignore)]
        public ColorElement? Y { get; set; }

        [JsonProperty("font", NullValueHandling = NullValueHandling.Ignore)]
        public ColorElement? Font { get; set; }

        [JsonProperty("fontSize", NullValueHandling = NullValueHandling.Ignore)]
        public Radius? FontSize { get; set; }

        [JsonProperty("fontSizeRange")]
        public FontSizeRange? FontSizeRange { get; set; }

        [JsonProperty("fontStyle", NullValueHandling = NullValueHandling.Ignore)]
        public ColorElement? FontStyle { get; set; }

        [JsonProperty("fontWeight", NullValueHandling = NullValueHandling.Ignore)]
        public ColorElement? FontWeight { get; set; }

        [JsonProperty("rotate", NullValueHandling = NullValueHandling.Ignore)]
        public Radius? Rotate { get; set; }

        [JsonProperty("spiral", NullValueHandling = NullValueHandling.Ignore)]
        public TypeElement? Spiral { get; set; }

        [JsonProperty("text", NullValueHandling = NullValueHandling.Ignore)]
        public ColorElement? Text { get; set; }
    }
}