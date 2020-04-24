namespace Vega.Schema
{
    public struct LabelBound
    {
        public bool?      Bool;
        public BoundsType BoundsType;
        public double?    Double;

        public static implicit operator LabelBound(bool       Bool)       => new LabelBound { Bool       = Bool };
        public static implicit operator LabelBound(BoundsType boundsType) => new LabelBound { BoundsType = boundsType };
        public static implicit operator LabelBound(double     Double)     => new LabelBound { Double     = Double };
    }
}