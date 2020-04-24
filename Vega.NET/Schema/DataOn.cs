using Newtonsoft.Json;

namespace Vega.Schema
{
    public sealed class DataOn
    {
        [JsonProperty("insert", NullValueHandling = NullValueHandling.Ignore)]
        public string Insert { get; set; }

        [JsonProperty("modify", NullValueHandling = NullValueHandling.Ignore)]
        public string Modify { get; set; }

        [JsonProperty("remove", NullValueHandling = NullValueHandling.Ignore)]
        public Remove? Remove { get; set; }

        [JsonProperty("toggle", NullValueHandling = NullValueHandling.Ignore)]
        public string Toggle { get; set; }

        [JsonProperty("trigger", Required = Required.Always)]
        public string Trigger { get; set; }

        [JsonProperty("values", NullValueHandling = NullValueHandling.Ignore)]
        public string Values { get; set; }
    }
}