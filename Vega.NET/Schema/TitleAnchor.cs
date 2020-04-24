namespace Vega.Schema
{
    public struct TitleAnchor
    {
        public ColumnTitleAnchorEnum? Enum;
        public ColumnTitleAnchorType  Type;

        public static implicit operator TitleAnchor(ColumnTitleAnchorEnum Enum) => new TitleAnchor { Enum = Enum };
        public static implicit operator TitleAnchor(ColumnTitleAnchorType Type) => new TitleAnchor { Type = Type };
    }
}