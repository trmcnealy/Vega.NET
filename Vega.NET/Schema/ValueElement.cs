namespace Vega.Schema
{
    public struct ValueElement
    {
        public double?          Double;
        public string           String;
        public ValueElementType Type;

        public static implicit operator ValueElement(double           Double) => new ValueElement { Double = Double };
        public static implicit operator ValueElement(string           String) => new ValueElement { String = String };
        public static implicit operator ValueElement(ValueElementType Type)   => new ValueElement { Type   = Type };
    }
}