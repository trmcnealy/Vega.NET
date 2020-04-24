namespace Vega.Schema
{
    public struct TimezoneUnion
    {
        public BoundsType    BoundsType;
        public TimezoneEnum? Enum;

        public static implicit operator TimezoneUnion(BoundsType   boundsType) => new TimezoneUnion { BoundsType = boundsType };
        public static implicit operator TimezoneUnion(TimezoneEnum Enum)       => new TimezoneUnion { Enum       = Enum };
    }
}