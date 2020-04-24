using System.Collections.Generic;

using Newtonsoft.Json;

namespace Vega.Schema
{
    public sealed class FormatType
    {
        [JsonProperty("parse", NullValueHandling = NullValueHandling.Ignore)]
        public ParseUnion? Parse { get; set; }

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public TypeElement? Type { get; set; }

        [JsonProperty("copy", NullValueHandling = NullValueHandling.Ignore)]
        public TickExtraUnion? Copy { get; set; }

        [JsonProperty("property", NullValueHandling = NullValueHandling.Ignore)]
        public TypeElement? Property { get; set; }

        [JsonProperty("header", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Header { get; set; }

        [JsonProperty("delimiter", NullValueHandling = NullValueHandling.Ignore)]
        public string Delimiter { get; set; }

        [JsonProperty("feature", NullValueHandling = NullValueHandling.Ignore)]
        public TypeElement? Feature { get; set; }

        [JsonProperty("filter")]
        public FilterEnum? Filter { get; set; }

        [JsonProperty("mesh", NullValueHandling = NullValueHandling.Ignore)]
        public TypeElement? Mesh { get; set; }

        [JsonProperty("signal", NullValueHandling = NullValueHandling.Ignore)]
        public string Signal { get; set; }
    }
}