namespace Vega.Schema
{
    public struct Interpolate
    {
        public string          String;
        public InterpolateType Type;

        public static implicit operator Interpolate(string          String) => new Interpolate { String = String };
        public static implicit operator Interpolate(InterpolateType Type)   => new Interpolate { Type   = Type };
    }
}