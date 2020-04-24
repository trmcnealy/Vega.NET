namespace Vega.Schema
{
    public struct Nice
    {
        public bool?          Bool;
        public double?        Double;
        public TickCountEnum? Enum;
        public NiceNice       NiceNice;

        public static implicit operator Nice(bool          Bool)     => new Nice { Bool     = Bool };
        public static implicit operator Nice(double        Double)   => new Nice { Double   = Double };
        public static implicit operator Nice(TickCountEnum Enum)     => new Nice { Enum     = Enum };
        public static implicit operator Nice(NiceNice      NiceNice) => new Nice { NiceNice = NiceNice };
    }
}