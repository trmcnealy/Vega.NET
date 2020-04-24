namespace Vega.Schema
{
    public struct TransformOrient
    {
        public BoundsType           BoundsType;
        public TransformOrientEnum? Enum;

        public static implicit operator TransformOrient(BoundsType          boundsType) => new TransformOrient { BoundsType = boundsType };
        public static implicit operator TransformOrient(TransformOrientEnum Enum)       => new TransformOrient { Enum       = Enum };
    }
}