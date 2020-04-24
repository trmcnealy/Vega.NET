namespace Vega.Schema
{
    public struct TitleBand
    {
        public double?       Double;
        public TitleBandType TitleBandType;

        public static implicit operator TitleBand(double        Double)        => new TitleBand { Double        = Double };
        public static implicit operator TitleBand(TitleBandType titleBandType) => new TitleBand { TitleBandType = titleBandType };
        public                          bool IsNull                            => TitleBandType == null && Double == null;
    }
}