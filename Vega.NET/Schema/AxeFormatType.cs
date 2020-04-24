using Newtonsoft.Json;

namespace Vega.Schema
{
    public sealed class AxeFormatType
    {
        [JsonProperty("date", NullValueHandling = NullValueHandling.Ignore)]
        public string Date { get; set; }

        [JsonProperty("day", NullValueHandling = NullValueHandling.Ignore)]
        public string Day { get; set; }

        [JsonProperty("hours", NullValueHandling = NullValueHandling.Ignore)]
        public string Hours { get; set; }

        [JsonProperty("milliseconds", NullValueHandling = NullValueHandling.Ignore)]
        public string Milliseconds { get; set; }

        [JsonProperty("minutes", NullValueHandling = NullValueHandling.Ignore)]
        public string Minutes { get; set; }

        [JsonProperty("month", NullValueHandling = NullValueHandling.Ignore)]
        public string Month { get; set; }

        [JsonProperty("quarter", NullValueHandling = NullValueHandling.Ignore)]
        public string Quarter { get; set; }

        [JsonProperty("seconds", NullValueHandling = NullValueHandling.Ignore)]
        public string Seconds { get; set; }

        [JsonProperty("week", NullValueHandling = NullValueHandling.Ignore)]
        public string Week { get; set; }

        [JsonProperty("year", NullValueHandling = NullValueHandling.Ignore)]
        public string Year { get; set; }

        [JsonProperty("signal", NullValueHandling = NullValueHandling.Ignore)]
        public string Signal { get; set; }
    }
}