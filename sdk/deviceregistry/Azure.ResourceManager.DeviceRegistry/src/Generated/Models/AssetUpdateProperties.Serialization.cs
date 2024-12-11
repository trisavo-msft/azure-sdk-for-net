// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DeviceRegistry.Models
{
    public partial class AssetUpdateProperties : IUtf8JsonSerializable, IJsonModel<AssetUpdateProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AssetUpdateProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<AssetUpdateProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AssetUpdateProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AssetUpdateProperties)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(Enabled))
            {
                writer.WritePropertyName("enabled"u8);
                writer.WriteBooleanValue(Enabled.Value);
            }
            if (Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(Manufacturer))
            {
                writer.WritePropertyName("manufacturer"u8);
                writer.WriteStringValue(Manufacturer);
            }
            if (Optional.IsDefined(ManufacturerUri))
            {
                writer.WritePropertyName("manufacturerUri"u8);
                writer.WriteStringValue(ManufacturerUri);
            }
            if (Optional.IsDefined(Model))
            {
                writer.WritePropertyName("model"u8);
                writer.WriteStringValue(Model);
            }
            if (Optional.IsDefined(ProductCode))
            {
                writer.WritePropertyName("productCode"u8);
                writer.WriteStringValue(ProductCode);
            }
            if (Optional.IsDefined(HardwareRevision))
            {
                writer.WritePropertyName("hardwareRevision"u8);
                writer.WriteStringValue(HardwareRevision);
            }
            if (Optional.IsDefined(SoftwareRevision))
            {
                writer.WritePropertyName("softwareRevision"u8);
                writer.WriteStringValue(SoftwareRevision);
            }
            if (Optional.IsDefined(DocumentationUri))
            {
                writer.WritePropertyName("documentationUri"u8);
                writer.WriteStringValue(DocumentationUri);
            }
            if (Optional.IsDefined(SerialNumber))
            {
                writer.WritePropertyName("serialNumber"u8);
                writer.WriteStringValue(SerialNumber);
            }
            if (Optional.IsCollectionDefined(Attributes))
            {
                writer.WritePropertyName("attributes"u8);
                writer.WriteStartObject();
                foreach (var item in Attributes)
                {
                    writer.WritePropertyName(item.Key);
                    if (item.Value == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(DefaultDatasetsConfiguration))
            {
                writer.WritePropertyName("defaultDatasetsConfiguration"u8);
                writer.WriteStringValue(DefaultDatasetsConfiguration);
            }
            if (Optional.IsDefined(DefaultEventsConfiguration))
            {
                writer.WritePropertyName("defaultEventsConfiguration"u8);
                writer.WriteStringValue(DefaultEventsConfiguration);
            }
            if (Optional.IsDefined(DefaultTopic))
            {
                writer.WritePropertyName("defaultTopic"u8);
                writer.WriteObjectValue(DefaultTopic, options);
            }
            if (Optional.IsCollectionDefined(Datasets))
            {
                writer.WritePropertyName("datasets"u8);
                writer.WriteStartArray();
                foreach (var item in Datasets)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Events))
            {
                writer.WritePropertyName("events"u8);
                writer.WriteStartArray();
                foreach (var item in Events)
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

        AssetUpdateProperties IJsonModel<AssetUpdateProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AssetUpdateProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AssetUpdateProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAssetUpdateProperties(document.RootElement, options);
        }

        internal static AssetUpdateProperties DeserializeAssetUpdateProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool? enabled = default;
            string displayName = default;
            string description = default;
            string manufacturer = default;
            string manufacturerUri = default;
            string model = default;
            string productCode = default;
            string hardwareRevision = default;
            string softwareRevision = default;
            string documentationUri = default;
            string serialNumber = default;
            IDictionary<string, BinaryData> attributes = default;
            string defaultDatasetsConfiguration = default;
            string defaultEventsConfiguration = default;
            DeviceRegistryMqttTopic defaultTopic = default;
            IList<DeviceRegistryDataset> datasets = default;
            IList<DeviceRegistryEvent> events = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("enabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("displayName"u8))
                {
                    displayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("manufacturer"u8))
                {
                    manufacturer = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("manufacturerUri"u8))
                {
                    manufacturerUri = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("model"u8))
                {
                    model = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("productCode"u8))
                {
                    productCode = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("hardwareRevision"u8))
                {
                    hardwareRevision = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("softwareRevision"u8))
                {
                    softwareRevision = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("documentationUri"u8))
                {
                    documentationUri = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("serialNumber"u8))
                {
                    serialNumber = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("attributes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, BinaryData> dictionary = new Dictionary<string, BinaryData>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.Value.ValueKind == JsonValueKind.Null)
                        {
                            dictionary.Add(property0.Name, null);
                        }
                        else
                        {
                            dictionary.Add(property0.Name, BinaryData.FromString(property0.Value.GetRawText()));
                        }
                    }
                    attributes = dictionary;
                    continue;
                }
                if (property.NameEquals("defaultDatasetsConfiguration"u8))
                {
                    defaultDatasetsConfiguration = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("defaultEventsConfiguration"u8))
                {
                    defaultEventsConfiguration = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("defaultTopic"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    defaultTopic = DeviceRegistryMqttTopic.DeserializeDeviceRegistryMqttTopic(property.Value, options);
                    continue;
                }
                if (property.NameEquals("datasets"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DeviceRegistryDataset> array = new List<DeviceRegistryDataset>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DeviceRegistryDataset.DeserializeDeviceRegistryDataset(item, options));
                    }
                    datasets = array;
                    continue;
                }
                if (property.NameEquals("events"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DeviceRegistryEvent> array = new List<DeviceRegistryEvent>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DeviceRegistryEvent.DeserializeDeviceRegistryEvent(item, options));
                    }
                    events = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new AssetUpdateProperties(
                enabled,
                displayName,
                description,
                manufacturer,
                manufacturerUri,
                model,
                productCode,
                hardwareRevision,
                softwareRevision,
                documentationUri,
                serialNumber,
                attributes ?? new ChangeTrackingDictionary<string, BinaryData>(),
                defaultDatasetsConfiguration,
                defaultEventsConfiguration,
                defaultTopic,
                datasets ?? new ChangeTrackingList<DeviceRegistryDataset>(),
                events ?? new ChangeTrackingList<DeviceRegistryEvent>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AssetUpdateProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AssetUpdateProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AssetUpdateProperties)} does not support writing '{options.Format}' format.");
            }
        }

        AssetUpdateProperties IPersistableModel<AssetUpdateProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AssetUpdateProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAssetUpdateProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AssetUpdateProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AssetUpdateProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
