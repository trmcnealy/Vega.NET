using Newtonsoft.Json;

namespace Vega.Schema
{
    public sealed class LegendEncode
    {
        [JsonProperty("entries", NullValueHandling = NullValueHandling.Ignore)]
        public Axis Entries { get; set; }

        [JsonProperty("gradient", NullValueHandling = NullValueHandling.Ignore)]
        public Axis Gradient { get; set; }

        [JsonProperty("labels", NullValueHandling = NullValueHandling.Ignore)]
        public Axis Labels { get; set; }

        [JsonProperty("legend", NullValueHandling = NullValueHandling.Ignore)]
        public Axis Legend { get; set; }

        [JsonProperty("symbols", NullValueHandling = NullValueHandling.Ignore)]
        public Axis Symbols { get; set; }

        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public Axis Title { get; set; }
    }
}