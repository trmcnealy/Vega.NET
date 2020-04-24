using Newtonsoft.Json;

namespace Vega.Schema
{
    public sealed class InterpolateType
    {
        [JsonProperty("signal", NullValueHandling = NullValueHandling.Ignore)]
        public string Signal { get; set; }

        [JsonProperty("gamma", NullValueHandling = NullValueHandling.Ignore)]
        public ColumnsElement? Gamma { get; set; }

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public TypeElement? Type { get; set; }
    }
}