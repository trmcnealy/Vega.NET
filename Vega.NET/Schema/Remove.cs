namespace Vega.Schema
{
    public struct Remove
    {
        public bool?  Bool;
        public string String;

        public static implicit operator Remove(bool   Bool)   => new Remove { Bool   = Bool };
        public static implicit operator Remove(string String) => new Remove { String = String };
    }
}