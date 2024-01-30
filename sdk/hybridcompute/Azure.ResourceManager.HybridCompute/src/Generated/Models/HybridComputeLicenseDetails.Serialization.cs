// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HybridCompute.Models
{
    public partial class HybridComputeLicenseDetails : IUtf8JsonSerializable, IJsonModel<HybridComputeLicenseDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<HybridComputeLicenseDetails>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<HybridComputeLicenseDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HybridComputeLicenseDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HybridComputeLicenseDetails)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(State))
            {
                writer.WritePropertyName("state"u8);
                writer.WriteStringValue(State.Value.ToString());
            }
            if (Optional.IsDefined(Target))
            {
                writer.WritePropertyName("target"u8);
                writer.WriteStringValue(Target.Value.ToString());
            }
            if (Optional.IsDefined(Edition))
            {
                writer.WritePropertyName("edition"u8);
                writer.WriteStringValue(Edition.Value.ToString());
            }
            if (Optional.IsDefined(LicenseCoreType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(LicenseCoreType.Value.ToString());
            }
            if (Optional.IsDefined(Processors))
            {
                writer.WritePropertyName("processors"u8);
                writer.WriteNumberValue(Processors.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(AssignedLicenses))
            {
                writer.WritePropertyName("assignedLicenses"u8);
                writer.WriteNumberValue(AssignedLicenses.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(ImmutableId))
            {
                writer.WritePropertyName("immutableId"u8);
                writer.WriteStringValue(ImmutableId);
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

        HybridComputeLicenseDetails IJsonModel<HybridComputeLicenseDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HybridComputeLicenseDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HybridComputeLicenseDetails)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeHybridComputeLicenseDetails(document.RootElement, options);
        }

        internal static HybridComputeLicenseDetails DeserializeHybridComputeLicenseDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<HybridComputeLicenseState> state = default;
            Optional<HybridComputeLicenseTarget> target = default;
            Optional<HybridComputeLicenseEdition> edition = default;
            Optional<LicenseCoreType> type = default;
            Optional<int> processors = default;
            Optional<int> assignedLicenses = default;
            Optional<string> immutableId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("state"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    state = new HybridComputeLicenseState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("target"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    target = new HybridComputeLicenseTarget(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("edition"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    edition = new HybridComputeLicenseEdition(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new LicenseCoreType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("processors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    processors = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("assignedLicenses"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    assignedLicenses = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("immutableId"u8))
                {
                    immutableId = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new HybridComputeLicenseDetails(Optional.ToNullable(state), Optional.ToNullable(target), Optional.ToNullable(edition), Optional.ToNullable(type), Optional.ToNullable(processors), Optional.ToNullable(assignedLicenses), immutableId.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<HybridComputeLicenseDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HybridComputeLicenseDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(HybridComputeLicenseDetails)} does not support '{options.Format}' format.");
            }
        }

        HybridComputeLicenseDetails IPersistableModel<HybridComputeLicenseDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HybridComputeLicenseDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeHybridComputeLicenseDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(HybridComputeLicenseDetails)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<HybridComputeLicenseDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
