namespace Vega.Schema
{
    public struct ColumnsElement
    {
        public BoundsType BoundsType;
        public double?    Double;

        public static implicit operator ColumnsElement(BoundsType boundsType) => new ColumnsElement { BoundsType = boundsType };
        public static implicit operator ColumnsElement(double     Double)     => new ColumnsElement { Double     = Double };
    }
}