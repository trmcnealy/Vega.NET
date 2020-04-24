using Newtonsoft.Json;

namespace Vega.Schema
{
    public sealed class SignalOn
    {
        [JsonProperty("events", Required = Required.Always)]
        public Events Events { get; set; }

        [JsonProperty("force", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Force { get; set; }

        [JsonProperty("encode", NullValueHandling = NullValueHandling.Ignore)]
        public string Encode { get; set; }

        [JsonProperty("update", NullValueHandling = NullValueHandling.Ignore)]
        public Update? Update { get; set; }
    }
}