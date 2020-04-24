namespace Vega.Schema
{
    public struct Radius
    {
        public Distance Distance;
        public double?  Double;

        public static implicit operator Radius(Distance distance) => new Radius { Distance = distance };
        public static implicit operator Radius(double   Double)   => new Radius { Double   = Double };
    }
}