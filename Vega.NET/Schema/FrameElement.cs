namespace Vega.Schema
{
    public struct FrameElement
    {
        public BoundsType BoundsType;
        public double?    Double;

        public static implicit operator FrameElement(BoundsType boundsType) => new FrameElement { BoundsType = boundsType };
        public static implicit operator FrameElement(double     Double)     => new FrameElement { Double     = Double };
        public                          bool IsNull                         => BoundsType == null && Double == null;
    }
}