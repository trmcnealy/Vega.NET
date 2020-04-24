using System.Collections.Generic;

using Newtonsoft.Json;

namespace Vega.Schema
{
    public sealed class SignalElement
    {
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        [JsonProperty("name", Required = Required.Always)]
        public string Name { get; set; }

        [JsonProperty("on", NullValueHandling = NullValueHandling.Ignore)]
        public List<SignalOn> On { get; set; }

        [JsonProperty("push", NullValueHandling = NullValueHandling.Ignore)]
        public PushEnum? Push { get; set; }

        [JsonProperty("bind", NullValueHandling = NullValueHandling.Ignore)]
        public Bind Bind { get; set; }

        [JsonProperty("react", NullValueHandling = NullValueHandling.Ignore)]
        public bool? React { get; set; }

        [JsonProperty("update", NullValueHandling = NullValueHandling.Ignore)]
        public string Update { get; set; }

        [JsonProperty("value")]
        public object Value { get; set; }

        [JsonProperty("init", NullValueHandling = NullValueHandling.Ignore)]
        public string Init { get; set; }
    }
}