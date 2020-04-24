using System.Collections.Generic;

namespace Vega.Schema
{
    public struct EncodeBaseline
    {
        public LabelBaselineType          LabelBaselineType;
        public List<LabelBaselineElement> LabelBaselineElementArray;

        public static implicit operator EncodeBaseline(LabelBaselineType          labelBaselineType)         => new EncodeBaseline { LabelBaselineType         = labelBaselineType };
        public static implicit operator EncodeBaseline(List<LabelBaselineElement> LabelBaselineElementArray) => new EncodeBaseline { LabelBaselineElementArray = LabelBaselineElementArray };
    }
}