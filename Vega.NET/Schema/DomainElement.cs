using System.Collections.Generic;

namespace Vega.Schema
{
    public struct DomainElement
    {
        public List<ColumnsElement> AnythingArray;
        public bool?                Bool;
        public BoundsType           BoundsType;
        public double?              Double;
        public string               String;

        public static implicit operator DomainElement(List<ColumnsElement> AnythingArray) => new DomainElement { AnythingArray = AnythingArray };
        public static implicit operator DomainElement(bool                 Bool)          => new DomainElement { Bool          = Bool };
        public static implicit operator DomainElement(BoundsType           boundsType)    => new DomainElement { BoundsType    = boundsType };
        public static implicit operator DomainElement(double               Double)        => new DomainElement { Double        = Double };
        public static implicit operator DomainElement(string               String)        => new DomainElement { String        = String };
        public                          bool IsNull                                       => AnythingArray == null && Bool == null && BoundsType == null && Double == null && String == null;
    }
}