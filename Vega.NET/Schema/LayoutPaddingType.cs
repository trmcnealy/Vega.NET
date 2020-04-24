using Newtonsoft.Json;

namespace Vega.Schema
{
    public sealed class LayoutPaddingType
    {
        [JsonProperty("signal", NullValueHandling = NullValueHandling.Ignore)]
        public string Signal { get; set; }

        [JsonProperty("column", NullValueHandling = NullValueHandling.Ignore)]
        public ColumnsElement? Column { get; set; }

        [JsonProperty("row", NullValueHandling = NullValueHandling.Ignore)]
        public ColumnsElement? Row { get; set; }
    }
}