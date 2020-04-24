using System.Collections.Generic;

namespace Vega.Schema
{
    public struct Translate
    {
        public List<Radius> AnythingArray;
        public BoundsType   BoundsType;

        public static implicit operator Translate(List<Radius> AnythingArray) => new Translate { AnythingArray = AnythingArray };
        public static implicit operator Translate(BoundsType   boundsType)    => new Translate { BoundsType    = boundsType };
    }
}