using Newtonsoft.Json;

namespace Vega.Schema
{
    public sealed class LayoutAlignType
    {
        [JsonProperty("signal", NullValueHandling = NullValueHandling.Ignore)]
        public string Signal { get; set; }

        [JsonProperty("column", NullValueHandling = NullValueHandling.Ignore)]
        public GridAlignUnion? Column { get; set; }

        [JsonProperty("row", NullValueHandling = NullValueHandling.Ignore)]
        public GridAlignUnion? Row { get; set; }
    }
}