using System.Collections.Generic;

namespace Vega.Schema
{
    public struct UnitsUnion
    {
        public List<TypeElement> AnythingArray;
        public BoundsType        BoundsType;

        public static implicit operator UnitsUnion(List<TypeElement> AnythingArray) => new UnitsUnion { AnythingArray = AnythingArray };
        public static implicit operator UnitsUnion(BoundsType        boundsType)    => new UnitsUnion { BoundsType    = boundsType };
    }
}