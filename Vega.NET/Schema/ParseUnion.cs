namespace Vega.Schema
{
    public struct ParseUnion
    {
        public ParseEnum? Enum;
        public Parse      Parse;

        public static implicit operator ParseUnion(ParseEnum Enum)  => new ParseUnion { Enum  = Enum };
        public static implicit operator ParseUnion(Parse     parse) => new ParseUnion { Parse = parse };
    }
}