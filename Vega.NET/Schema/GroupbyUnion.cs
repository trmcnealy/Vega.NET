using System.Collections.Generic;

namespace Vega.Schema
{
    public struct GroupbyUnion
    {
        public List<ColorElement> AnythingArray;
        public BoundsType         BoundsType;

        public static implicit operator GroupbyUnion(List<ColorElement> AnythingArray) => new GroupbyUnion { AnythingArray = AnythingArray };
        public static implicit operator GroupbyUnion(BoundsType         boundsType)    => new GroupbyUnion { BoundsType    = boundsType };
    }
}