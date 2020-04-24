using System.Collections.Generic;

using Newtonsoft.Json;

namespace Vega.Schema
{
    public sealed class Domain
    {
        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public string Data { get; set; }

        [JsonProperty("field", NullValueHandling = NullValueHandling.Ignore)]
        public TypeElement? Field { get; set; }

        [JsonProperty("sort", NullValueHandling = NullValueHandling.Ignore)]
        public DomainSort? Sort { get; set; }

        [JsonProperty("fields", NullValueHandling = NullValueHandling.Ignore)]
        public List<DomainFields> Fields { get; set; }

        [JsonProperty("signal", NullValueHandling = NullValueHandling.Ignore)]
        public string Signal { get; set; }
    }
}