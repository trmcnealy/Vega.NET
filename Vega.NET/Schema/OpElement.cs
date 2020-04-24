namespace Vega.Schema
{
    public struct OpElement
    {
        public BoundsType     BoundsType;
        public OpElementEnum? Enum;

        public static implicit operator OpElement(BoundsType    boundsType)  => new OpElement { BoundsType = boundsType };
        public static implicit operator OpElement(OpElementEnum elementEnum) => new OpElement { Enum       = elementEnum };
    }
}