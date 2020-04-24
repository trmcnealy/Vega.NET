using Newtonsoft.Json;

namespace Vega.Schema
{
    public sealed class ForceElement
    {
        [JsonProperty("force", Required = Required.Always)]
        public ForceEnum Force { get; set; }

        [JsonProperty("x", NullValueHandling = NullValueHandling.Ignore)]
        public XUnion? X { get; set; }

        [JsonProperty("y", NullValueHandling = NullValueHandling.Ignore)]
        public XUnion? Y { get; set; }

        [JsonProperty("iterations", NullValueHandling = NullValueHandling.Ignore)]
        public ColumnsElement? Iterations { get; set; }

        [JsonProperty("radius", NullValueHandling = NullValueHandling.Ignore)]
        public Radius? Radius { get; set; }

        [JsonProperty("strength", NullValueHandling = NullValueHandling.Ignore)]
        public StrengthUnion? Strength { get; set; }

        [JsonProperty("distanceMax", NullValueHandling = NullValueHandling.Ignore)]
        public ColumnsElement? DistanceMax { get; set; }

        [JsonProperty("distanceMin", NullValueHandling = NullValueHandling.Ignore)]
        public ColumnsElement? DistanceMin { get; set; }

        [JsonProperty("theta", NullValueHandling = NullValueHandling.Ignore)]
        public ColumnsElement? Theta { get; set; }

        [JsonProperty("distance", NullValueHandling = NullValueHandling.Ignore)]
        public Radius? Distance { get; set; }

        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public ColorElement? Id { get; set; }

        [JsonProperty("links", NullValueHandling = NullValueHandling.Ignore)]
        public string Links { get; set; }
    }
}