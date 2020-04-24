using Newtonsoft.Json;

namespace Vega.Schema
{
    public sealed class Distribution
    {
        [JsonProperty("function", Required = Required.Always)]
        public FunctionEnum FunctionEnum { get; set; }

        [JsonProperty("mean", NullValueHandling = NullValueHandling.Ignore)]
        public ColumnsElement? Mean { get; set; }

        [JsonProperty("stdev", NullValueHandling = NullValueHandling.Ignore)]
        public ColumnsElement? Stdev { get; set; }

        [JsonProperty("max", NullValueHandling = NullValueHandling.Ignore)]
        public ColumnsElement? Max { get; set; }

        [JsonProperty("min", NullValueHandling = NullValueHandling.Ignore)]
        public ColumnsElement? Min { get; set; }

        [JsonProperty("bandwidth", NullValueHandling = NullValueHandling.Ignore)]
        public ColumnsElement? Bandwidth { get; set; }

        [JsonProperty("field", NullValueHandling = NullValueHandling.Ignore)]
        public ColorElement? Field { get; set; }

        [JsonProperty("from", NullValueHandling = NullValueHandling.Ignore)]
        public string From { get; set; }

        [JsonProperty("distributions", NullValueHandling = NullValueHandling.Ignore)]
        public Values? Distributions { get; set; }

        [JsonProperty("weights", NullValueHandling = NullValueHandling.Ignore)]
        public CenterElement? Weights { get; set; }
    }
}