using System.Collections.Generic;

using Newtonsoft.Json;

namespace Vega.Schema
{
    public sealed class Range
    {
        [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        public ColumnsElement? Count { get; set; }

        [JsonProperty("extent", NullValueHandling = NullValueHandling.Ignore)]
        public CenterElement? Extent { get; set; }

        [JsonProperty("scheme", NullValueHandling = NullValueHandling.Ignore)]
        public Scheme? Scheme { get; set; }

        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public string Data { get; set; }

        [JsonProperty("field", NullValueHandling = NullValueHandling.Ignore)]
        public TypeElement? Field { get; set; }

        [JsonProperty("sort", NullValueHandling = NullValueHandling.Ignore)]
        public RangeSort? Sort { get; set; }

        [JsonProperty("fields", NullValueHandling = NullValueHandling.Ignore)]
        public List<RangeFields> Fields { get; set; }

        [JsonProperty("signal", NullValueHandling = NullValueHandling.Ignore)]
        public string Signal { get; set; }

        [JsonProperty("step", NullValueHandling = NullValueHandling.Ignore)]
        public ColumnsElement? Step { get; set; }
    }
}