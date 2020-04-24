using Newtonsoft.Json;

namespace Vega.Schema
{
    public sealed class PaddingType
    {
        [JsonProperty("bottom", NullValueHandling = NullValueHandling.Ignore)]
        public double? Bottom { get; set; }

        [JsonProperty("left", NullValueHandling = NullValueHandling.Ignore)]
        public double? Left { get; set; }

        [JsonProperty("right", NullValueHandling = NullValueHandling.Ignore)]
        public double? Right { get; set; }

        [JsonProperty("top", NullValueHandling = NullValueHandling.Ignore)]
        public double? Top { get; set; }
    }
}