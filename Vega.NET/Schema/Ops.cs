using System.Collections.Generic;

namespace Vega.Schema
{
    public struct Ops
    {
        public List<OpElement> AnythingArray;
        public BoundsType      BoundsType;

        public static implicit operator Ops(List<OpElement> AnythingArray) => new Ops { AnythingArray = AnythingArray };
        public static implicit operator Ops(BoundsType      boundsType)    => new Ops { BoundsType    = boundsType };
    }
}