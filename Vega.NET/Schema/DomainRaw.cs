using System.Collections.Generic;

namespace Vega.Schema
{
    public struct DomainRaw
    {
        public List<object> AnythingArray;
        public BoundsType   BoundsType;

        public static implicit operator DomainRaw(List<object> AnythingArray) => new DomainRaw { AnythingArray = AnythingArray };
        public static implicit operator DomainRaw(BoundsType   boundsType)    => new DomainRaw { BoundsType    = boundsType };
        public                          bool IsNull                           => AnythingArray == null && BoundsType == null;
    }
}