namespace Vega.Schema
{
    public struct Autosize
    {
        public AutosizeType  AutosizeType;
        public AutosizeEnum? Enum;

        public static implicit operator Autosize(AutosizeType autosizeType) => new Autosize { AutosizeType = autosizeType };
        public static implicit operator Autosize(AutosizeEnum Enum)         => new Autosize { Enum         = Enum };
    }
}