using System.Collections.Generic;

namespace Vega.Schema
{
    public struct Values
    {
        public List<object> AnythingArray;
        public BoundsType   BoundsType;

        public static implicit operator Values(List<object> AnythingArray) => new Values { AnythingArray = AnythingArray };
        public static implicit operator Values(BoundsType   boundsType)    => new Values { BoundsType    = boundsType };
    }
}