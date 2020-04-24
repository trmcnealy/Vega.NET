namespace Vega.Schema
{
    public struct Fields
    {
        public string     String;
        public FieldsType Type;

        public static implicit operator Fields(string     String) => new Fields { String = String };
        public static implicit operator Fields(FieldsType Type)   => new Fields { Type   = Type };
        public                          bool IsNull               => Type == null && String == null;
    }
}