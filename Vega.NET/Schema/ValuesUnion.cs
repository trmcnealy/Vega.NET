using System.Collections.Generic;

namespace Vega.Schema
{
    public struct ValuesUnion
    {
        public List<ValueElement> AnythingArray;
        public BoundsType         BoundsType;

        public static implicit operator ValuesUnion(List<ValueElement> AnythingArray) => new ValuesUnion { AnythingArray = AnythingArray };
        public static implicit operator ValuesUnion(BoundsType         boundsType)    => new ValuesUnion { BoundsType    = boundsType };
    }
}