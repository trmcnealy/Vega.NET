using Newtonsoft.Json;

namespace Vega.Schema
{
    public sealed class ScaleElement
    {
        [JsonProperty("domain", NullValueHandling = NullValueHandling.Ignore)]
        public ScaleDomain? Domain { get; set; }

        [JsonProperty("domainMax", NullValueHandling = NullValueHandling.Ignore)]
        public ColumnsElement? DomainMax { get; set; }

        [JsonProperty("domainMid", NullValueHandling = NullValueHandling.Ignore)]
        public ColumnsElement? DomainMid { get; set; }

        [JsonProperty("domainMin", NullValueHandling = NullValueHandling.Ignore)]
        public ColumnsElement? DomainMin { get; set; }

        [JsonProperty("domainRaw")]
        public DomainRaw? DomainRaw { get; set; }

        [JsonProperty("name", Required = Required.Always)]
        public string Name { get; set; }

        [JsonProperty("nice", NullValueHandling = NullValueHandling.Ignore)]
        public Nice? Nice { get; set; }

        [JsonProperty("reverse", NullValueHandling = NullValueHandling.Ignore)]
        public TickExtraUnion? Reverse { get; set; }

        [JsonProperty("round", NullValueHandling = NullValueHandling.Ignore)]
        public TickExtraUnion? Round { get; set; }

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public ScaleTypeEnum? Type { get; set; }

        [JsonProperty("domainImplicit", NullValueHandling = NullValueHandling.Ignore)]
        public TickExtraUnion? DomainImplicit { get; set; }

        [JsonProperty("interpolate", NullValueHandling = NullValueHandling.Ignore)]
        public Interpolate? Interpolate { get; set; }

        [JsonProperty("range", NullValueHandling = NullValueHandling.Ignore)]
        public RangeUnion? Range { get; set; }

        [JsonProperty("align", NullValueHandling = NullValueHandling.Ignore)]
        public ColumnsElement? Align { get; set; }

        [JsonProperty("padding", NullValueHandling = NullValueHandling.Ignore)]
        public ColumnsElement? Padding { get; set; }

        [JsonProperty("paddingInner", NullValueHandling = NullValueHandling.Ignore)]
        public ColumnsElement? PaddingInner { get; set; }

        [JsonProperty("paddingOuter", NullValueHandling = NullValueHandling.Ignore)]
        public ColumnsElement? PaddingOuter { get; set; }

        [JsonProperty("zero", NullValueHandling = NullValueHandling.Ignore)]
        public TickExtraUnion? Zero { get; set; }

        [JsonProperty("bins", NullValueHandling = NullValueHandling.Ignore)]
        public Bins? Bins { get; set; }

        [JsonProperty("clamp", NullValueHandling = NullValueHandling.Ignore)]
        public TickExtraUnion? Clamp { get; set; }

        [JsonProperty("base", NullValueHandling = NullValueHandling.Ignore)]
        public ColumnsElement? Base { get; set; }

        [JsonProperty("exponent", NullValueHandling = NullValueHandling.Ignore)]
        public ColumnsElement? Exponent { get; set; }

        [JsonProperty("constant", NullValueHandling = NullValueHandling.Ignore)]
        public ColumnsElement? Constant { get; set; }
    }
}