namespace Vega.Schema
{
    public struct HeaderBand
    {
        public double?        Double;
        public HeaderBandType HeaderBandType;

        public static implicit operator HeaderBand(double         Double)         => new HeaderBand { Double         = Double };
        public static implicit operator HeaderBand(HeaderBandType headerBandType) => new HeaderBand { HeaderBandType = headerBandType };
        public                          bool IsNull                               => HeaderBandType == null && Double == null;
    }
}