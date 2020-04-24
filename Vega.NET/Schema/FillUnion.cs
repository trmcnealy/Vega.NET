using System.Collections.Generic;

namespace Vega.Schema
{
    public struct FillUnion
    {
        public List<DomainColorElement> DomainColorElementArray;
        public DomainColorElementType   DomainColorElementType;

        public static implicit operator FillUnion(List<DomainColorElement> DomainColorElementArray) => new FillUnion { DomainColorElementArray = DomainColorElementArray };
        public static implicit operator FillUnion(DomainColorElementType   domainColorElementType)  => new FillUnion { DomainColorElementType  = domainColorElementType };
    }
}