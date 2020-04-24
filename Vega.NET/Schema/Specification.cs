using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

using Newtonsoft.Json;

namespace Vega.Schema
{
    public sealed class Specification
    {
        private static readonly Uri schema = new Uri("https://vega.github.io/schema/vega/v5.json");

        [JsonProperty("$schema",
                      Required          = Required.Always)]
        public Uri Schema
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return schema; }
        }

        [JsonProperty("axes", NullValueHandling = NullValueHandling.Ignore)]
        public List<AxeElement> Axes { get; set; }

        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public List<Data> Data { get; set; }

        [JsonProperty("encode", NullValueHandling = NullValueHandling.Ignore)]
        public Encode Encode { get; set; }

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

        [JsonProperty("autosize", NullValueHandling = NullValueHandling.Ignore)]
        public Autosize? Autosize { get; set; }

        [JsonProperty("background", NullValueHandling = NullValueHandling.Ignore)]
        public string Background { get; set; }

        [JsonProperty("config", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, object> Config { get; set; }

        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        [JsonProperty("height", NullValueHandling = NullValueHandling.Ignore)]
        public double? Height { get; set; }

        [JsonProperty("padding", NullValueHandling = NullValueHandling.Ignore)]
        public Padding? Padding { get; set; }

        [JsonProperty("style", NullValueHandling = NullValueHandling.Ignore)]
        public Value? Style { get; set; }

        [JsonProperty("width", NullValueHandling = NullValueHandling.Ignore)]
        public double? Width { get; set; }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Specification FromJson(string json) => JsonConvert.DeserializeObject<Specification>(json, Converter.Settings);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public string ToJson() => JsonConvert.SerializeObject(this, Converter.Settings);
    }
}
