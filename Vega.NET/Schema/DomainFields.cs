using System.Collections.Generic;

namespace Vega.Schema
{
    public struct DomainFields
    {
        public List<DomainFieldsElement> AnythingArray;
        public string                    String;
        public DomainFieldsType          Type;

        public static implicit operator DomainFields(List<DomainFieldsElement> AnythingArray) => new DomainFields { AnythingArray = AnythingArray };
        public static implicit operator DomainFields(string                    String)        => new DomainFields { String        = String };
        public static implicit operator DomainFields(DomainFieldsType          Type)          => new DomainFields { Type          = Type };
    }
}