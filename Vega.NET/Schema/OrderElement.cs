namespace Vega.Schema
{
    public struct OrderElement
    {
        public BoundsType BoundsType;
        public OrderEnum? Enum;

        public static implicit operator OrderElement(BoundsType boundsType) => new OrderElement { BoundsType = boundsType };
        public static implicit operator OrderElement(OrderEnum  Enum)       => new OrderElement { Enum       = Enum };
    }
}