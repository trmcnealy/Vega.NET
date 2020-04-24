using Newtonsoft.Json;

namespace Vega.Schema
{
    public sealed class RangeFieldsType
    {
        [JsonProperty("signal", NullValueHandling = NullValueHandling.Ignore)]
        public string Signal { get; set; }

        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public string Data { get; set; }

        [JsonProperty("field", NullValueHandling = NullValueHandling.Ignore)]
        public TypeElement? Field { get; set; }
    }
}