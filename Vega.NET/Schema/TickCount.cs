namespace Vega.Schema
{
    public struct TickCount
    {
        public double?        Double;
        public TickCountEnum? Enum;
        public TickCountType  TickCountType;

        public static implicit operator TickCount(double        Double)        => new TickCount { Double        = Double };
        public static implicit operator TickCount(TickCountEnum Enum)          => new TickCount { Enum          = Enum };
        public static implicit operator TickCount(TickCountType tickCountType) => new TickCount { TickCountType = tickCountType };
    }
}