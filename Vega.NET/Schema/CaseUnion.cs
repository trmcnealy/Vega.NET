namespace Vega.Schema
{
    public struct CaseUnion
    {
        public BoundsType BoundsType;
        public CaseEnum?  Enum;

        public static implicit operator CaseUnion(BoundsType boundsType) => new CaseUnion { BoundsType = boundsType };
        public static implicit operator CaseUnion(CaseEnum   Enum)       => new CaseUnion { Enum       = Enum };
    }
}