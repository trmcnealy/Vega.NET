namespace Vega.Schema
{
    public struct AxeFormat
    {
        public AxeFormatType AxeFormatType;
        public string        String;

        public static implicit operator AxeFormat(AxeFormatType axeFormatType) => new AxeFormat { AxeFormatType = axeFormatType };
        public static implicit operator AxeFormat(string        String)        => new AxeFormat { String        = String };
    }
}