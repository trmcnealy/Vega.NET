using Newtonsoft.Json;

namespace Vega.Schema
{
    public sealed class ProjectionElement
    {
        [JsonProperty("center", NullValueHandling = NullValueHandling.Ignore)]
        public CenterElement? Center { get; set; }

        [JsonProperty("clipAngle", NullValueHandling = NullValueHandling.Ignore)]
        public ColumnsElement? ClipAngle { get; set; }

        [JsonProperty("clipExtent", NullValueHandling = NullValueHandling.Ignore)]
        public Extent? ClipExtent { get; set; }

        [JsonProperty("extent", NullValueHandling = NullValueHandling.Ignore)]
        public Extent? Extent { get; set; }

        [JsonProperty("fit", NullValueHandling = NullValueHandling.Ignore)]
        public Fit? Fit { get; set; }

        [JsonProperty("name", Required = Required.Always)]
        public string Name { get; set; }

        [JsonProperty("parallels", NullValueHandling = NullValueHandling.Ignore)]
        public CenterElement? Parallels { get; set; }

        [JsonProperty("pointRadius", NullValueHandling = NullValueHandling.Ignore)]
        public ColumnsElement? PointRadius { get; set; }

        [JsonProperty("precision", NullValueHandling = NullValueHandling.Ignore)]
        public ColumnsElement? Precision { get; set; }

        [JsonProperty("rotate", NullValueHandling = NullValueHandling.Ignore)]
        public CenterElement? Rotate { get; set; }

        [JsonProperty("scale", NullValueHandling = NullValueHandling.Ignore)]
        public ColumnsElement? Scale { get; set; }

        [JsonProperty("size", NullValueHandling = NullValueHandling.Ignore)]
        public CenterElement? Size { get; set; }

        [JsonProperty("translate", NullValueHandling = NullValueHandling.Ignore)]
        public CenterElement? Translate { get; set; }

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public TypeElement? Type { get; set; }
    }
}