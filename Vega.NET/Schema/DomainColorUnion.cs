using System.Collections.Generic;

namespace Vega.Schema
{
    public struct DomainColorUnion
    {
        public List<DomainColorElement> DomainColorElementArray;
        public DomainColorType          DomainColorType;
        public string                   String;

        public static implicit operator DomainColorUnion(List<DomainColorElement> DomainColorElementArray) => new DomainColorUnion { DomainColorElementArray = DomainColorElementArray };
        public static implicit operator DomainColorUnion(DomainColorType          domainColorType)         => new DomainColorUnion { DomainColorType         = domainColorType };
        public static implicit operator DomainColorUnion(string                   String)                  => new DomainColorUnion { String                  = String };
        public                          bool IsNull                                                        => DomainColorElementArray == null && DomainColorType == null && String == null;
    }
}