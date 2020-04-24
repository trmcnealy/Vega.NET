using System.Collections.Generic;

namespace Vega.Schema
{
    public struct Tooltip
    {
        public TooltipType          TooltipType;
        public List<TooltipElement> TooltipElementArray;

        public static implicit operator Tooltip(TooltipType          tooltipType)         => new Tooltip { TooltipType         = tooltipType };
        public static implicit operator Tooltip(List<TooltipElement> TooltipElementArray) => new Tooltip { TooltipElementArray = TooltipElementArray };
    }
}