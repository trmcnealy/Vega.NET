using Newtonsoft.Json;

namespace Vega.Schema
{
    public sealed class FieldsType
    {
        [JsonProperty("signal", NullValueHandling = NullValueHandling.Ignore)]
        public string Signal { get; set; }

        [JsonProperty("as", NullValueHandling = NullValueHandling.Ignore)]
        public string As { get; set; }

        [JsonProperty("field", NullValueHandling = NullValueHandling.Ignore)]
        public string Field { get; set; }

        [JsonProperty("expr", NullValueHandling = NullValueHandling.Ignore)]
        public string Expr { get; set; }
    }
}