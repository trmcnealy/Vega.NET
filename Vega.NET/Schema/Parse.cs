using Newtonsoft.Json;

namespace Vega.Schema
{
    public sealed class Parse
    {
        [JsonProperty("signal", NullValueHandling = NullValueHandling.Ignore)]
        public string Signal { get; set; }
    }
}