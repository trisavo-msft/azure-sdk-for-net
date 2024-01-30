// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    [PersistableModelProxy(typeof(UnknownMonitoringSignalBase))]
    public partial class MonitoringSignalBase : IUtf8JsonSerializable, IJsonModel<MonitoringSignalBase>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MonitoringSignalBase>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MonitoringSignalBase>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MonitoringSignalBase>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MonitoringSignalBase)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Mode))
            {
                writer.WritePropertyName("mode"u8);
                writer.WriteStringValue(Mode.Value.ToString());
            }
            if (Optional.IsCollectionDefined(Properties))
            {
                if (Properties != null)
                {
                    writer.WritePropertyName("properties"u8);
                    writer.WriteStartObject();
                    foreach (var item in Properties)
                    {
                        writer.WritePropertyName(item.Key);
                        writer.WriteStringValue(item.Value);
                    }
                    writer.WriteEndObject();
                }
                else
                {
                    writer.WriteNull("properties");
                }
            }
            writer.WritePropertyName("signalType"u8);
            writer.WriteStringValue(SignalType.ToString());
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        MonitoringSignalBase IJsonModel<MonitoringSignalBase>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MonitoringSignalBase>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MonitoringSignalBase)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMonitoringSignalBase(document.RootElement, options);
        }

        internal static MonitoringSignalBase DeserializeMonitoringSignalBase(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("signalType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "Custom": return CustomMonitoringSignal.DeserializeCustomMonitoringSignal(element);
                    case "DataDrift": return DataDriftMonitoringSignal.DeserializeDataDriftMonitoringSignal(element);
                    case "DataQuality": return DataQualityMonitoringSignal.DeserializeDataQualityMonitoringSignal(element);
                    case "FeatureAttributionDrift": return FeatureAttributionDriftMonitoringSignal.DeserializeFeatureAttributionDriftMonitoringSignal(element);
                    case "GenerationSafetyQuality": return GenerationSafetyQualityMonitoringSignal.DeserializeGenerationSafetyQualityMonitoringSignal(element);
                    case "GenerationTokenStatistics": return GenerationTokenStatisticsSignal.DeserializeGenerationTokenStatisticsSignal(element);
                    case "ModelPerformance": return ModelPerformanceSignal.DeserializeModelPerformanceSignal(element);
                    case "PredictionDrift": return PredictionDriftMonitoringSignal.DeserializePredictionDriftMonitoringSignal(element);
                }
            }
            return UnknownMonitoringSignalBase.DeserializeUnknownMonitoringSignalBase(element);
        }

        BinaryData IPersistableModel<MonitoringSignalBase>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MonitoringSignalBase>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MonitoringSignalBase)} does not support '{options.Format}' format.");
            }
        }

        MonitoringSignalBase IPersistableModel<MonitoringSignalBase>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MonitoringSignalBase>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMonitoringSignalBase(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MonitoringSignalBase)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MonitoringSignalBase>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
