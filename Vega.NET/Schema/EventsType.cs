using System.Collections.Generic;

using Newtonsoft.Json;

namespace Vega.Schema
{
    public sealed class EventsType
    {
        [JsonProperty("signal", NullValueHandling = NullValueHandling.Ignore)]
        public string Signal { get; set; }

        [JsonProperty("scale", NullValueHandling = NullValueHandling.Ignore)]
        public string Scale { get; set; }

        [JsonProperty("between", NullValueHandling = NullValueHandling.Ignore)]
        public List<StreamElement> Between { get; set; }

        [JsonProperty("consume", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Consume { get; set; }

        [JsonProperty("debounce", NullValueHandling = NullValueHandling.Ignore)]
        public double? Debounce { get; set; }

        [JsonProperty("filter", NullValueHandling = NullValueHandling.Ignore)]
        public Value? Filter { get; set; }

        [JsonProperty("markname", NullValueHandling = NullValueHandling.Ignore)]
        public string Markname { get; set; }

        [JsonProperty("marktype", NullValueHandling = NullValueHandling.Ignore)]
        public string Marktype { get; set; }

        [JsonProperty("throttle", NullValueHandling = NullValueHandling.Ignore)]
        public double? Throttle { get; set; }

        [JsonProperty("source", NullValueHandling = NullValueHandling.Ignore)]
        public string Source { get; set; }

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        [JsonProperty("stream", NullValueHandling = NullValueHandling.Ignore)]
        public StreamElement Stream { get; set; }

        [JsonProperty("merge", NullValueHandling = NullValueHandling.Ignore)]
        public List<StreamElement> Merge { get; set; }
    }
}