using System.Collections.Generic;

namespace Vega.Schema
{
    public struct TransformAs
    {
        public List<AsA>  AnythingArray;
        public BoundsType BoundsType;
        public string     String;

        public static implicit operator TransformAs(List<AsA>  AnythingArray) => new TransformAs { AnythingArray = AnythingArray };
        public static implicit operator TransformAs(BoundsType boundsType)    => new TransformAs { BoundsType    = boundsType };
        public static implicit operator TransformAs(string     String)        => new TransformAs { String        = String };
        public                          bool IsNull                                => AnythingArray == null && BoundsType == null && String == null;
    }
}