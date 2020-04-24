using System.Collections.Generic;

namespace Vega.Schema
{
    public struct BandPosition
    {
        public List<BandPositionElement> BandPositionElementArray;
        public double?                   Double;
        public SType                     SType;

        public static implicit operator BandPosition(List<BandPositionElement> BandPositionElementArray) => new BandPosition { BandPositionElementArray = BandPositionElementArray };
        public static implicit operator BandPosition(double                    Double)                   => new BandPosition { Double                   = Double };
        public static implicit operator BandPosition(SType                     sType)                    => new BandPosition { SType                    = sType };
    }
}