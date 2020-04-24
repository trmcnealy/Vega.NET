namespace Vega.Schema
{
    public struct LegendOrient
    {
        public BoundsType        BoundsType;
        public LegendOrientEnum? Enum;

        public static implicit operator LegendOrient(BoundsType       boundsType) => new LegendOrient { BoundsType = boundsType };
        public static implicit operator LegendOrient(LegendOrientEnum Enum)       => new LegendOrient { Enum       = Enum };
    }
}