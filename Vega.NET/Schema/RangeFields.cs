using System.Collections.Generic;

namespace Vega.Schema
{
    public struct RangeFields
    {
        public List<DomainFieldsElement> AnythingArray;
        public string                    String;
        public RangeFieldsType           Type;

        public static implicit operator RangeFields(List<DomainFieldsElement> AnythingArray) => new RangeFields { AnythingArray = AnythingArray };
        public static implicit operator RangeFields(string                    String)        => new RangeFields { String        = String };
        public static implicit operator RangeFields(RangeFieldsType           Type)          => new RangeFields { Type          = Type };
    }
}