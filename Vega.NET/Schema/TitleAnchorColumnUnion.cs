namespace Vega.Schema
{
    public struct TitleAnchorColumnUnion
    {
        public BoundsType             BoundsType;
        public ColumnTitleAnchorEnum? Enum;

        public static implicit operator TitleAnchorColumnUnion(BoundsType            boundsType) => new TitleAnchorColumnUnion { BoundsType = boundsType };
        public static implicit operator TitleAnchorColumnUnion(ColumnTitleAnchorEnum Enum)       => new TitleAnchorColumnUnion { Enum       = Enum };
    }
}