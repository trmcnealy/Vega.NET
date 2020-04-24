namespace Vega.Schema
{
    public struct FormatTypeUnion
    {
        public BoundsType      BoundsType;
        public FormatTypeEnum? Enum;

        public static implicit operator FormatTypeUnion(BoundsType     boundsType) => new FormatTypeUnion { BoundsType = boundsType };
        public static implicit operator FormatTypeUnion(FormatTypeEnum Enum)       => new FormatTypeUnion { Enum       = Enum };
    }
}