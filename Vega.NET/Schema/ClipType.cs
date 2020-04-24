using Newtonsoft.Json;

namespace Vega.Schema
{
    public sealed class ClipType
    {
        [JsonProperty("signal", NullValueHandling = NullValueHandling.Ignore)]
        public string Signal { get; set; }

        [JsonProperty("path", NullValueHandling = NullValueHandling.Ignore)]
        public TypeElement? Path { get; set; }

        [JsonProperty("sphere", NullValueHandling = NullValueHandling.Ignore)]
        public TypeElement? Sphere { get; set; }
    }
}