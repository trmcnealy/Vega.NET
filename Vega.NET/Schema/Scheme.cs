using System.Collections.Generic;

namespace Vega.Schema
{
    public struct Scheme
    {
        public List<TypeElement> AnythingArray;
        public BoundsType        BoundsType;
        public string            String;

        public static implicit operator Scheme(List<TypeElement> AnythingArray) => new Scheme { AnythingArray = AnythingArray };
        public static implicit operator Scheme(BoundsType        boundsType)    => new Scheme { BoundsType    = boundsType };
        public static implicit operator Scheme(string            String)        => new Scheme { String        = String };
    }
}