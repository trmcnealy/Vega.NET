using System.Collections.Generic;

namespace Vega.Schema
{
    public struct RangeUnion
    {
        public List<DomainElement> AnythingArray;
        public RangeEnum?          Enum;
        public Range               Range;

        public static implicit operator RangeUnion(List<DomainElement> AnythingArray) => new RangeUnion { AnythingArray = AnythingArray };
        public static implicit operator RangeUnion(RangeEnum           Enum)          => new RangeUnion { Enum          = Enum };
        public static implicit operator RangeUnion(Range               range)         => new RangeUnion { Range         = range };
    }
}