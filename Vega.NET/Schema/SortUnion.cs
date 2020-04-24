namespace Vega.Schema
{
    public struct SortUnion
    {
        public bool? Bool;
        public Sort  Sort;

        public static implicit operator SortUnion(bool Bool) => new SortUnion { Bool = Bool };
        public static implicit operator SortUnion(Sort sort) => new SortUnion { Sort = sort };
    }
}