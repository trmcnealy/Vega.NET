using System.Collections.Generic;

namespace Vega.Schema
{
    public struct LabelAlignUnion
    {
        public LabelAlignEnum?         Enum;
        public List<LabelAlignElement> LabelAlignElementArray;
        public AlignType               AlignType;

        public static implicit operator LabelAlignUnion(LabelAlignEnum          Enum)                   => new LabelAlignUnion { Enum                   = Enum };
        public static implicit operator LabelAlignUnion(List<LabelAlignElement> LabelAlignElementArray) => new LabelAlignUnion { LabelAlignElementArray = LabelAlignElementArray };
        public static implicit operator LabelAlignUnion(AlignType               alignType)              => new LabelAlignUnion { AlignType              = alignType };
    }
}