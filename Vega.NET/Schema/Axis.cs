using Newtonsoft.Json;

namespace Vega.Schema
{
    public sealed class Axis
    {
        [JsonProperty("enter", NullValueHandling = NullValueHandling.Ignore)]
        public EncodeEntry EncodeEntry { get; set; }

        [JsonProperty("exit", NullValueHandling = NullValueHandling.Ignore)]
        public EncodeEntry Exit { get; set; }

        [JsonProperty("hover", NullValueHandling = NullValueHandling.Ignore)]
        public EncodeEntry Hover { get; set; }

        [JsonProperty("interactive", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Interactive { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("style", NullValueHandling = NullValueHandling.Ignore)]
        public Value? Style { get; set; }

        [JsonProperty("update", NullValueHandling = NullValueHandling.Ignore)]
        public EncodeEntry Update { get; set; }
    }
}