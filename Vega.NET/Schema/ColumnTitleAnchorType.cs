using Newtonsoft.Json;

namespace Vega.Schema
{
    public sealed class ColumnTitleAnchorType
    {
        [JsonProperty("signal", NullValueHandling = NullValueHandling.Ignore)]
        public string Signal { get; set; }

        [JsonProperty("column", NullValueHandling = NullValueHandling.Ignore)]
        public TitleAnchorColumnUnion? Column { get; set; }

        [JsonProperty("row", NullValueHandling = NullValueHandling.Ignore)]
        public TitleAnchorColumnUnion? Row { get; set; }
    }
}