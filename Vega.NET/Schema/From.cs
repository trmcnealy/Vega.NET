using Newtonsoft.Json;

namespace Vega.Schema
{
    public sealed class From
    {
        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public string Data { get; set; }

        [JsonProperty("facet", NullValueHandling = NullValueHandling.Ignore)]
        public Facet Facet { get; set; }
    }
}