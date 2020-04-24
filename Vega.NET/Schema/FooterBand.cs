namespace Vega.Schema
{
    public struct FooterBand
    {
        public double?        Double;
        public FooterBandType FooterBandType;

        public static implicit operator FooterBand(double         Double)         => new FooterBand { Double         = Double };
        public static implicit operator FooterBand(FooterBandType footerBandType) => new FooterBand { FooterBandType = footerBandType };
        public                          bool IsNull                               => FooterBandType == null && Double == null;
    }
}