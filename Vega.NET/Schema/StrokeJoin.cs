using System.Collections.Generic;

namespace Vega.Schema
{
    public struct StrokeJoin
    {
        public StrokeJoinType          StrokeJoinType;
        public List<StrokeJoinElement> StrokeJoinElementArray;

        public static implicit operator StrokeJoin(StrokeJoinType          strokeJoinType)         => new StrokeJoin { StrokeJoinType         = strokeJoinType };
        public static implicit operator StrokeJoin(List<StrokeJoinElement> StrokeJoinElementArray) => new StrokeJoin { StrokeJoinElementArray = StrokeJoinElementArray };
    }
}