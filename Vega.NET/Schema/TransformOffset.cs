namespace Vega.Schema
{
    public struct TransformOffset
    {
        public BoundsType  BoundsType;
        public OffsetEnum? Enum;

        public static implicit operator TransformOffset(BoundsType boundsType) => new TransformOffset { BoundsType = boundsType };
        public static implicit operator TransformOffset(OffsetEnum Enum)       => new TransformOffset { Enum       = Enum };
    }
}