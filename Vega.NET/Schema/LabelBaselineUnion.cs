using System.Collections.Generic;

namespace Vega.Schema
{
    public struct LabelBaselineUnion
    {
        public LabelBaselineEnum?         Enum;
        public LabelBaselineType          LabelBaselineType;
        public List<LabelBaselineElement> LabelBaselineElementArray;

        public static implicit operator LabelBaselineUnion(LabelBaselineEnum          Enum)                      => new LabelBaselineUnion { Enum                      = Enum };
        public static implicit operator LabelBaselineUnion(LabelBaselineType          labelBaselineType)         => new LabelBaselineUnion { LabelBaselineType         = labelBaselineType };
        public static implicit operator LabelBaselineUnion(List<LabelBaselineElement> LabelBaselineElementArray) => new LabelBaselineUnion { LabelBaselineElementArray = LabelBaselineElementArray };
    }
}