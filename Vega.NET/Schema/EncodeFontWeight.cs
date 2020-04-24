using System.Collections.Generic;

namespace Vega.Schema
{
    public struct EncodeFontWeight
    {
        public LabelFontWeightType          LabelFontWeightType;
        public List<LabelFontWeightElement> LabelFontWeightElementArray;

        public static implicit operator EncodeFontWeight(LabelFontWeightType          labelFontWeightType)         => new EncodeFontWeight { LabelFontWeightType         = labelFontWeightType };
        public static implicit operator EncodeFontWeight(List<LabelFontWeightElement> LabelFontWeightElementArray) => new EncodeFontWeight { LabelFontWeightElementArray = LabelFontWeightElementArray };
    }
}