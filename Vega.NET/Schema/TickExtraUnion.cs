namespace Vega.Schema
{
    public struct TickExtraUnion
    {
        public bool?      Bool;
        public BoundsType BoundsType;

        public static implicit operator TickExtraUnion(bool       Bool)       => new TickExtraUnion { Bool       = Bool };
        public static implicit operator TickExtraUnion(BoundsType boundsType) => new TickExtraUnion { BoundsType = boundsType };
    }
}