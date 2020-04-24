namespace Vega.Schema
{
    public struct IntervalUnion
    {
        public BoundsType     BoundsType;
        public TickCountEnum? Enum;

        public static implicit operator IntervalUnion(BoundsType    boundsType) => new IntervalUnion { BoundsType = boundsType };
        public static implicit operator IntervalUnion(TickCountEnum Enum)       => new IntervalUnion { Enum       = Enum };
    }
}