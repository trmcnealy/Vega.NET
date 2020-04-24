namespace Vega.Schema
{
    public struct StrengthUnion
    {
        public double?  Double;
        public Strength Strength;

        public static implicit operator StrengthUnion(double   Double)   => new StrengthUnion { Double   = Double };
        public static implicit operator StrengthUnion(Strength strength) => new StrengthUnion { Strength = strength };
    }
}