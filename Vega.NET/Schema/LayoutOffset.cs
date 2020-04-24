namespace Vega.Schema
{
    public struct LayoutOffset
    {
        public double? Double;
        public Offset  Offset;

        public static implicit operator LayoutOffset(double Double) => new LayoutOffset { Double = Double };
        public static implicit operator LayoutOffset(Offset offset) => new LayoutOffset { Offset = offset };
    }
}