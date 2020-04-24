namespace Vega.Schema
{
    public struct DomainSort
    {
        public bool?          Bool;
        public DomainSortType DomainSortType;

        public static implicit operator DomainSort(bool           Bool)           => new DomainSort { Bool           = Bool };
        public static implicit operator DomainSort(DomainSortType domainSortType) => new DomainSort { DomainSortType = domainSortType };
    }
}