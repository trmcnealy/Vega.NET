using Newtonsoft.Json;

namespace Vega.Schema
{
    public sealed class TextType
    {
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

        [JsonProperty("band")]
        public object Band { get; set; }

        [JsonProperty("offset")]
        public object Offset { get; set; }
    }
}