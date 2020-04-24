namespace Vega.Schema
{
    public struct XUnion
    {
        public double? Double;
        public string  String;
        public XType   Type;

        public static implicit operator XUnion(double Double) => new XUnion { Double = Double };
        public static implicit operator XUnion(string String) => new XUnion { String = String };
        public static implicit operator XUnion(XType  Type)   => new XUnion { Type   = Type };
    }
}