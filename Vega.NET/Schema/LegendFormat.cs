namespace Vega.Schema
{
    public struct LegendFormat
    {
        public string           String;
        public LegendFormatType Type;

        public static implicit operator LegendFormat(string           String) => new LegendFormat { String = String };
        public static implicit operator LegendFormat(LegendFormatType Type)   => new LegendFormat { Type   = Type };
    }
}