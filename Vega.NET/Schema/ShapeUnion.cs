namespace Vega.Schema
{
    public struct ShapeUnion
    {
        public BoundsType BoundsType;
        public ShapeEnum? Enum;

        public static implicit operator ShapeUnion(BoundsType boundsType) => new ShapeUnion { BoundsType = boundsType };
        public static implicit operator ShapeUnion(ShapeEnum  Enum)       => new ShapeUnion { Enum       = Enum };
    }
}