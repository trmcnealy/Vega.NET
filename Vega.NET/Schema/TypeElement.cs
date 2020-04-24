namespace Vega.Schema
{
    public struct TypeElement
    {
        public BoundsType BoundsType;
        public string     String;

        public static implicit operator TypeElement(BoundsType boundsType) => new TypeElement { BoundsType = boundsType };
        public static implicit operator TypeElement(string     String)     => new TypeElement { String     = String };
    }
}