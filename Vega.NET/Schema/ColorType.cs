using Newtonsoft.Json;

namespace Vega.Schema
{
    public sealed class ColorType
    {
        [JsonProperty("b", NullValueHandling = NullValueHandling.Ignore)]
        public AngleUnion? B { get; set; }

        [JsonProperty("g", NullValueHandling = NullValueHandling.Ignore)]
        public AngleUnion? G { get; set; }

        [JsonProperty("r", NullValueHandling = NullValueHandling.Ignore)]
        public AngleUnion? R { get; set; }

        [JsonProperty("h", NullValueHandling = NullValueHandling.Ignore)]
        public AngleUnion? H { get; set; }

        [JsonProperty("l", NullValueHandling = NullValueHandling.Ignore)]
        public AngleUnion? L { get; set; }

        [JsonProperty("s", NullValueHandling = NullValueHandling.Ignore)]
        public AngleUnion? S { get; set; }

        [JsonProperty("a", NullValueHandling = NullValueHandling.Ignore)]
        public AngleUnion? A { get; set; }

        [JsonProperty("c", NullValueHandling = NullValueHandling.Ignore)]
        public AngleUnion? C { get; set; }
    }
}