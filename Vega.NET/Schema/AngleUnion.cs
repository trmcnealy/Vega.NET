using System.Collections.Generic;

namespace Vega.Schema
{
    public struct AngleUnion
    {
        public List<BandPositionElement> BandPositionElementArray;
        public SType                     SType;

        public static implicit operator AngleUnion(List<BandPositionElement> BandPositionElementArray) => new AngleUnion { BandPositionElementArray = BandPositionElementArray };
        public static implicit operator AngleUnion(SType                     sType)                    => new AngleUnion { SType                    = sType };
    }
}