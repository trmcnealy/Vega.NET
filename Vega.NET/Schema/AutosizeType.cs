using Newtonsoft.Json;

namespace Vega.Schema
{
    public sealed class AutosizeType
    {
        [JsonProperty("contains", NullValueHandling = NullValueHandling.Ignore)]
        public ContainsEnum? Contains { get; set; }

        [JsonProperty("resize", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Resize { get; set; }

        [JsonProperty("type", Required = Required.Always)]
        public AutosizeEnum Type { get; set; }
    }
}