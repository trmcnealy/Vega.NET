using Newtonsoft.Json;

namespace Vega.Schema
{
    public sealed class BinsType
    {
        [JsonProperty("start", NullValueHandling = NullValueHandling.Ignore)]
        public ColumnsElement? Start { get; set; }

        [JsonProperty("step", NullValueHandling = NullValueHandling.Ignore)]
        public ColumnsElement? Step { get; set; }

        [JsonProperty("stop", NullValueHandling = NullValueHandling.Ignore)]
        public ColumnsElement? Stop { get; set; }

        [JsonProperty("signal", NullValueHandling = NullValueHandling.Ignore)]
        public string Signal { get; set; }
    }
}