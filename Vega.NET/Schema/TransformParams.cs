using System.Collections.Generic;

namespace Vega.Schema
{
    public struct TransformParams
    {
        public List<FrameElement> AnythingArray;
        public bool?              Bool;
        public BoundsType         BoundsType;

        public static implicit operator TransformParams(List<FrameElement> AnythingArray) => new TransformParams { AnythingArray = AnythingArray };
        public static implicit operator TransformParams(bool               Bool)          => new TransformParams { Bool          = Bool };
        public static implicit operator TransformParams(BoundsType         boundsType)    => new TransformParams { BoundsType    = boundsType };
    }
}