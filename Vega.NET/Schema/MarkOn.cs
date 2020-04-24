using Newtonsoft.Json;

namespace Vega.Schema
{
    public sealed class MarkOn
    {
        [JsonProperty("modify", NullValueHandling = NullValueHandling.Ignore)]
        public string Modify { get; set; }

        [JsonProperty("trigger", Required = Required.Always)]
        public string Trigger { get; set; }

        [JsonProperty("values", NullValueHandling = NullValueHandling.Ignore)]
        public string Values { get; set; }
    }
}