using System.Collections.Generic;

namespace Vega.Schema
{
    public struct StrokeDashUnion
    {
        public DashType                DashType;
        public List<StrokeDashElement> StrokeDashElementArray;

        public static implicit operator StrokeDashUnion(DashType                dashType)               => new StrokeDashUnion { DashType               = dashType };
        public static implicit operator StrokeDashUnion(List<StrokeDashElement> StrokeDashElementArray) => new StrokeDashUnion { StrokeDashElementArray = StrokeDashElementArray };
    }
}