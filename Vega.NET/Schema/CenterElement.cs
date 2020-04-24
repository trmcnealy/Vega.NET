using System.Collections.Generic;

namespace Vega.Schema
{
    public struct CenterElement
    {
        public List<ColumnsElement> AnythingArray;
        public BoundsType           BoundsType;

        public static implicit operator CenterElement(List<ColumnsElement> AnythingArray) => new CenterElement { AnythingArray = AnythingArray };
        public static implicit operator CenterElement(BoundsType           boundsType)    => new CenterElement { BoundsType    = boundsType };
    }
}