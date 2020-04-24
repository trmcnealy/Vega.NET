using System.Collections.Generic;

namespace Vega.Schema
{
    public struct MarkSortOrder
    {
        public List<OrderElement> AnythingArray;
        public BoundsType         BoundsType;
        public OrderEnum?         Enum;

        public static implicit operator MarkSortOrder(List<OrderElement> AnythingArray) => new MarkSortOrder { AnythingArray = AnythingArray };
        public static implicit operator MarkSortOrder(BoundsType         boundsType)    => new MarkSortOrder { BoundsType    = boundsType };
        public static implicit operator MarkSortOrder(OrderEnum          Enum)          => new MarkSortOrder { Enum          = Enum };
    }
}