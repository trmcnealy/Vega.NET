namespace Vega.Schema
{
    public struct MarkTitle
    {
        public string String;
        public Title  Title;

        public static implicit operator MarkTitle(string String) => new MarkTitle { String = String };
        public static implicit operator MarkTitle(Title  title)  => new MarkTitle { Title  = title };
    }
}