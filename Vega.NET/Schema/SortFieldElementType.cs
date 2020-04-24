namespace Vega.Schema
{
    public struct SortFieldElementType
    {
        public string        String;
        public SortFieldType Type;

        public static implicit operator SortFieldElementType(string        String) => new SortFieldElementType { String = String };
        public static implicit operator SortFieldElementType(SortFieldType Type)   => new SortFieldElementType { Type   = Type };
    }
}