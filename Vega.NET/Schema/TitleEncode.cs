using Newtonsoft.Json;

namespace Vega.Schema
{
    public sealed class TitleEncode
    {
        [JsonProperty("enter", NullValueHandling = NullValueHandling.Ignore)]
        public EncodeEntry EncodeEntry { get; set; }

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

        [JsonProperty("group", NullValueHandling = NullValueHandling.Ignore)]
        public Axis Group { get; set; }

        [JsonProperty("subtitle", NullValueHandling = NullValueHandling.Ignore)]
        public Axis Subtitle { get; set; }

        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public Axis Title { get; set; }
    }
}