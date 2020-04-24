using System.Collections.Generic;

namespace Vega.Schema
{
    public struct FieldsUnion
    {
        public List<Fields> AnythingArray;
        public BoundsType   BoundsType;

        public static implicit operator FieldsUnion(List<Fields> AnythingArray) => new FieldsUnion { AnythingArray = AnythingArray };
        public static implicit operator FieldsUnion(BoundsType   boundsType)    => new FieldsUnion { BoundsType    = boundsType };
    }
}