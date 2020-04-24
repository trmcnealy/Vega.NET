using System.Collections.Generic;

using Vega.Schema;

namespace Vega.ChartSpecifications
{
    public class BarChartSpecification
    {
        public Specification Specification { get; }

        public double Width { get { return Specification.Width ?? 500;} set { Specification.Width = value; } }

        public double Height { get { return Specification.Height ?? 500;} set { Specification.Width = value; } }

        public Padding? Padding { get { return Specification.Padding;} set { Specification.Padding = value; } }

        public List<Data> Data { get { return Specification.Data;} set { Specification.Data = value; } }

        public List<SignalElement> Signals { get { return Specification.Signals;} set { Specification.Signals = value; } }

        public List<ScaleElement> Scales { get { return Specification.Scales;} set { Specification.Scales = value; } }

        public List<AxeElement> Axes { get { return Specification.Axes;} set { Specification.Axes = value; } }

        public List<Mark> Marks { get { return Specification.Marks;} set { Specification.Marks = value; } }

        public BarChartSpecification(string json)
        {
            Specification = Specification.FromJson(json);
        }

        public BarChartSpecification(double width,
                                     double height,
                                     string xAxisFieldName,
                                     string yAxisFieldName,
                                     params Data[] data)
        {
            Specification = new Specification();

            Width  = width;
            Height = height;

            Data = new List<Data>(data);

            Signals = new List<SignalElement>()
            {
                new SignalElement
                {
                    Name  = "tooltip",
                    Value = "{}",
                    On = new List<SignalOn>
                    {
                        new SignalOn
                        {
                            Events = "rect:mouseover", Update = "datum"
                        },
                        new SignalOn
                        {
                            Events = "rect:mouseout", Update = "{}"
                        }
                    }
                }
            };

            Scales = new List<ScaleElement>
            {
                new ScaleElement
                {
                    Name = "xscale",
                    Type = ScaleTypeEnum.Band,
                    Domain = new Domain
                    {
                        Data = "table",
                        Field = xAxisFieldName
                    },
                    Range   = RangeEnum.Width,
                    Padding = 0.05,
                    Round   = true
                },
                new ScaleElement
                {
                    Name = "yscale",
                    Type = ScaleTypeEnum.Band,
                    Domain = new Domain
                    {
                        Data = "table",
                        Field = yAxisFieldName
                    },
                    Range = RangeEnum.Height,
                    Nice  = true
                }
            };

            Axes = new List<AxeElement>
            {
                new AxeElement
                {
                    Orient = TitleOrientEnum.Bottom, Scale = "xscale"
                },
                new AxeElement
                {
                    Orient = TitleOrientEnum.Left, Scale = "yscale"
                }
            };

            Marks = new List<Mark>
            {
                new Mark
                {
                    Type = "rect",
                    From =
                    {
                        Data = "table"
                    },
                    Encode = new Encode
                    {
                        Enter = new EncodeEntry
                        {
                            X = new SType
                            {
                                Scale = "xscale", Field = xAxisFieldName
                            },
                            Width = new SType
                            {
                                Scale = "xscale", Band = 1
                            },
                            Y = new SType
                            {
                                Scale = "yscale", Field = yAxisFieldName
                            },
                            Y2 = new SType
                            {
                                Scale = "yscale", Value = 0
                            }
                        },
                        Update = new EncodeEntry
                        {
                            Fill = new DomainColorElementType
                            {
                                Value = "steelblue"
                            }
                        },
                        Hover = new EncodeEntry
                        {
                            Fill = new DomainColorElementType
                            {
                                Value = "red"
                            }
                        }
                    }
                },
                new Mark
                {
                    Type = "text",
                    Encode = new Encode
                    {
                        Enter = new EncodeEntry
                        {
                            Align = new AlignType
                            {
                                Value = "center"
                            },
                            Baseline = new LabelBaselineType
                            {
                                Value = "bottom"
                            },
                            Fill = new DomainColorElementType
                            {
                                Value = "#333"
                            }
                        },
                        Update = new EncodeEntry
                        {
                            X = new SType
                            {
                                Scale = "xscale", Signal = $"tooltip.{xAxisFieldName}", Band=0.5
                            },
                            Y = new SType
                            {
                                Scale = "yscale", Signal = $"tooltip.{yAxisFieldName}", Offset = -2
                            },
                            Text = new TextType
                            {
                                Signal = $"tooltip.{yAxisFieldName}"
                            },
                            FillOpacity = new List<BandPositionElement>
                            {
                                new BandPositionElement
                                {
                                    Test = "datum === tooltip",
                                    Value = 0
                                },
                                new BandPositionElement
                                {
                                    Value = 1
                                }
                            }
                        }
                    }
                }
            };
        }

        public override string ToString()
        {
            return Specification.ToJson();
        }
    }
}
