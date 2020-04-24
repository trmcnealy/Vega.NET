namespace Vega.Schema
{
    public struct LayoutAlign
    {
        public AlignEnum?      Enum;
        public LayoutAlignType Type;

        public static implicit operator LayoutAlign(AlignEnum       Enum) => new LayoutAlign { Enum = Enum };
        public static implicit operator LayoutAlign(LayoutAlignType Type) => new LayoutAlign { Type = Type };
    }
}