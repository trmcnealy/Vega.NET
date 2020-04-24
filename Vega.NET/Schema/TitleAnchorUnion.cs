using System.Collections.Generic;

namespace Vega.Schema
{
    public struct TitleAnchorUnion
    {
        public TitleAnchorEnum?         Enum;
        public List<TitleAnchorElement> TitleAnchorElementArray;
        public TitleAnchorType          Type;

        public static implicit operator TitleAnchorUnion(TitleAnchorEnum          Enum)                    => new TitleAnchorUnion { Enum                    = Enum };
        public static implicit operator TitleAnchorUnion(List<TitleAnchorElement> TitleAnchorElementArray) => new TitleAnchorUnion { TitleAnchorElementArray = TitleAnchorElementArray };
        public static implicit operator TitleAnchorUnion(TitleAnchorType          Type)                    => new TitleAnchorUnion { Type                    = Type };
        public                          bool IsNull                                                        => TitleAnchorElementArray == null && Type == null && Enum == null;
    }
}