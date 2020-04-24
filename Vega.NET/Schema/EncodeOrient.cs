using System.Collections.Generic;

namespace Vega.Schema
{
    public struct EncodeOrient
    {
        public EncodeOrientType    EncodeOrientType;
        public List<OrientElement> OrientElementArray;

        public static implicit operator EncodeOrient(EncodeOrientType    encodeOrientType)   => new EncodeOrient { EncodeOrientType   = encodeOrientType };
        public static implicit operator EncodeOrient(List<OrientElement> OrientElementArray) => new EncodeOrient { OrientElementArray = OrientElementArray };
    }
}