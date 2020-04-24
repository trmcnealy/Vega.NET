using Newtonsoft.Json;

namespace Vega.Schema
{
    public sealed class Encode
    {
        [JsonProperty("enter", NullValueHandling = NullValueHandling.Ignore)]
        public EncodeEntry Enter { get; set; }

        [JsonProperty("exit", NullValueHandling = NullValueHandling.Ignore)]
        public EncodeEntry Exit { get; set; }

        [JsonProperty("hover", NullValueHandling = NullValueHandling.Ignore)]
        public EncodeEntry Hover { get; set; }

        [JsonProperty("leave", NullValueHandling = NullValueHandling.Ignore)]
        public EncodeEntry Leave { get; set; }

        [JsonProperty("release", NullValueHandling = NullValueHandling.Ignore)]
        public EncodeEntry Release { get; set; }

        [JsonProperty("select", NullValueHandling = NullValueHandling.Ignore)]
        public EncodeEntry Select { get; set; }

        [JsonProperty("update", NullValueHandling = NullValueHandling.Ignore)]
        public EncodeEntry Update { get; set; }
    }
}