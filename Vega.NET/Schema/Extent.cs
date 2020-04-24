using System.Collections.Generic;

namespace Vega.Schema
{
    public struct Extent
    {
        public List<CenterElement> AnythingArray;
        public BoundsType          BoundsType;

        public static implicit operator Extent(List<CenterElement> AnythingArray) => new Extent { AnythingArray = AnythingArray };
        public static implicit operator Extent(BoundsType          boundsType)    => new Extent { BoundsType    = boundsType };
    }
}