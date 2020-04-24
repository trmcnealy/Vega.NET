namespace Vega.Schema
{
    public struct ResolveUnion
    {
        public BoundsType   BoundsType;
        public ResolveEnum? Enum;

        public static implicit operator ResolveUnion(BoundsType  boundsType) => new ResolveUnion { BoundsType = boundsType };
        public static implicit operator ResolveUnion(ResolveEnum Enum)       => new ResolveUnion { Enum       = Enum };
    }
}