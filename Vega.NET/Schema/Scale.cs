namespace Vega.Schema
{
    public struct Scale
    {
        public GradientType GradientType;
        public string       String;

        public static implicit operator Scale(GradientType gradientType) => new Scale { GradientType = gradientType };
        public static implicit operator Scale(string       String)       => new Scale { String       = String };
    }
}