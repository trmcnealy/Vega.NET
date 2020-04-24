namespace Vega.Schema
{
    public struct AsA
    {
        public BoundsType BoundsType;
        public string     String;

        public static implicit operator AsA(BoundsType boundsType) => new AsA { BoundsType = boundsType };
        public static implicit operator AsA(string     String)     => new AsA { String     = String };
        public                          bool IsNull                => BoundsType == null && String == null;
    }
}