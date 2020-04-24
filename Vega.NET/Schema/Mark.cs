using System.Collections.Generic;

using Newtonsoft.Json;

namespace Vega.Schema
{
    public sealed class Mark
    {
        [JsonProperty("from", NullValueHandling = NullValueHandling.Ignore)]
        public From From { get; set; }

        [JsonProperty("type", Required = Required.Always)]
        public string Type { get; set; }

        [JsonProperty("clip", NullValueHandling = NullValueHandling.Ignore)]
        public Clip? Clip { get; set; }

        [JsonProperty("encode", NullValueHandling = NullValueHandling.Ignore)]
        public Encode Encode { get; set; }

        [JsonProperty("interactive", NullValueHandling = NullValueHandling.Ignore)]
        public TickExtraUnion? Interactive { get; set; }

        [JsonProperty("key", NullValueHandling = NullValueHandling.Ignore)]
        public string Key { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("on", NullValueHandling = NullValueHandling.Ignore)]
        public List<MarkOn> On { get; set; }

        [JsonProperty("role", NullValueHandling = NullValueHandling.Ignore)]
        public string Role { get; set; }

        [JsonProperty("sort", NullValueHandling = NullValueHandling.Ignore)]
        public MarkSort Sort { get; set; }

        [JsonProperty("style", NullValueHandling = NullValueHandling.Ignore)]
        public Value? Style { get; set; }

        [JsonProperty("transform", NullValueHandling = NullValueHandling.Ignore)]
        public List<MarkTransform> Transform { get; set; }

        [JsonProperty("axes", NullValueHandling = NullValueHandling.Ignore)]
        public List<AxeElement> Axes { get; set; }

        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public List<Data> Data { get; set; }

        [JsonProperty("layout", NullValueHandling = NullValueHandling.Ignore)]
        public Layout Layout { get; set; }

        [JsonProperty("legends", NullValueHandling = NullValueHandling.Ignore)]
        public List<LegendElement> Legends { get; set; }

        [JsonProperty("marks", NullValueHandling = NullValueHandling.Ignore)]
        public List<Mark> Marks { get; set; }

        [JsonProperty("projections", NullValueHandling = NullValueHandling.Ignore)]
        public List<ProjectionElement> Projections { get; set; }

        [JsonProperty("scales", NullValueHandling = NullValueHandling.Ignore)]
        public List<ScaleElement> Scales { get; set; }

        [JsonProperty("signals", NullValueHandling = NullValueHandling.Ignore)]
        public List<SignalElement> Signals { get; set; }

        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public MarkTitle? Title { get; set; }

        [JsonProperty("usermeta", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, object> Usermeta { get; set; }
    }
}