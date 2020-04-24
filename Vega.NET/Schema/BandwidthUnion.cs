using System.Collections.Generic;

namespace Vega.Schema
{
    public struct BandwidthUnion
    {
        public List<ColumnsElement> AnythingArray;
        public BoundsType           BoundsType;
        public double?              Double;

        public static implicit operator BandwidthUnion(List<ColumnsElement> AnythingArray) => new BandwidthUnion { AnythingArray = AnythingArray };
        public static implicit operator BandwidthUnion(BoundsType           boundsType)    => new BandwidthUnion { BoundsType    = boundsType };
        public static implicit operator BandwidthUnion(double               Double)        => new BandwidthUnion { Double        = Double };
    }
}