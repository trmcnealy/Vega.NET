using System.Collections.Generic;

namespace Vega.Schema
{
    public struct Value
    {
        public string       String;
        public List<string> StringArray;

        public static implicit operator Value(string       String)      => new Value { String      = String };
        public static implicit operator Value(List<string> StringArray) => new Value { StringArray = StringArray };
    }
}