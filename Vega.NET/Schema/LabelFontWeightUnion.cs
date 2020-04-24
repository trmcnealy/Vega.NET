using System.Collections.Generic;

namespace Vega.Schema
{
    public struct LabelFontWeightUnion
    {
        public double?                      Double;
        public LabelFontWeightEnum?         Enum;
        public LabelFontWeightType          LabelFontWeightType;
        public long?                        Integer;
        public List<LabelFontWeightElement> LabelFontWeightElementArray;

        public static implicit operator LabelFontWeightUnion(double                       Double)                      => new LabelFontWeightUnion { Double                      = Double };
        public static implicit operator LabelFontWeightUnion(LabelFontWeightEnum          Enum)                        => new LabelFontWeightUnion { Enum                        = Enum };
        public static implicit operator LabelFontWeightUnion(LabelFontWeightType          labelFontWeightType)         => new LabelFontWeightUnion { LabelFontWeightType         = labelFontWeightType };
        public static implicit operator LabelFontWeightUnion(long                         Integer)                     => new LabelFontWeightUnion { Integer                     = Integer };
        public static implicit operator LabelFontWeightUnion(List<LabelFontWeightElement> LabelFontWeightElementArray) => new LabelFontWeightUnion { LabelFontWeightElementArray = LabelFontWeightElementArray };
        public                          bool IsNull                                                                    => LabelFontWeightElementArray == null && LabelFontWeightType == null && Double == null && Integer == null && Enum == null;
    }
}