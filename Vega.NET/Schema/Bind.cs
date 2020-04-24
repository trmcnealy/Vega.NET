using System.Collections.Generic;

using Newtonsoft.Json;

namespace Vega.Schema
{
    public sealed class Bind
    {
        [JsonProperty("debounce", NullValueHandling = NullValueHandling.Ignore)]
        public double? Debounce { get; set; }

        [JsonProperty("element", NullValueHandling = NullValueHandling.Ignore)]
        public string Element { get; set; }

        [JsonProperty("input", Required = Required.AllowNull)]
        public object Input { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("labels", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Labels { get; set; }

        [JsonProperty("options", NullValueHandling = NullValueHandling.Ignore)]
        public List<object> Options { get; set; }

        [JsonProperty("max", NullValueHandling = NullValueHandling.Ignore)]
        public double? Max { get; set; }

        [JsonProperty("min", NullValueHandling = NullValueHandling.Ignore)]
        public double? Min { get; set; }

        [JsonProperty("step", NullValueHandling = NullValueHandling.Ignore)]
        public double? Step { get; set; }
    }
}