namespace Vega.Schema
{
    public struct TickBand
    {
        public BoundsType    BoundsType;
        public TickBandEnum? Enum;

        public static implicit operator TickBand(BoundsType   boundsType) => new TickBand { BoundsType = boundsType };
        public static implicit operator TickBand(TickBandEnum Enum)       => new TickBand { Enum       = Enum };
    }
}