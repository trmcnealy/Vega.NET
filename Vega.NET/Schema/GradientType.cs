using Newtonsoft.Json;

namespace Vega.Schema
{
    public sealed class GradientType
    {
        [JsonProperty("signal", NullValueHandling = NullValueHandling.Ignore)]
        public string Signal { get; set; }

        [JsonProperty("datum", NullValueHandling = NullValueHandling.Ignore)]
        public Scale? Datum { get; set; }

        [JsonProperty("group", NullValueHandling = NullValueHandling.Ignore)]
        public Scale? Group { get; set; }

        [JsonProperty("level", NullValueHandling = NullValueHandling.Ignore)]
        public double? Level { get; set; }

        [JsonProperty("parent", NullValueHandling = NullValueHandling.Ignore)]
        public Scale? Parent { get; set; }
    }
}