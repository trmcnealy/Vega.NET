namespace Vega.Schema
{
    public struct TitleOrient
    {
        public BoundsType      BoundsType;
        public BoundsTypeEnum? Enum;

        public static implicit operator TitleOrient(BoundsType     boundsType) => new TitleOrient { BoundsType = boundsType };
        public static implicit operator TitleOrient(BoundsTypeEnum Enum)       => new TitleOrient { Enum       = Enum };
    }
}