namespace Vega.Schema
{
    public struct Padding
    {
        public double?     Double;
        public PaddingType Type;

        public static implicit operator Padding(double      Double) => new Padding { Double = Double };
        public static implicit operator Padding(PaddingType Type)   => new Padding { Type   = Type };
    }
}