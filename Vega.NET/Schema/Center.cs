namespace Vega.Schema
{
    public struct Center
    {
        public bool?      Bool;
        public CenterType CenterType;

        public static implicit operator Center(bool       Bool)       => new Center { Bool       = Bool };
        public static implicit operator Center(CenterType centerType) => new Center { CenterType = centerType };
    }
}