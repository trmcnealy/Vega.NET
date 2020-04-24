using System.Collections.Generic;

namespace Vega.Schema
{
    public struct TickRound
    {
        public bool?                  Bool;
        public TickRoundType          TickRoundType;
        public List<TickRoundElement> TickRoundElementArray;

        public static implicit operator TickRound(bool                   Bool)                  => new TickRound { Bool                  = Bool };
        public static implicit operator TickRound(TickRoundType          tickRoundType)         => new TickRound { TickRoundType         = tickRoundType };
        public static implicit operator TickRound(List<TickRoundElement> TickRoundElementArray) => new TickRound { TickRoundElementArray = TickRoundElementArray };
    }
}