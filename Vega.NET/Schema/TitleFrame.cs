using System.Collections.Generic;

namespace Vega.Schema
{
    public struct TitleFrame
    {
        public EllipsisType           EllipsisType;
        public FrameEnum?             Enum;
        public List<LabelFontElement> LabelFontElementArray;

        public static implicit operator TitleFrame(EllipsisType           ellipsisType)          => new TitleFrame { EllipsisType          = ellipsisType };
        public static implicit operator TitleFrame(FrameEnum              Enum)                  => new TitleFrame { Enum                  = Enum };
        public static implicit operator TitleFrame(List<LabelFontElement> LabelFontElementArray) => new TitleFrame { LabelFontElementArray = LabelFontElementArray };
    }
}