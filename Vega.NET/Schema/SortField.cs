using System.Collections.Generic;

namespace Vega.Schema
{
    public struct SortField
    {
        public List<SortFieldElementType> AnythingArray;
        public string                     String;
        public SortFieldType              Type;

        public static implicit operator SortField(List<SortFieldElementType> AnythingArray) => new SortField { AnythingArray = AnythingArray };
        public static implicit operator SortField(string                     String)        => new SortField { String        = String };
        public static implicit operator SortField(SortFieldType              Type)          => new SortField { Type          = Type };
    }
}