using System.Collections.Generic;

namespace Vega.Schema
{
    public struct ScaleDomain
    {
        public List<DomainElement> AnythingArray;
        public Domain              Domain;

        public static implicit operator ScaleDomain(List<DomainElement> AnythingArray) => new ScaleDomain { AnythingArray = AnythingArray };
        public static implicit operator ScaleDomain(Domain              domain)        => new ScaleDomain { Domain        = domain };
    }
}