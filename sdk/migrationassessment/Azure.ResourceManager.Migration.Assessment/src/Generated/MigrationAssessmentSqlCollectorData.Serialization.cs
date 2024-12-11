// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Migration.Assessment.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Migration.Assessment
{
    public partial class MigrationAssessmentSqlCollectorData : IUtf8JsonSerializable, IJsonModel<MigrationAssessmentSqlCollectorData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MigrationAssessmentSqlCollectorData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<MigrationAssessmentSqlCollectorData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrationAssessmentSqlCollectorData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MigrationAssessmentSqlCollectorData)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (Optional.IsDefined(AgentProperties))
            {
                writer.WritePropertyName("agentProperties"u8);
                writer.WriteObjectValue(AgentProperties, options);
            }
            if (Optional.IsDefined(DiscoverySiteId))
            {
                writer.WritePropertyName("discoverySiteId"u8);
                writer.WriteStringValue(DiscoverySiteId);
            }
            if (options.Format != "W" && Optional.IsDefined(CreatedOn))
            {
                writer.WritePropertyName("createdTimestamp"u8);
                writer.WriteStringValue(CreatedOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(UpdatedOn))
            {
                writer.WritePropertyName("updatedTimestamp"u8);
                writer.WriteStringValue(UpdatedOn.Value, "O");
            }
            writer.WriteEndObject();
        }

        MigrationAssessmentSqlCollectorData IJsonModel<MigrationAssessmentSqlCollectorData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrationAssessmentSqlCollectorData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MigrationAssessmentSqlCollectorData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMigrationAssessmentSqlCollectorData(document.RootElement, options);
        }

        internal static MigrationAssessmentSqlCollectorData DeserializeMigrationAssessmentSqlCollectorData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            MigrationAssessmentProvisioningState? provisioningState = default;
            CollectorAgentPropertiesBase agentProperties = default;
            string discoverySiteId = default;
            DateTimeOffset? createdTimestamp = default;
            DateTimeOffset? updatedTimestamp = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new MigrationAssessmentProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("agentProperties"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            agentProperties = CollectorAgentPropertiesBase.DeserializeCollectorAgentPropertiesBase(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("discoverySiteId"u8))
                        {
                            discoverySiteId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("createdTimestamp"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            createdTimestamp = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("updatedTimestamp"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            updatedTimestamp = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new MigrationAssessmentSqlCollectorData(
                id,
                name,
                type,
                systemData,
                provisioningState,
                agentProperties,
                discoverySiteId,
                createdTimestamp,
                updatedTimestamp,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MigrationAssessmentSqlCollectorData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrationAssessmentSqlCollectorData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MigrationAssessmentSqlCollectorData)} does not support writing '{options.Format}' format.");
            }
        }

        MigrationAssessmentSqlCollectorData IPersistableModel<MigrationAssessmentSqlCollectorData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrationAssessmentSqlCollectorData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMigrationAssessmentSqlCollectorData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MigrationAssessmentSqlCollectorData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MigrationAssessmentSqlCollectorData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
