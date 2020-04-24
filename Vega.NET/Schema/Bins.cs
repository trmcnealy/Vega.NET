using System.Collections.Generic;

namespace Vega.Schema
{
    public struct Bins
    {
        public List<ColumnsElement> AnythingArray;
        public BinsType             BinsType;

        public static implicit operator Bins(List<ColumnsElement> AnythingArray) => new Bins { AnythingArray = AnythingArray };
        public static implicit operator Bins(BinsType             binsType)      => new Bins { BinsType      = binsType };
    }
}