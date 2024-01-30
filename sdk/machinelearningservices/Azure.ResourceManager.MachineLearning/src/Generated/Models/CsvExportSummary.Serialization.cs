// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class CsvExportSummary : IUtf8JsonSerializable, IJsonModel<CsvExportSummary>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CsvExportSummary>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<CsvExportSummary>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CsvExportSummary>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CsvExportSummary)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(ContainerName))
            {
                if (ContainerName != null)
                {
                    writer.WritePropertyName("containerName"u8);
                    writer.WriteStringValue(ContainerName);
                }
                else
                {
                    writer.WriteNull("containerName");
                }
            }
            if (options.Format != "W" && Optional.IsDefined(SnapshotPath))
            {
                if (SnapshotPath != null)
                {
                    writer.WritePropertyName("snapshotPath"u8);
                    writer.WriteStringValue(SnapshotPath);
                }
                else
                {
                    writer.WriteNull("snapshotPath");
                }
            }
            if (options.Format != "W" && Optional.IsDefined(EndOn))
            {
                if (EndOn != null)
                {
                    writer.WritePropertyName("endDateTime"u8);
                    writer.WriteStringValue(EndOn.Value, "O");
                }
                else
                {
                    writer.WriteNull("endDateTime");
                }
            }
            if (options.Format != "W" && Optional.IsDefined(ExportedRowCount))
            {
                if (ExportedRowCount != null)
                {
                    writer.WritePropertyName("exportedRowCount"u8);
                    writer.WriteNumberValue(ExportedRowCount.Value);
                }
                else
                {
                    writer.WriteNull("exportedRowCount");
                }
            }
            writer.WritePropertyName("format"u8);
            writer.WriteStringValue(Format.ToString());
            if (options.Format != "W" && Optional.IsDefined(LabelingJobId))
            {
                if (LabelingJobId != null)
                {
                    writer.WritePropertyName("labelingJobId"u8);
                    writer.WriteStringValue(LabelingJobId);
                }
                else
                {
                    writer.WriteNull("labelingJobId");
                }
            }
            if (options.Format != "W" && Optional.IsDefined(StartOn))
            {
                if (StartOn != null)
                {
                    writer.WritePropertyName("startDateTime"u8);
                    writer.WriteStringValue(StartOn.Value, "O");
                }
                else
                {
                    writer.WriteNull("startDateTime");
                }
            }
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

        CsvExportSummary IJsonModel<CsvExportSummary>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CsvExportSummary>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CsvExportSummary)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCsvExportSummary(document.RootElement, options);
        }

        internal static CsvExportSummary DeserializeCsvExportSummary(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> containerName = default;
            Optional<string> snapshotPath = default;
            Optional<DateTimeOffset?> endDateTime = default;
            Optional<long?> exportedRowCount = default;
            ExportFormatType format = default;
            Optional<string> labelingJobId = default;
            Optional<DateTimeOffset?> startDateTime = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("containerName"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        containerName = null;
                        continue;
                    }
                    containerName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("snapshotPath"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        snapshotPath = null;
                        continue;
                    }
                    snapshotPath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("endDateTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        endDateTime = null;
                        continue;
                    }
                    endDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("exportedRowCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        exportedRowCount = null;
                        continue;
                    }
                    exportedRowCount = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("format"u8))
                {
                    format = new ExportFormatType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("labelingJobId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        labelingJobId = null;
                        continue;
                    }
                    labelingJobId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("startDateTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        startDateTime = null;
                        continue;
                    }
                    startDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new CsvExportSummary(Optional.ToNullable(endDateTime), Optional.ToNullable(exportedRowCount), format, labelingJobId.Value, Optional.ToNullable(startDateTime), serializedAdditionalRawData, containerName.Value, snapshotPath.Value);
        }

        BinaryData IPersistableModel<CsvExportSummary>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CsvExportSummary>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CsvExportSummary)} does not support '{options.Format}' format.");
            }
        }

        CsvExportSummary IPersistableModel<CsvExportSummary>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CsvExportSummary>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCsvExportSummary(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CsvExportSummary)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<CsvExportSummary>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
