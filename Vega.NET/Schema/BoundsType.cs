using Newtonsoft.Json;

namespace Vega.Schema
{
    public sealed class BoundsType
    {
        [JsonProperty("signal", Required = Required.Always)]
        public string Signal { get; set; }
    }
}