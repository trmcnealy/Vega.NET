using System.Collections.Generic;

namespace Vega.Schema
{
    public struct SubtitleUnion
    {
        public BoundsType   BoundsType;
        public string       String;
        public List<string> StringArray;

        public static implicit operator SubtitleUnion(BoundsType   boundsType)  => new SubtitleUnion { BoundsType  = boundsType };
        public static implicit operator SubtitleUnion(string       String)      => new SubtitleUnion { String      = String };
        public static implicit operator SubtitleUnion(List<string> StringArray) => new SubtitleUnion { StringArray = StringArray };
    }
}