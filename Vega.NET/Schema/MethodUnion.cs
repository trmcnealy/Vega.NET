namespace Vega.Schema
{
    public struct MethodUnion
    {
        public BoundsType  BoundsType;
        public MethodEnum? Enum;

        public static implicit operator MethodUnion(BoundsType boundsType) => new MethodUnion { BoundsType = boundsType };
        public static implicit operator MethodUnion(MethodEnum Enum)       => new MethodUnion { Enum       = Enum };
    }
}