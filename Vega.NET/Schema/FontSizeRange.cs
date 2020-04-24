using System.Collections.Generic;

namespace Vega.Schema
{
    public struct FontSizeRange
    {
        public List<ColumnsElement> AnythingArray;
        public BoundsType           BoundsType;

        public static implicit operator FontSizeRange(List<ColumnsElement> AnythingArray) => new FontSizeRange { AnythingArray = AnythingArray };
        public static implicit operator FontSizeRange(BoundsType           boundsType)    => new FontSizeRange { BoundsType    = boundsType };
        public                          bool IsNull                                       => AnythingArray == null && BoundsType == null;
    }
}