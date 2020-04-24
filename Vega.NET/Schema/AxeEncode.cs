using Newtonsoft.Json;

namespace Vega.Schema
{
    public sealed class AxeEncode
    {
        [JsonProperty("axis", NullValueHandling = NullValueHandling.Ignore)]
        public Axis Axis { get; set; }

        [JsonProperty("domain", NullValueHandling = NullValueHandling.Ignore)]
        public Axis Domain { get; set; }

        [JsonProperty("grid", NullValueHandling = NullValueHandling.Ignore)]
        public Axis Grid { get; set; }

        [JsonProperty("labels", NullValueHandling = NullValueHandling.Ignore)]
        public Axis Labels { get; set; }

        [JsonProperty("ticks", NullValueHandling = NullValueHandling.Ignore)]
        public Axis Ticks { get; set; }

        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public Axis Title { get; set; }
    }
}