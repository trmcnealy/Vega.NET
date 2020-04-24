using System.Collections.Generic;

namespace Vega.Schema
{
    public struct Text
    {
        public TextType          TextType;
        public List<TextElement> TextElementArray;

        public static implicit operator Text(TextType          textType)         => new Text { TextType         = textType };
        public static implicit operator Text(List<TextElement> TextElementArray) => new Text { TextElementArray = TextElementArray };
    }
}