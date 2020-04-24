using System.Collections.Generic;

using Newtonsoft.Json;

namespace Vega.Schema
{
    public sealed class DomainColorElement
    {
        [JsonProperty("test", NullValueHandling = NullValueHandling.Ignore)]
        public string Test { get; set; }

        [JsonProperty("scale", NullValueHandling = NullValueHandling.Ignore)]
        public Scale? Scale { get; set; }

        [JsonProperty("signal", NullValueHandling = NullValueHandling.Ignore)]
        public string Signal { get; set; }

        [JsonProperty("value")]
        public object Value { get; set; }

        [JsonProperty("field", NullValueHandling = NullValueHandling.Ignore)]
        public Scale? Field { get; set; }

        [JsonProperty("range", NullValueHandling = NullValueHandling.Ignore)]
        public Band? Range { get; set; }

        [JsonProperty("band")]
        public object Band { get; set; }

        [JsonProperty("offset")]
        public object Offset { get; set; }

        [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        public double? Count { get; set; }

        [JsonProperty("gradient", NullValueHandling = NullValueHandling.Ignore)]
        public Scale? Gradient { get; set; }

        [JsonProperty("start", NullValueHandling = NullValueHandling.Ignore)]
        public List<double> Start { get; set; }

        [JsonProperty("stop", NullValueHandling = NullValueHandling.Ignore)]
        public List<double> Stop { get; set; }

        [JsonProperty("color", NullValueHandling = NullValueHandling.Ignore)]
        public ColorType Color { get; set; }
    }
}