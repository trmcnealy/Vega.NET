namespace Vega.Schema
{
    public struct DomainDashElement
    {
        public double?           Double;
        public StrokeDashElement StrokeDashElement;

        public static implicit operator DomainDashElement(double            Double)            => new DomainDashElement { Double            = Double };
        public static implicit operator DomainDashElement(StrokeDashElement StrokeDashElement) => new DomainDashElement { StrokeDashElement = StrokeDashElement };
    }
}