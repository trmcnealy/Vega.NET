using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;


using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Vega.Schema
{
    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            NullValueHandling        = NullValueHandling.Ignore,
            Formatting               = Formatting.Indented,
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling        = DateParseHandling.None,
            Converters =
            {
                AutosizeConverter.Singleton,
                ContainsConverter.Singleton,
                AutosizeEnumConverter.Singleton,
                BandPositionConverter.Singleton,
                BandConverter.Singleton,
                ScaleConverter.Singleton,
                DomainColorUnionConverter.Singleton,
                AngleUnionConverter.Singleton,
                AxeDomainDashConverter.Singleton,
                DomainDashElementConverter.Singleton,
                EnterAlignConverter.Singleton,
                AspectConverter.Singleton,
                EnterBaselineConverter.Singleton,
                CursorConverter.Singleton,
                FillUnionConverter.Singleton,
                EnterFontWeightConverter.Singleton,
                EnterOrientConverter.Singleton,
                StrokeCapConverter.Singleton,
                StrokeDashUnionConverter.Singleton,
                StrokeJoinConverter.Singleton,
                TextConverter.Singleton,
                TooltipConverter.Singleton,
                ValueConverter.Singleton,
                AxeFormatConverter.Singleton,
                FormatTypeUnionConverter.Singleton,
                FormatTypeEnumConverter.Singleton,
                LabelAlignUnionConverter.Singleton,
                LabelAlignEnumConverter.Singleton,
                LabelBaselineUnionConverter.Singleton,
                LabelBaselineEnumConverter.Singleton,
                LabelBoundConverter.Singleton,
                ColumnsElementConverter.Singleton,
                LabelFontConverter.Singleton,
                LabelFontWeightUnionConverter.Singleton,
                LabelFontWeightEnumConverter.Singleton,
                LabelOverlapConverter.Singleton,
                LabelOverlapEnumConverter.Singleton,
                TitleOrientEnumConverter.Singleton,
                TickBandConverter.Singleton,
                TickBandEnumConverter.Singleton,
                TickCountConverter.Singleton,
                IntervalUnionConverter.Singleton,
                TickCountEnumConverter.Singleton,
                TickExtraUnionConverter.Singleton,
                TickRoundConverter.Singleton,
                SubtitleUnionConverter.Singleton,
                TitleAnchorUnionConverter.Singleton,
                TitleAnchorEnumConverter.Singleton,
                ValuesConverter.Singleton,
                TypeElementConverter.Singleton,
                FilterConverter.Singleton,
                ParseUnionConverter.Singleton,
                ParseEnumConverter.Singleton,
                RemoveConverter.Singleton,
                PurpleAsConverter.Singleton,
                AsAConverter.Singleton,
                BandwidthUnionConverter.Singleton,
                CaseUnionConverter.Singleton,
                CaseEnumConverter.Singleton,
                ColorElementConverter.Singleton,
                FunctionConverter.Singleton,
                CenterElementConverter.Singleton,
                FieldsUnionConverter.Singleton,
                FieldsFieldConverter.Singleton,
                RadiusConverter.Singleton,
                FontSizeRangeConverter.Singleton,
                ForceEnumConverter.Singleton,
                StrengthUnionConverter.Singleton,
                XUnionConverter.Singleton,
                FrameUnionConverter.Singleton,
                FrameElementConverter.Singleton,
                GroupbyUnionConverter.Singleton,
                TransformOffsetConverter.Singleton,
                OffsetEnumConverter.Singleton,
                TransformOpConverter.Singleton,
                PurpleOpConverter.Singleton,
                OpsConverter.Singleton,
                OpElementConverter.Singleton,
                FluffyOpConverter.Singleton,
                TransformOrientConverter.Singleton,
                PurpleOrientConverter.Singleton,
                PurpleParamsConverter.Singleton,
                ResolveUnionConverter.Singleton,
                ResolveEnumConverter.Singleton,
                ShapeUnionConverter.Singleton,
                ShapeEnumConverter.Singleton,
                SortUnionConverter.Singleton,
                SortFieldConverter.Singleton,
                PurpleFieldConverter.Singleton,
                PurpleOrderConverter.Singleton,
                OrderElementConverter.Singleton,
                OrderEnumConverter.Singleton,
                TimezoneUnionConverter.Singleton,
                TimezoneEnumConverter.Singleton,
                TranslateConverter.Singleton,
                PurpleTypeConverter.Singleton,
                UnitsUnionConverter.Singleton,
                ValuesUnionConverter.Singleton,
                ValueElementConverter.Singleton,
                LayoutAlignConverter.Singleton,
                GridAlignUnionConverter.Singleton,
                AlignEnumConverter.Singleton,
                BoundsUnionConverter.Singleton,
                BoundsEnumConverter.Singleton,
                CenterConverter.Singleton,
                FooterBandConverter.Singleton,
                HeaderBandConverter.Singleton,
                LayoutOffsetConverter.Singleton,
                LayoutPaddingConverter.Singleton,
                TitleAnchorConverter.Singleton,
                TitleAnchorColumnUnionConverter.Singleton,
                ColumnTitleAnchorConverter.Singleton,
                TitleBandConverter.Singleton,
                DirectionConverter.Singleton,
                LegendFormatConverter.Singleton,
                LegendOrientConverter.Singleton,
                FluffyOrientConverter.Singleton,
                TitleOrientUnionConverter.Singleton,
                LegendTypeConverter.Singleton,
                ClipConverter.Singleton,
                ExtentConverter.Singleton,
                FitConverter.Singleton,
                BinsConverter.Singleton,
                ScaleDomainConverter.Singleton,
                DomainElementConverter.Singleton,
                V59216_Converter.Singleton,
                FluffyFieldConverter.Singleton,
                DomainSortConverter.Singleton,
                DomainRawConverter.Singleton,
                InterpolateConverter.Singleton,
                NiceConverter.Singleton,
                RangeUnionConverter.Singleton,
                V59217_Converter.Singleton,
                SchemeConverter.Singleton,
                RangeSortConverter.Singleton,
                RangeEnumConverter.Singleton,
                ScaleTypeConverter.Singleton,
                EventsConverter.Singleton,
                UpdateConverter.Singleton,
                PushConverter.Singleton,
                MarkTitleConverter.Singleton,
                TitleFrameConverter.Singleton,
                FrameEnumConverter.Singleton,
                TitleOrientConverter.Singleton,
                TentacledOrientConverter.Singleton,
                FluffyAsConverter.Singleton,
                MethodUnionConverter.Singleton,
                MethodEnumConverter.Singleton,
                FluffyTypeConverter.Singleton,
                VegaSpecificationPaddingConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class AutosizeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Autosize) || t == typeof(Autosize?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    switch (stringValue)
                    {
                        case "fit":
                            return new Autosize { Enum = AutosizeEnum.Fit };
                        case "fit-x":
                            return new Autosize { Enum = AutosizeEnum.FitX };
                        case "fit-y":
                            return new Autosize { Enum = AutosizeEnum.FitY };
                        case "none":
                            return new Autosize { Enum = AutosizeEnum.None };
                        case "pad":
                            return new Autosize { Enum = AutosizeEnum.Pad };
                    }
                    break;
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<AutosizeType>(reader);
                    return new Autosize { AutosizeType = objectValue };
            }
            throw new Exception("Cannot unmarshal type Autosize");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (Autosize)untypedValue;
            if (value.Enum != null)
            {
                switch (value.Enum)
                {
                    case AutosizeEnum.Fit:
                        serializer.Serialize(writer, "fit");
                        return;
                    case AutosizeEnum.FitX:
                        serializer.Serialize(writer, "fit-x");
                        return;
                    case AutosizeEnum.FitY:
                        serializer.Serialize(writer, "fit-y");
                        return;
                    case AutosizeEnum.None:
                        serializer.Serialize(writer, "none");
                        return;
                    case AutosizeEnum.Pad:
                        serializer.Serialize(writer, "pad");
                        return;
                }
            }
            if (value.AutosizeType != null)
            {
                serializer.Serialize(writer, value.AutosizeType);
                return;
            }
            throw new Exception("Cannot marshal type Autosize");
        }

        public static readonly AutosizeConverter Singleton = new AutosizeConverter();
    }

    internal class ContainsConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ContainsEnum) || t == typeof(ContainsEnum?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "content":
                    return ContainsEnum.Content;
                case "padding":
                    return ContainsEnum.Padding;
            }
            throw new Exception("Cannot unmarshal type Contains");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (ContainsEnum)untypedValue;
            switch (value)
            {
                case ContainsEnum.Content:
                    serializer.Serialize(writer, "content");
                    return;
                case ContainsEnum.Padding:
                    serializer.Serialize(writer, "padding");
                    return;
            }
            throw new Exception("Cannot marshal type Contains");
        }

        public static readonly ContainsConverter Singleton = new ContainsConverter();
    }

    internal class AutosizeEnumConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(AutosizeEnum) || t == typeof(AutosizeEnum?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "fit":
                    return AutosizeEnum.Fit;
                case "fit-x":
                    return AutosizeEnum.FitX;
                case "fit-y":
                    return AutosizeEnum.FitY;
                case "none":
                    return AutosizeEnum.None;
                case "pad":
                    return AutosizeEnum.Pad;
            }
            throw new Exception("Cannot unmarshal type AutosizeEnum");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (AutosizeEnum)untypedValue;
            switch (value)
            {
                case AutosizeEnum.Fit:
                    serializer.Serialize(writer, "fit");
                    return;
                case AutosizeEnum.FitX:
                    serializer.Serialize(writer, "fit-x");
                    return;
                case AutosizeEnum.FitY:
                    serializer.Serialize(writer, "fit-y");
                    return;
                case AutosizeEnum.None:
                    serializer.Serialize(writer, "none");
                    return;
                case AutosizeEnum.Pad:
                    serializer.Serialize(writer, "pad");
                    return;
            }
            throw new Exception("Cannot marshal type AutosizeEnum");
        }

        public static readonly AutosizeEnumConverter Singleton = new AutosizeEnumConverter();
    }

    internal class BandPositionConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(BandPosition) || t == typeof(BandPosition?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Integer:
                case JsonToken.Float:
                    var doubleValue = serializer.Deserialize<double>(reader);
                    return new BandPosition { Double = doubleValue };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<SType>(reader);
                    return new BandPosition { SType = objectValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<List<BandPositionElement>>(reader);
                    return new BandPosition { BandPositionElementArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type BandPosition");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (BandPosition)untypedValue;
            if (value.Double != null)
            {
                serializer.Serialize(writer, value.Double.Value);
                return;
            }
            if (value.BandPositionElementArray != null)
            {
                serializer.Serialize(writer, value.BandPositionElementArray);
                return;
            }
            if (value.SType != null)
            {
                serializer.Serialize(writer, value.SType);
                return;
            }
            throw new Exception("Cannot marshal type BandPosition");
        }

        public static readonly BandPositionConverter Singleton = new BandPositionConverter();
    }

    internal class BandConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Band) || t == typeof(Band?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Integer:
                case JsonToken.Float:
                    var doubleValue = serializer.Deserialize<double>(reader);
                    return new Band { Double = doubleValue };
                case JsonToken.Boolean:
                    var boolValue = serializer.Deserialize<bool>(reader);
                    return new Band { Bool = boolValue };
            }
            throw new Exception("Cannot unmarshal type Band");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (Band)untypedValue;
            if (value.Double != null)
            {
                serializer.Serialize(writer, value.Double.Value);
                return;
            }
            if (value.Bool != null)
            {
                serializer.Serialize(writer, value.Bool.Value);
                return;
            }
            throw new Exception("Cannot marshal type Band");
        }

        public static readonly BandConverter Singleton = new BandConverter();
    }

    internal class ScaleConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Scale) || t == typeof(Scale?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    return new Scale { String = stringValue };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<GradientType>(reader);
                    return new Scale { GradientType = objectValue };
            }
            throw new Exception("Cannot unmarshal type Scale");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (Scale)untypedValue;
            if (value.String != null)
            {
                serializer.Serialize(writer, value.String);
                return;
            }
            if (value.GradientType != null)
            {
                serializer.Serialize(writer, value.GradientType);
                return;
            }
            throw new Exception("Cannot marshal type Scale");
        }

        public static readonly ScaleConverter Singleton = new ScaleConverter();
    }

    internal class DomainColorUnionConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(DomainColorUnion) || t == typeof(DomainColorUnion?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Null:
                    return new DomainColorUnion { };
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    return new DomainColorUnion { String = stringValue };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<DomainColorType>(reader);
                    return new DomainColorUnion { DomainColorType = objectValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<List<DomainColorElement>>(reader);
                    return new DomainColorUnion { DomainColorElementArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type DomainColorUnion");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (DomainColorUnion)untypedValue;
            if (value.IsNull)
            {
                serializer.Serialize(writer, null);
                return;
            }
            if (value.String != null)
            {
                serializer.Serialize(writer, value.String);
                return;
            }
            if (value.DomainColorElementArray != null)
            {
                serializer.Serialize(writer, value.DomainColorElementArray);
                return;
            }
            if (value.DomainColorType != null)
            {
                serializer.Serialize(writer, value.DomainColorType);
                return;
            }
            throw new Exception("Cannot marshal type DomainColorUnion");
        }

        public static readonly DomainColorUnionConverter Singleton = new DomainColorUnionConverter();
    }

    internal class AngleUnionConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(AngleUnion) || t == typeof(AngleUnion?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<SType>(reader);
                    return new AngleUnion { SType = objectValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<List<BandPositionElement>>(reader);
                    return new AngleUnion { BandPositionElementArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type AngleUnion");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (AngleUnion)untypedValue;
            if (value.BandPositionElementArray != null)
            {
                serializer.Serialize(writer, value.BandPositionElementArray);
                return;
            }
            if (value.SType != null)
            {
                serializer.Serialize(writer, value.SType);
                return;
            }
            throw new Exception("Cannot marshal type AngleUnion");
        }

        public static readonly AngleUnionConverter Singleton = new AngleUnionConverter();
    }

    internal class AxeDomainDashConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(AxeDomainDash) || t == typeof(AxeDomainDash?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<DashType>(reader);
                    return new AxeDomainDash { DashType = objectValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<List<DomainDashElement>>(reader);
                    return new AxeDomainDash { AnythingArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type AxeDomainDash");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (AxeDomainDash)untypedValue;
            if (value.AnythingArray != null)
            {
                serializer.Serialize(writer, value.AnythingArray);
                return;
            }
            if (value.DashType != null)
            {
                serializer.Serialize(writer, value.DashType);
                return;
            }
            throw new Exception("Cannot marshal type AxeDomainDash");
        }

        public static readonly AxeDomainDashConverter Singleton = new AxeDomainDashConverter();
    }

    internal class DomainDashElementConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(DomainDashElement) || t == typeof(DomainDashElement?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Integer:
                case JsonToken.Float:
                    var doubleValue = serializer.Deserialize<double>(reader);
                    return new DomainDashElement { Double = doubleValue };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<StrokeDashElement>(reader);
                    return new DomainDashElement { StrokeDashElement = objectValue };
            }
            throw new Exception("Cannot unmarshal type DomainDashElement");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (DomainDashElement)untypedValue;
            if (value.Double != null)
            {
                serializer.Serialize(writer, value.Double.Value);
                return;
            }
            if (value.StrokeDashElement != null)
            {
                serializer.Serialize(writer, value.StrokeDashElement);
                return;
            }
            throw new Exception("Cannot marshal type DomainDashElement");
        }

        public static readonly DomainDashElementConverter Singleton = new DomainDashElementConverter();
    }

    internal class EnterAlignConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(EncodeAlign) || t == typeof(EncodeAlign?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<AlignType>(reader);
                    return new EncodeAlign { AlignType = objectValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<List<LabelAlignElement>>(reader);
                    return new EncodeAlign { LabelAlignElementArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type EnterAlign");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (EncodeAlign)untypedValue;
            if (value.LabelAlignElementArray != null)
            {
                serializer.Serialize(writer, value.LabelAlignElementArray);
                return;
            }
            if (value.AlignType != null)
            {
                serializer.Serialize(writer, value.AlignType);
                return;
            }
            throw new Exception("Cannot marshal type EnterAlign");
        }

        public static readonly EnterAlignConverter Singleton = new EnterAlignConverter();
    }

    internal class AspectConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Aspect) || t == typeof(Aspect?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<TickRoundType>(reader);
                    return new Aspect { TickRoundType = objectValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<List<TickRoundElement>>(reader);
                    return new Aspect { TickRoundElementArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type Aspect");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (Aspect)untypedValue;
            if (value.TickRoundElementArray != null)
            {
                serializer.Serialize(writer, value.TickRoundElementArray);
                return;
            }
            if (value.TickRoundType != null)
            {
                serializer.Serialize(writer, value.TickRoundType);
                return;
            }
            throw new Exception("Cannot marshal type Aspect");
        }

        public static readonly AspectConverter Singleton = new AspectConverter();
    }

    internal class EnterBaselineConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(EncodeBaseline) || t == typeof(EncodeBaseline?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<LabelBaselineType>(reader);
                    return new EncodeBaseline { LabelBaselineType = objectValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<List<LabelBaselineElement>>(reader);
                    return new EncodeBaseline { LabelBaselineElementArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type EnterBaseline");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (EncodeBaseline)untypedValue;
            if (value.LabelBaselineElementArray != null)
            {
                serializer.Serialize(writer, value.LabelBaselineElementArray);
                return;
            }
            if (value.LabelBaselineType != null)
            {
                serializer.Serialize(writer, value.LabelBaselineType);
                return;
            }
            throw new Exception("Cannot marshal type EnterBaseline");
        }

        public static readonly EnterBaselineConverter Singleton = new EnterBaselineConverter();
    }

    internal class CursorConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Cursor) || t == typeof(Cursor?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<EllipsisType>(reader);
                    return new Cursor { EllipsisType = objectValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<List<LabelFontElement>>(reader);
                    return new Cursor { LabelFontElementArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type Cursor");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (Cursor)untypedValue;
            if (value.LabelFontElementArray != null)
            {
                serializer.Serialize(writer, value.LabelFontElementArray);
                return;
            }
            if (value.EllipsisType != null)
            {
                serializer.Serialize(writer, value.EllipsisType);
                return;
            }
            throw new Exception("Cannot marshal type Cursor");
        }

        public static readonly CursorConverter Singleton = new CursorConverter();
    }

    internal class FillUnionConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(FillUnion) || t == typeof(FillUnion?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<DomainColorElementType>(reader);
                    return new FillUnion { DomainColorElementType = objectValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<List<DomainColorElement>>(reader);
                    return new FillUnion { DomainColorElementArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type FillUnion");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (FillUnion)untypedValue;
            if (value.DomainColorElementArray != null)
            {
                serializer.Serialize(writer, value.DomainColorElementArray);
                return;
            }
            if (value.DomainColorElementType != null)
            {
                serializer.Serialize(writer, value.DomainColorElementType);
                return;
            }
            throw new Exception("Cannot marshal type FillUnion");
        }

        public static readonly FillUnionConverter Singleton = new FillUnionConverter();
    }

    internal class EnterFontWeightConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(EncodeFontWeight) || t == typeof(EncodeFontWeight?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<LabelFontWeightType>(reader);
                    return new EncodeFontWeight { LabelFontWeightType = objectValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<List<LabelFontWeightElement>>(reader);
                    return new EncodeFontWeight { LabelFontWeightElementArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type EnterFontWeight");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (EncodeFontWeight)untypedValue;
            if (value.LabelFontWeightElementArray != null)
            {
                serializer.Serialize(writer, value.LabelFontWeightElementArray);
                return;
            }
            if (value.LabelFontWeightType != null)
            {
                serializer.Serialize(writer, value.LabelFontWeightType);
                return;
            }
            throw new Exception("Cannot marshal type EnterFontWeight");
        }

        public static readonly EnterFontWeightConverter Singleton = new EnterFontWeightConverter();
    }

    internal class EnterOrientConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(EncodeOrient) || t == typeof(EncodeOrient?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<EncodeOrientType>(reader);
                    return new EncodeOrient { EncodeOrientType = objectValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<List<OrientElement>>(reader);
                    return new EncodeOrient { OrientElementArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type EnterOrient");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (EncodeOrient)untypedValue;
            if (value.OrientElementArray != null)
            {
                serializer.Serialize(writer, value.OrientElementArray);
                return;
            }
            if (value.EncodeOrientType != null)
            {
                serializer.Serialize(writer, value.EncodeOrientType);
                return;
            }
            throw new Exception("Cannot marshal type EnterOrient");
        }

        public static readonly EnterOrientConverter Singleton = new EnterOrientConverter();
    }

    internal class StrokeCapConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(StrokeCap) || t == typeof(StrokeCap?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<StrokeCapType>(reader);
                    return new StrokeCap { StrokeCapType = objectValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<List<StrokeCapElement>>(reader);
                    return new StrokeCap { StrokeCapElementArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type StrokeCap");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (StrokeCap)untypedValue;
            if (value.StrokeCapElementArray != null)
            {
                serializer.Serialize(writer, value.StrokeCapElementArray);
                return;
            }
            if (value.StrokeCapType != null)
            {
                serializer.Serialize(writer, value.StrokeCapType);
                return;
            }
            throw new Exception("Cannot marshal type StrokeCap");
        }

        public static readonly StrokeCapConverter Singleton = new StrokeCapConverter();
    }

    internal class StrokeDashUnionConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(StrokeDashUnion) || t == typeof(StrokeDashUnion?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<DashType>(reader);
                    return new StrokeDashUnion { DashType = objectValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<List<StrokeDashElement>>(reader);
                    return new StrokeDashUnion { StrokeDashElementArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type StrokeDashUnion");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (StrokeDashUnion)untypedValue;
            if (value.StrokeDashElementArray != null)
            {
                serializer.Serialize(writer, value.StrokeDashElementArray);
                return;
            }
            if (value.DashType != null)
            {
                serializer.Serialize(writer, value.DashType);
                return;
            }
            throw new Exception("Cannot marshal type StrokeDashUnion");
        }

        public static readonly StrokeDashUnionConverter Singleton = new StrokeDashUnionConverter();
    }

    internal class StrokeJoinConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(StrokeJoin) || t == typeof(StrokeJoin?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<StrokeJoinType>(reader);
                    return new StrokeJoin { StrokeJoinType = objectValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<List<StrokeJoinElement>>(reader);
                    return new StrokeJoin { StrokeJoinElementArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type StrokeJoin");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (StrokeJoin)untypedValue;
            if (value.StrokeJoinElementArray != null)
            {
                serializer.Serialize(writer, value.StrokeJoinElementArray);
                return;
            }
            if (value.StrokeJoinType != null)
            {
                serializer.Serialize(writer, value.StrokeJoinType);
                return;
            }
            throw new Exception("Cannot marshal type StrokeJoin");
        }

        public static readonly StrokeJoinConverter Singleton = new StrokeJoinConverter();
    }

    internal class TextConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Text) || t == typeof(Text?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<TextType>(reader);
                    return new Text { TextType = objectValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<List<TextElement>>(reader);
                    return new Text { TextElementArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type Text");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (Text)untypedValue;
            if (value.TextElementArray != null)
            {
                serializer.Serialize(writer, value.TextElementArray);
                return;
            }
            if (value.TextType != null)
            {
                serializer.Serialize(writer, value.TextType);
                return;
            }
            throw new Exception("Cannot marshal type Text");
        }

        public static readonly TextConverter Singleton = new TextConverter();
    }

    internal class TooltipConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Tooltip) || t == typeof(Tooltip?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<TooltipType>(reader);
                    return new Tooltip { TooltipType = objectValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<List<TooltipElement>>(reader);
                    return new Tooltip { TooltipElementArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type Tooltip");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (Tooltip)untypedValue;
            if (value.TooltipElementArray != null)
            {
                serializer.Serialize(writer, value.TooltipElementArray);
                return;
            }
            if (value.TooltipType != null)
            {
                serializer.Serialize(writer, value.TooltipType);
                return;
            }
            throw new Exception("Cannot marshal type Tooltip");
        }

        public static readonly TooltipConverter Singleton = new TooltipConverter();
    }

    internal class ValueConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Value) || t == typeof(Value?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    return new Value { String = stringValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<List<string>>(reader);
                    return new Value { StringArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type Value");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (Value)untypedValue;
            if (value.String != null)
            {
                serializer.Serialize(writer, value.String);
                return;
            }
            if (value.StringArray != null)
            {
                serializer.Serialize(writer, value.StringArray);
                return;
            }
            throw new Exception("Cannot marshal type Value");
        }

        public static readonly ValueConverter Singleton = new ValueConverter();
    }

    internal class AxeFormatConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(AxeFormat) || t == typeof(AxeFormat?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    return new AxeFormat { String = stringValue };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<AxeFormatType>(reader);
                    return new AxeFormat { AxeFormatType = objectValue };
            }
            throw new Exception("Cannot unmarshal type AxeFormat");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (AxeFormat)untypedValue;
            if (value.String != null)
            {
                serializer.Serialize(writer, value.String);
                return;
            }
            if (value.AxeFormatType != null)
            {
                serializer.Serialize(writer, value.AxeFormatType);
                return;
            }
            throw new Exception("Cannot marshal type AxeFormat");
        }

        public static readonly AxeFormatConverter Singleton = new AxeFormatConverter();
    }

    internal class FormatTypeUnionConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(FormatTypeUnion) || t == typeof(FormatTypeUnion?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    switch (stringValue)
                    {
                        case "number":
                            return new FormatTypeUnion { Enum = FormatTypeEnum.Number };
                        case "time":
                            return new FormatTypeUnion { Enum = FormatTypeEnum.Time };
                        case "utc":
                            return new FormatTypeUnion { Enum = FormatTypeEnum.Utc };
                    }
                    break;
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<BoundsType>(reader);
                    return new FormatTypeUnion { BoundsType = objectValue };
            }
            throw new Exception("Cannot unmarshal type FormatTypeUnion");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (FormatTypeUnion)untypedValue;
            if (value.Enum != null)
            {
                switch (value.Enum)
                {
                    case FormatTypeEnum.Number:
                        serializer.Serialize(writer, "number");
                        return;
                    case FormatTypeEnum.Time:
                        serializer.Serialize(writer, "time");
                        return;
                    case FormatTypeEnum.Utc:
                        serializer.Serialize(writer, "utc");
                        return;
                }
            }
            if (value.BoundsType != null)
            {
                serializer.Serialize(writer, value.BoundsType);
                return;
            }
            throw new Exception("Cannot marshal type FormatTypeUnion");
        }

        public static readonly FormatTypeUnionConverter Singleton = new FormatTypeUnionConverter();
    }

    internal class FormatTypeEnumConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(FormatTypeEnum) || t == typeof(FormatTypeEnum?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "number":
                    return FormatTypeEnum.Number;
                case "time":
                    return FormatTypeEnum.Time;
                case "utc":
                    return FormatTypeEnum.Utc;
            }
            throw new Exception("Cannot unmarshal type FormatTypeEnum");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (FormatTypeEnum)untypedValue;
            switch (value)
            {
                case FormatTypeEnum.Number:
                    serializer.Serialize(writer, "number");
                    return;
                case FormatTypeEnum.Time:
                    serializer.Serialize(writer, "time");
                    return;
                case FormatTypeEnum.Utc:
                    serializer.Serialize(writer, "utc");
                    return;
            }
            throw new Exception("Cannot marshal type FormatTypeEnum");
        }

        public static readonly FormatTypeEnumConverter Singleton = new FormatTypeEnumConverter();
    }

    internal class LabelAlignUnionConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(LabelAlignUnion) || t == typeof(LabelAlignUnion?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    switch (stringValue)
                    {
                        case "center":
                            return new LabelAlignUnion { Enum = LabelAlignEnum.Center };
                        case "left":
                            return new LabelAlignUnion { Enum = LabelAlignEnum.Left };
                        case "right":
                            return new LabelAlignUnion { Enum = LabelAlignEnum.Right };
                    }
                    break;
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<AlignType>(reader);
                    return new LabelAlignUnion { AlignType = objectValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<List<LabelAlignElement>>(reader);
                    return new LabelAlignUnion { LabelAlignElementArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type LabelAlignUnion");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (LabelAlignUnion)untypedValue;
            if (value.Enum != null)
            {
                switch (value.Enum)
                {
                    case LabelAlignEnum.Center:
                        serializer.Serialize(writer, "center");
                        return;
                    case LabelAlignEnum.Left:
                        serializer.Serialize(writer, "left");
                        return;
                    case LabelAlignEnum.Right:
                        serializer.Serialize(writer, "right");
                        return;
                }
            }
            if (value.LabelAlignElementArray != null)
            {
                serializer.Serialize(writer, value.LabelAlignElementArray);
                return;
            }
            if (value.AlignType != null)
            {
                serializer.Serialize(writer, value.AlignType);
                return;
            }
            throw new Exception("Cannot marshal type LabelAlignUnion");
        }

        public static readonly LabelAlignUnionConverter Singleton = new LabelAlignUnionConverter();
    }

    internal class LabelAlignEnumConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(LabelAlignEnum) || t == typeof(LabelAlignEnum?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "center":
                    return LabelAlignEnum.Center;
                case "left":
                    return LabelAlignEnum.Left;
                case "right":
                    return LabelAlignEnum.Right;
            }
            throw new Exception("Cannot unmarshal type LabelAlignEnum");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (LabelAlignEnum)untypedValue;
            switch (value)
            {
                case LabelAlignEnum.Center:
                    serializer.Serialize(writer, "center");
                    return;
                case LabelAlignEnum.Left:
                    serializer.Serialize(writer, "left");
                    return;
                case LabelAlignEnum.Right:
                    serializer.Serialize(writer, "right");
                    return;
            }
            throw new Exception("Cannot marshal type LabelAlignEnum");
        }

        public static readonly LabelAlignEnumConverter Singleton = new LabelAlignEnumConverter();
    }

    internal class LabelBaselineUnionConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(LabelBaselineUnion) || t == typeof(LabelBaselineUnion?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    switch (stringValue)
                    {
                        case "alphabetic":
                            return new LabelBaselineUnion { Enum = LabelBaselineEnum.Alphabetic };
                        case "bottom":
                            return new LabelBaselineUnion { Enum = LabelBaselineEnum.Bottom };
                        case "middle":
                            return new LabelBaselineUnion { Enum = LabelBaselineEnum.Middle };
                        case "top":
                            return new LabelBaselineUnion { Enum = LabelBaselineEnum.Top };
                    }
                    break;
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<LabelBaselineType>(reader);
                    return new LabelBaselineUnion { LabelBaselineType = objectValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<List<LabelBaselineElement>>(reader);
                    return new LabelBaselineUnion { LabelBaselineElementArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type LabelBaselineUnion");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (LabelBaselineUnion)untypedValue;
            if (value.Enum != null)
            {
                switch (value.Enum)
                {
                    case LabelBaselineEnum.Alphabetic:
                        serializer.Serialize(writer, "alphabetic");
                        return;
                    case LabelBaselineEnum.Bottom:
                        serializer.Serialize(writer, "bottom");
                        return;
                    case LabelBaselineEnum.Middle:
                        serializer.Serialize(writer, "middle");
                        return;
                    case LabelBaselineEnum.Top:
                        serializer.Serialize(writer, "top");
                        return;
                }
            }
            if (value.LabelBaselineElementArray != null)
            {
                serializer.Serialize(writer, value.LabelBaselineElementArray);
                return;
            }
            if (value.LabelBaselineType != null)
            {
                serializer.Serialize(writer, value.LabelBaselineType);
                return;
            }
            throw new Exception("Cannot marshal type LabelBaselineUnion");
        }

        public static readonly LabelBaselineUnionConverter Singleton = new LabelBaselineUnionConverter();
    }

    internal class LabelBaselineEnumConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(LabelBaselineEnum) || t == typeof(LabelBaselineEnum?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "alphabetic":
                    return LabelBaselineEnum.Alphabetic;
                case "bottom":
                    return LabelBaselineEnum.Bottom;
                case "middle":
                    return LabelBaselineEnum.Middle;
                case "top":
                    return LabelBaselineEnum.Top;
            }
            throw new Exception("Cannot unmarshal type LabelBaselineEnum");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (LabelBaselineEnum)untypedValue;
            switch (value)
            {
                case LabelBaselineEnum.Alphabetic:
                    serializer.Serialize(writer, "alphabetic");
                    return;
                case LabelBaselineEnum.Bottom:
                    serializer.Serialize(writer, "bottom");
                    return;
                case LabelBaselineEnum.Middle:
                    serializer.Serialize(writer, "middle");
                    return;
                case LabelBaselineEnum.Top:
                    serializer.Serialize(writer, "top");
                    return;
            }
            throw new Exception("Cannot marshal type LabelBaselineEnum");
        }

        public static readonly LabelBaselineEnumConverter Singleton = new LabelBaselineEnumConverter();
    }

    internal class LabelBoundConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(LabelBound) || t == typeof(LabelBound?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Integer:
                case JsonToken.Float:
                    var doubleValue = serializer.Deserialize<double>(reader);
                    return new LabelBound { Double = doubleValue };
                case JsonToken.Boolean:
                    var boolValue = serializer.Deserialize<bool>(reader);
                    return new LabelBound { Bool = boolValue };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<BoundsType>(reader);
                    return new LabelBound { BoundsType = objectValue };
            }
            throw new Exception("Cannot unmarshal type LabelBound");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (LabelBound)untypedValue;
            if (value.Double != null)
            {
                serializer.Serialize(writer, value.Double.Value);
                return;
            }
            if (value.Bool != null)
            {
                serializer.Serialize(writer, value.Bool.Value);
                return;
            }
            if (value.BoundsType != null)
            {
                serializer.Serialize(writer, value.BoundsType);
                return;
            }
            throw new Exception("Cannot marshal type LabelBound");
        }

        public static readonly LabelBoundConverter Singleton = new LabelBoundConverter();
    }

    internal class ColumnsElementConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ColumnsElement) || t == typeof(ColumnsElement?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Integer:
                case JsonToken.Float:
                    var doubleValue = serializer.Deserialize<double>(reader);
                    return new ColumnsElement { Double = doubleValue };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<BoundsType>(reader);
                    return new ColumnsElement { BoundsType = objectValue };
            }
            throw new Exception("Cannot unmarshal type ColumnsElement");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (ColumnsElement)untypedValue;
            if (value.Double != null)
            {
                serializer.Serialize(writer, value.Double.Value);
                return;
            }
            if (value.BoundsType != null)
            {
                serializer.Serialize(writer, value.BoundsType);
                return;
            }
            throw new Exception("Cannot marshal type ColumnsElement");
        }

        public static readonly ColumnsElementConverter Singleton = new ColumnsElementConverter();
    }

    internal class LabelFontConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(LabelFont) || t == typeof(LabelFont?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    return new LabelFont { String = stringValue };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<EllipsisType>(reader);
                    return new LabelFont { EllipsisType = objectValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<List<LabelFontElement>>(reader);
                    return new LabelFont { LabelFontElementArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type LabelFont");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (LabelFont)untypedValue;
            if (value.String != null)
            {
                serializer.Serialize(writer, value.String);
                return;
            }
            if (value.LabelFontElementArray != null)
            {
                serializer.Serialize(writer, value.LabelFontElementArray);
                return;
            }
            if (value.EllipsisType != null)
            {
                serializer.Serialize(writer, value.EllipsisType);
                return;
            }
            throw new Exception("Cannot marshal type LabelFont");
        }

        public static readonly LabelFontConverter Singleton = new LabelFontConverter();
    }

    internal class LabelFontWeightUnionConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(LabelFontWeightUnion) || t == typeof(LabelFontWeightUnion?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Null:
                    return new LabelFontWeightUnion { };
                case JsonToken.Integer:
                    var integerValue = serializer.Deserialize<long>(reader);
                    return new LabelFontWeightUnion { Integer = integerValue };
                case JsonToken.Float:
                    var doubleValue = serializer.Deserialize<double>(reader);
                    return new LabelFontWeightUnion { Double = doubleValue };
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    switch (stringValue)
                    {
                        case "100":
                            return new LabelFontWeightUnion { Enum = LabelFontWeightEnum.OneHundred };
                        case "200":
                            return new LabelFontWeightUnion { Enum = LabelFontWeightEnum.TwoHundred };
                        case "300":
                            return new LabelFontWeightUnion { Enum = LabelFontWeightEnum.ThreeHundred };
                        case "400":
                            return new LabelFontWeightUnion { Enum = LabelFontWeightEnum.FourHundred };
                        case "500":
                            return new LabelFontWeightUnion { Enum = LabelFontWeightEnum.FiveHundred };
                        case "600":
                            return new LabelFontWeightUnion { Enum = LabelFontWeightEnum.SixHundred };
                        case "700":
                            return new LabelFontWeightUnion { Enum = LabelFontWeightEnum.SevenHundred };
                        case "800":
                            return new LabelFontWeightUnion { Enum = LabelFontWeightEnum.EightHundred };
                        case "900":
                            return new LabelFontWeightUnion { Enum = LabelFontWeightEnum.NineHundred };
                        case "bold":
                            return new LabelFontWeightUnion { Enum = LabelFontWeightEnum.Bold };
                        case "bolder":
                            return new LabelFontWeightUnion { Enum = LabelFontWeightEnum.Bolder };
                        case "lighter":
                            return new LabelFontWeightUnion { Enum = LabelFontWeightEnum.Lighter };
                        case "normal":
                            return new LabelFontWeightUnion { Enum = LabelFontWeightEnum.Normal };
                    }
                    break;
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<LabelFontWeightType>(reader);
                    return new LabelFontWeightUnion { LabelFontWeightType = objectValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<List<LabelFontWeightElement>>(reader);
                    return new LabelFontWeightUnion { LabelFontWeightElementArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type LabelFontWeightUnion");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (LabelFontWeightUnion)untypedValue;
            if (value.IsNull)
            {
                serializer.Serialize(writer, null);
                return;
            }
            if (value.Integer != null)
            {
                serializer.Serialize(writer, value.Integer.Value);
                return;
            }
            if (value.Double != null)
            {
                serializer.Serialize(writer, value.Double.Value);
                return;
            }
            if (value.Enum != null)
            {
                switch (value.Enum)
                {
                    case LabelFontWeightEnum.OneHundred:
                        serializer.Serialize(writer, "100");
                        return;
                    case LabelFontWeightEnum.TwoHundred:
                        serializer.Serialize(writer, "200");
                        return;
                    case LabelFontWeightEnum.ThreeHundred:
                        serializer.Serialize(writer, "300");
                        return;
                    case LabelFontWeightEnum.FourHundred:
                        serializer.Serialize(writer, "400");
                        return;
                    case LabelFontWeightEnum.FiveHundred:
                        serializer.Serialize(writer, "500");
                        return;
                    case LabelFontWeightEnum.SixHundred:
                        serializer.Serialize(writer, "600");
                        return;
                    case LabelFontWeightEnum.SevenHundred:
                        serializer.Serialize(writer, "700");
                        return;
                    case LabelFontWeightEnum.EightHundred:
                        serializer.Serialize(writer, "800");
                        return;
                    case LabelFontWeightEnum.NineHundred:
                        serializer.Serialize(writer, "900");
                        return;
                    case LabelFontWeightEnum.Bold:
                        serializer.Serialize(writer, "bold");
                        return;
                    case LabelFontWeightEnum.Bolder:
                        serializer.Serialize(writer, "bolder");
                        return;
                    case LabelFontWeightEnum.Lighter:
                        serializer.Serialize(writer, "lighter");
                        return;
                    case LabelFontWeightEnum.Normal:
                        serializer.Serialize(writer, "normal");
                        return;
                }
            }
            if (value.LabelFontWeightElementArray != null)
            {
                serializer.Serialize(writer, value.LabelFontWeightElementArray);
                return;
            }
            if (value.LabelFontWeightType != null)
            {
                serializer.Serialize(writer, value.LabelFontWeightType);
                return;
            }
            throw new Exception("Cannot marshal type LabelFontWeightUnion");
        }

        public static readonly LabelFontWeightUnionConverter Singleton = new LabelFontWeightUnionConverter();
    }

    internal class LabelFontWeightEnumConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(LabelFontWeightEnum) || t == typeof(LabelFontWeightEnum?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "100":
                    return LabelFontWeightEnum.OneHundred;
                case "200":
                    return LabelFontWeightEnum.TwoHundred;
                case "300":
                    return LabelFontWeightEnum.ThreeHundred;
                case "400":
                    return LabelFontWeightEnum.FourHundred;
                case "500":
                    return LabelFontWeightEnum.FiveHundred;
                case "600":
                    return LabelFontWeightEnum.SixHundred;
                case "700":
                    return LabelFontWeightEnum.SevenHundred;
                case "800":
                    return LabelFontWeightEnum.EightHundred;
                case "900":
                    return LabelFontWeightEnum.NineHundred;
                case "bold":
                    return LabelFontWeightEnum.Bold;
                case "bolder":
                    return LabelFontWeightEnum.Bolder;
                case "lighter":
                    return LabelFontWeightEnum.Lighter;
                case "normal":
                    return LabelFontWeightEnum.Normal;
            }
            throw new Exception("Cannot unmarshal type LabelFontWeightEnum");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (LabelFontWeightEnum)untypedValue;
            switch (value)
            {
                case LabelFontWeightEnum.OneHundred:
                    serializer.Serialize(writer, "100");
                    return;
                case LabelFontWeightEnum.TwoHundred:
                    serializer.Serialize(writer, "200");
                    return;
                case LabelFontWeightEnum.ThreeHundred:
                    serializer.Serialize(writer, "300");
                    return;
                case LabelFontWeightEnum.FourHundred:
                    serializer.Serialize(writer, "400");
                    return;
                case LabelFontWeightEnum.FiveHundred:
                    serializer.Serialize(writer, "500");
                    return;
                case LabelFontWeightEnum.SixHundred:
                    serializer.Serialize(writer, "600");
                    return;
                case LabelFontWeightEnum.SevenHundred:
                    serializer.Serialize(writer, "700");
                    return;
                case LabelFontWeightEnum.EightHundred:
                    serializer.Serialize(writer, "800");
                    return;
                case LabelFontWeightEnum.NineHundred:
                    serializer.Serialize(writer, "900");
                    return;
                case LabelFontWeightEnum.Bold:
                    serializer.Serialize(writer, "bold");
                    return;
                case LabelFontWeightEnum.Bolder:
                    serializer.Serialize(writer, "bolder");
                    return;
                case LabelFontWeightEnum.Lighter:
                    serializer.Serialize(writer, "lighter");
                    return;
                case LabelFontWeightEnum.Normal:
                    serializer.Serialize(writer, "normal");
                    return;
            }
            throw new Exception("Cannot marshal type LabelFontWeightEnum");
        }

        public static readonly LabelFontWeightEnumConverter Singleton = new LabelFontWeightEnumConverter();
    }

    internal class LabelOverlapConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(LabelOverlap) || t == typeof(LabelOverlap?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Boolean:
                    var boolValue = serializer.Deserialize<bool>(reader);
                    return new LabelOverlap { Bool = boolValue };
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    switch (stringValue)
                    {
                        case "greedy":
                            return new LabelOverlap { Enum = LabelOverlapEnum.Greedy };
                        case "parity":
                            return new LabelOverlap { Enum = LabelOverlapEnum.Parity };
                    }
                    break;
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<BoundsType>(reader);
                    return new LabelOverlap { BoundsType = objectValue };
            }
            throw new Exception("Cannot unmarshal type LabelOverlap");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (LabelOverlap)untypedValue;
            if (value.Bool != null)
            {
                serializer.Serialize(writer, value.Bool.Value);
                return;
            }
            if (value.Enum != null)
            {
                switch (value.Enum)
                {
                    case LabelOverlapEnum.Greedy:
                        serializer.Serialize(writer, "greedy");
                        return;
                    case LabelOverlapEnum.Parity:
                        serializer.Serialize(writer, "parity");
                        return;
                }
            }
            if (value.BoundsType != null)
            {
                serializer.Serialize(writer, value.BoundsType);
                return;
            }
            throw new Exception("Cannot marshal type LabelOverlap");
        }

        public static readonly LabelOverlapConverter Singleton = new LabelOverlapConverter();
    }

    internal class LabelOverlapEnumConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(LabelOverlapEnum) || t == typeof(LabelOverlapEnum?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "greedy":
                    return LabelOverlapEnum.Greedy;
                case "parity":
                    return LabelOverlapEnum.Parity;
            }
            throw new Exception("Cannot unmarshal type LabelOverlapEnum");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (LabelOverlapEnum)untypedValue;
            switch (value)
            {
                case LabelOverlapEnum.Greedy:
                    serializer.Serialize(writer, "greedy");
                    return;
                case LabelOverlapEnum.Parity:
                    serializer.Serialize(writer, "parity");
                    return;
            }
            throw new Exception("Cannot marshal type LabelOverlapEnum");
        }

        public static readonly LabelOverlapEnumConverter Singleton = new LabelOverlapEnumConverter();
    }

    internal class TitleOrientEnumConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(TitleOrientEnum) || t == typeof(TitleOrientEnum?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "bottom":
                    return TitleOrientEnum.Bottom;
                case "left":
                    return TitleOrientEnum.Left;
                case "right":
                    return TitleOrientEnum.Right;
                case "top":
                    return TitleOrientEnum.Top;
            }
            throw new Exception("Cannot unmarshal type TitleOrientEnum");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (TitleOrientEnum)untypedValue;
            switch (value)
            {
                case TitleOrientEnum.Bottom:
                    serializer.Serialize(writer, "bottom");
                    return;
                case TitleOrientEnum.Left:
                    serializer.Serialize(writer, "left");
                    return;
                case TitleOrientEnum.Right:
                    serializer.Serialize(writer, "right");
                    return;
                case TitleOrientEnum.Top:
                    serializer.Serialize(writer, "top");
                    return;
            }
            throw new Exception("Cannot marshal type TitleOrientEnum");
        }

        public static readonly TitleOrientEnumConverter Singleton = new TitleOrientEnumConverter();
    }

    internal class TickBandConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(TickBand) || t == typeof(TickBand?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    switch (stringValue)
                    {
                        case "center":
                            return new TickBand { Enum = TickBandEnum.Center };
                        case "extent":
                            return new TickBand { Enum = TickBandEnum.Extent };
                    }
                    break;
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<BoundsType>(reader);
                    return new TickBand { BoundsType = objectValue };
            }
            throw new Exception("Cannot unmarshal type TickBand");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (TickBand)untypedValue;
            if (value.Enum != null)
            {
                switch (value.Enum)
                {
                    case TickBandEnum.Center:
                        serializer.Serialize(writer, "center");
                        return;
                    case TickBandEnum.Extent:
                        serializer.Serialize(writer, "extent");
                        return;
                }
            }
            if (value.BoundsType != null)
            {
                serializer.Serialize(writer, value.BoundsType);
                return;
            }
            throw new Exception("Cannot marshal type TickBand");
        }

        public static readonly TickBandConverter Singleton = new TickBandConverter();
    }

    internal class TickBandEnumConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(TickBandEnum) || t == typeof(TickBandEnum?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "center":
                    return TickBandEnum.Center;
                case "extent":
                    return TickBandEnum.Extent;
            }
            throw new Exception("Cannot unmarshal type TickBandEnum");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (TickBandEnum)untypedValue;
            switch (value)
            {
                case TickBandEnum.Center:
                    serializer.Serialize(writer, "center");
                    return;
                case TickBandEnum.Extent:
                    serializer.Serialize(writer, "extent");
                    return;
            }
            throw new Exception("Cannot marshal type TickBandEnum");
        }

        public static readonly TickBandEnumConverter Singleton = new TickBandEnumConverter();
    }

    internal class TickCountConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(TickCount) || t == typeof(TickCount?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Integer:
                case JsonToken.Float:
                    var doubleValue = serializer.Deserialize<double>(reader);
                    return new TickCount { Double = doubleValue };
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    switch (stringValue)
                    {
                        case "day":
                            return new TickCount { Enum = TickCountEnum.Day };
                        case "hour":
                            return new TickCount { Enum = TickCountEnum.Hour };
                        case "millisecond":
                            return new TickCount { Enum = TickCountEnum.Millisecond };
                        case "minute":
                            return new TickCount { Enum = TickCountEnum.Minute };
                        case "month":
                            return new TickCount { Enum = TickCountEnum.Month };
                        case "second":
                            return new TickCount { Enum = TickCountEnum.Second };
                        case "week":
                            return new TickCount { Enum = TickCountEnum.Week };
                        case "year":
                            return new TickCount { Enum = TickCountEnum.Year };
                    }
                    break;
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<TickCountType>(reader);
                    return new TickCount { TickCountType = objectValue };
            }
            throw new Exception("Cannot unmarshal type TickCount");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (TickCount)untypedValue;
            if (value.Double != null)
            {
                serializer.Serialize(writer, value.Double.Value);
                return;
            }
            if (value.Enum != null)
            {
                switch (value.Enum)
                {
                    case TickCountEnum.Day:
                        serializer.Serialize(writer, "day");
                        return;
                    case TickCountEnum.Hour:
                        serializer.Serialize(writer, "hour");
                        return;
                    case TickCountEnum.Millisecond:
                        serializer.Serialize(writer, "millisecond");
                        return;
                    case TickCountEnum.Minute:
                        serializer.Serialize(writer, "minute");
                        return;
                    case TickCountEnum.Month:
                        serializer.Serialize(writer, "month");
                        return;
                    case TickCountEnum.Second:
                        serializer.Serialize(writer, "second");
                        return;
                    case TickCountEnum.Week:
                        serializer.Serialize(writer, "week");
                        return;
                    case TickCountEnum.Year:
                        serializer.Serialize(writer, "year");
                        return;
                }
            }
            if (value.TickCountType != null)
            {
                serializer.Serialize(writer, value.TickCountType);
                return;
            }
            throw new Exception("Cannot marshal type TickCount");
        }

        public static readonly TickCountConverter Singleton = new TickCountConverter();
    }

    internal class IntervalUnionConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(IntervalUnion) || t == typeof(IntervalUnion?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    switch (stringValue)
                    {
                        case "day":
                            return new IntervalUnion { Enum = TickCountEnum.Day };
                        case "hour":
                            return new IntervalUnion { Enum = TickCountEnum.Hour };
                        case "millisecond":
                            return new IntervalUnion { Enum = TickCountEnum.Millisecond };
                        case "minute":
                            return new IntervalUnion { Enum = TickCountEnum.Minute };
                        case "month":
                            return new IntervalUnion { Enum = TickCountEnum.Month };
                        case "second":
                            return new IntervalUnion { Enum = TickCountEnum.Second };
                        case "week":
                            return new IntervalUnion { Enum = TickCountEnum.Week };
                        case "year":
                            return new IntervalUnion { Enum = TickCountEnum.Year };
                    }
                    break;
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<BoundsType>(reader);
                    return new IntervalUnion { BoundsType = objectValue };
            }
            throw new Exception("Cannot unmarshal type IntervalUnion");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (IntervalUnion)untypedValue;
            if (value.Enum != null)
            {
                switch (value.Enum)
                {
                    case TickCountEnum.Day:
                        serializer.Serialize(writer, "day");
                        return;
                    case TickCountEnum.Hour:
                        serializer.Serialize(writer, "hour");
                        return;
                    case TickCountEnum.Millisecond:
                        serializer.Serialize(writer, "millisecond");
                        return;
                    case TickCountEnum.Minute:
                        serializer.Serialize(writer, "minute");
                        return;
                    case TickCountEnum.Month:
                        serializer.Serialize(writer, "month");
                        return;
                    case TickCountEnum.Second:
                        serializer.Serialize(writer, "second");
                        return;
                    case TickCountEnum.Week:
                        serializer.Serialize(writer, "week");
                        return;
                    case TickCountEnum.Year:
                        serializer.Serialize(writer, "year");
                        return;
                }
            }
            if (value.BoundsType != null)
            {
                serializer.Serialize(writer, value.BoundsType);
                return;
            }
            throw new Exception("Cannot marshal type IntervalUnion");
        }

        public static readonly IntervalUnionConverter Singleton = new IntervalUnionConverter();
    }

    internal class TickCountEnumConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(TickCountEnum) || t == typeof(TickCountEnum?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "day":
                    return TickCountEnum.Day;
                case "hour":
                    return TickCountEnum.Hour;
                case "millisecond":
                    return TickCountEnum.Millisecond;
                case "minute":
                    return TickCountEnum.Minute;
                case "month":
                    return TickCountEnum.Month;
                case "second":
                    return TickCountEnum.Second;
                case "week":
                    return TickCountEnum.Week;
                case "year":
                    return TickCountEnum.Year;
            }
            throw new Exception("Cannot unmarshal type TickCountEnum");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (TickCountEnum)untypedValue;
            switch (value)
            {
                case TickCountEnum.Day:
                    serializer.Serialize(writer, "day");
                    return;
                case TickCountEnum.Hour:
                    serializer.Serialize(writer, "hour");
                    return;
                case TickCountEnum.Millisecond:
                    serializer.Serialize(writer, "millisecond");
                    return;
                case TickCountEnum.Minute:
                    serializer.Serialize(writer, "minute");
                    return;
                case TickCountEnum.Month:
                    serializer.Serialize(writer, "month");
                    return;
                case TickCountEnum.Second:
                    serializer.Serialize(writer, "second");
                    return;
                case TickCountEnum.Week:
                    serializer.Serialize(writer, "week");
                    return;
                case TickCountEnum.Year:
                    serializer.Serialize(writer, "year");
                    return;
            }
            throw new Exception("Cannot marshal type TickCountEnum");
        }

        public static readonly TickCountEnumConverter Singleton = new TickCountEnumConverter();
    }

    internal class TickExtraUnionConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(TickExtraUnion) || t == typeof(TickExtraUnion?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Boolean:
                    var boolValue = serializer.Deserialize<bool>(reader);
                    return new TickExtraUnion { Bool = boolValue };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<BoundsType>(reader);
                    return new TickExtraUnion { BoundsType = objectValue };
            }
            throw new Exception("Cannot unmarshal type TickExtraUnion");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (TickExtraUnion)untypedValue;
            if (value.Bool != null)
            {
                serializer.Serialize(writer, value.Bool.Value);
                return;
            }
            if (value.BoundsType != null)
            {
                serializer.Serialize(writer, value.BoundsType);
                return;
            }
            throw new Exception("Cannot marshal type TickExtraUnion");
        }

        public static readonly TickExtraUnionConverter Singleton = new TickExtraUnionConverter();
    }

    internal class TickRoundConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(TickRound) || t == typeof(TickRound?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Boolean:
                    var boolValue = serializer.Deserialize<bool>(reader);
                    return new TickRound { Bool = boolValue };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<TickRoundType>(reader);
                    return new TickRound { TickRoundType = objectValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<List<TickRoundElement>>(reader);
                    return new TickRound { TickRoundElementArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type TickRound");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (TickRound)untypedValue;
            if (value.Bool != null)
            {
                serializer.Serialize(writer, value.Bool.Value);
                return;
            }
            if (value.TickRoundElementArray != null)
            {
                serializer.Serialize(writer, value.TickRoundElementArray);
                return;
            }
            if (value.TickRoundType != null)
            {
                serializer.Serialize(writer, value.TickRoundType);
                return;
            }
            throw new Exception("Cannot marshal type TickRound");
        }

        public static readonly TickRoundConverter Singleton = new TickRoundConverter();
    }

    internal class SubtitleUnionConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(SubtitleUnion) || t == typeof(SubtitleUnion?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    return new SubtitleUnion { String = stringValue };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<BoundsType>(reader);
                    return new SubtitleUnion { BoundsType = objectValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<List<string>>(reader);
                    return new SubtitleUnion { StringArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type SubtitleUnion");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (SubtitleUnion)untypedValue;
            if (value.String != null)
            {
                serializer.Serialize(writer, value.String);
                return;
            }
            if (value.StringArray != null)
            {
                serializer.Serialize(writer, value.StringArray);
                return;
            }
            if (value.BoundsType != null)
            {
                serializer.Serialize(writer, value.BoundsType);
                return;
            }
            throw new Exception("Cannot marshal type SubtitleUnion");
        }

        public static readonly SubtitleUnionConverter Singleton = new SubtitleUnionConverter();
    }

    internal class TitleAnchorUnionConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(TitleAnchorUnion) || t == typeof(TitleAnchorUnion?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Null:
                    return new TitleAnchorUnion { };
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    switch (stringValue)
                    {
                        case "end":
                            return new TitleAnchorUnion { Enum = TitleAnchorEnum.End };
                        case "middle":
                            return new TitleAnchorUnion { Enum = TitleAnchorEnum.Middle };
                        case "start":
                            return new TitleAnchorUnion { Enum = TitleAnchorEnum.Start };
                    }
                    break;
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<TitleAnchorType>(reader);
                    return new TitleAnchorUnion { Type = objectValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<List<TitleAnchorElement>>(reader);
                    return new TitleAnchorUnion { TitleAnchorElementArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type TitleAnchorUnion");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (TitleAnchorUnion)untypedValue;
            if (value.IsNull)
            {
                serializer.Serialize(writer, null);
                return;
            }
            if (value.Enum != null)
            {
                switch (value.Enum)
                {
                    case TitleAnchorEnum.End:
                        serializer.Serialize(writer, "end");
                        return;
                    case TitleAnchorEnum.Middle:
                        serializer.Serialize(writer, "middle");
                        return;
                    case TitleAnchorEnum.Start:
                        serializer.Serialize(writer, "start");
                        return;
                }
            }
            if (value.TitleAnchorElementArray != null)
            {
                serializer.Serialize(writer, value.TitleAnchorElementArray);
                return;
            }
            if (value.Type != null)
            {
                serializer.Serialize(writer, value.Type);
                return;
            }
            throw new Exception("Cannot marshal type TitleAnchorUnion");
        }

        public static readonly TitleAnchorUnionConverter Singleton = new TitleAnchorUnionConverter();
    }

    internal class TitleAnchorEnumConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(TitleAnchorEnum) || t == typeof(TitleAnchorEnum?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "end":
                    return TitleAnchorEnum.End;
                case "middle":
                    return TitleAnchorEnum.Middle;
                case "start":
                    return TitleAnchorEnum.Start;
            }
            throw new Exception("Cannot unmarshal type TitleAnchorEnum");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (TitleAnchorEnum)untypedValue;
            switch (value)
            {
                case TitleAnchorEnum.End:
                    serializer.Serialize(writer, "end");
                    return;
                case TitleAnchorEnum.Middle:
                    serializer.Serialize(writer, "middle");
                    return;
                case TitleAnchorEnum.Start:
                    serializer.Serialize(writer, "start");
                    return;
            }
            throw new Exception("Cannot marshal type TitleAnchorEnum");
        }

        public static readonly TitleAnchorEnumConverter Singleton = new TitleAnchorEnumConverter();
    }

    internal class ValuesConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Values) || t == typeof(Values?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<BoundsType>(reader);
                    return new Values { BoundsType = objectValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<List<object>>(reader);
                    return new Values { AnythingArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type Values");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (Values)untypedValue;
            if (value.AnythingArray != null)
            {
                serializer.Serialize(writer, value.AnythingArray);
                return;
            }
            if (value.BoundsType != null)
            {
                serializer.Serialize(writer, value.BoundsType);
                return;
            }
            throw new Exception("Cannot marshal type Values");
        }

        public static readonly ValuesConverter Singleton = new ValuesConverter();
    }

    internal class TypeElementConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(TypeElement) || t == typeof(TypeElement?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    return new TypeElement { String = stringValue };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<BoundsType>(reader);
                    return new TypeElement { BoundsType = objectValue };
            }
            throw new Exception("Cannot unmarshal type TypeElement");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (TypeElement)untypedValue;
            if (value.String != null)
            {
                serializer.Serialize(writer, value.String);
                return;
            }
            if (value.BoundsType != null)
            {
                serializer.Serialize(writer, value.BoundsType);
                return;
            }
            throw new Exception("Cannot marshal type TypeElement");
        }

        public static readonly TypeElementConverter Singleton = new TypeElementConverter();
    }

    internal class FilterConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(FilterEnum) || t == typeof(FilterEnum?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "exterior":
                    return FilterEnum.Exterior;
                case "interior":
                    return FilterEnum.Interior;
            }
            throw new Exception("Cannot unmarshal type Filter");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (FilterEnum)untypedValue;
            switch (value)
            {
                case FilterEnum.Exterior:
                    serializer.Serialize(writer, "exterior");
                    return;
                case FilterEnum.Interior:
                    serializer.Serialize(writer, "interior");
                    return;
            }
            throw new Exception("Cannot marshal type Filter");
        }

        public static readonly FilterConverter Singleton = new FilterConverter();
    }

    internal class ParseUnionConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ParseUnion) || t == typeof(ParseUnion?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    if (stringValue == "auto")
                    {
                        return new ParseUnion { Enum = ParseEnum.Auto };
                    }
                    break;
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<Parse>(reader);
                    return new ParseUnion { Parse = objectValue };
            }
            throw new Exception("Cannot unmarshal type ParseUnion");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (ParseUnion)untypedValue;
            if (value.Enum != null)
            {
                if (value.Enum == ParseEnum.Auto)
                {
                    serializer.Serialize(writer, "auto");
                    return;
                }
            }
            if (value.Parse != null)
            {
                serializer.Serialize(writer, value.Parse);
                return;
            }
            throw new Exception("Cannot marshal type ParseUnion");
        }

        public static readonly ParseUnionConverter Singleton = new ParseUnionConverter();
    }

    internal class ParseEnumConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ParseEnum) || t == typeof(ParseEnum?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "auto")
            {
                return ParseEnum.Auto;
            }
            throw new Exception("Cannot unmarshal type ParseEnum");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (ParseEnum)untypedValue;
            if (value == ParseEnum.Auto)
            {
                serializer.Serialize(writer, "auto");
                return;
            }
            throw new Exception("Cannot marshal type ParseEnum");
        }

        public static readonly ParseEnumConverter Singleton = new ParseEnumConverter();
    }

    internal class RemoveConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Remove) || t == typeof(Remove?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Boolean:
                    var boolValue = serializer.Deserialize<bool>(reader);
                    return new Remove { Bool = boolValue };
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    return new Remove { String = stringValue };
            }
            throw new Exception("Cannot unmarshal type Remove");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (Remove)untypedValue;
            if (value.Bool != null)
            {
                serializer.Serialize(writer, value.Bool.Value);
                return;
            }
            if (value.String != null)
            {
                serializer.Serialize(writer, value.String);
                return;
            }
            throw new Exception("Cannot marshal type Remove");
        }

        public static readonly RemoveConverter Singleton = new RemoveConverter();
    }

    internal class PurpleAsConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(TransformAs) || t == typeof(TransformAs?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Null:
                    return new TransformAs { };
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    return new TransformAs { String = stringValue };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<BoundsType>(reader);
                    return new TransformAs { BoundsType = objectValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<List<AsA>>(reader);
                    return new TransformAs { AnythingArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type PurpleAs");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (TransformAs)untypedValue;
            if (value.IsNull)
            {
                serializer.Serialize(writer, null);
                return;
            }
            if (value.String != null)
            {
                serializer.Serialize(writer, value.String);
                return;
            }
            if (value.AnythingArray != null)
            {
                serializer.Serialize(writer, value.AnythingArray);
                return;
            }
            if (value.BoundsType != null)
            {
                serializer.Serialize(writer, value.BoundsType);
                return;
            }
            throw new Exception("Cannot marshal type PurpleAs");
        }

        public static readonly PurpleAsConverter Singleton = new PurpleAsConverter();
    }

    internal class AsAConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(AsA) || t == typeof(AsA?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Null:
                    return new AsA { };
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    return new AsA { String = stringValue };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<BoundsType>(reader);
                    return new AsA { BoundsType = objectValue };
            }
            throw new Exception("Cannot unmarshal type AsA");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (AsA)untypedValue;
            if (value.IsNull)
            {
                serializer.Serialize(writer, null);
                return;
            }
            if (value.String != null)
            {
                serializer.Serialize(writer, value.String);
                return;
            }
            if (value.BoundsType != null)
            {
                serializer.Serialize(writer, value.BoundsType);
                return;
            }
            throw new Exception("Cannot marshal type AsA");
        }

        public static readonly AsAConverter Singleton = new AsAConverter();
    }

    internal class BandwidthUnionConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(BandwidthUnion) || t == typeof(BandwidthUnion?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Integer:
                case JsonToken.Float:
                    var doubleValue = serializer.Deserialize<double>(reader);
                    return new BandwidthUnion { Double = doubleValue };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<BoundsType>(reader);
                    return new BandwidthUnion { BoundsType = objectValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<List<ColumnsElement>>(reader);
                    return new BandwidthUnion { AnythingArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type BandwidthUnion");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (BandwidthUnion)untypedValue;
            if (value.Double != null)
            {
                serializer.Serialize(writer, value.Double.Value);
                return;
            }
            if (value.AnythingArray != null)
            {
                serializer.Serialize(writer, value.AnythingArray);
                return;
            }
            if (value.BoundsType != null)
            {
                serializer.Serialize(writer, value.BoundsType);
                return;
            }
            throw new Exception("Cannot marshal type BandwidthUnion");
        }

        public static readonly BandwidthUnionConverter Singleton = new BandwidthUnionConverter();
    }

    internal class CaseUnionConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(CaseUnion) || t == typeof(CaseUnion?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    switch (stringValue)
                    {
                        case "lower":
                            return new CaseUnion { Enum = CaseEnum.Lower };
                        case "mixed":
                            return new CaseUnion { Enum = CaseEnum.Mixed };
                        case "upper":
                            return new CaseUnion { Enum = CaseEnum.Upper };
                    }
                    break;
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<BoundsType>(reader);
                    return new CaseUnion { BoundsType = objectValue };
            }
            throw new Exception("Cannot unmarshal type CaseUnion");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (CaseUnion)untypedValue;
            if (value.Enum != null)
            {
                switch (value.Enum)
                {
                    case CaseEnum.Lower:
                        serializer.Serialize(writer, "lower");
                        return;
                    case CaseEnum.Mixed:
                        serializer.Serialize(writer, "mixed");
                        return;
                    case CaseEnum.Upper:
                        serializer.Serialize(writer, "upper");
                        return;
                }
            }
            if (value.BoundsType != null)
            {
                serializer.Serialize(writer, value.BoundsType);
                return;
            }
            throw new Exception("Cannot marshal type CaseUnion");
        }

        public static readonly CaseUnionConverter Singleton = new CaseUnionConverter();
    }

    internal class CaseEnumConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(CaseEnum) || t == typeof(CaseEnum?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "lower":
                    return CaseEnum.Lower;
                case "mixed":
                    return CaseEnum.Mixed;
                case "upper":
                    return CaseEnum.Upper;
            }
            throw new Exception("Cannot unmarshal type CaseEnum");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (CaseEnum)untypedValue;
            switch (value)
            {
                case CaseEnum.Lower:
                    serializer.Serialize(writer, "lower");
                    return;
                case CaseEnum.Mixed:
                    serializer.Serialize(writer, "mixed");
                    return;
                case CaseEnum.Upper:
                    serializer.Serialize(writer, "upper");
                    return;
            }
            throw new Exception("Cannot marshal type CaseEnum");
        }

        public static readonly CaseEnumConverter Singleton = new CaseEnumConverter();
    }

    internal class ColorElementConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ColorElement) || t == typeof(ColorElement?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    return new ColorElement { String = stringValue };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<GeoJson>(reader);
                    return new ColorElement { GeoJson = objectValue };
            }
            throw new Exception("Cannot unmarshal type ColorElement");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (ColorElement)untypedValue;
            if (value.String != null)
            {
                serializer.Serialize(writer, value.String);
                return;
            }
            if (value.GeoJson != null)
            {
                serializer.Serialize(writer, value.GeoJson);
                return;
            }
            throw new Exception("Cannot marshal type ColorElement");
        }

        public static readonly ColorElementConverter Singleton = new ColorElementConverter();
    }

    internal class FunctionConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(FunctionEnum) || t == typeof(FunctionEnum?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "kde":
                    return FunctionEnum.Kde;
                case "lognormal":
                    return FunctionEnum.Lognormal;
                case "mixture":
                    return FunctionEnum.Mixture;
                case "normal":
                    return FunctionEnum.Normal;
                case "uniform":
                    return FunctionEnum.Uniform;
            }
            throw new Exception("Cannot unmarshal type Function");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (FunctionEnum)untypedValue;
            switch (value)
            {
                case FunctionEnum.Kde:
                    serializer.Serialize(writer, "kde");
                    return;
                case FunctionEnum.Lognormal:
                    serializer.Serialize(writer, "lognormal");
                    return;
                case FunctionEnum.Mixture:
                    serializer.Serialize(writer, "mixture");
                    return;
                case FunctionEnum.Normal:
                    serializer.Serialize(writer, "normal");
                    return;
                case FunctionEnum.Uniform:
                    serializer.Serialize(writer, "uniform");
                    return;
            }
            throw new Exception("Cannot marshal type Function");
        }

        public static readonly FunctionConverter Singleton = new FunctionConverter();
    }

    internal class CenterElementConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(CenterElement) || t == typeof(CenterElement?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<BoundsType>(reader);
                    return new CenterElement { BoundsType = objectValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<List<ColumnsElement>>(reader);
                    return new CenterElement { AnythingArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type CenterElement");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (CenterElement)untypedValue;
            if (value.AnythingArray != null)
            {
                serializer.Serialize(writer, value.AnythingArray);
                return;
            }
            if (value.BoundsType != null)
            {
                serializer.Serialize(writer, value.BoundsType);
                return;
            }
            throw new Exception("Cannot marshal type CenterElement");
        }

        public static readonly CenterElementConverter Singleton = new CenterElementConverter();
    }

    internal class FieldsUnionConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(FieldsUnion) || t == typeof(FieldsUnion?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<BoundsType>(reader);
                    return new FieldsUnion { BoundsType = objectValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<List<Fields>>(reader);
                    return new FieldsUnion { AnythingArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type FieldsUnion");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (FieldsUnion)untypedValue;
            if (value.AnythingArray != null)
            {
                serializer.Serialize(writer, value.AnythingArray);
                return;
            }
            if (value.BoundsType != null)
            {
                serializer.Serialize(writer, value.BoundsType);
                return;
            }
            throw new Exception("Cannot marshal type FieldsUnion");
        }

        public static readonly FieldsUnionConverter Singleton = new FieldsUnionConverter();
    }

    internal class FieldsFieldConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Fields) || t == typeof(Fields?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Null:
                    return new Fields { };
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    return new Fields { String = stringValue };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<FieldsType>(reader);
                    return new Fields { Type = objectValue };
            }
            throw new Exception("Cannot unmarshal type FieldsField");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (Fields)untypedValue;
            if (value.IsNull)
            {
                serializer.Serialize(writer, null);
                return;
            }
            if (value.String != null)
            {
                serializer.Serialize(writer, value.String);
                return;
            }
            if (value.Type != null)
            {
                serializer.Serialize(writer, value.Type);
                return;
            }
            throw new Exception("Cannot marshal type FieldsField");
        }

        public static readonly FieldsFieldConverter Singleton = new FieldsFieldConverter();
    }

    internal class RadiusConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Radius) || t == typeof(Radius?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Integer:
                case JsonToken.Float:
                    var doubleValue = serializer.Deserialize<double>(reader);
                    return new Radius { Double = doubleValue };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<Distance>(reader);
                    return new Radius { Distance = objectValue };
            }
            throw new Exception("Cannot unmarshal type Radius");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (Radius)untypedValue;
            if (value.Double != null)
            {
                serializer.Serialize(writer, value.Double.Value);
                return;
            }
            if (value.Distance != null)
            {
                serializer.Serialize(writer, value.Distance);
                return;
            }
            throw new Exception("Cannot marshal type Radius");
        }

        public static readonly RadiusConverter Singleton = new RadiusConverter();
    }

    internal class FontSizeRangeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(FontSizeRange) || t == typeof(FontSizeRange?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Null:
                    return new FontSizeRange { };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<BoundsType>(reader);
                    return new FontSizeRange { BoundsType = objectValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<List<ColumnsElement>>(reader);
                    return new FontSizeRange { AnythingArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type FontSizeRange");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (FontSizeRange)untypedValue;
            if (value.IsNull)
            {
                serializer.Serialize(writer, null);
                return;
            }
            if (value.AnythingArray != null)
            {
                serializer.Serialize(writer, value.AnythingArray);
                return;
            }
            if (value.BoundsType != null)
            {
                serializer.Serialize(writer, value.BoundsType);
                return;
            }
            throw new Exception("Cannot marshal type FontSizeRange");
        }

        public static readonly FontSizeRangeConverter Singleton = new FontSizeRangeConverter();
    }

    internal class ForceEnumConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ForceEnum) || t == typeof(ForceEnum?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "center":
                    return ForceEnum.Center;
                case "collide":
                    return ForceEnum.Collide;
                case "link":
                    return ForceEnum.Link;
                case "nbody":
                    return ForceEnum.Nbody;
                case "x":
                    return ForceEnum.X;
                case "y":
                    return ForceEnum.Y;
            }
            throw new Exception("Cannot unmarshal type ForceEnum");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (ForceEnum)untypedValue;
            switch (value)
            {
                case ForceEnum.Center:
                    serializer.Serialize(writer, "center");
                    return;
                case ForceEnum.Collide:
                    serializer.Serialize(writer, "collide");
                    return;
                case ForceEnum.Link:
                    serializer.Serialize(writer, "link");
                    return;
                case ForceEnum.Nbody:
                    serializer.Serialize(writer, "nbody");
                    return;
                case ForceEnum.X:
                    serializer.Serialize(writer, "x");
                    return;
                case ForceEnum.Y:
                    serializer.Serialize(writer, "y");
                    return;
            }
            throw new Exception("Cannot marshal type ForceEnum");
        }

        public static readonly ForceEnumConverter Singleton = new ForceEnumConverter();
    }

    internal class StrengthUnionConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(StrengthUnion) || t == typeof(StrengthUnion?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Integer:
                case JsonToken.Float:
                    var doubleValue = serializer.Deserialize<double>(reader);
                    return new StrengthUnion { Double = doubleValue };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<Strength>(reader);
                    return new StrengthUnion { Strength = objectValue };
            }
            throw new Exception("Cannot unmarshal type StrengthUnion");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (StrengthUnion)untypedValue;
            if (value.Double != null)
            {
                serializer.Serialize(writer, value.Double.Value);
                return;
            }
            if (value.Strength != null)
            {
                serializer.Serialize(writer, value.Strength);
                return;
            }
            throw new Exception("Cannot marshal type StrengthUnion");
        }

        public static readonly StrengthUnionConverter Singleton = new StrengthUnionConverter();
    }

    internal class XUnionConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(XUnion) || t == typeof(XUnion?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Integer:
                case JsonToken.Float:
                    var doubleValue = serializer.Deserialize<double>(reader);
                    return new XUnion { Double = doubleValue };
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    return new XUnion { String = stringValue };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<XType>(reader);
                    return new XUnion { Type = objectValue };
            }
            throw new Exception("Cannot unmarshal type XUnion");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (XUnion)untypedValue;
            if (value.Double != null)
            {
                serializer.Serialize(writer, value.Double.Value);
                return;
            }
            if (value.String != null)
            {
                serializer.Serialize(writer, value.String);
                return;
            }
            if (value.Type != null)
            {
                serializer.Serialize(writer, value.Type);
                return;
            }
            throw new Exception("Cannot marshal type XUnion");
        }

        public static readonly XUnionConverter Singleton = new XUnionConverter();
    }

    internal class FrameUnionConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(FrameUnion) || t == typeof(FrameUnion?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<BoundsType>(reader);
                    return new FrameUnion { BoundsType = objectValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<List<FrameElement>>(reader);
                    return new FrameUnion { AnythingArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type FrameUnion");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (FrameUnion)untypedValue;
            if (value.AnythingArray != null)
            {
                serializer.Serialize(writer, value.AnythingArray);
                return;
            }
            if (value.BoundsType != null)
            {
                serializer.Serialize(writer, value.BoundsType);
                return;
            }
            throw new Exception("Cannot marshal type FrameUnion");
        }

        public static readonly FrameUnionConverter Singleton = new FrameUnionConverter();
    }

    internal class FrameElementConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(FrameElement) || t == typeof(FrameElement?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Null:
                    return new FrameElement { };
                case JsonToken.Integer:
                case JsonToken.Float:
                    var doubleValue = serializer.Deserialize<double>(reader);
                    return new FrameElement { Double = doubleValue };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<BoundsType>(reader);
                    return new FrameElement { BoundsType = objectValue };
            }
            throw new Exception("Cannot unmarshal type FrameElement");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (FrameElement)untypedValue;
            if (value.IsNull)
            {
                serializer.Serialize(writer, null);
                return;
            }
            if (value.Double != null)
            {
                serializer.Serialize(writer, value.Double.Value);
                return;
            }
            if (value.BoundsType != null)
            {
                serializer.Serialize(writer, value.BoundsType);
                return;
            }
            throw new Exception("Cannot marshal type FrameElement");
        }

        public static readonly FrameElementConverter Singleton = new FrameElementConverter();
    }

    internal class GroupbyUnionConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(GroupbyUnion) || t == typeof(GroupbyUnion?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<BoundsType>(reader);
                    return new GroupbyUnion { BoundsType = objectValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<List<ColorElement>>(reader);
                    return new GroupbyUnion { AnythingArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type GroupbyUnion");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (GroupbyUnion)untypedValue;
            if (value.AnythingArray != null)
            {
                serializer.Serialize(writer, value.AnythingArray);
                return;
            }
            if (value.BoundsType != null)
            {
                serializer.Serialize(writer, value.BoundsType);
                return;
            }
            throw new Exception("Cannot marshal type GroupbyUnion");
        }

        public static readonly GroupbyUnionConverter Singleton = new GroupbyUnionConverter();
    }

    internal class TransformOffsetConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(TransformOffset) || t == typeof(TransformOffset?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    switch (stringValue)
                    {
                        case "center":
                            return new TransformOffset { Enum = OffsetEnum.Center };
                        case "normalize":
                            return new TransformOffset { Enum = OffsetEnum.Normalize };
                        case "zero":
                            return new TransformOffset { Enum = OffsetEnum.Zero };
                    }
                    break;
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<BoundsType>(reader);
                    return new TransformOffset { BoundsType = objectValue };
            }
            throw new Exception("Cannot unmarshal type TransformOffset");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (TransformOffset)untypedValue;
            if (value.Enum != null)
            {
                switch (value.Enum)
                {
                    case OffsetEnum.Center:
                        serializer.Serialize(writer, "center");
                        return;
                    case OffsetEnum.Normalize:
                        serializer.Serialize(writer, "normalize");
                        return;
                    case OffsetEnum.Zero:
                        serializer.Serialize(writer, "zero");
                        return;
                }
            }
            if (value.BoundsType != null)
            {
                serializer.Serialize(writer, value.BoundsType);
                return;
            }
            throw new Exception("Cannot marshal type TransformOffset");
        }

        public static readonly TransformOffsetConverter Singleton = new TransformOffsetConverter();
    }

    internal class OffsetEnumConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(OffsetEnum) || t == typeof(OffsetEnum?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "center":
                    return OffsetEnum.Center;
                case "normalize":
                    return OffsetEnum.Normalize;
                case "zero":
                    return OffsetEnum.Zero;
            }
            throw new Exception("Cannot unmarshal type OffsetEnum");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (OffsetEnum)untypedValue;
            switch (value)
            {
                case OffsetEnum.Center:
                    serializer.Serialize(writer, "center");
                    return;
                case OffsetEnum.Normalize:
                    serializer.Serialize(writer, "normalize");
                    return;
                case OffsetEnum.Zero:
                    serializer.Serialize(writer, "zero");
                    return;
            }
            throw new Exception("Cannot marshal type OffsetEnum");
        }

        public static readonly OffsetEnumConverter Singleton = new OffsetEnumConverter();
    }

    internal class TransformOpConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(TransformOp) || t == typeof(TransformOp?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    switch (stringValue)
                    {
                        case "__count__":
                            return new TransformOp { Enum = TransformOpEnum.OpCount };
                        case "argmax":
                            return new TransformOp { Enum = TransformOpEnum.Argmax };
                        case "argmin":
                            return new TransformOp { Enum = TransformOpEnum.Argmin };
                        case "average":
                            return new TransformOp { Enum = TransformOpEnum.Average };
                        case "ci0":
                            return new TransformOp { Enum = TransformOpEnum.Ci0 };
                        case "ci1":
                            return new TransformOp { Enum = TransformOpEnum.Ci1 };
                        case "count":
                            return new TransformOp { Enum = TransformOpEnum.Count };
                        case "distinct":
                            return new TransformOp { Enum = TransformOpEnum.Distinct };
                        case "max":
                            return new TransformOp { Enum = TransformOpEnum.Max };
                        case "mean":
                            return new TransformOp { Enum = TransformOpEnum.Mean };
                        case "median":
                            return new TransformOp { Enum = TransformOpEnum.Median };
                        case "min":
                            return new TransformOp { Enum = TransformOpEnum.Min };
                        case "missing":
                            return new TransformOp { Enum = TransformOpEnum.Missing };
                        case "q1":
                            return new TransformOp { Enum = TransformOpEnum.Q1 };
                        case "q3":
                            return new TransformOp { Enum = TransformOpEnum.Q3 };
                        case "stderr":
                            return new TransformOp { Enum = TransformOpEnum.Stderr };
                        case "stdev":
                            return new TransformOp { Enum = TransformOpEnum.Stdev };
                        case "stdevp":
                            return new TransformOp { Enum = TransformOpEnum.Stdevp };
                        case "sum":
                            return new TransformOp { Enum = TransformOpEnum.Sum };
                        case "valid":
                            return new TransformOp { Enum = TransformOpEnum.Valid };
                        case "values":
                            return new TransformOp { Enum = TransformOpEnum.Values };
                        case "variance":
                            return new TransformOp { Enum = TransformOpEnum.Variance };
                        case "variancep":
                            return new TransformOp { Enum = TransformOpEnum.Variancep };
                    }
                    break;
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<BoundsType>(reader);
                    return new TransformOp { BoundsType = objectValue };
            }
            throw new Exception("Cannot unmarshal type TransformOp");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (TransformOp)untypedValue;
            if (value.Enum != null)
            {
                switch (value.Enum)
                {
                    case TransformOpEnum.OpCount:
                        serializer.Serialize(writer, "__count__");
                        return;
                    case TransformOpEnum.Argmax:
                        serializer.Serialize(writer, "argmax");
                        return;
                    case TransformOpEnum.Argmin:
                        serializer.Serialize(writer, "argmin");
                        return;
                    case TransformOpEnum.Average:
                        serializer.Serialize(writer, "average");
                        return;
                    case TransformOpEnum.Ci0:
                        serializer.Serialize(writer, "ci0");
                        return;
                    case TransformOpEnum.Ci1:
                        serializer.Serialize(writer, "ci1");
                        return;
                    case TransformOpEnum.Count:
                        serializer.Serialize(writer, "count");
                        return;
                    case TransformOpEnum.Distinct:
                        serializer.Serialize(writer, "distinct");
                        return;
                    case TransformOpEnum.Max:
                        serializer.Serialize(writer, "max");
                        return;
                    case TransformOpEnum.Mean:
                        serializer.Serialize(writer, "mean");
                        return;
                    case TransformOpEnum.Median:
                        serializer.Serialize(writer, "median");
                        return;
                    case TransformOpEnum.Min:
                        serializer.Serialize(writer, "min");
                        return;
                    case TransformOpEnum.Missing:
                        serializer.Serialize(writer, "missing");
                        return;
                    case TransformOpEnum.Q1:
                        serializer.Serialize(writer, "q1");
                        return;
                    case TransformOpEnum.Q3:
                        serializer.Serialize(writer, "q3");
                        return;
                    case TransformOpEnum.Stderr:
                        serializer.Serialize(writer, "stderr");
                        return;
                    case TransformOpEnum.Stdev:
                        serializer.Serialize(writer, "stdev");
                        return;
                    case TransformOpEnum.Stdevp:
                        serializer.Serialize(writer, "stdevp");
                        return;
                    case TransformOpEnum.Sum:
                        serializer.Serialize(writer, "sum");
                        return;
                    case TransformOpEnum.Valid:
                        serializer.Serialize(writer, "valid");
                        return;
                    case TransformOpEnum.Values:
                        serializer.Serialize(writer, "values");
                        return;
                    case TransformOpEnum.Variance:
                        serializer.Serialize(writer, "variance");
                        return;
                    case TransformOpEnum.Variancep:
                        serializer.Serialize(writer, "variancep");
                        return;
                }
            }
            if (value.BoundsType != null)
            {
                serializer.Serialize(writer, value.BoundsType);
                return;
            }
            throw new Exception("Cannot marshal type TransformOp");
        }

        public static readonly TransformOpConverter Singleton = new TransformOpConverter();
    }

    internal class PurpleOpConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(TransformOpEnum) || t == typeof(TransformOpEnum?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "__count__":
                    return TransformOpEnum.OpCount;
                case "argmax":
                    return TransformOpEnum.Argmax;
                case "argmin":
                    return TransformOpEnum.Argmin;
                case "average":
                    return TransformOpEnum.Average;
                case "ci0":
                    return TransformOpEnum.Ci0;
                case "ci1":
                    return TransformOpEnum.Ci1;
                case "count":
                    return TransformOpEnum.Count;
                case "distinct":
                    return TransformOpEnum.Distinct;
                case "max":
                    return TransformOpEnum.Max;
                case "mean":
                    return TransformOpEnum.Mean;
                case "median":
                    return TransformOpEnum.Median;
                case "min":
                    return TransformOpEnum.Min;
                case "missing":
                    return TransformOpEnum.Missing;
                case "q1":
                    return TransformOpEnum.Q1;
                case "q3":
                    return TransformOpEnum.Q3;
                case "stderr":
                    return TransformOpEnum.Stderr;
                case "stdev":
                    return TransformOpEnum.Stdev;
                case "stdevp":
                    return TransformOpEnum.Stdevp;
                case "sum":
                    return TransformOpEnum.Sum;
                case "valid":
                    return TransformOpEnum.Valid;
                case "values":
                    return TransformOpEnum.Values;
                case "variance":
                    return TransformOpEnum.Variance;
                case "variancep":
                    return TransformOpEnum.Variancep;
            }
            throw new Exception("Cannot unmarshal type PurpleOp");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (TransformOpEnum)untypedValue;
            switch (value)
            {
                case TransformOpEnum.OpCount:
                    serializer.Serialize(writer, "__count__");
                    return;
                case TransformOpEnum.Argmax:
                    serializer.Serialize(writer, "argmax");
                    return;
                case TransformOpEnum.Argmin:
                    serializer.Serialize(writer, "argmin");
                    return;
                case TransformOpEnum.Average:
                    serializer.Serialize(writer, "average");
                    return;
                case TransformOpEnum.Ci0:
                    serializer.Serialize(writer, "ci0");
                    return;
                case TransformOpEnum.Ci1:
                    serializer.Serialize(writer, "ci1");
                    return;
                case TransformOpEnum.Count:
                    serializer.Serialize(writer, "count");
                    return;
                case TransformOpEnum.Distinct:
                    serializer.Serialize(writer, "distinct");
                    return;
                case TransformOpEnum.Max:
                    serializer.Serialize(writer, "max");
                    return;
                case TransformOpEnum.Mean:
                    serializer.Serialize(writer, "mean");
                    return;
                case TransformOpEnum.Median:
                    serializer.Serialize(writer, "median");
                    return;
                case TransformOpEnum.Min:
                    serializer.Serialize(writer, "min");
                    return;
                case TransformOpEnum.Missing:
                    serializer.Serialize(writer, "missing");
                    return;
                case TransformOpEnum.Q1:
                    serializer.Serialize(writer, "q1");
                    return;
                case TransformOpEnum.Q3:
                    serializer.Serialize(writer, "q3");
                    return;
                case TransformOpEnum.Stderr:
                    serializer.Serialize(writer, "stderr");
                    return;
                case TransformOpEnum.Stdev:
                    serializer.Serialize(writer, "stdev");
                    return;
                case TransformOpEnum.Stdevp:
                    serializer.Serialize(writer, "stdevp");
                    return;
                case TransformOpEnum.Sum:
                    serializer.Serialize(writer, "sum");
                    return;
                case TransformOpEnum.Valid:
                    serializer.Serialize(writer, "valid");
                    return;
                case TransformOpEnum.Values:
                    serializer.Serialize(writer, "values");
                    return;
                case TransformOpEnum.Variance:
                    serializer.Serialize(writer, "variance");
                    return;
                case TransformOpEnum.Variancep:
                    serializer.Serialize(writer, "variancep");
                    return;
            }
            throw new Exception("Cannot marshal type PurpleOp");
        }

        public static readonly PurpleOpConverter Singleton = new PurpleOpConverter();
    }

    internal class OpsConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Ops) || t == typeof(Ops?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<BoundsType>(reader);
                    return new Ops { BoundsType = objectValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<List<OpElement>>(reader);
                    return new Ops { AnythingArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type Ops");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (Ops)untypedValue;
            if (value.AnythingArray != null)
            {
                serializer.Serialize(writer, value.AnythingArray);
                return;
            }
            if (value.BoundsType != null)
            {
                serializer.Serialize(writer, value.BoundsType);
                return;
            }
            throw new Exception("Cannot marshal type Ops");
        }

        public static readonly OpsConverter Singleton = new OpsConverter();
    }

    internal class OpElementConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(OpElement) || t == typeof(OpElement?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    switch (stringValue)
                    {
                        case "__count__":
                            return new OpElement { Enum = OpElementEnum.OpCount };
                        case "argmax":
                            return new OpElement { Enum = OpElementEnum.Argmax };
                        case "argmin":
                            return new OpElement { Enum = OpElementEnum.Argmin };
                        case "average":
                            return new OpElement { Enum = OpElementEnum.Average };
                        case "ci0":
                            return new OpElement { Enum = OpElementEnum.Ci0 };
                        case "ci1":
                            return new OpElement { Enum = OpElementEnum.Ci1 };
                        case "count":
                            return new OpElement { Enum = OpElementEnum.Count };
                        case "cume_dist":
                            return new OpElement { Enum = OpElementEnum.CumeDist };
                        case "dense_rank":
                            return new OpElement { Enum = OpElementEnum.DenseRank };
                        case "distinct":
                            return new OpElement { Enum = OpElementEnum.Distinct };
                        case "first_value":
                            return new OpElement { Enum = OpElementEnum.FirstValue };
                        case "lag":
                            return new OpElement { Enum = OpElementEnum.Lag };
                        case "last_value":
                            return new OpElement { Enum = OpElementEnum.LastValue };
                        case "lead":
                            return new OpElement { Enum = OpElementEnum.Lead };
                        case "max":
                            return new OpElement { Enum = OpElementEnum.Max };
                        case "mean":
                            return new OpElement { Enum = OpElementEnum.Mean };
                        case "median":
                            return new OpElement { Enum = OpElementEnum.Median };
                        case "min":
                            return new OpElement { Enum = OpElementEnum.Min };
                        case "missing":
                            return new OpElement { Enum = OpElementEnum.Missing };
                        case "next_value":
                            return new OpElement { Enum = OpElementEnum.NextValue };
                        case "nth_value":
                            return new OpElement { Enum = OpElementEnum.NthValue };
                        case "ntile":
                            return new OpElement { Enum = OpElementEnum.Ntile };
                        case "percent_rank":
                            return new OpElement { Enum = OpElementEnum.PercentRank };
                        case "prev_value":
                            return new OpElement { Enum = OpElementEnum.PrevValue };
                        case "q1":
                            return new OpElement { Enum = OpElementEnum.Q1 };
                        case "q3":
                            return new OpElement { Enum = OpElementEnum.Q3 };
                        case "rank":
                            return new OpElement { Enum = OpElementEnum.Rank };
                        case "row_number":
                            return new OpElement { Enum = OpElementEnum.RowNumber };
                        case "stderr":
                            return new OpElement { Enum = OpElementEnum.Stderr };
                        case "stdev":
                            return new OpElement { Enum = OpElementEnum.Stdev };
                        case "stdevp":
                            return new OpElement { Enum = OpElementEnum.Stdevp };
                        case "sum":
                            return new OpElement { Enum = OpElementEnum.Sum };
                        case "valid":
                            return new OpElement { Enum = OpElementEnum.Valid };
                        case "values":
                            return new OpElement { Enum = OpElementEnum.Values };
                        case "variance":
                            return new OpElement { Enum = OpElementEnum.Variance };
                        case "variancep":
                            return new OpElement { Enum = OpElementEnum.Variancep };
                    }
                    break;
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<BoundsType>(reader);
                    return new OpElement { BoundsType = objectValue };
            }
            throw new Exception("Cannot unmarshal type OpElement");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (OpElement)untypedValue;
            if (value.Enum != null)
            {
                switch (value.Enum)
                {
                    case OpElementEnum.OpCount:
                        serializer.Serialize(writer, "__count__");
                        return;
                    case OpElementEnum.Argmax:
                        serializer.Serialize(writer, "argmax");
                        return;
                    case OpElementEnum.Argmin:
                        serializer.Serialize(writer, "argmin");
                        return;
                    case OpElementEnum.Average:
                        serializer.Serialize(writer, "average");
                        return;
                    case OpElementEnum.Ci0:
                        serializer.Serialize(writer, "ci0");
                        return;
                    case OpElementEnum.Ci1:
                        serializer.Serialize(writer, "ci1");
                        return;
                    case OpElementEnum.Count:
                        serializer.Serialize(writer, "count");
                        return;
                    case OpElementEnum.CumeDist:
                        serializer.Serialize(writer, "cume_dist");
                        return;
                    case OpElementEnum.DenseRank:
                        serializer.Serialize(writer, "dense_rank");
                        return;
                    case OpElementEnum.Distinct:
                        serializer.Serialize(writer, "distinct");
                        return;
                    case OpElementEnum.FirstValue:
                        serializer.Serialize(writer, "first_value");
                        return;
                    case OpElementEnum.Lag:
                        serializer.Serialize(writer, "lag");
                        return;
                    case OpElementEnum.LastValue:
                        serializer.Serialize(writer, "last_value");
                        return;
                    case OpElementEnum.Lead:
                        serializer.Serialize(writer, "lead");
                        return;
                    case OpElementEnum.Max:
                        serializer.Serialize(writer, "max");
                        return;
                    case OpElementEnum.Mean:
                        serializer.Serialize(writer, "mean");
                        return;
                    case OpElementEnum.Median:
                        serializer.Serialize(writer, "median");
                        return;
                    case OpElementEnum.Min:
                        serializer.Serialize(writer, "min");
                        return;
                    case OpElementEnum.Missing:
                        serializer.Serialize(writer, "missing");
                        return;
                    case OpElementEnum.NextValue:
                        serializer.Serialize(writer, "next_value");
                        return;
                    case OpElementEnum.NthValue:
                        serializer.Serialize(writer, "nth_value");
                        return;
                    case OpElementEnum.Ntile:
                        serializer.Serialize(writer, "ntile");
                        return;
                    case OpElementEnum.PercentRank:
                        serializer.Serialize(writer, "percent_rank");
                        return;
                    case OpElementEnum.PrevValue:
                        serializer.Serialize(writer, "prev_value");
                        return;
                    case OpElementEnum.Q1:
                        serializer.Serialize(writer, "q1");
                        return;
                    case OpElementEnum.Q3:
                        serializer.Serialize(writer, "q3");
                        return;
                    case OpElementEnum.Rank:
                        serializer.Serialize(writer, "rank");
                        return;
                    case OpElementEnum.RowNumber:
                        serializer.Serialize(writer, "row_number");
                        return;
                    case OpElementEnum.Stderr:
                        serializer.Serialize(writer, "stderr");
                        return;
                    case OpElementEnum.Stdev:
                        serializer.Serialize(writer, "stdev");
                        return;
                    case OpElementEnum.Stdevp:
                        serializer.Serialize(writer, "stdevp");
                        return;
                    case OpElementEnum.Sum:
                        serializer.Serialize(writer, "sum");
                        return;
                    case OpElementEnum.Valid:
                        serializer.Serialize(writer, "valid");
                        return;
                    case OpElementEnum.Values:
                        serializer.Serialize(writer, "values");
                        return;
                    case OpElementEnum.Variance:
                        serializer.Serialize(writer, "variance");
                        return;
                    case OpElementEnum.Variancep:
                        serializer.Serialize(writer, "variancep");
                        return;
                }
            }
            if (value.BoundsType != null)
            {
                serializer.Serialize(writer, value.BoundsType);
                return;
            }
            throw new Exception("Cannot marshal type OpElement");
        }

        public static readonly OpElementConverter Singleton = new OpElementConverter();
    }

    internal class FluffyOpConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(OpElementEnum) || t == typeof(OpElementEnum?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "__count__":
                    return OpElementEnum.OpCount;
                case "argmax":
                    return OpElementEnum.Argmax;
                case "argmin":
                    return OpElementEnum.Argmin;
                case "average":
                    return OpElementEnum.Average;
                case "ci0":
                    return OpElementEnum.Ci0;
                case "ci1":
                    return OpElementEnum.Ci1;
                case "count":
                    return OpElementEnum.Count;
                case "cume_dist":
                    return OpElementEnum.CumeDist;
                case "dense_rank":
                    return OpElementEnum.DenseRank;
                case "distinct":
                    return OpElementEnum.Distinct;
                case "first_value":
                    return OpElementEnum.FirstValue;
                case "lag":
                    return OpElementEnum.Lag;
                case "last_value":
                    return OpElementEnum.LastValue;
                case "lead":
                    return OpElementEnum.Lead;
                case "max":
                    return OpElementEnum.Max;
                case "mean":
                    return OpElementEnum.Mean;
                case "median":
                    return OpElementEnum.Median;
                case "min":
                    return OpElementEnum.Min;
                case "missing":
                    return OpElementEnum.Missing;
                case "next_value":
                    return OpElementEnum.NextValue;
                case "nth_value":
                    return OpElementEnum.NthValue;
                case "ntile":
                    return OpElementEnum.Ntile;
                case "percent_rank":
                    return OpElementEnum.PercentRank;
                case "prev_value":
                    return OpElementEnum.PrevValue;
                case "q1":
                    return OpElementEnum.Q1;
                case "q3":
                    return OpElementEnum.Q3;
                case "rank":
                    return OpElementEnum.Rank;
                case "row_number":
                    return OpElementEnum.RowNumber;
                case "stderr":
                    return OpElementEnum.Stderr;
                case "stdev":
                    return OpElementEnum.Stdev;
                case "stdevp":
                    return OpElementEnum.Stdevp;
                case "sum":
                    return OpElementEnum.Sum;
                case "valid":
                    return OpElementEnum.Valid;
                case "values":
                    return OpElementEnum.Values;
                case "variance":
                    return OpElementEnum.Variance;
                case "variancep":
                    return OpElementEnum.Variancep;
            }
            throw new Exception("Cannot unmarshal type FluffyOp");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (OpElementEnum)untypedValue;
            switch (value)
            {
                case OpElementEnum.OpCount:
                    serializer.Serialize(writer, "__count__");
                    return;
                case OpElementEnum.Argmax:
                    serializer.Serialize(writer, "argmax");
                    return;
                case OpElementEnum.Argmin:
                    serializer.Serialize(writer, "argmin");
                    return;
                case OpElementEnum.Average:
                    serializer.Serialize(writer, "average");
                    return;
                case OpElementEnum.Ci0:
                    serializer.Serialize(writer, "ci0");
                    return;
                case OpElementEnum.Ci1:
                    serializer.Serialize(writer, "ci1");
                    return;
                case OpElementEnum.Count:
                    serializer.Serialize(writer, "count");
                    return;
                case OpElementEnum.CumeDist:
                    serializer.Serialize(writer, "cume_dist");
                    return;
                case OpElementEnum.DenseRank:
                    serializer.Serialize(writer, "dense_rank");
                    return;
                case OpElementEnum.Distinct:
                    serializer.Serialize(writer, "distinct");
                    return;
                case OpElementEnum.FirstValue:
                    serializer.Serialize(writer, "first_value");
                    return;
                case OpElementEnum.Lag:
                    serializer.Serialize(writer, "lag");
                    return;
                case OpElementEnum.LastValue:
                    serializer.Serialize(writer, "last_value");
                    return;
                case OpElementEnum.Lead:
                    serializer.Serialize(writer, "lead");
                    return;
                case OpElementEnum.Max:
                    serializer.Serialize(writer, "max");
                    return;
                case OpElementEnum.Mean:
                    serializer.Serialize(writer, "mean");
                    return;
                case OpElementEnum.Median:
                    serializer.Serialize(writer, "median");
                    return;
                case OpElementEnum.Min:
                    serializer.Serialize(writer, "min");
                    return;
                case OpElementEnum.Missing:
                    serializer.Serialize(writer, "missing");
                    return;
                case OpElementEnum.NextValue:
                    serializer.Serialize(writer, "next_value");
                    return;
                case OpElementEnum.NthValue:
                    serializer.Serialize(writer, "nth_value");
                    return;
                case OpElementEnum.Ntile:
                    serializer.Serialize(writer, "ntile");
                    return;
                case OpElementEnum.PercentRank:
                    serializer.Serialize(writer, "percent_rank");
                    return;
                case OpElementEnum.PrevValue:
                    serializer.Serialize(writer, "prev_value");
                    return;
                case OpElementEnum.Q1:
                    serializer.Serialize(writer, "q1");
                    return;
                case OpElementEnum.Q3:
                    serializer.Serialize(writer, "q3");
                    return;
                case OpElementEnum.Rank:
                    serializer.Serialize(writer, "rank");
                    return;
                case OpElementEnum.RowNumber:
                    serializer.Serialize(writer, "row_number");
                    return;
                case OpElementEnum.Stderr:
                    serializer.Serialize(writer, "stderr");
                    return;
                case OpElementEnum.Stdev:
                    serializer.Serialize(writer, "stdev");
                    return;
                case OpElementEnum.Stdevp:
                    serializer.Serialize(writer, "stdevp");
                    return;
                case OpElementEnum.Sum:
                    serializer.Serialize(writer, "sum");
                    return;
                case OpElementEnum.Valid:
                    serializer.Serialize(writer, "valid");
                    return;
                case OpElementEnum.Values:
                    serializer.Serialize(writer, "values");
                    return;
                case OpElementEnum.Variance:
                    serializer.Serialize(writer, "variance");
                    return;
                case OpElementEnum.Variancep:
                    serializer.Serialize(writer, "variancep");
                    return;
            }
            throw new Exception("Cannot marshal type FluffyOp");
        }

        public static readonly FluffyOpConverter Singleton = new FluffyOpConverter();
    }

    internal class TransformOrientConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(TransformOrient) || t == typeof(TransformOrient?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    switch (stringValue)
                    {
                        case "horizontal":
                            return new TransformOrient { Enum = TransformOrientEnum.Horizontal };
                        case "radial":
                            return new TransformOrient { Enum = TransformOrientEnum.Radial };
                        case "vertical":
                            return new TransformOrient { Enum = TransformOrientEnum.Vertical };
                    }
                    break;
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<BoundsType>(reader);
                    return new TransformOrient { BoundsType = objectValue };
            }
            throw new Exception("Cannot unmarshal type TransformOrient");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (TransformOrient)untypedValue;
            if (value.Enum != null)
            {
                switch (value.Enum)
                {
                    case TransformOrientEnum.Horizontal:
                        serializer.Serialize(writer, "horizontal");
                        return;
                    case TransformOrientEnum.Radial:
                        serializer.Serialize(writer, "radial");
                        return;
                    case TransformOrientEnum.Vertical:
                        serializer.Serialize(writer, "vertical");
                        return;
                }
            }
            if (value.BoundsType != null)
            {
                serializer.Serialize(writer, value.BoundsType);
                return;
            }
            throw new Exception("Cannot marshal type TransformOrient");
        }

        public static readonly TransformOrientConverter Singleton = new TransformOrientConverter();
    }

    internal class PurpleOrientConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(TransformOrientEnum) || t == typeof(TransformOrientEnum?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "horizontal":
                    return TransformOrientEnum.Horizontal;
                case "radial":
                    return TransformOrientEnum.Radial;
                case "vertical":
                    return TransformOrientEnum.Vertical;
            }
            throw new Exception("Cannot unmarshal type PurpleOrient");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (TransformOrientEnum)untypedValue;
            switch (value)
            {
                case TransformOrientEnum.Horizontal:
                    serializer.Serialize(writer, "horizontal");
                    return;
                case TransformOrientEnum.Radial:
                    serializer.Serialize(writer, "radial");
                    return;
                case TransformOrientEnum.Vertical:
                    serializer.Serialize(writer, "vertical");
                    return;
            }
            throw new Exception("Cannot marshal type PurpleOrient");
        }

        public static readonly PurpleOrientConverter Singleton = new PurpleOrientConverter();
    }

    internal class PurpleParamsConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(TransformParams) || t == typeof(TransformParams?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Boolean:
                    var boolValue = serializer.Deserialize<bool>(reader);
                    return new TransformParams { Bool = boolValue };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<BoundsType>(reader);
                    return new TransformParams { BoundsType = objectValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<List<FrameElement>>(reader);
                    return new TransformParams { AnythingArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type PurpleParams");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (TransformParams)untypedValue;
            if (value.Bool != null)
            {
                serializer.Serialize(writer, value.Bool.Value);
                return;
            }
            if (value.AnythingArray != null)
            {
                serializer.Serialize(writer, value.AnythingArray);
                return;
            }
            if (value.BoundsType != null)
            {
                serializer.Serialize(writer, value.BoundsType);
                return;
            }
            throw new Exception("Cannot marshal type PurpleParams");
        }

        public static readonly PurpleParamsConverter Singleton = new PurpleParamsConverter();
    }

    internal class ResolveUnionConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ResolveUnion) || t == typeof(ResolveUnion?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    switch (stringValue)
                    {
                        case "independent":
                            return new ResolveUnion { Enum = ResolveEnum.Independent };
                        case "shared":
                            return new ResolveUnion { Enum = ResolveEnum.Shared };
                    }
                    break;
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<BoundsType>(reader);
                    return new ResolveUnion { BoundsType = objectValue };
            }
            throw new Exception("Cannot unmarshal type ResolveUnion");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (ResolveUnion)untypedValue;
            if (value.Enum != null)
            {
                switch (value.Enum)
                {
                    case ResolveEnum.Independent:
                        serializer.Serialize(writer, "independent");
                        return;
                    case ResolveEnum.Shared:
                        serializer.Serialize(writer, "shared");
                        return;
                }
            }
            if (value.BoundsType != null)
            {
                serializer.Serialize(writer, value.BoundsType);
                return;
            }
            throw new Exception("Cannot marshal type ResolveUnion");
        }

        public static readonly ResolveUnionConverter Singleton = new ResolveUnionConverter();
    }

    internal class ResolveEnumConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ResolveEnum) || t == typeof(ResolveEnum?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "independent":
                    return ResolveEnum.Independent;
                case "shared":
                    return ResolveEnum.Shared;
            }
            throw new Exception("Cannot unmarshal type ResolveEnum");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (ResolveEnum)untypedValue;
            switch (value)
            {
                case ResolveEnum.Independent:
                    serializer.Serialize(writer, "independent");
                    return;
                case ResolveEnum.Shared:
                    serializer.Serialize(writer, "shared");
                    return;
            }
            throw new Exception("Cannot marshal type ResolveEnum");
        }

        public static readonly ResolveEnumConverter Singleton = new ResolveEnumConverter();
    }

    internal class ShapeUnionConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ShapeUnion) || t == typeof(ShapeUnion?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    switch (stringValue)
                    {
                        case "arc":
                            return new ShapeUnion { Enum = ShapeEnum.Arc };
                        case "curve":
                            return new ShapeUnion { Enum = ShapeEnum.Curve };
                        case "diagonal":
                            return new ShapeUnion { Enum = ShapeEnum.Diagonal };
                        case "line":
                            return new ShapeUnion { Enum = ShapeEnum.Line };
                        case "orthogonal":
                            return new ShapeUnion { Enum = ShapeEnum.Orthogonal };
                    }
                    break;
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<BoundsType>(reader);
                    return new ShapeUnion { BoundsType = objectValue };
            }
            throw new Exception("Cannot unmarshal type ShapeUnion");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (ShapeUnion)untypedValue;
            if (value.Enum != null)
            {
                switch (value.Enum)
                {
                    case ShapeEnum.Arc:
                        serializer.Serialize(writer, "arc");
                        return;
                    case ShapeEnum.Curve:
                        serializer.Serialize(writer, "curve");
                        return;
                    case ShapeEnum.Diagonal:
                        serializer.Serialize(writer, "diagonal");
                        return;
                    case ShapeEnum.Line:
                        serializer.Serialize(writer, "line");
                        return;
                    case ShapeEnum.Orthogonal:
                        serializer.Serialize(writer, "orthogonal");
                        return;
                }
            }
            if (value.BoundsType != null)
            {
                serializer.Serialize(writer, value.BoundsType);
                return;
            }
            throw new Exception("Cannot marshal type ShapeUnion");
        }

        public static readonly ShapeUnionConverter Singleton = new ShapeUnionConverter();
    }

    internal class ShapeEnumConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ShapeEnum) || t == typeof(ShapeEnum?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "arc":
                    return ShapeEnum.Arc;
                case "curve":
                    return ShapeEnum.Curve;
                case "diagonal":
                    return ShapeEnum.Diagonal;
                case "line":
                    return ShapeEnum.Line;
                case "orthogonal":
                    return ShapeEnum.Orthogonal;
            }
            throw new Exception("Cannot unmarshal type ShapeEnum");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (ShapeEnum)untypedValue;
            switch (value)
            {
                case ShapeEnum.Arc:
                    serializer.Serialize(writer, "arc");
                    return;
                case ShapeEnum.Curve:
                    serializer.Serialize(writer, "curve");
                    return;
                case ShapeEnum.Diagonal:
                    serializer.Serialize(writer, "diagonal");
                    return;
                case ShapeEnum.Line:
                    serializer.Serialize(writer, "line");
                    return;
                case ShapeEnum.Orthogonal:
                    serializer.Serialize(writer, "orthogonal");
                    return;
            }
            throw new Exception("Cannot marshal type ShapeEnum");
        }

        public static readonly ShapeEnumConverter Singleton = new ShapeEnumConverter();
    }

    internal class SortUnionConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(SortUnion) || t == typeof(SortUnion?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Boolean:
                    var boolValue = serializer.Deserialize<bool>(reader);
                    return new SortUnion { Bool = boolValue };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<Sort>(reader);
                    return new SortUnion { Sort = objectValue };
            }
            throw new Exception("Cannot unmarshal type SortUnion");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (SortUnion)untypedValue;
            if (value.Bool != null)
            {
                serializer.Serialize(writer, value.Bool.Value);
                return;
            }
            if (value.Sort != null)
            {
                serializer.Serialize(writer, value.Sort);
                return;
            }
            throw new Exception("Cannot marshal type SortUnion");
        }

        public static readonly SortUnionConverter Singleton = new SortUnionConverter();
    }

    internal class SortFieldConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(SortField) || t == typeof(SortField?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    return new SortField { String = stringValue };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<SortFieldType>(reader);
                    return new SortField { Type = objectValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<List<SortFieldElementType>>(reader);
                    return new SortField { AnythingArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type SortField");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (SortField)untypedValue;
            if (value.String != null)
            {
                serializer.Serialize(writer, value.String);
                return;
            }
            if (value.AnythingArray != null)
            {
                serializer.Serialize(writer, value.AnythingArray);
                return;
            }
            if (value.Type != null)
            {
                serializer.Serialize(writer, value.Type);
                return;
            }
            throw new Exception("Cannot marshal type SortField");
        }

        public static readonly SortFieldConverter Singleton = new SortFieldConverter();
    }

    internal class PurpleFieldConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(SortFieldElementType) || t == typeof(SortFieldElementType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    return new SortFieldElementType { String = stringValue };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<SortFieldType>(reader);
                    return new SortFieldElementType { Type = objectValue };
            }
            throw new Exception("Cannot unmarshal type PurpleField");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (SortFieldElementType)untypedValue;
            if (value.String != null)
            {
                serializer.Serialize(writer, value.String);
                return;
            }
            if (value.Type != null)
            {
                serializer.Serialize(writer, value.Type);
                return;
            }
            throw new Exception("Cannot marshal type PurpleField");
        }

        public static readonly PurpleFieldConverter Singleton = new PurpleFieldConverter();
    }

    internal class PurpleOrderConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(MarkSortOrder) || t == typeof(MarkSortOrder?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    switch (stringValue)
                    {
                        case "ascending":
                            return new MarkSortOrder { Enum = OrderEnum.Ascending };
                        case "descending":
                            return new MarkSortOrder { Enum = OrderEnum.Descending };
                    }
                    break;
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<BoundsType>(reader);
                    return new MarkSortOrder { BoundsType = objectValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<List<OrderElement>>(reader);
                    return new MarkSortOrder { AnythingArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type PurpleOrder");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (MarkSortOrder)untypedValue;
            if (value.Enum != null)
            {
                switch (value.Enum)
                {
                    case OrderEnum.Ascending:
                        serializer.Serialize(writer, "ascending");
                        return;
                    case OrderEnum.Descending:
                        serializer.Serialize(writer, "descending");
                        return;
                }
            }
            if (value.AnythingArray != null)
            {
                serializer.Serialize(writer, value.AnythingArray);
                return;
            }
            if (value.BoundsType != null)
            {
                serializer.Serialize(writer, value.BoundsType);
                return;
            }
            throw new Exception("Cannot marshal type PurpleOrder");
        }

        public static readonly PurpleOrderConverter Singleton = new PurpleOrderConverter();
    }

    internal class OrderElementConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(OrderElement) || t == typeof(OrderElement?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    switch (stringValue)
                    {
                        case "ascending":
                            return new OrderElement { Enum = OrderEnum.Ascending };
                        case "descending":
                            return new OrderElement { Enum = OrderEnum.Descending };
                    }
                    break;
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<BoundsType>(reader);
                    return new OrderElement { BoundsType = objectValue };
            }
            throw new Exception("Cannot unmarshal type OrderElement");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (OrderElement)untypedValue;
            if (value.Enum != null)
            {
                switch (value.Enum)
                {
                    case OrderEnum.Ascending:
                        serializer.Serialize(writer, "ascending");
                        return;
                    case OrderEnum.Descending:
                        serializer.Serialize(writer, "descending");
                        return;
                }
            }
            if (value.BoundsType != null)
            {
                serializer.Serialize(writer, value.BoundsType);
                return;
            }
            throw new Exception("Cannot marshal type OrderElement");
        }

        public static readonly OrderElementConverter Singleton = new OrderElementConverter();
    }

    internal class OrderEnumConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(OrderEnum) || t == typeof(OrderEnum?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "ascending":
                    return OrderEnum.Ascending;
                case "descending":
                    return OrderEnum.Descending;
            }
            throw new Exception("Cannot unmarshal type OrderEnum");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (OrderEnum)untypedValue;
            switch (value)
            {
                case OrderEnum.Ascending:
                    serializer.Serialize(writer, "ascending");
                    return;
                case OrderEnum.Descending:
                    serializer.Serialize(writer, "descending");
                    return;
            }
            throw new Exception("Cannot marshal type OrderEnum");
        }

        public static readonly OrderEnumConverter Singleton = new OrderEnumConverter();
    }

    internal class TimezoneUnionConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(TimezoneUnion) || t == typeof(TimezoneUnion?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    switch (stringValue)
                    {
                        case "local":
                            return new TimezoneUnion { Enum = TimezoneEnum.Local };
                        case "utc":
                            return new TimezoneUnion { Enum = TimezoneEnum.Utc };
                    }
                    break;
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<BoundsType>(reader);
                    return new TimezoneUnion { BoundsType = objectValue };
            }
            throw new Exception("Cannot unmarshal type TimezoneUnion");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (TimezoneUnion)untypedValue;
            if (value.Enum != null)
            {
                switch (value.Enum)
                {
                    case TimezoneEnum.Local:
                        serializer.Serialize(writer, "local");
                        return;
                    case TimezoneEnum.Utc:
                        serializer.Serialize(writer, "utc");
                        return;
                }
            }
            if (value.BoundsType != null)
            {
                serializer.Serialize(writer, value.BoundsType);
                return;
            }
            throw new Exception("Cannot marshal type TimezoneUnion");
        }

        public static readonly TimezoneUnionConverter Singleton = new TimezoneUnionConverter();
    }

    internal class TimezoneEnumConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(TimezoneEnum) || t == typeof(TimezoneEnum?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "local":
                    return TimezoneEnum.Local;
                case "utc":
                    return TimezoneEnum.Utc;
            }
            throw new Exception("Cannot unmarshal type TimezoneEnum");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (TimezoneEnum)untypedValue;
            switch (value)
            {
                case TimezoneEnum.Local:
                    serializer.Serialize(writer, "local");
                    return;
                case TimezoneEnum.Utc:
                    serializer.Serialize(writer, "utc");
                    return;
            }
            throw new Exception("Cannot marshal type TimezoneEnum");
        }

        public static readonly TimezoneEnumConverter Singleton = new TimezoneEnumConverter();
    }

    internal class TranslateConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Translate) || t == typeof(Translate?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<BoundsType>(reader);
                    return new Translate { BoundsType = objectValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<List<Radius>>(reader);
                    return new Translate { AnythingArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type Translate");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (Translate)untypedValue;
            if (value.AnythingArray != null)
            {
                serializer.Serialize(writer, value.AnythingArray);
                return;
            }
            if (value.BoundsType != null)
            {
                serializer.Serialize(writer, value.BoundsType);
                return;
            }
            throw new Exception("Cannot marshal type Translate");
        }

        public static readonly TranslateConverter Singleton = new TranslateConverter();
    }

    internal class PurpleTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(TransformEnum) || t == typeof(TransformEnum?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "aggregate":
                    return TransformEnum.Aggregate;
                case "bin":
                    return TransformEnum.Bin;
                case "collect":
                    return TransformEnum.Collect;
                case "contour":
                    return TransformEnum.Contour;
                case "countpattern":
                    return TransformEnum.Countpattern;
                case "cross":
                    return TransformEnum.Cross;
                case "crossfilter":
                    return TransformEnum.Crossfilter;
                case "density":
                    return TransformEnum.Density;
                case "dotbin":
                    return TransformEnum.Dotbin;
                case "extent":
                    return TransformEnum.Extent;
                case "filter":
                    return TransformEnum.Filter;
                case "flatten":
                    return TransformEnum.Flatten;
                case "fold":
                    return TransformEnum.Fold;
                case "force":
                    return TransformEnum.Force;
                case "formula":
                    return TransformEnum.Formula;
                case "geojson":
                    return TransformEnum.Geojson;
                case "geopath":
                    return TransformEnum.Geopath;
                case "geopoint":
                    return TransformEnum.Geopoint;
                case "geoshape":
                    return TransformEnum.Geoshape;
                case "graticule":
                    return TransformEnum.Graticule;
                case "heatmap":
                    return TransformEnum.Heatmap;
                case "identifier":
                    return TransformEnum.Identifier;
                case "impute":
                    return TransformEnum.Impute;
                case "isocontour":
                    return TransformEnum.Isocontour;
                case "joinaggregate":
                    return TransformEnum.Joinaggregate;
                case "kde":
                    return TransformEnum.Kde;
                case "kde2d":
                    return TransformEnum.Kde2D;
                case "linkpath":
                    return TransformEnum.Linkpath;
                case "loess":
                    return TransformEnum.Loess;
                case "lookup":
                    return TransformEnum.Lookup;
                case "nest":
                    return TransformEnum.Nest;
                case "pack":
                    return TransformEnum.Pack;
                case "partition":
                    return TransformEnum.Partition;
                case "pie":
                    return TransformEnum.Pie;
                case "pivot":
                    return TransformEnum.Pivot;
                case "project":
                    return TransformEnum.Project;
                case "quantile":
                    return TransformEnum.Quantile;
                case "regression":
                    return TransformEnum.Regression;
                case "resolvefilter":
                    return TransformEnum.Resolvefilter;
                case "sample":
                    return TransformEnum.Sample;
                case "sequence":
                    return TransformEnum.Sequence;
                case "stack":
                    return TransformEnum.Stack;
                case "stratify":
                    return TransformEnum.Stratify;
                case "timeunit":
                    return TransformEnum.Timeunit;
                case "tree":
                    return TransformEnum.Tree;
                case "treelinks":
                    return TransformEnum.Treelinks;
                case "treemap":
                    return TransformEnum.Treemap;
                case "voronoi":
                    return TransformEnum.Voronoi;
                case "window":
                    return TransformEnum.Window;
                case "wordcloud":
                    return TransformEnum.Wordcloud;
            }
            throw new Exception("Cannot unmarshal type PurpleType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (TransformEnum)untypedValue;
            switch (value)
            {
                case TransformEnum.Aggregate:
                    serializer.Serialize(writer, "aggregate");
                    return;
                case TransformEnum.Bin:
                    serializer.Serialize(writer, "bin");
                    return;
                case TransformEnum.Collect:
                    serializer.Serialize(writer, "collect");
                    return;
                case TransformEnum.Contour:
                    serializer.Serialize(writer, "contour");
                    return;
                case TransformEnum.Countpattern:
                    serializer.Serialize(writer, "countpattern");
                    return;
                case TransformEnum.Cross:
                    serializer.Serialize(writer, "cross");
                    return;
                case TransformEnum.Crossfilter:
                    serializer.Serialize(writer, "crossfilter");
                    return;
                case TransformEnum.Density:
                    serializer.Serialize(writer, "density");
                    return;
                case TransformEnum.Dotbin:
                    serializer.Serialize(writer, "dotbin");
                    return;
                case TransformEnum.Extent:
                    serializer.Serialize(writer, "extent");
                    return;
                case TransformEnum.Filter:
                    serializer.Serialize(writer, "filter");
                    return;
                case TransformEnum.Flatten:
                    serializer.Serialize(writer, "flatten");
                    return;
                case TransformEnum.Fold:
                    serializer.Serialize(writer, "fold");
                    return;
                case TransformEnum.Force:
                    serializer.Serialize(writer, "force");
                    return;
                case TransformEnum.Formula:
                    serializer.Serialize(writer, "formula");
                    return;
                case TransformEnum.Geojson:
                    serializer.Serialize(writer, "geojson");
                    return;
                case TransformEnum.Geopath:
                    serializer.Serialize(writer, "geopath");
                    return;
                case TransformEnum.Geopoint:
                    serializer.Serialize(writer, "geopoint");
                    return;
                case TransformEnum.Geoshape:
                    serializer.Serialize(writer, "geoshape");
                    return;
                case TransformEnum.Graticule:
                    serializer.Serialize(writer, "graticule");
                    return;
                case TransformEnum.Heatmap:
                    serializer.Serialize(writer, "heatmap");
                    return;
                case TransformEnum.Identifier:
                    serializer.Serialize(writer, "identifier");
                    return;
                case TransformEnum.Impute:
                    serializer.Serialize(writer, "impute");
                    return;
                case TransformEnum.Isocontour:
                    serializer.Serialize(writer, "isocontour");
                    return;
                case TransformEnum.Joinaggregate:
                    serializer.Serialize(writer, "joinaggregate");
                    return;
                case TransformEnum.Kde:
                    serializer.Serialize(writer, "kde");
                    return;
                case TransformEnum.Kde2D:
                    serializer.Serialize(writer, "kde2d");
                    return;
                case TransformEnum.Linkpath:
                    serializer.Serialize(writer, "linkpath");
                    return;
                case TransformEnum.Loess:
                    serializer.Serialize(writer, "loess");
                    return;
                case TransformEnum.Lookup:
                    serializer.Serialize(writer, "lookup");
                    return;
                case TransformEnum.Nest:
                    serializer.Serialize(writer, "nest");
                    return;
                case TransformEnum.Pack:
                    serializer.Serialize(writer, "pack");
                    return;
                case TransformEnum.Partition:
                    serializer.Serialize(writer, "partition");
                    return;
                case TransformEnum.Pie:
                    serializer.Serialize(writer, "pie");
                    return;
                case TransformEnum.Pivot:
                    serializer.Serialize(writer, "pivot");
                    return;
                case TransformEnum.Project:
                    serializer.Serialize(writer, "project");
                    return;
                case TransformEnum.Quantile:
                    serializer.Serialize(writer, "quantile");
                    return;
                case TransformEnum.Regression:
                    serializer.Serialize(writer, "regression");
                    return;
                case TransformEnum.Resolvefilter:
                    serializer.Serialize(writer, "resolvefilter");
                    return;
                case TransformEnum.Sample:
                    serializer.Serialize(writer, "sample");
                    return;
                case TransformEnum.Sequence:
                    serializer.Serialize(writer, "sequence");
                    return;
                case TransformEnum.Stack:
                    serializer.Serialize(writer, "stack");
                    return;
                case TransformEnum.Stratify:
                    serializer.Serialize(writer, "stratify");
                    return;
                case TransformEnum.Timeunit:
                    serializer.Serialize(writer, "timeunit");
                    return;
                case TransformEnum.Tree:
                    serializer.Serialize(writer, "tree");
                    return;
                case TransformEnum.Treelinks:
                    serializer.Serialize(writer, "treelinks");
                    return;
                case TransformEnum.Treemap:
                    serializer.Serialize(writer, "treemap");
                    return;
                case TransformEnum.Voronoi:
                    serializer.Serialize(writer, "voronoi");
                    return;
                case TransformEnum.Window:
                    serializer.Serialize(writer, "window");
                    return;
                case TransformEnum.Wordcloud:
                    serializer.Serialize(writer, "wordcloud");
                    return;
            }
            throw new Exception("Cannot marshal type PurpleType");
        }

        public static readonly PurpleTypeConverter Singleton = new PurpleTypeConverter();
    }

    internal class UnitsUnionConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(UnitsUnion) || t == typeof(UnitsUnion?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<BoundsType>(reader);
                    return new UnitsUnion { BoundsType = objectValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<List<TypeElement>>(reader);
                    return new UnitsUnion { AnythingArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type UnitsUnion");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (UnitsUnion)untypedValue;
            if (value.AnythingArray != null)
            {
                serializer.Serialize(writer, value.AnythingArray);
                return;
            }
            if (value.BoundsType != null)
            {
                serializer.Serialize(writer, value.BoundsType);
                return;
            }
            throw new Exception("Cannot marshal type UnitsUnion");
        }

        public static readonly UnitsUnionConverter Singleton = new UnitsUnionConverter();
    }

    internal class ValuesUnionConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ValuesUnion) || t == typeof(ValuesUnion?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<BoundsType>(reader);
                    return new ValuesUnion { BoundsType = objectValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<List<ValueElement>>(reader);
                    return new ValuesUnion { AnythingArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type ValuesUnion");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (ValuesUnion)untypedValue;
            if (value.AnythingArray != null)
            {
                serializer.Serialize(writer, value.AnythingArray);
                return;
            }
            if (value.BoundsType != null)
            {
                serializer.Serialize(writer, value.BoundsType);
                return;
            }
            throw new Exception("Cannot marshal type ValuesUnion");
        }

        public static readonly ValuesUnionConverter Singleton = new ValuesUnionConverter();
    }

    internal class ValueElementConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ValueElement) || t == typeof(ValueElement?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Integer:
                case JsonToken.Float:
                    var doubleValue = serializer.Deserialize<double>(reader);
                    return new ValueElement { Double = doubleValue };
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    return new ValueElement { String = stringValue };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<ValueElementType>(reader);
                    return new ValueElement { Type = objectValue };
            }
            throw new Exception("Cannot unmarshal type ValueElement");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (ValueElement)untypedValue;
            if (value.Double != null)
            {
                serializer.Serialize(writer, value.Double.Value);
                return;
            }
            if (value.String != null)
            {
                serializer.Serialize(writer, value.String);
                return;
            }
            if (value.Type != null)
            {
                serializer.Serialize(writer, value.Type);
                return;
            }
            throw new Exception("Cannot marshal type ValueElement");
        }

        public static readonly ValueElementConverter Singleton = new ValueElementConverter();
    }

    internal class LayoutAlignConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(LayoutAlign) || t == typeof(LayoutAlign?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    switch (stringValue)
                    {
                        case "all":
                            return new LayoutAlign { Enum = AlignEnum.All };
                        case "each":
                            return new LayoutAlign { Enum = AlignEnum.Each };
                        case "none":
                            return new LayoutAlign { Enum = AlignEnum.None };
                    }
                    break;
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<LayoutAlignType>(reader);
                    return new LayoutAlign { Type = objectValue };
            }
            throw new Exception("Cannot unmarshal type LayoutAlign");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (LayoutAlign)untypedValue;
            if (value.Enum != null)
            {
                switch (value.Enum)
                {
                    case AlignEnum.All:
                        serializer.Serialize(writer, "all");
                        return;
                    case AlignEnum.Each:
                        serializer.Serialize(writer, "each");
                        return;
                    case AlignEnum.None:
                        serializer.Serialize(writer, "none");
                        return;
                }
            }
            if (value.Type != null)
            {
                serializer.Serialize(writer, value.Type);
                return;
            }
            throw new Exception("Cannot marshal type LayoutAlign");
        }

        public static readonly LayoutAlignConverter Singleton = new LayoutAlignConverter();
    }

    internal class GridAlignUnionConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(GridAlignUnion) || t == typeof(GridAlignUnion?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    switch (stringValue)
                    {
                        case "all":
                            return new GridAlignUnion { Enum = AlignEnum.All };
                        case "each":
                            return new GridAlignUnion { Enum = AlignEnum.Each };
                        case "none":
                            return new GridAlignUnion { Enum = AlignEnum.None };
                    }
                    break;
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<BoundsType>(reader);
                    return new GridAlignUnion { BoundsType = objectValue };
            }
            throw new Exception("Cannot unmarshal type GridAlignUnion");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (GridAlignUnion)untypedValue;
            if (value.Enum != null)
            {
                switch (value.Enum)
                {
                    case AlignEnum.All:
                        serializer.Serialize(writer, "all");
                        return;
                    case AlignEnum.Each:
                        serializer.Serialize(writer, "each");
                        return;
                    case AlignEnum.None:
                        serializer.Serialize(writer, "none");
                        return;
                }
            }
            if (value.BoundsType != null)
            {
                serializer.Serialize(writer, value.BoundsType);
                return;
            }
            throw new Exception("Cannot marshal type GridAlignUnion");
        }

        public static readonly GridAlignUnionConverter Singleton = new GridAlignUnionConverter();
    }

    internal class AlignEnumConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(AlignEnum) || t == typeof(AlignEnum?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "all":
                    return AlignEnum.All;
                case "each":
                    return AlignEnum.Each;
                case "none":
                    return AlignEnum.None;
            }
            throw new Exception("Cannot unmarshal type AlignEnum");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (AlignEnum)untypedValue;
            switch (value)
            {
                case AlignEnum.All:
                    serializer.Serialize(writer, "all");
                    return;
                case AlignEnum.Each:
                    serializer.Serialize(writer, "each");
                    return;
                case AlignEnum.None:
                    serializer.Serialize(writer, "none");
                    return;
            }
            throw new Exception("Cannot marshal type AlignEnum");
        }

        public static readonly AlignEnumConverter Singleton = new AlignEnumConverter();
    }

    internal class BoundsUnionConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(BoundsUnion) || t == typeof(BoundsUnion?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    switch (stringValue)
                    {
                        case "flush":
                            return new BoundsUnion { Enum = BoundsEnum.Flush };
                        case "full":
                            return new BoundsUnion { Enum = BoundsEnum.Full };
                    }
                    break;
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<BoundsType>(reader);
                    return new BoundsUnion { BoundsType = objectValue };
            }
            throw new Exception("Cannot unmarshal type BoundsUnion");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (BoundsUnion)untypedValue;
            if (value.Enum != null)
            {
                switch (value.Enum)
                {
                    case BoundsEnum.Flush:
                        serializer.Serialize(writer, "flush");
                        return;
                    case BoundsEnum.Full:
                        serializer.Serialize(writer, "full");
                        return;
                }
            }
            if (value.BoundsType != null)
            {
                serializer.Serialize(writer, value.BoundsType);
                return;
            }
            throw new Exception("Cannot marshal type BoundsUnion");
        }

        public static readonly BoundsUnionConverter Singleton = new BoundsUnionConverter();
    }

    internal class BoundsEnumConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(BoundsEnum) || t == typeof(BoundsEnum?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "flush":
                    return BoundsEnum.Flush;
                case "full":
                    return BoundsEnum.Full;
            }
            throw new Exception("Cannot unmarshal type BoundsEnum");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (BoundsEnum)untypedValue;
            switch (value)
            {
                case BoundsEnum.Flush:
                    serializer.Serialize(writer, "flush");
                    return;
                case BoundsEnum.Full:
                    serializer.Serialize(writer, "full");
                    return;
            }
            throw new Exception("Cannot marshal type BoundsEnum");
        }

        public static readonly BoundsEnumConverter Singleton = new BoundsEnumConverter();
    }

    internal class CenterConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Center) || t == typeof(Center?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Boolean:
                    var boolValue = serializer.Deserialize<bool>(reader);
                    return new Center { Bool = boolValue };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<CenterType>(reader);
                    return new Center { CenterType = objectValue };
            }
            throw new Exception("Cannot unmarshal type Center");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (Center)untypedValue;
            if (value.Bool != null)
            {
                serializer.Serialize(writer, value.Bool.Value);
                return;
            }
            if (value.CenterType != null)
            {
                serializer.Serialize(writer, value.CenterType);
                return;
            }
            throw new Exception("Cannot marshal type Center");
        }

        public static readonly CenterConverter Singleton = new CenterConverter();
    }

    internal class FooterBandConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(FooterBand) || t == typeof(FooterBand?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Null:
                    return new FooterBand();
                case JsonToken.Integer:
                case JsonToken.Float:
                    var doubleValue = serializer.Deserialize<double>(reader);
                    return new FooterBand { Double = doubleValue };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<FooterBandType>(reader);
                    return new FooterBand { FooterBandType = objectValue };
            }
            throw new Exception("Cannot unmarshal type FooterBand");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (FooterBand)untypedValue;
            if (value.IsNull)
            {
                serializer.Serialize(writer, null);
                return;
            }
            if (value.Double != null)
            {
                serializer.Serialize(writer, value.Double.Value);
                return;
            }
            if (value.FooterBandType != null)
            {
                serializer.Serialize(writer, value.FooterBandType);
                return;
            }
            throw new Exception("Cannot marshal type FooterBand");
        }

        public static readonly FooterBandConverter Singleton = new FooterBandConverter();
    }

    internal class HeaderBandConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(HeaderBand) || t == typeof(HeaderBand?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Null:
                    return new HeaderBand { };
                case JsonToken.Integer:
                case JsonToken.Float:
                    var doubleValue = serializer.Deserialize<double>(reader);
                    return new HeaderBand { Double = doubleValue };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<HeaderBandType>(reader);
                    return new HeaderBand { HeaderBandType = objectValue };
            }
            throw new Exception("Cannot unmarshal type HeaderBand");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (HeaderBand)untypedValue;
            if (value.IsNull)
            {
                serializer.Serialize(writer, null);
                return;
            }
            if (value.Double != null)
            {
                serializer.Serialize(writer, value.Double.Value);
                return;
            }
            if (value.HeaderBandType != null)
            {
                serializer.Serialize(writer, value.HeaderBandType);
                return;
            }
            throw new Exception("Cannot marshal type HeaderBand");
        }

        public static readonly HeaderBandConverter Singleton = new HeaderBandConverter();
    }

    internal class LayoutOffsetConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(LayoutOffset) || t == typeof(LayoutOffset?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Integer:
                case JsonToken.Float:
                    var doubleValue = serializer.Deserialize<double>(reader);
                    return new LayoutOffset { Double = doubleValue };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<Offset>(reader);
                    return new LayoutOffset { Offset = objectValue };
            }
            throw new Exception("Cannot unmarshal type LayoutOffset");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (LayoutOffset)untypedValue;
            if (value.Double != null)
            {
                serializer.Serialize(writer, value.Double.Value);
                return;
            }
            if (value.Offset != null)
            {
                serializer.Serialize(writer, value.Offset);
                return;
            }
            throw new Exception("Cannot marshal type LayoutOffset");
        }

        public static readonly LayoutOffsetConverter Singleton = new LayoutOffsetConverter();
    }

    internal class LayoutPaddingConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(LayoutPadding) || t == typeof(LayoutPadding?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Integer:
                case JsonToken.Float:
                    var doubleValue = serializer.Deserialize<double>(reader);
                    return new LayoutPadding { Double = doubleValue };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<LayoutPaddingType>(reader);
                    return new LayoutPadding { Type = objectValue };
            }
            throw new Exception("Cannot unmarshal type LayoutPadding");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (LayoutPadding)untypedValue;
            if (value.Double != null)
            {
                serializer.Serialize(writer, value.Double.Value);
                return;
            }
            if (value.Type != null)
            {
                serializer.Serialize(writer, value.Type);
                return;
            }
            throw new Exception("Cannot marshal type LayoutPadding");
        }

        public static readonly LayoutPaddingConverter Singleton = new LayoutPaddingConverter();
    }

    internal class TitleAnchorConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(TitleAnchor) || t == typeof(TitleAnchor?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    switch (stringValue)
                    {
                        case "end":
                            return new TitleAnchor { Enum = ColumnTitleAnchorEnum.End };
                        case "start":
                            return new TitleAnchor { Enum = ColumnTitleAnchorEnum.Start };
                    }
                    break;
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<ColumnTitleAnchorType>(reader);
                    return new TitleAnchor { Type = objectValue };
            }
            throw new Exception("Cannot unmarshal type TitleAnchor");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (TitleAnchor)untypedValue;
            if (value.Enum != null)
            {
                switch (value.Enum)
                {
                    case ColumnTitleAnchorEnum.End:
                        serializer.Serialize(writer, "end");
                        return;
                    case ColumnTitleAnchorEnum.Start:
                        serializer.Serialize(writer, "start");
                        return;
                }
            }
            if (value.Type != null)
            {
                serializer.Serialize(writer, value.Type);
                return;
            }
            throw new Exception("Cannot marshal type TitleAnchor");
        }

        public static readonly TitleAnchorConverter Singleton = new TitleAnchorConverter();
    }

    internal class TitleAnchorColumnUnionConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(TitleAnchorColumnUnion) || t == typeof(TitleAnchorColumnUnion?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    switch (stringValue)
                    {
                        case "end":
                            return new TitleAnchorColumnUnion { Enum = ColumnTitleAnchorEnum.End };
                        case "start":
                            return new TitleAnchorColumnUnion { Enum = ColumnTitleAnchorEnum.Start };
                    }
                    break;
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<BoundsType>(reader);
                    return new TitleAnchorColumnUnion { BoundsType = objectValue };
            }
            throw new Exception("Cannot unmarshal type TitleAnchorColumnUnion");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (TitleAnchorColumnUnion)untypedValue;
            if (value.Enum != null)
            {
                switch (value.Enum)
                {
                    case ColumnTitleAnchorEnum.End:
                        serializer.Serialize(writer, "end");
                        return;
                    case ColumnTitleAnchorEnum.Start:
                        serializer.Serialize(writer, "start");
                        return;
                }
            }
            if (value.BoundsType != null)
            {
                serializer.Serialize(writer, value.BoundsType);
                return;
            }
            throw new Exception("Cannot marshal type TitleAnchorColumnUnion");
        }

        public static readonly TitleAnchorColumnUnionConverter Singleton = new TitleAnchorColumnUnionConverter();
    }

    internal class ColumnTitleAnchorConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ColumnTitleAnchorEnum) || t == typeof(ColumnTitleAnchorEnum?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "end":
                    return ColumnTitleAnchorEnum.End;
                case "start":
                    return ColumnTitleAnchorEnum.Start;
            }
            throw new Exception("Cannot unmarshal type ColumnTitleAnchor");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (ColumnTitleAnchorEnum)untypedValue;
            switch (value)
            {
                case ColumnTitleAnchorEnum.End:
                    serializer.Serialize(writer, "end");
                    return;
                case ColumnTitleAnchorEnum.Start:
                    serializer.Serialize(writer, "start");
                    return;
            }
            throw new Exception("Cannot marshal type ColumnTitleAnchor");
        }

        public static readonly ColumnTitleAnchorConverter Singleton = new ColumnTitleAnchorConverter();
    }

    internal class TitleBandConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(TitleBand) || t == typeof(TitleBand?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Null:
                    return new TitleBand { };
                case JsonToken.Integer:
                case JsonToken.Float:
                    var doubleValue = serializer.Deserialize<double>(reader);
                    return new TitleBand { Double = doubleValue };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<TitleBandType>(reader);
                    return new TitleBand { TitleBandType = objectValue };
            }
            throw new Exception("Cannot unmarshal type TitleBand");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (TitleBand)untypedValue;
            if (value.IsNull)
            {
                serializer.Serialize(writer, null);
                return;
            }
            if (value.Double != null)
            {
                serializer.Serialize(writer, value.Double.Value);
                return;
            }
            if (value.TitleBandType != null)
            {
                serializer.Serialize(writer, value.TitleBandType);
                return;
            }
            throw new Exception("Cannot marshal type TitleBand");
        }

        public static readonly TitleBandConverter Singleton = new TitleBandConverter();
    }

    internal class DirectionConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(DirectionEnum) || t == typeof(DirectionEnum?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "horizontal":
                    return DirectionEnum.Horizontal;
                case "vertical":
                    return DirectionEnum.Vertical;
            }
            throw new Exception("Cannot unmarshal type Direction");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (DirectionEnum)untypedValue;
            switch (value)
            {
                case DirectionEnum.Horizontal:
                    serializer.Serialize(writer, "horizontal");
                    return;
                case DirectionEnum.Vertical:
                    serializer.Serialize(writer, "vertical");
                    return;
            }
            throw new Exception("Cannot marshal type Direction");
        }

        public static readonly DirectionConverter Singleton = new DirectionConverter();
    }

    internal class LegendFormatConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(LegendFormat) || t == typeof(LegendFormat?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    return new LegendFormat { String = stringValue };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<LegendFormatType>(reader);
                    return new LegendFormat { Type = objectValue };
            }
            throw new Exception("Cannot unmarshal type LegendFormat");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (LegendFormat)untypedValue;
            if (value.String != null)
            {
                serializer.Serialize(writer, value.String);
                return;
            }
            if (value.Type != null)
            {
                serializer.Serialize(writer, value.Type);
                return;
            }
            throw new Exception("Cannot marshal type LegendFormat");
        }

        public static readonly LegendFormatConverter Singleton = new LegendFormatConverter();
    }

    internal class LegendOrientConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(LegendOrient) || t == typeof(LegendOrient?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    switch (stringValue)
                    {
                        case "bottom":
                            return new LegendOrient { Enum = LegendOrientEnum.Bottom };
                        case "bottom-left":
                            return new LegendOrient { Enum = LegendOrientEnum.BottomLeft };
                        case "bottom-right":
                            return new LegendOrient { Enum = LegendOrientEnum.BottomRight };
                        case "left":
                            return new LegendOrient { Enum = LegendOrientEnum.Left };
                        case "none":
                            return new LegendOrient { Enum = LegendOrientEnum.None };
                        case "right":
                            return new LegendOrient { Enum = LegendOrientEnum.Right };
                        case "top":
                            return new LegendOrient { Enum = LegendOrientEnum.Top };
                        case "top-left":
                            return new LegendOrient { Enum = LegendOrientEnum.TopLeft };
                        case "top-right":
                            return new LegendOrient { Enum = LegendOrientEnum.TopRight };
                    }
                    break;
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<BoundsType>(reader);
                    return new LegendOrient { BoundsType = objectValue };
            }
            throw new Exception("Cannot unmarshal type LegendOrient");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (LegendOrient)untypedValue;
            if (value.Enum != null)
            {
                switch (value.Enum)
                {
                    case LegendOrientEnum.Bottom:
                        serializer.Serialize(writer, "bottom");
                        return;
                    case LegendOrientEnum.BottomLeft:
                        serializer.Serialize(writer, "bottom-left");
                        return;
                    case LegendOrientEnum.BottomRight:
                        serializer.Serialize(writer, "bottom-right");
                        return;
                    case LegendOrientEnum.Left:
                        serializer.Serialize(writer, "left");
                        return;
                    case LegendOrientEnum.None:
                        serializer.Serialize(writer, "none");
                        return;
                    case LegendOrientEnum.Right:
                        serializer.Serialize(writer, "right");
                        return;
                    case LegendOrientEnum.Top:
                        serializer.Serialize(writer, "top");
                        return;
                    case LegendOrientEnum.TopLeft:
                        serializer.Serialize(writer, "top-left");
                        return;
                    case LegendOrientEnum.TopRight:
                        serializer.Serialize(writer, "top-right");
                        return;
                }
            }
            if (value.BoundsType != null)
            {
                serializer.Serialize(writer, value.BoundsType);
                return;
            }
            throw new Exception("Cannot marshal type LegendOrient");
        }

        public static readonly LegendOrientConverter Singleton = new LegendOrientConverter();
    }

    internal class FluffyOrientConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(LegendOrientEnum) || t == typeof(LegendOrientEnum?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "bottom":
                    return LegendOrientEnum.Bottom;
                case "bottom-left":
                    return LegendOrientEnum.BottomLeft;
                case "bottom-right":
                    return LegendOrientEnum.BottomRight;
                case "left":
                    return LegendOrientEnum.Left;
                case "none":
                    return LegendOrientEnum.None;
                case "right":
                    return LegendOrientEnum.Right;
                case "top":
                    return LegendOrientEnum.Top;
                case "top-left":
                    return LegendOrientEnum.TopLeft;
                case "top-right":
                    return LegendOrientEnum.TopRight;
            }
            throw new Exception("Cannot unmarshal type FluffyOrient");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (LegendOrientEnum)untypedValue;
            switch (value)
            {
                case LegendOrientEnum.Bottom:
                    serializer.Serialize(writer, "bottom");
                    return;
                case LegendOrientEnum.BottomLeft:
                    serializer.Serialize(writer, "bottom-left");
                    return;
                case LegendOrientEnum.BottomRight:
                    serializer.Serialize(writer, "bottom-right");
                    return;
                case LegendOrientEnum.Left:
                    serializer.Serialize(writer, "left");
                    return;
                case LegendOrientEnum.None:
                    serializer.Serialize(writer, "none");
                    return;
                case LegendOrientEnum.Right:
                    serializer.Serialize(writer, "right");
                    return;
                case LegendOrientEnum.Top:
                    serializer.Serialize(writer, "top");
                    return;
                case LegendOrientEnum.TopLeft:
                    serializer.Serialize(writer, "top-left");
                    return;
                case LegendOrientEnum.TopRight:
                    serializer.Serialize(writer, "top-right");
                    return;
            }
            throw new Exception("Cannot marshal type FluffyOrient");
        }

        public static readonly FluffyOrientConverter Singleton = new FluffyOrientConverter();
    }

    internal class TitleOrientUnionConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(TitleOrientUnion) || t == typeof(TitleOrientUnion?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    switch (stringValue)
                    {
                        case "bottom":
                            return new TitleOrientUnion { Enum = TitleOrientEnum.Bottom };
                        case "left":
                            return new TitleOrientUnion { Enum = TitleOrientEnum.Left };
                        case "right":
                            return new TitleOrientUnion { Enum = TitleOrientEnum.Right };
                        case "top":
                            return new TitleOrientUnion { Enum = TitleOrientEnum.Top };
                    }
                    break;
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<TitleOrientType>(reader);
                    return new TitleOrientUnion { Type = objectValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<List<TitleOrientElement>>(reader);
                    return new TitleOrientUnion { TitleOrientElementArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type TitleOrientUnion");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (TitleOrientUnion)untypedValue;
            if (value.Enum != null)
            {
                switch (value.Enum)
                {
                    case TitleOrientEnum.Bottom:
                        serializer.Serialize(writer, "bottom");
                        return;
                    case TitleOrientEnum.Left:
                        serializer.Serialize(writer, "left");
                        return;
                    case TitleOrientEnum.Right:
                        serializer.Serialize(writer, "right");
                        return;
                    case TitleOrientEnum.Top:
                        serializer.Serialize(writer, "top");
                        return;
                }
            }
            if (value.TitleOrientElementArray != null)
            {
                serializer.Serialize(writer, value.TitleOrientElementArray);
                return;
            }
            if (value.Type != null)
            {
                serializer.Serialize(writer, value.Type);
                return;
            }
            throw new Exception("Cannot marshal type TitleOrientUnion");
        }

        public static readonly TitleOrientUnionConverter Singleton = new TitleOrientUnionConverter();
    }

    internal class LegendTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(LegendTypeEnum) || t == typeof(LegendTypeEnum?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "gradient":
                    return LegendTypeEnum.Gradient;
                case "symbol":
                    return LegendTypeEnum.Symbol;
            }
            throw new Exception("Cannot unmarshal type LegendType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (LegendTypeEnum)untypedValue;
            switch (value)
            {
                case LegendTypeEnum.Gradient:
                    serializer.Serialize(writer, "gradient");
                    return;
                case LegendTypeEnum.Symbol:
                    serializer.Serialize(writer, "symbol");
                    return;
            }
            throw new Exception("Cannot marshal type LegendType");
        }

        public static readonly LegendTypeConverter Singleton = new LegendTypeConverter();
    }

    internal class ClipConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Clip) || t == typeof(Clip?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Boolean:
                    var boolValue = serializer.Deserialize<bool>(reader);
                    return new Clip { Bool = boolValue };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<ClipType>(reader);
                    return new Clip { Type = objectValue };
            }
            throw new Exception("Cannot unmarshal type Clip");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (Clip)untypedValue;
            if (value.Bool != null)
            {
                serializer.Serialize(writer, value.Bool.Value);
                return;
            }
            if (value.Type != null)
            {
                serializer.Serialize(writer, value.Type);
                return;
            }
            throw new Exception("Cannot marshal type Clip");
        }

        public static readonly ClipConverter Singleton = new ClipConverter();
    }

    internal class ExtentConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Extent) || t == typeof(Extent?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<BoundsType>(reader);
                    return new Extent { BoundsType = objectValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<List<CenterElement>>(reader);
                    return new Extent { AnythingArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type Extent");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (Extent)untypedValue;
            if (value.AnythingArray != null)
            {
                serializer.Serialize(writer, value.AnythingArray);
                return;
            }
            if (value.BoundsType != null)
            {
                serializer.Serialize(writer, value.BoundsType);
                return;
            }
            throw new Exception("Cannot marshal type Extent");
        }

        public static readonly ExtentConverter Singleton = new ExtentConverter();
    }

    internal class FitConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Fit) || t == typeof(Fit?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<Dictionary<string, object>>(reader);
                    return new Fit { AnythingMap = objectValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<List<object>>(reader);
                    return new Fit { AnythingArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type Fit");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (Fit)untypedValue;
            if (value.AnythingArray != null)
            {
                serializer.Serialize(writer, value.AnythingArray);
                return;
            }
            if (value.AnythingMap != null)
            {
                serializer.Serialize(writer, value.AnythingMap);
                return;
            }
            throw new Exception("Cannot marshal type Fit");
        }

        public static readonly FitConverter Singleton = new FitConverter();
    }

    internal class BinsConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Bins) || t == typeof(Bins?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<BinsType>(reader);
                    return new Bins { BinsType = objectValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<List<ColumnsElement>>(reader);
                    return new Bins { AnythingArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type Bins");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (Bins)untypedValue;
            if (value.AnythingArray != null)
            {
                serializer.Serialize(writer, value.AnythingArray);
                return;
            }
            if (value.BinsType != null)
            {
                serializer.Serialize(writer, value.BinsType);
                return;
            }
            throw new Exception("Cannot marshal type Bins");
        }

        public static readonly BinsConverter Singleton = new BinsConverter();
    }

    internal class ScaleDomainConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ScaleDomain) || t == typeof(ScaleDomain?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<Domain>(reader);
                    return new ScaleDomain { Domain = objectValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<List<DomainElement>>(reader);
                    return new ScaleDomain { AnythingArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type ScaleDomain");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (ScaleDomain)untypedValue;
            if (value.AnythingArray != null)
            {
                serializer.Serialize(writer, value.AnythingArray);
                return;
            }
            if (value.Domain != null)
            {
                serializer.Serialize(writer, value.Domain);
                return;
            }
            throw new Exception("Cannot marshal type ScaleDomain");
        }

        public static readonly ScaleDomainConverter Singleton = new ScaleDomainConverter();
    }

    internal class DomainElementConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(DomainElement) || t == typeof(DomainElement?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Null:
                    return new DomainElement { };
                case JsonToken.Integer:
                case JsonToken.Float:
                    var doubleValue = serializer.Deserialize<double>(reader);
                    return new DomainElement { Double = doubleValue };
                case JsonToken.Boolean:
                    var boolValue = serializer.Deserialize<bool>(reader);
                    return new DomainElement { Bool = boolValue };
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    return new DomainElement { String = stringValue };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<BoundsType>(reader);
                    return new DomainElement { BoundsType = objectValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<List<ColumnsElement>>(reader);
                    return new DomainElement { AnythingArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type DomainElement");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (DomainElement)untypedValue;
            if (value.IsNull)
            {
                serializer.Serialize(writer, null);
                return;
            }
            if (value.Double != null)
            {
                serializer.Serialize(writer, value.Double.Value);
                return;
            }
            if (value.Bool != null)
            {
                serializer.Serialize(writer, value.Bool.Value);
                return;
            }
            if (value.String != null)
            {
                serializer.Serialize(writer, value.String);
                return;
            }
            if (value.AnythingArray != null)
            {
                serializer.Serialize(writer, value.AnythingArray);
                return;
            }
            if (value.BoundsType != null)
            {
                serializer.Serialize(writer, value.BoundsType);
                return;
            }
            throw new Exception("Cannot marshal type DomainElement");
        }

        public static readonly DomainElementConverter Singleton = new DomainElementConverter();
    }

    internal class V59216_Converter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(DomainFields) || t == typeof(DomainFields?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    return new DomainFields { String = stringValue };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<DomainFieldsType>(reader);
                    return new DomainFields { Type = objectValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<List<DomainFieldsElement>>(reader);
                    return new DomainFields { AnythingArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type V592_16");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (DomainFields)untypedValue;
            if (value.String != null)
            {
                serializer.Serialize(writer, value.String);
                return;
            }
            if (value.AnythingArray != null)
            {
                serializer.Serialize(writer, value.AnythingArray);
                return;
            }
            if (value.Type != null)
            {
                serializer.Serialize(writer, value.Type);
                return;
            }
            throw new Exception("Cannot marshal type V592_16");
        }

        public static readonly V59216_Converter Singleton = new V59216_Converter();
    }

    internal class FluffyFieldConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(DomainFieldsElement) || t == typeof(DomainFieldsElement?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Integer:
                case JsonToken.Float:
                    var doubleValue = serializer.Deserialize<double>(reader);
                    return new DomainFieldsElement { Double = doubleValue };
                case JsonToken.Boolean:
                    var boolValue = serializer.Deserialize<bool>(reader);
                    return new DomainFieldsElement { Bool = boolValue };
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    return new DomainFieldsElement { String = stringValue };
            }
            throw new Exception("Cannot unmarshal type FluffyField");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (DomainFieldsElement)untypedValue;
            if (value.Double != null)
            {
                serializer.Serialize(writer, value.Double.Value);
                return;
            }
            if (value.Bool != null)
            {
                serializer.Serialize(writer, value.Bool.Value);
                return;
            }
            if (value.String != null)
            {
                serializer.Serialize(writer, value.String);
                return;
            }
            throw new Exception("Cannot marshal type FluffyField");
        }

        public static readonly FluffyFieldConverter Singleton = new FluffyFieldConverter();
    }

    internal class DomainSortConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(DomainSort) || t == typeof(DomainSort?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Boolean:
                    var boolValue = serializer.Deserialize<bool>(reader);
                    return new DomainSort { Bool = boolValue };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<DomainSortType>(reader);
                    return new DomainSort { DomainSortType = objectValue };
            }
            throw new Exception("Cannot unmarshal type DomainSort");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (DomainSort)untypedValue;
            if (value.Bool != null)
            {
                serializer.Serialize(writer, value.Bool.Value);
                return;
            }
            if (value.DomainSortType != null)
            {
                serializer.Serialize(writer, value.DomainSortType);
                return;
            }
            throw new Exception("Cannot marshal type DomainSort");
        }

        public static readonly DomainSortConverter Singleton = new DomainSortConverter();
    }

    internal class DomainRawConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(DomainRaw) || t == typeof(DomainRaw?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Null:
                    return new DomainRaw { };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<BoundsType>(reader);
                    return new DomainRaw { BoundsType = objectValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<List<object>>(reader);
                    return new DomainRaw { AnythingArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type DomainRaw");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (DomainRaw)untypedValue;
            if (value.IsNull)
            {
                serializer.Serialize(writer, null);
                return;
            }
            if (value.AnythingArray != null)
            {
                serializer.Serialize(writer, value.AnythingArray);
                return;
            }
            if (value.BoundsType != null)
            {
                serializer.Serialize(writer, value.BoundsType);
                return;
            }
            throw new Exception("Cannot marshal type DomainRaw");
        }

        public static readonly DomainRawConverter Singleton = new DomainRawConverter();
    }

    internal class InterpolateConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Interpolate) || t == typeof(Interpolate?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    return new Interpolate { String = stringValue };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<InterpolateType>(reader);
                    return new Interpolate { Type = objectValue };
            }
            throw new Exception("Cannot unmarshal type Interpolate");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (Interpolate)untypedValue;
            if (value.String != null)
            {
                serializer.Serialize(writer, value.String);
                return;
            }
            if (value.Type != null)
            {
                serializer.Serialize(writer, value.Type);
                return;
            }
            throw new Exception("Cannot marshal type Interpolate");
        }

        public static readonly InterpolateConverter Singleton = new InterpolateConverter();
    }

    internal class NiceConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Nice) || t == typeof(Nice?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Integer:
                case JsonToken.Float:
                    var doubleValue = serializer.Deserialize<double>(reader);
                    return new Nice { Double = doubleValue };
                case JsonToken.Boolean:
                    var boolValue = serializer.Deserialize<bool>(reader);
                    return new Nice { Bool = boolValue };
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    switch (stringValue)
                    {
                        case "day":
                            return new Nice { Enum = TickCountEnum.Day };
                        case "hour":
                            return new Nice { Enum = TickCountEnum.Hour };
                        case "millisecond":
                            return new Nice { Enum = TickCountEnum.Millisecond };
                        case "minute":
                            return new Nice { Enum = TickCountEnum.Minute };
                        case "month":
                            return new Nice { Enum = TickCountEnum.Month };
                        case "second":
                            return new Nice { Enum = TickCountEnum.Second };
                        case "week":
                            return new Nice { Enum = TickCountEnum.Week };
                        case "year":
                            return new Nice { Enum = TickCountEnum.Year };
                    }
                    break;
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<NiceNice>(reader);
                    return new Nice { NiceNice = objectValue };
            }
            throw new Exception("Cannot unmarshal type Nice");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (Nice)untypedValue;
            if (value.Double != null)
            {
                serializer.Serialize(writer, value.Double.Value);
                return;
            }
            if (value.Bool != null)
            {
                serializer.Serialize(writer, value.Bool.Value);
                return;
            }
            if (value.Enum != null)
            {
                switch (value.Enum)
                {
                    case TickCountEnum.Day:
                        serializer.Serialize(writer, "day");
                        return;
                    case TickCountEnum.Hour:
                        serializer.Serialize(writer, "hour");
                        return;
                    case TickCountEnum.Millisecond:
                        serializer.Serialize(writer, "millisecond");
                        return;
                    case TickCountEnum.Minute:
                        serializer.Serialize(writer, "minute");
                        return;
                    case TickCountEnum.Month:
                        serializer.Serialize(writer, "month");
                        return;
                    case TickCountEnum.Second:
                        serializer.Serialize(writer, "second");
                        return;
                    case TickCountEnum.Week:
                        serializer.Serialize(writer, "week");
                        return;
                    case TickCountEnum.Year:
                        serializer.Serialize(writer, "year");
                        return;
                }
            }
            if (value.NiceNice != null)
            {
                serializer.Serialize(writer, value.NiceNice);
                return;
            }
            throw new Exception("Cannot marshal type Nice");
        }

        public static readonly NiceConverter Singleton = new NiceConverter();
    }

    internal class RangeUnionConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(RangeUnion) || t == typeof(RangeUnion?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    switch (stringValue)
                    {
                        case "category":
                            return new RangeUnion { Enum = RangeEnum.Category };
                        case "diverging":
                            return new RangeUnion { Enum = RangeEnum.Diverging };
                        case "heatmap":
                            return new RangeUnion { Enum = RangeEnum.Heatmap };
                        case "height":
                            return new RangeUnion { Enum = RangeEnum.Height };
                        case "ordinal":
                            return new RangeUnion { Enum = RangeEnum.Ordinal };
                        case "ramp":
                            return new RangeUnion { Enum = RangeEnum.Ramp };
                        case "symbol":
                            return new RangeUnion { Enum = RangeEnum.Symbol };
                        case "width":
                            return new RangeUnion { Enum = RangeEnum.Width };
                    }
                    break;
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<Range>(reader);
                    return new RangeUnion { Range = objectValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<List<DomainElement>>(reader);
                    return new RangeUnion { AnythingArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type RangeUnion");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (RangeUnion)untypedValue;
            if (value.Enum != null)
            {
                switch (value.Enum)
                {
                    case RangeEnum.Category:
                        serializer.Serialize(writer, "category");
                        return;
                    case RangeEnum.Diverging:
                        serializer.Serialize(writer, "diverging");
                        return;
                    case RangeEnum.Heatmap:
                        serializer.Serialize(writer, "heatmap");
                        return;
                    case RangeEnum.Height:
                        serializer.Serialize(writer, "height");
                        return;
                    case RangeEnum.Ordinal:
                        serializer.Serialize(writer, "ordinal");
                        return;
                    case RangeEnum.Ramp:
                        serializer.Serialize(writer, "ramp");
                        return;
                    case RangeEnum.Symbol:
                        serializer.Serialize(writer, "symbol");
                        return;
                    case RangeEnum.Width:
                        serializer.Serialize(writer, "width");
                        return;
                }
            }
            if (value.AnythingArray != null)
            {
                serializer.Serialize(writer, value.AnythingArray);
                return;
            }
            if (value.Range != null)
            {
                serializer.Serialize(writer, value.Range);
                return;
            }
            throw new Exception("Cannot marshal type RangeUnion");
        }

        public static readonly RangeUnionConverter Singleton = new RangeUnionConverter();
    }

    internal class V59217_Converter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(RangeFields) || t == typeof(RangeFields?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    return new RangeFields { String = stringValue };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<RangeFieldsType>(reader);
                    return new RangeFields { Type = objectValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<List<DomainFieldsElement>>(reader);
                    return new RangeFields { AnythingArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type V592_17");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (RangeFields)untypedValue;
            if (value.String != null)
            {
                serializer.Serialize(writer, value.String);
                return;
            }
            if (value.AnythingArray != null)
            {
                serializer.Serialize(writer, value.AnythingArray);
                return;
            }
            if (value.Type != null)
            {
                serializer.Serialize(writer, value.Type);
                return;
            }
            throw new Exception("Cannot marshal type V592_17");
        }

        public static readonly V59217_Converter Singleton = new V59217_Converter();
    }

    internal class SchemeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Scheme) || t == typeof(Scheme?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    return new Scheme { String = stringValue };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<BoundsType>(reader);
                    return new Scheme { BoundsType = objectValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<List<TypeElement>>(reader);
                    return new Scheme { AnythingArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type Scheme");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (Scheme)untypedValue;
            if (value.String != null)
            {
                serializer.Serialize(writer, value.String);
                return;
            }
            if (value.AnythingArray != null)
            {
                serializer.Serialize(writer, value.AnythingArray);
                return;
            }
            if (value.BoundsType != null)
            {
                serializer.Serialize(writer, value.BoundsType);
                return;
            }
            throw new Exception("Cannot marshal type Scheme");
        }

        public static readonly SchemeConverter Singleton = new SchemeConverter();
    }

    internal class RangeSortConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(RangeSort) || t == typeof(RangeSort?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Boolean:
                    var boolValue = serializer.Deserialize<bool>(reader);
                    return new RangeSort { Bool = boolValue };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<RangeSortType>(reader);
                    return new RangeSort { RangeSortType = objectValue };
            }
            throw new Exception("Cannot unmarshal type RangeSort");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (RangeSort)untypedValue;
            if (value.Bool != null)
            {
                serializer.Serialize(writer, value.Bool.Value);
                return;
            }
            if (value.RangeSortType != null)
            {
                serializer.Serialize(writer, value.RangeSortType);
                return;
            }
            throw new Exception("Cannot marshal type RangeSort");
        }

        public static readonly RangeSortConverter Singleton = new RangeSortConverter();
    }

    internal class RangeEnumConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(RangeEnum) || t == typeof(RangeEnum?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "category":
                    return RangeEnum.Category;
                case "diverging":
                    return RangeEnum.Diverging;
                case "heatmap":
                    return RangeEnum.Heatmap;
                case "height":
                    return RangeEnum.Height;
                case "ordinal":
                    return RangeEnum.Ordinal;
                case "ramp":
                    return RangeEnum.Ramp;
                case "symbol":
                    return RangeEnum.Symbol;
                case "width":
                    return RangeEnum.Width;
            }
            throw new Exception("Cannot unmarshal type RangeEnum");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (RangeEnum)untypedValue;
            switch (value)
            {
                case RangeEnum.Category:
                    serializer.Serialize(writer, "category");
                    return;
                case RangeEnum.Diverging:
                    serializer.Serialize(writer, "diverging");
                    return;
                case RangeEnum.Heatmap:
                    serializer.Serialize(writer, "heatmap");
                    return;
                case RangeEnum.Height:
                    serializer.Serialize(writer, "height");
                    return;
                case RangeEnum.Ordinal:
                    serializer.Serialize(writer, "ordinal");
                    return;
                case RangeEnum.Ramp:
                    serializer.Serialize(writer, "ramp");
                    return;
                case RangeEnum.Symbol:
                    serializer.Serialize(writer, "symbol");
                    return;
                case RangeEnum.Width:
                    serializer.Serialize(writer, "width");
                    return;
            }
            throw new Exception("Cannot marshal type RangeEnum");
        }

        public static readonly RangeEnumConverter Singleton = new RangeEnumConverter();
    }

    internal class ScaleTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ScaleTypeEnum) || t == typeof(ScaleTypeEnum?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "band":
                    return ScaleTypeEnum.Band;
                case "bin-ordinal":
                    return ScaleTypeEnum.BinOrdinal;
                case "identity":
                    return ScaleTypeEnum.Identity;
                case "linear":
                    return ScaleTypeEnum.Linear;
                case "log":
                    return ScaleTypeEnum.Log;
                case "ordinal":
                    return ScaleTypeEnum.Ordinal;
                case "point":
                    return ScaleTypeEnum.Point;
                case "pow":
                    return ScaleTypeEnum.Pow;
                case "quantile":
                    return ScaleTypeEnum.Quantile;
                case "quantize":
                    return ScaleTypeEnum.Quantize;
                case "sequential":
                    return ScaleTypeEnum.Sequential;
                case "sqrt":
                    return ScaleTypeEnum.Sqrt;
                case "symlog":
                    return ScaleTypeEnum.Symlog;
                case "threshold":
                    return ScaleTypeEnum.Threshold;
                case "time":
                    return ScaleTypeEnum.Time;
                case "utc":
                    return ScaleTypeEnum.Utc;
            }
            throw new Exception("Cannot unmarshal type ScaleType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (ScaleTypeEnum)untypedValue;
            switch (value)
            {
                case ScaleTypeEnum.Band:
                    serializer.Serialize(writer, "band");
                    return;
                case ScaleTypeEnum.BinOrdinal:
                    serializer.Serialize(writer, "bin-ordinal");
                    return;
                case ScaleTypeEnum.Identity:
                    serializer.Serialize(writer, "identity");
                    return;
                case ScaleTypeEnum.Linear:
                    serializer.Serialize(writer, "linear");
                    return;
                case ScaleTypeEnum.Log:
                    serializer.Serialize(writer, "log");
                    return;
                case ScaleTypeEnum.Ordinal:
                    serializer.Serialize(writer, "ordinal");
                    return;
                case ScaleTypeEnum.Point:
                    serializer.Serialize(writer, "point");
                    return;
                case ScaleTypeEnum.Pow:
                    serializer.Serialize(writer, "pow");
                    return;
                case ScaleTypeEnum.Quantile:
                    serializer.Serialize(writer, "quantile");
                    return;
                case ScaleTypeEnum.Quantize:
                    serializer.Serialize(writer, "quantize");
                    return;
                case ScaleTypeEnum.Sequential:
                    serializer.Serialize(writer, "sequential");
                    return;
                case ScaleTypeEnum.Sqrt:
                    serializer.Serialize(writer, "sqrt");
                    return;
                case ScaleTypeEnum.Symlog:
                    serializer.Serialize(writer, "symlog");
                    return;
                case ScaleTypeEnum.Threshold:
                    serializer.Serialize(writer, "threshold");
                    return;
                case ScaleTypeEnum.Time:
                    serializer.Serialize(writer, "time");
                    return;
                case ScaleTypeEnum.Utc:
                    serializer.Serialize(writer, "utc");
                    return;
            }
            throw new Exception("Cannot marshal type ScaleType");
        }

        public static readonly ScaleTypeConverter Singleton = new ScaleTypeConverter();
    }

    internal class EventsConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Events) || t == typeof(Events?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    return new Events { String = stringValue };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<EventsType>(reader);
                    return new Events { EventsType = objectValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<List<EventElement>>(reader);
                    return new Events { EventElementArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type Events");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (Events)untypedValue;
            if (value.String != null)
            {
                serializer.Serialize(writer, value.String);
                return;
            }
            if (value.EventElementArray != null)
            {
                serializer.Serialize(writer, value.EventElementArray);
                return;
            }
            if (value.EventsType != null)
            {
                serializer.Serialize(writer, value.EventsType);
                return;
            }
            throw new Exception("Cannot marshal type Events");
        }

        public static readonly EventsConverter Singleton = new EventsConverter();
    }

    internal class UpdateConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Update) || t == typeof(Update?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    return new Update { String = stringValue };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<UpdateType>(reader);
                    return new Update { UpdateType = objectValue };
            }
            throw new Exception("Cannot unmarshal type Update");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (Update)untypedValue;
            if (value.String != null)
            {
                serializer.Serialize(writer, value.String);
                return;
            }
            if (value.UpdateType != null)
            {
                serializer.Serialize(writer, value.UpdateType);
                return;
            }
            throw new Exception("Cannot marshal type Update");
        }

        public static readonly UpdateConverter Singleton = new UpdateConverter();
    }

    internal class PushConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(PushEnum) || t == typeof(PushEnum?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "outer")
            {
                return PushEnum.Outer;
            }
            throw new Exception("Cannot unmarshal type Push");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (PushEnum)untypedValue;
            if (value == PushEnum.Outer)
            {
                serializer.Serialize(writer, "outer");
                return;
            }
            throw new Exception("Cannot marshal type Push");
        }

        public static readonly PushConverter Singleton = new PushConverter();
    }

    internal class MarkTitleConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(MarkTitle) || t == typeof(MarkTitle?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    return new MarkTitle { String = stringValue };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<Title>(reader);
                    return new MarkTitle { Title = objectValue };
            }
            throw new Exception("Cannot unmarshal type MarkTitle");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (MarkTitle)untypedValue;
            if (value.String != null)
            {
                serializer.Serialize(writer, value.String);
                return;
            }
            if (value.Title != null)
            {
                serializer.Serialize(writer, value.Title);
                return;
            }
            throw new Exception("Cannot marshal type MarkTitle");
        }

        public static readonly MarkTitleConverter Singleton = new MarkTitleConverter();
    }

    internal class TitleFrameConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(TitleFrame) || t == typeof(TitleFrame?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    switch (stringValue)
                    {
                        case "bounds":
                            return new TitleFrame { Enum = FrameEnum.Bounds };
                        case "group":
                            return new TitleFrame { Enum = FrameEnum.Group };
                    }
                    break;
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<EllipsisType>(reader);
                    return new TitleFrame { EllipsisType = objectValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<List<LabelFontElement>>(reader);
                    return new TitleFrame { LabelFontElementArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type TitleFrame");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (TitleFrame)untypedValue;
            if (value.Enum != null)
            {
                switch (value.Enum)
                {
                    case FrameEnum.Bounds:
                        serializer.Serialize(writer, "bounds");
                        return;
                    case FrameEnum.Group:
                        serializer.Serialize(writer, "group");
                        return;
                }
            }
            if (value.LabelFontElementArray != null)
            {
                serializer.Serialize(writer, value.LabelFontElementArray);
                return;
            }
            if (value.EllipsisType != null)
            {
                serializer.Serialize(writer, value.EllipsisType);
                return;
            }
            throw new Exception("Cannot marshal type TitleFrame");
        }

        public static readonly TitleFrameConverter Singleton = new TitleFrameConverter();
    }

    internal class FrameEnumConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(FrameEnum) || t == typeof(FrameEnum?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "bounds":
                    return FrameEnum.Bounds;
                case "group":
                    return FrameEnum.Group;
            }
            throw new Exception("Cannot unmarshal type FrameEnum");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (FrameEnum)untypedValue;
            switch (value)
            {
                case FrameEnum.Bounds:
                    serializer.Serialize(writer, "bounds");
                    return;
                case FrameEnum.Group:
                    serializer.Serialize(writer, "group");
                    return;
            }
            throw new Exception("Cannot marshal type FrameEnum");
        }

        public static readonly FrameEnumConverter Singleton = new FrameEnumConverter();
    }

    internal class TitleOrientConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(TitleOrient) || t == typeof(TitleOrient?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    switch (stringValue)
                    {
                        case "bottom":
                            return new TitleOrient { Enum = BoundsTypeEnum.Bottom };
                        case "left":
                            return new TitleOrient { Enum = BoundsTypeEnum.Left };
                        case "none":
                            return new TitleOrient { Enum = BoundsTypeEnum.None };
                        case "right":
                            return new TitleOrient { Enum = BoundsTypeEnum.Right };
                        case "top":
                            return new TitleOrient { Enum = BoundsTypeEnum.Top };
                    }
                    break;
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<BoundsType>(reader);
                    return new TitleOrient { BoundsType = objectValue };
            }
            throw new Exception("Cannot unmarshal type TitleOrient");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (TitleOrient)untypedValue;
            if (value.Enum != null)
            {
                switch (value.Enum)
                {
                    case BoundsTypeEnum.Bottom:
                        serializer.Serialize(writer, "bottom");
                        return;
                    case BoundsTypeEnum.Left:
                        serializer.Serialize(writer, "left");
                        return;
                    case BoundsTypeEnum.None:
                        serializer.Serialize(writer, "none");
                        return;
                    case BoundsTypeEnum.Right:
                        serializer.Serialize(writer, "right");
                        return;
                    case BoundsTypeEnum.Top:
                        serializer.Serialize(writer, "top");
                        return;
                }
            }
            if (value.BoundsType != null)
            {
                serializer.Serialize(writer, value.BoundsType);
                return;
            }
            throw new Exception("Cannot marshal type TitleOrient");
        }

        public static readonly TitleOrientConverter Singleton = new TitleOrientConverter();
    }

    internal class TentacledOrientConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(BoundsTypeEnum) || t == typeof(BoundsTypeEnum?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "bottom":
                    return BoundsTypeEnum.Bottom;
                case "left":
                    return BoundsTypeEnum.Left;
                case "none":
                    return BoundsTypeEnum.None;
                case "right":
                    return BoundsTypeEnum.Right;
                case "top":
                    return BoundsTypeEnum.Top;
            }
            throw new Exception("Cannot unmarshal type TentacledOrient");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (BoundsTypeEnum)untypedValue;
            switch (value)
            {
                case BoundsTypeEnum.Bottom:
                    serializer.Serialize(writer, "bottom");
                    return;
                case BoundsTypeEnum.Left:
                    serializer.Serialize(writer, "left");
                    return;
                case BoundsTypeEnum.None:
                    serializer.Serialize(writer, "none");
                    return;
                case BoundsTypeEnum.Right:
                    serializer.Serialize(writer, "right");
                    return;
                case BoundsTypeEnum.Top:
                    serializer.Serialize(writer, "top");
                    return;
            }
            throw new Exception("Cannot marshal type TentacledOrient");
        }

        public static readonly TentacledOrientConverter Singleton = new TentacledOrientConverter();
    }

    internal class FluffyAsConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(MarkTransformAs) || t == typeof(MarkTransformAs?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    return new MarkTransformAs { String = stringValue };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<BoundsType>(reader);
                    return new MarkTransformAs { BoundsType = objectValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<List<AsA>>(reader);
                    return new MarkTransformAs { AnythingArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type FluffyAs");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (MarkTransformAs)untypedValue;
            if (value.String != null)
            {
                serializer.Serialize(writer, value.String);
                return;
            }
            if (value.AnythingArray != null)
            {
                serializer.Serialize(writer, value.AnythingArray);
                return;
            }
            if (value.BoundsType != null)
            {
                serializer.Serialize(writer, value.BoundsType);
                return;
            }
            throw new Exception("Cannot marshal type FluffyAs");
        }

        public static readonly FluffyAsConverter Singleton = new FluffyAsConverter();
    }

    internal class MethodUnionConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(MethodUnion) || t == typeof(MethodUnion?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    switch (stringValue)
                    {
                        case "binary":
                            return new MethodUnion { Enum = MethodEnum.Binary };
                        case "cluster":
                            return new MethodUnion { Enum = MethodEnum.Cluster };
                        case "dice":
                            return new MethodUnion { Enum = MethodEnum.Dice };
                        case "resquarify":
                            return new MethodUnion { Enum = MethodEnum.Resquarify };
                        case "slice":
                            return new MethodUnion { Enum = MethodEnum.Slice };
                        case "slicedice":
                            return new MethodUnion { Enum = MethodEnum.Slicedice };
                        case "squarify":
                            return new MethodUnion { Enum = MethodEnum.Squarify };
                        case "tidy":
                            return new MethodUnion { Enum = MethodEnum.Tidy };
                    }
                    break;
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<BoundsType>(reader);
                    return new MethodUnion { BoundsType = objectValue };
            }
            throw new Exception("Cannot unmarshal type MethodUnion");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (MethodUnion)untypedValue;
            if (value.Enum != null)
            {
                switch (value.Enum)
                {
                    case MethodEnum.Binary:
                        serializer.Serialize(writer, "binary");
                        return;
                    case MethodEnum.Cluster:
                        serializer.Serialize(writer, "cluster");
                        return;
                    case MethodEnum.Dice:
                        serializer.Serialize(writer, "dice");
                        return;
                    case MethodEnum.Resquarify:
                        serializer.Serialize(writer, "resquarify");
                        return;
                    case MethodEnum.Slice:
                        serializer.Serialize(writer, "slice");
                        return;
                    case MethodEnum.Slicedice:
                        serializer.Serialize(writer, "slicedice");
                        return;
                    case MethodEnum.Squarify:
                        serializer.Serialize(writer, "squarify");
                        return;
                    case MethodEnum.Tidy:
                        serializer.Serialize(writer, "tidy");
                        return;
                }
            }
            if (value.BoundsType != null)
            {
                serializer.Serialize(writer, value.BoundsType);
                return;
            }
            throw new Exception("Cannot marshal type MethodUnion");
        }

        public static readonly MethodUnionConverter Singleton = new MethodUnionConverter();
    }

    internal class MethodEnumConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(MethodEnum) || t == typeof(MethodEnum?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "binary":
                    return MethodEnum.Binary;
                case "cluster":
                    return MethodEnum.Cluster;
                case "dice":
                    return MethodEnum.Dice;
                case "resquarify":
                    return MethodEnum.Resquarify;
                case "slice":
                    return MethodEnum.Slice;
                case "slicedice":
                    return MethodEnum.Slicedice;
                case "squarify":
                    return MethodEnum.Squarify;
                case "tidy":
                    return MethodEnum.Tidy;
            }
            throw new Exception("Cannot unmarshal type MethodEnum");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (MethodEnum)untypedValue;
            switch (value)
            {
                case MethodEnum.Binary:
                    serializer.Serialize(writer, "binary");
                    return;
                case MethodEnum.Cluster:
                    serializer.Serialize(writer, "cluster");
                    return;
                case MethodEnum.Dice:
                    serializer.Serialize(writer, "dice");
                    return;
                case MethodEnum.Resquarify:
                    serializer.Serialize(writer, "resquarify");
                    return;
                case MethodEnum.Slice:
                    serializer.Serialize(writer, "slice");
                    return;
                case MethodEnum.Slicedice:
                    serializer.Serialize(writer, "slicedice");
                    return;
                case MethodEnum.Squarify:
                    serializer.Serialize(writer, "squarify");
                    return;
                case MethodEnum.Tidy:
                    serializer.Serialize(writer, "tidy");
                    return;
            }
            throw new Exception("Cannot marshal type MethodEnum");
        }

        public static readonly MethodEnumConverter Singleton = new MethodEnumConverter();
    }

    internal class FluffyTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(MarkTransformEnum) || t == typeof(MarkTransformEnum?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "bin":
                    return MarkTransformEnum.Bin;
                case "collect":
                    return MarkTransformEnum.Collect;
                case "crossfilter":
                    return MarkTransformEnum.Crossfilter;
                case "dotbin":
                    return MarkTransformEnum.Dotbin;
                case "extent":
                    return MarkTransformEnum.Extent;
                case "force":
                    return MarkTransformEnum.Force;
                case "formula":
                    return MarkTransformEnum.Formula;
                case "geojson":
                    return MarkTransformEnum.Geojson;
                case "geopath":
                    return MarkTransformEnum.Geopath;
                case "geopoint":
                    return MarkTransformEnum.Geopoint;
                case "geoshape":
                    return MarkTransformEnum.Geoshape;
                case "heatmap":
                    return MarkTransformEnum.Heatmap;
                case "identifier":
                    return MarkTransformEnum.Identifier;
                case "joinaggregate":
                    return MarkTransformEnum.Joinaggregate;
                case "linkpath":
                    return MarkTransformEnum.Linkpath;
                case "lookup":
                    return MarkTransformEnum.Lookup;
                case "pack":
                    return MarkTransformEnum.Pack;
                case "partition":
                    return MarkTransformEnum.Partition;
                case "pie":
                    return MarkTransformEnum.Pie;
                case "resolvefilter":
                    return MarkTransformEnum.Resolvefilter;
                case "sample":
                    return MarkTransformEnum.Sample;
                case "stack":
                    return MarkTransformEnum.Stack;
                case "stratify":
                    return MarkTransformEnum.Stratify;
                case "timeunit":
                    return MarkTransformEnum.Timeunit;
                case "tree":
                    return MarkTransformEnum.Tree;
                case "treemap":
                    return MarkTransformEnum.Treemap;
                case "voronoi":
                    return MarkTransformEnum.Voronoi;
                case "window":
                    return MarkTransformEnum.Window;
                case "wordcloud":
                    return MarkTransformEnum.Wordcloud;
            }
            throw new Exception("Cannot unmarshal type FluffyType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (MarkTransformEnum)untypedValue;
            switch (value)
            {
                case MarkTransformEnum.Bin:
                    serializer.Serialize(writer, "bin");
                    return;
                case MarkTransformEnum.Collect:
                    serializer.Serialize(writer, "collect");
                    return;
                case MarkTransformEnum.Crossfilter:
                    serializer.Serialize(writer, "crossfilter");
                    return;
                case MarkTransformEnum.Dotbin:
                    serializer.Serialize(writer, "dotbin");
                    return;
                case MarkTransformEnum.Extent:
                    serializer.Serialize(writer, "extent");
                    return;
                case MarkTransformEnum.Force:
                    serializer.Serialize(writer, "force");
                    return;
                case MarkTransformEnum.Formula:
                    serializer.Serialize(writer, "formula");
                    return;
                case MarkTransformEnum.Geojson:
                    serializer.Serialize(writer, "geojson");
                    return;
                case MarkTransformEnum.Geopath:
                    serializer.Serialize(writer, "geopath");
                    return;
                case MarkTransformEnum.Geopoint:
                    serializer.Serialize(writer, "geopoint");
                    return;
                case MarkTransformEnum.Geoshape:
                    serializer.Serialize(writer, "geoshape");
                    return;
                case MarkTransformEnum.Heatmap:
                    serializer.Serialize(writer, "heatmap");
                    return;
                case MarkTransformEnum.Identifier:
                    serializer.Serialize(writer, "identifier");
                    return;
                case MarkTransformEnum.Joinaggregate:
                    serializer.Serialize(writer, "joinaggregate");
                    return;
                case MarkTransformEnum.Linkpath:
                    serializer.Serialize(writer, "linkpath");
                    return;
                case MarkTransformEnum.Lookup:
                    serializer.Serialize(writer, "lookup");
                    return;
                case MarkTransformEnum.Pack:
                    serializer.Serialize(writer, "pack");
                    return;
                case MarkTransformEnum.Partition:
                    serializer.Serialize(writer, "partition");
                    return;
                case MarkTransformEnum.Pie:
                    serializer.Serialize(writer, "pie");
                    return;
                case MarkTransformEnum.Resolvefilter:
                    serializer.Serialize(writer, "resolvefilter");
                    return;
                case MarkTransformEnum.Sample:
                    serializer.Serialize(writer, "sample");
                    return;
                case MarkTransformEnum.Stack:
                    serializer.Serialize(writer, "stack");
                    return;
                case MarkTransformEnum.Stratify:
                    serializer.Serialize(writer, "stratify");
                    return;
                case MarkTransformEnum.Timeunit:
                    serializer.Serialize(writer, "timeunit");
                    return;
                case MarkTransformEnum.Tree:
                    serializer.Serialize(writer, "tree");
                    return;
                case MarkTransformEnum.Treemap:
                    serializer.Serialize(writer, "treemap");
                    return;
                case MarkTransformEnum.Voronoi:
                    serializer.Serialize(writer, "voronoi");
                    return;
                case MarkTransformEnum.Window:
                    serializer.Serialize(writer, "window");
                    return;
                case MarkTransformEnum.Wordcloud:
                    serializer.Serialize(writer, "wordcloud");
                    return;
            }
            throw new Exception("Cannot marshal type FluffyType");
        }

        public static readonly FluffyTypeConverter Singleton = new FluffyTypeConverter();
    }

    internal class VegaSpecificationPaddingConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Padding) || t == typeof(Padding?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Integer:
                case JsonToken.Float:
                    var doubleValue = serializer.Deserialize<double>(reader);
                    return new Padding { Double = doubleValue };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<PaddingType>(reader);
                    return new Padding { Type = objectValue };
            }
            throw new Exception("Cannot unmarshal type VegaSpecificationPadding");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (Padding)untypedValue;
            if (value.Double != null)
            {
                serializer.Serialize(writer, value.Double.Value);
                return;
            }
            if (value.Type != null)
            {
                serializer.Serialize(writer, value.Type);
                return;
            }
            throw new Exception("Cannot marshal type VegaSpecificationPadding");
        }

        public static readonly VegaSpecificationPaddingConverter Singleton = new VegaSpecificationPaddingConverter();
    }

}
