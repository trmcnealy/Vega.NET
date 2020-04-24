using System.Collections.Generic;

namespace Vega.Schema
{
    public struct AxeDomainDash
    {
        public List<DomainDashElement> AnythingArray;
        public DashType                DashType;

        public static implicit operator AxeDomainDash(List<DomainDashElement> AnythingArray) => new AxeDomainDash { AnythingArray = AnythingArray };
        public static implicit operator AxeDomainDash(DashType                dashType)      => new AxeDomainDash { DashType      = dashType };
    }
}