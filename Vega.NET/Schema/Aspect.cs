using System.Collections.Generic;

namespace Vega.Schema
{
    public struct Aspect
    {
        public TickRoundType          TickRoundType;
        public List<TickRoundElement> TickRoundElementArray;

        public static implicit operator Aspect(TickRoundType          tickRoundType)         => new Aspect { TickRoundType         = tickRoundType };
        public static implicit operator Aspect(List<TickRoundElement> TickRoundElementArray) => new Aspect { TickRoundElementArray = TickRoundElementArray };
    }
}