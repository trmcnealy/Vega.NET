namespace Vega.Schema
{
    public struct DomainFieldsElement
    {
        public bool?   Bool;
        public double? Double;
        public string  String;

        public static implicit operator DomainFieldsElement(bool   Bool)   => new DomainFieldsElement { Bool   = Bool };
        public static implicit operator DomainFieldsElement(double Double) => new DomainFieldsElement { Double = Double };
        public static implicit operator DomainFieldsElement(string String) => new DomainFieldsElement { String = String };
    }
}