namespace Vega.Schema
{
    public struct Clip
    {
        public bool?    Bool;
        public ClipType Type;

        public static implicit operator Clip(bool     Bool) => new Clip { Bool = Bool };
        public static implicit operator Clip(ClipType Type) => new Clip { Type = Type };
    }
}