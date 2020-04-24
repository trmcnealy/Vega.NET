namespace Vega.Schema
{
    public struct TransformOp
    {
        public BoundsType       BoundsType;
        public TransformOpEnum? Enum;

        public static implicit operator TransformOp(BoundsType      boundsType) => new TransformOp { BoundsType = boundsType };
        public static implicit operator TransformOp(TransformOpEnum Enum)       => new TransformOp { Enum       = Enum };
    }
}