using System.Collections.Generic;

namespace Vega.Schema
{
    public struct FrameUnion
    {
        public List<FrameElement> AnythingArray;
        public BoundsType         BoundsType;

        public static implicit operator FrameUnion(List<FrameElement> AnythingArray) => new FrameUnion { AnythingArray = AnythingArray };
        public static implicit operator FrameUnion(BoundsType         boundsType)    => new FrameUnion { BoundsType    = boundsType };
    }
}