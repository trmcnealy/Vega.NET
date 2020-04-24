using System.Collections.Generic;

using Newtonsoft.Json;

namespace Vega.Schema
{
    public sealed class Data
    {
        [JsonProperty("name", Required = Required.Always)]
        public string Name { get; set; }

        [JsonProperty("on", NullValueHandling = NullValueHandling.Ignore)]
        public List<DataOn> On { get; set; }

        [JsonProperty("transform", NullValueHandling = NullValueHandling.Ignore)]
        public List<Transform> Transform { get; set; }

        [JsonProperty("source", NullValueHandling = NullValueHandling.Ignore)]
        public Value? Source { get; set; }

        [JsonProperty("async", NullValueHandling = NullValueHandling.Ignore)]
        public TickExtraUnion? Async { get; set; }

        [JsonProperty("format", NullValueHandling = NullValueHandling.Ignore)]
        public FormatType Format { get; set; }

        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public TypeElement? Url { get; set; }

        [JsonProperty("values", NullValueHandling = NullValueHandling.Ignore)]
        public object Values { get; set; }
    }
}