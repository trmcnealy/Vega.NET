using System.Collections.Generic;

namespace Vega.Schema
{
    public struct Fit
    {
        public List<object>               AnythingArray;
        public Dictionary<string, object> AnythingMap;

        public static implicit operator Fit(List<object>               AnythingArray) => new Fit { AnythingArray = AnythingArray };
        public static implicit operator Fit(Dictionary<string, object> AnythingMap)   => new Fit { AnythingMap   = AnythingMap };
    }
}