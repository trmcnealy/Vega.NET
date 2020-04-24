using System.Collections.Generic;

namespace Vega.Schema
{
    public struct Cursor
    {
        public EllipsisType           EllipsisType;
        public List<LabelFontElement> LabelFontElementArray;

        public static implicit operator Cursor(EllipsisType           ellipsisType)          => new Cursor { EllipsisType          = ellipsisType };
        public static implicit operator Cursor(List<LabelFontElement> LabelFontElementArray) => new Cursor { LabelFontElementArray = LabelFontElementArray };
    }
}