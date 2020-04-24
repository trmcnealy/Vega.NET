namespace Vega.Schema
{
    public struct ColorElement
    {
        public GeoJson GeoJson;
        public string  String;

        public static implicit operator ColorElement(GeoJson geoJson) => new ColorElement { GeoJson = geoJson };
        public static implicit operator ColorElement(string  String)  => new ColorElement { String  = String };
    }
}