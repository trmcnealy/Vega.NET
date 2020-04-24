namespace Vega.Schema
{
    public struct Band
    {
        public bool?   Bool;
        public double? Double;

        public static implicit operator Band(bool   Bool)   => new Band { Bool   = Bool };
        public static implicit operator Band(double Double) => new Band { Double = Double };
    }
}