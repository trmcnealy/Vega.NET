using Newtonsoft.Json;

namespace Vega.Schema
{
    public sealed class UpdateType
    {
        [JsonProperty("as", NullValueHandling = NullValueHandling.Ignore)]
        public string As { get; set; }

        [JsonProperty("expr", NullValueHandling = NullValueHandling.Ignore)]
        public string Expr { get; set; }

        [JsonProperty("signal", NullValueHandling = NullValueHandling.Ignore)]
        public string Signal { get; set; }

        [JsonProperty("value")]
        public object Value { get; set; }
    }
}