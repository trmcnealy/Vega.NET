namespace Vega.Schema
{
    public struct GridAlignUnion
    {
        public BoundsType BoundsType;
        public AlignEnum? Enum;

        public static implicit operator GridAlignUnion(BoundsType boundsType) => new GridAlignUnion { BoundsType = boundsType };
        public static implicit operator GridAlignUnion(AlignEnum  Enum)       => new GridAlignUnion { Enum       = Enum };
    }
}