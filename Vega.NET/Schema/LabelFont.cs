using System.Collections.Generic;

namespace Vega.Schema
{
    public struct LabelFont
    {
        public EllipsisType           EllipsisType;
        public List<LabelFontElement> LabelFontElementArray;
        public string                 String;

        public static implicit operator LabelFont(EllipsisType           ellipsisType)          => new LabelFont { EllipsisType          = ellipsisType };
        public static implicit operator LabelFont(List<LabelFontElement> LabelFontElementArray) => new LabelFont { LabelFontElementArray = LabelFontElementArray };
        public static implicit operator LabelFont(string                 String)                => new LabelFont { String                = String };
    }
}