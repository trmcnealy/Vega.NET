namespace Vega.Schema
{
    public struct BoundsUnion
    {
        public BoundsType  BoundsType;
        public BoundsEnum? Enum;

        public static implicit operator BoundsUnion(BoundsType boundsType) => new BoundsUnion { BoundsType = boundsType };
        public static implicit operator BoundsUnion(BoundsEnum Enum)       => new BoundsUnion { Enum       = Enum };
    }
}