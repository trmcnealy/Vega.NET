using Newtonsoft.Json;

namespace Vega.Schema
{
    public sealed class CenterType
    {
        [JsonProperty("signal", NullValueHandling = NullValueHandling.Ignore)]
        public string Signal { get; set; }

        [JsonProperty("column", NullValueHandling = NullValueHandling.Ignore)]
        public TickExtraUnion? Column { get; set; }

        [JsonProperty("row", NullValueHandling = NullValueHandling.Ignore)]
        public TickExtraUnion? Row { get; set; }
    }
}