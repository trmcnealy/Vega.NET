using Newtonsoft.Json;

namespace Vega.Schema
{
    public sealed class Offset
    {
        [JsonProperty("signal", NullValueHandling = NullValueHandling.Ignore)]
        public string Signal { get; set; }

        [JsonProperty("columnFooter", NullValueHandling = NullValueHandling.Ignore)]
        public ColumnsElement? ColumnFooter { get; set; }

        [JsonProperty("columnHeader", NullValueHandling = NullValueHandling.Ignore)]
        public ColumnsElement? ColumnHeader { get; set; }

        [JsonProperty("columnTitle", NullValueHandling = NullValueHandling.Ignore)]
        public ColumnsElement? ColumnTitle { get; set; }

        [JsonProperty("rowFooter", NullValueHandling = NullValueHandling.Ignore)]
        public ColumnsElement? RowFooter { get; set; }

        [JsonProperty("rowHeader", NullValueHandling = NullValueHandling.Ignore)]
        public ColumnsElement? RowHeader { get; set; }

        [JsonProperty("rowTitle", NullValueHandling = NullValueHandling.Ignore)]
        public ColumnsElement? RowTitle { get; set; }
    }
}