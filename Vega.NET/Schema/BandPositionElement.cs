using Newtonsoft.Json;

namespace Vega.Schema
{
    public sealed class BandPositionElement
    {
        [JsonProperty("test", NullValueHandling = NullValueHandling.Ignore)]
        public string Test { get; set; }

        [JsonProperty("band", NullValueHandling = NullValueHandling.Ignore)]
        public Band? Band { get; set; }

        [JsonProperty("exponent", NullValueHandling = NullValueHandling.Ignore)]
        public BandPosition? Exponent { get; set; }

        [JsonProperty("extra", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Extra { get; set; }

        [JsonProperty("mult", NullValueHandling = NullValueHandling.Ignore)]
        public BandPosition? Mult { get; set; }

        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public BandPosition? Offset { get; set; }

        [JsonProperty("round", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Round { get; set; }

        [JsonProperty("scale", NullValueHandling = NullValueHandling.Ignore)]
        public Scale? Scale { get; set; }

        [JsonProperty("signal", NullValueHandling = NullValueHandling.Ignore)]
        public string Signal { get; set; }

        [JsonProperty("value")]
        public object Value { get; set; }

        [JsonProperty("field", NullValueHandling = NullValueHandling.Ignore)]
        public Scale? Field { get; set; }

        [JsonProperty("range", NullValueHandling = NullValueHandling.Ignore)]
        public Band? Range { get; set; }
    }
}