using System.Collections.Generic;

namespace Vega.Schema
{
    public struct MarkTransformAs
    {
        public List<AsA>  AnythingArray;
        public BoundsType BoundsType;
        public string     String;

        public static implicit operator MarkTransformAs(List<AsA>  AnythingArray) => new MarkTransformAs { AnythingArray = AnythingArray };
        public static implicit operator MarkTransformAs(BoundsType boundsType)    => new MarkTransformAs { BoundsType    = boundsType };
        public static implicit operator MarkTransformAs(string     String)        => new MarkTransformAs { String        = String };
    }
}