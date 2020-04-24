using Newtonsoft.Json;

namespace Vega.Schema
{
    public sealed class DomainSortType
    {
        [JsonProperty("field", NullValueHandling = NullValueHandling.Ignore)]
        public TypeElement? Field { get; set; }

        [JsonProperty("op", NullValueHandling = NullValueHandling.Ignore)]
        public TypeElement? Op { get; set; }

        [JsonProperty("order", NullValueHandling = NullValueHandling.Ignore)]
        public OrderElement? Order { get; set; }
    }
}