// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Migration.Assessment.Models
{
    public partial class SqlAssessmentV2IaasSuitabilityDetails : IUtf8JsonSerializable, IJsonModel<SqlAssessmentV2IaasSuitabilityDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SqlAssessmentV2IaasSuitabilityDetails>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<SqlAssessmentV2IaasSuitabilityDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlAssessmentV2IaasSuitabilityDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SqlAssessmentV2IaasSuitabilityDetails)} does not support writing '{format}' format.");
            }

            if (options.Format != "W" && Optional.IsDefined(AzureSqlSku))
            {
                writer.WritePropertyName("azureSqlSku"u8);
                writer.WriteObjectValue(AzureSqlSku, options);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(ReplicaAzureSqlSku))
            {
                writer.WritePropertyName("replicaAzureSqlSku"u8);
                writer.WriteStartArray();
                foreach (var item in ReplicaAzureSqlSku)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(SharedResources))
            {
                writer.WritePropertyName("sharedResources"u8);
                writer.WriteObjectValue(SharedResources, options);
            }
            if (options.Format != "W" && Optional.IsDefined(MonthlyComputeCost))
            {
                writer.WritePropertyName("monthlyComputeCost"u8);
                writer.WriteNumberValue(MonthlyComputeCost.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(MonthlyStorageCost))
            {
                writer.WritePropertyName("monthlyStorageCost"u8);
                writer.WriteNumberValue(MonthlyStorageCost.Value);
            }
            if (Optional.IsCollectionDefined(CostComponents))
            {
                writer.WritePropertyName("costComponents"u8);
                writer.WriteStartArray();
                foreach (var item in CostComponents)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(SecuritySuitability))
            {
                writer.WritePropertyName("securitySuitability"u8);
                writer.WriteStringValue(SecuritySuitability.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(ShouldProvisionReplicas))
            {
                writer.WritePropertyName("shouldProvisionReplicas"u8);
                writer.WriteBooleanValue(ShouldProvisionReplicas.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(SkuReplicationMode))
            {
                writer.WritePropertyName("skuReplicationMode"u8);
                writer.WriteStringValue(SkuReplicationMode.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(MigrationGuidelines))
            {
                writer.WritePropertyName("migrationGuidelines"u8);
                writer.WriteStartArray();
                foreach (var item in MigrationGuidelines)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(RecommendationReasonings))
            {
                writer.WritePropertyName("recommendationReasonings"u8);
                writer.WriteStartArray();
                foreach (var item in RecommendationReasonings)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(MigrationTargetPlatform))
            {
                writer.WritePropertyName("migrationTargetPlatform"u8);
                writer.WriteStringValue(MigrationTargetPlatform.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(Suitability))
            {
                writer.WritePropertyName("suitability"u8);
                writer.WriteStringValue(Suitability.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(MigrationIssues))
            {
                writer.WritePropertyName("migrationIssues"u8);
                writer.WriteStartArray();
                foreach (var item in MigrationIssues)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
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
        }

        SqlAssessmentV2IaasSuitabilityDetails IJsonModel<SqlAssessmentV2IaasSuitabilityDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlAssessmentV2IaasSuitabilityDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SqlAssessmentV2IaasSuitabilityDetails)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSqlAssessmentV2IaasSuitabilityDetails(document.RootElement, options);
        }

        internal static SqlAssessmentV2IaasSuitabilityDetails DeserializeSqlAssessmentV2IaasSuitabilityDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            AzureSqlIaasSkuDto azureSqlSku = default;
            IReadOnlyList<AzureSqlIaasSkuDto> replicaAzureSqlSku = default;
            SharedResourcesDto sharedResources = default;
            double? monthlyComputeCost = default;
            double? monthlyStorageCost = default;
            IReadOnlyList<CostComponent> costComponents = default;
            MigrationAssessmentCloudSuitability? securitySuitability = default;
            bool? shouldProvisionReplicas = default;
            SkuReplicationMode? skuReplicationMode = default;
            IReadOnlyList<SqlMigrationGuideline> migrationGuidelines = default;
            IReadOnlyList<SqlRecommendationReasoning> recommendationReasonings = default;
            MigrationAssessmentTargetType? migrationTargetPlatform = default;
            MigrationAssessmentCloudSuitability? suitability = default;
            IReadOnlyList<SqlAssessmentMigrationIssue> migrationIssues = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("azureSqlSku"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    azureSqlSku = AzureSqlIaasSkuDto.DeserializeAzureSqlIaasSkuDto(property.Value, options);
                    continue;
                }
                if (property.NameEquals("replicaAzureSqlSku"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AzureSqlIaasSkuDto> array = new List<AzureSqlIaasSkuDto>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AzureSqlIaasSkuDto.DeserializeAzureSqlIaasSkuDto(item, options));
                    }
                    replicaAzureSqlSku = array;
                    continue;
                }
                if (property.NameEquals("sharedResources"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sharedResources = SharedResourcesDto.DeserializeSharedResourcesDto(property.Value, options);
                    continue;
                }
                if (property.NameEquals("monthlyComputeCost"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    monthlyComputeCost = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("monthlyStorageCost"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    monthlyStorageCost = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("costComponents"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<CostComponent> array = new List<CostComponent>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(CostComponent.DeserializeCostComponent(item, options));
                    }
                    costComponents = array;
                    continue;
                }
                if (property.NameEquals("securitySuitability"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    securitySuitability = new MigrationAssessmentCloudSuitability(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("shouldProvisionReplicas"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    shouldProvisionReplicas = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("skuReplicationMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    skuReplicationMode = new SkuReplicationMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("migrationGuidelines"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SqlMigrationGuideline> array = new List<SqlMigrationGuideline>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SqlMigrationGuideline.DeserializeSqlMigrationGuideline(item, options));
                    }
                    migrationGuidelines = array;
                    continue;
                }
                if (property.NameEquals("recommendationReasonings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SqlRecommendationReasoning> array = new List<SqlRecommendationReasoning>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SqlRecommendationReasoning.DeserializeSqlRecommendationReasoning(item, options));
                    }
                    recommendationReasonings = array;
                    continue;
                }
                if (property.NameEquals("migrationTargetPlatform"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    migrationTargetPlatform = new MigrationAssessmentTargetType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("suitability"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    suitability = new MigrationAssessmentCloudSuitability(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("migrationIssues"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SqlAssessmentMigrationIssue> array = new List<SqlAssessmentMigrationIssue>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SqlAssessmentMigrationIssue.DeserializeSqlAssessmentMigrationIssue(item, options));
                    }
                    migrationIssues = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new SqlAssessmentV2IaasSuitabilityDetails(
                azureSqlSku,
                replicaAzureSqlSku ?? new ChangeTrackingList<AzureSqlIaasSkuDto>(),
                sharedResources,
                monthlyComputeCost,
                monthlyStorageCost,
                costComponents ?? new ChangeTrackingList<CostComponent>(),
                securitySuitability,
                shouldProvisionReplicas,
                skuReplicationMode,
                migrationGuidelines ?? new ChangeTrackingList<SqlMigrationGuideline>(),
                recommendationReasonings ?? new ChangeTrackingList<SqlRecommendationReasoning>(),
                migrationTargetPlatform,
                suitability,
                migrationIssues ?? new ChangeTrackingList<SqlAssessmentMigrationIssue>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SqlAssessmentV2IaasSuitabilityDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlAssessmentV2IaasSuitabilityDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SqlAssessmentV2IaasSuitabilityDetails)} does not support writing '{options.Format}' format.");
            }
        }

        SqlAssessmentV2IaasSuitabilityDetails IPersistableModel<SqlAssessmentV2IaasSuitabilityDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlAssessmentV2IaasSuitabilityDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSqlAssessmentV2IaasSuitabilityDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SqlAssessmentV2IaasSuitabilityDetails)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SqlAssessmentV2IaasSuitabilityDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
