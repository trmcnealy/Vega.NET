using System.Collections.Generic;

namespace Vega.Schema
{
    public struct EncodeAlign
    {
        public List<LabelAlignElement> LabelAlignElementArray;
        public AlignType               AlignType;

        public static implicit operator EncodeAlign(List<LabelAlignElement> LabelAlignElementArray) => new EncodeAlign { LabelAlignElementArray = LabelAlignElementArray };
        public static implicit operator EncodeAlign(AlignType               alignType)              => new EncodeAlign { AlignType              = alignType };
    }
}