using System.Collections.Generic;

namespace Vega.Schema
{
    public struct TitleOrientUnion
    {
        public TitleOrientEnum?         Enum;
        public List<TitleOrientElement> TitleOrientElementArray;
        public TitleOrientType          Type;

        public static implicit operator TitleOrientUnion(TitleOrientEnum          Enum)                    => new TitleOrientUnion { Enum                    = Enum };
        public static implicit operator TitleOrientUnion(List<TitleOrientElement> TitleOrientElementArray) => new TitleOrientUnion { TitleOrientElementArray = TitleOrientElementArray };
        public static implicit operator TitleOrientUnion(TitleOrientType          Type)                    => new TitleOrientUnion { Type                    = Type };
    }
}