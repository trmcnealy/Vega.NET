using Newtonsoft.Json;

namespace Vega.Schema
{
    public sealed class NiceNice
    {
        [JsonProperty("signal", NullValueHandling = NullValueHandling.Ignore)]
        public string Signal { get; set; }

        [JsonProperty("interval", NullValueHandling = NullValueHandling.Ignore)]
        public IntervalUnion? Interval { get; set; }

        [JsonProperty("step", NullValueHandling = NullValueHandling.Ignore)]
        public ColumnsElement? Step { get; set; }
    }
}