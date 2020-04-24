namespace Vega.Schema
{
    public struct RangeSort
    {
        public bool?         Bool;
        public RangeSortType RangeSortType;

        public static implicit operator RangeSort(bool          Bool)          => new RangeSort { Bool          = Bool };
        public static implicit operator RangeSort(RangeSortType rangeSortType) => new RangeSort { RangeSortType = rangeSortType };
    }
}