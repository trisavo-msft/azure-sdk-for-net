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
    public partial class MigrationAssessmentAvsAssessedMachineData : IUtf8JsonSerializable, IJsonModel<MigrationAssessmentAvsAssessedMachineData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MigrationAssessmentAvsAssessedMachineData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<MigrationAssessmentAvsAssessedMachineData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrationAssessmentAvsAssessedMachineData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MigrationAssessmentAvsAssessedMachineData)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsCollectionDefined(Errors))
            {
                writer.WritePropertyName("errors"u8);
                writer.WriteStartArray();
                foreach (var item in Errors)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(Disks))
            {
                writer.WritePropertyName("disks"u8);
                writer.WriteStartObject();
                foreach (var item in Disks)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value, options);
                }
                writer.WriteEndObject();
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(NetworkAdapters))
            {
                writer.WritePropertyName("networkAdapters"u8);
                writer.WriteStartObject();
                foreach (var item in NetworkAdapters)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value, options);
                }
                writer.WriteEndObject();
            }
            if (options.Format != "W" && Optional.IsDefined(StorageInUseGB))
            {
                writer.WritePropertyName("storageInUseGB"u8);
                writer.WriteNumberValue(StorageInUseGB.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(SuitabilityExplanation))
            {
                writer.WritePropertyName("suitabilityExplanation"u8);
                writer.WriteStringValue(SuitabilityExplanation.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(SuitabilityDetail))
            {
                writer.WritePropertyName("suitabilityDetail"u8);
                writer.WriteStringValue(SuitabilityDetail.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(TypePropertiesType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(TypePropertiesType.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(BootType))
            {
                writer.WritePropertyName("bootType"u8);
                writer.WriteStringValue(BootType.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(OperatingSystemType))
            {
                writer.WritePropertyName("operatingSystemType"u8);
                writer.WriteStringValue(OperatingSystemType);
            }
            if (options.Format != "W" && Optional.IsDefined(OperatingSystemName))
            {
                writer.WritePropertyName("operatingSystemName"u8);
                writer.WriteStringValue(OperatingSystemName);
            }
            if (options.Format != "W" && Optional.IsDefined(OperatingSystemVersion))
            {
                writer.WritePropertyName("operatingSystemVersion"u8);
                writer.WriteStringValue(OperatingSystemVersion);
            }
            if (options.Format != "W" && Optional.IsDefined(OperatingSystemArchitecture))
            {
                writer.WritePropertyName("operatingSystemArchitecture"u8);
                writer.WriteStringValue(OperatingSystemArchitecture.Value.ToString());
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
            if (options.Format != "W" && Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            if (options.Format != "W" && Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (options.Format != "W" && Optional.IsDefined(DatacenterMachineArmId))
            {
                writer.WritePropertyName("datacenterMachineArmId"u8);
                writer.WriteStringValue(DatacenterMachineArmId);
            }
            if (options.Format != "W" && Optional.IsDefined(DatacenterManagementServerArmId))
            {
                writer.WritePropertyName("datacenterManagementServerArmId"u8);
                writer.WriteStringValue(DatacenterManagementServerArmId);
            }
            if (options.Format != "W" && Optional.IsDefined(DatacenterManagementServerName))
            {
                writer.WritePropertyName("datacenterManagementServerName"u8);
                writer.WriteStringValue(DatacenterManagementServerName);
            }
            if (options.Format != "W" && Optional.IsDefined(MegabytesOfMemory))
            {
                writer.WritePropertyName("megabytesOfMemory"u8);
                writer.WriteNumberValue(MegabytesOfMemory.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(NumberOfCores))
            {
                writer.WritePropertyName("numberOfCores"u8);
                writer.WriteNumberValue(NumberOfCores.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(ConfidenceRatingInPercentage))
            {
                writer.WritePropertyName("confidenceRatingInPercentage"u8);
                writer.WriteNumberValue(ConfidenceRatingInPercentage.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(PercentageCoresUtilization))
            {
                writer.WritePropertyName("percentageCoresUtilization"u8);
                writer.WriteNumberValue(PercentageCoresUtilization.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(PercentageMemoryUtilization))
            {
                writer.WritePropertyName("percentageMemoryUtilization"u8);
                writer.WriteNumberValue(PercentageMemoryUtilization.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(Suitability))
            {
                writer.WritePropertyName("suitability"u8);
                writer.WriteStringValue(Suitability.Value.ToString());
            }
            writer.WriteEndObject();
        }

        MigrationAssessmentAvsAssessedMachineData IJsonModel<MigrationAssessmentAvsAssessedMachineData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrationAssessmentAvsAssessedMachineData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MigrationAssessmentAvsAssessedMachineData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMigrationAssessmentAvsAssessedMachineData(document.RootElement, options);
        }

        internal static MigrationAssessmentAvsAssessedMachineData DeserializeMigrationAssessmentAvsAssessedMachineData(JsonElement element, ModelReaderWriterOptions options = null)
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
            IReadOnlyList<MigrationAssessmentError> errors = default;
            IReadOnlyDictionary<string, AvsAssessedDisk> disks = default;
            IReadOnlyDictionary<string, AvsAssessedNetworkAdapter> networkAdapters = default;
            double? storageInUseGB = default;
            AvsVmSuitabilityExplanation? suitabilityExplanation = default;
            AvsVmSuitabilityDetail? suitabilityDetail = default;
            AssessedMachineType? type0 = default;
            MachineBootType? bootType = default;
            string operatingSystemType = default;
            string operatingSystemName = default;
            string operatingSystemVersion = default;
            GuestOperatingSystemArchitecture? operatingSystemArchitecture = default;
            DateTimeOffset? createdTimestamp = default;
            DateTimeOffset? updatedTimestamp = default;
            string displayName = default;
            string description = default;
            ResourceIdentifier datacenterMachineArmId = default;
            ResourceIdentifier datacenterManagementServerArmId = default;
            string datacenterManagementServerName = default;
            double? megabytesOfMemory = default;
            int? numberOfCores = default;
            double? confidenceRatingInPercentage = default;
            double? percentageCoresUtilization = default;
            double? percentageMemoryUtilization = default;
            MigrationAssessmentCloudSuitability? suitability = default;
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
                        if (property0.NameEquals("errors"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<MigrationAssessmentError> array = new List<MigrationAssessmentError>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(MigrationAssessmentError.DeserializeMigrationAssessmentError(item, options));
                            }
                            errors = array;
                            continue;
                        }
                        if (property0.NameEquals("disks"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, AvsAssessedDisk> dictionary = new Dictionary<string, AvsAssessedDisk>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, AvsAssessedDisk.DeserializeAvsAssessedDisk(property1.Value, options));
                            }
                            disks = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("networkAdapters"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, AvsAssessedNetworkAdapter> dictionary = new Dictionary<string, AvsAssessedNetworkAdapter>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, AvsAssessedNetworkAdapter.DeserializeAvsAssessedNetworkAdapter(property1.Value, options));
                            }
                            networkAdapters = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("storageInUseGB"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            storageInUseGB = property0.Value.GetDouble();
                            continue;
                        }
                        if (property0.NameEquals("suitabilityExplanation"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            suitabilityExplanation = new AvsVmSuitabilityExplanation(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("suitabilityDetail"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            suitabilityDetail = new AvsVmSuitabilityDetail(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("type"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            type0 = new AssessedMachineType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("bootType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            bootType = new MachineBootType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("operatingSystemType"u8))
                        {
                            operatingSystemType = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("operatingSystemName"u8))
                        {
                            operatingSystemName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("operatingSystemVersion"u8))
                        {
                            operatingSystemVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("operatingSystemArchitecture"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            operatingSystemArchitecture = new GuestOperatingSystemArchitecture(property0.Value.GetString());
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
                        if (property0.NameEquals("displayName"u8))
                        {
                            displayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("description"u8))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("datacenterMachineArmId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            datacenterMachineArmId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("datacenterManagementServerArmId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            datacenterManagementServerArmId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("datacenterManagementServerName"u8))
                        {
                            datacenterManagementServerName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("megabytesOfMemory"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            megabytesOfMemory = property0.Value.GetDouble();
                            continue;
                        }
                        if (property0.NameEquals("numberOfCores"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            numberOfCores = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("confidenceRatingInPercentage"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            confidenceRatingInPercentage = property0.Value.GetDouble();
                            continue;
                        }
                        if (property0.NameEquals("percentageCoresUtilization"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            percentageCoresUtilization = property0.Value.GetDouble();
                            continue;
                        }
                        if (property0.NameEquals("percentageMemoryUtilization"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            percentageMemoryUtilization = property0.Value.GetDouble();
                            continue;
                        }
                        if (property0.NameEquals("suitability"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            suitability = new MigrationAssessmentCloudSuitability(property0.Value.GetString());
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
            return new MigrationAssessmentAvsAssessedMachineData(
                id,
                name,
                type,
                systemData,
                errors ?? new ChangeTrackingList<MigrationAssessmentError>(),
                disks ?? new ChangeTrackingDictionary<string, AvsAssessedDisk>(),
                networkAdapters ?? new ChangeTrackingDictionary<string, AvsAssessedNetworkAdapter>(),
                storageInUseGB,
                suitabilityExplanation,
                suitabilityDetail,
                type0,
                bootType,
                operatingSystemType,
                operatingSystemName,
                operatingSystemVersion,
                operatingSystemArchitecture,
                createdTimestamp,
                updatedTimestamp,
                displayName,
                description,
                datacenterMachineArmId,
                datacenterManagementServerArmId,
                datacenterManagementServerName,
                megabytesOfMemory,
                numberOfCores,
                confidenceRatingInPercentage,
                percentageCoresUtilization,
                percentageMemoryUtilization,
                suitability,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MigrationAssessmentAvsAssessedMachineData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrationAssessmentAvsAssessedMachineData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MigrationAssessmentAvsAssessedMachineData)} does not support writing '{options.Format}' format.");
            }
        }

        MigrationAssessmentAvsAssessedMachineData IPersistableModel<MigrationAssessmentAvsAssessedMachineData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrationAssessmentAvsAssessedMachineData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMigrationAssessmentAvsAssessedMachineData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MigrationAssessmentAvsAssessedMachineData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MigrationAssessmentAvsAssessedMachineData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
