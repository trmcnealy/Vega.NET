using System.Collections.Generic;

using Newtonsoft.Json;

namespace Vega.Schema
{
    public sealed class Aggregate
    {
        [JsonProperty("as", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> As { get; set; }

        [JsonProperty("cross", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Cross { get; set; }

        [JsonProperty("fields", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Fields { get; set; }

        [JsonProperty("ops", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Ops { get; set; }
    }
}