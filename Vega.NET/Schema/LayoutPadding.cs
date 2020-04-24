namespace Vega.Schema
{
    public struct LayoutPadding
    {
        public double?           Double;
        public LayoutPaddingType Type;

        public static implicit operator LayoutPadding(double            Double) => new LayoutPadding { Double = Double };
        public static implicit operator LayoutPadding(LayoutPaddingType Type)   => new LayoutPadding { Type   = Type };
    }
}