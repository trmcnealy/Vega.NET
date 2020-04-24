using System.Collections.Generic;

namespace Vega.Schema
{
    public struct StrokeCap
    {
        public StrokeCapType          StrokeCapType;
        public List<StrokeCapElement> StrokeCapElementArray;

        public static implicit operator StrokeCap(StrokeCapType          strokeCapType)         => new StrokeCap { StrokeCapType         = strokeCapType };
        public static implicit operator StrokeCap(List<StrokeCapElement> StrokeCapElementArray) => new StrokeCap { StrokeCapElementArray = StrokeCapElementArray };
    }
}