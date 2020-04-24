namespace Vega.Schema
{
    public struct LabelOverlap
    {
        public bool?             Bool;
        public BoundsType        BoundsType;
        public LabelOverlapEnum? Enum;

        public static implicit operator LabelOverlap(bool             Bool)       => new LabelOverlap { Bool       = Bool };
        public static implicit operator LabelOverlap(BoundsType       boundsType) => new LabelOverlap { BoundsType = boundsType };
        public static implicit operator LabelOverlap(LabelOverlapEnum Enum)       => new LabelOverlap { Enum       = Enum };
    }
}