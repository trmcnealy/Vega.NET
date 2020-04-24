using Newtonsoft.Json;

namespace Vega.Schema
{
    public sealed class Sort
    {
        [JsonProperty("signal", NullValueHandling = NullValueHandling.Ignore)]
        public string Signal { get; set; }

        [JsonProperty("field", NullValueHandling = NullValueHandling.Ignore)]
        public SortField? Field { get; set; }

        [JsonProperty("order", NullValueHandling = NullValueHandling.Ignore)]
        public MarkSortOrder? Order { get; set; }
    }
}