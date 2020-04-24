using Newtonsoft.Json;

namespace Vega.Schema
{
    public sealed class Facet
    {
        [JsonProperty("data", Required = Required.Always)]
        public string Data { get; set; }

        [JsonProperty("field", NullValueHandling = NullValueHandling.Ignore)]
        public string Field { get; set; }

        [JsonProperty("name", Required = Required.Always)]
        public string Name { get; set; }

        [JsonProperty("aggregate", NullValueHandling = NullValueHandling.Ignore)]
        public Aggregate Aggregate { get; set; }

        [JsonProperty("groupby", NullValueHandling = NullValueHandling.Ignore)]
        public Value? Groupby { get; set; }
    }
}