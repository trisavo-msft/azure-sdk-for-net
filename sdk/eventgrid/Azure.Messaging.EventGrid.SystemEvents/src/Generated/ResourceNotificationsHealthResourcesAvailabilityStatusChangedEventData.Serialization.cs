// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    public partial class ResourceNotificationsHealthResourcesAvailabilityStatusChangedEventData : IUtf8JsonSerializable, IJsonModel<ResourceNotificationsHealthResourcesAvailabilityStatusChangedEventData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ResourceNotificationsHealthResourcesAvailabilityStatusChangedEventData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ResourceNotificationsHealthResourcesAvailabilityStatusChangedEventData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceNotificationsHealthResourcesAvailabilityStatusChangedEventData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ResourceNotificationsHealthResourcesAvailabilityStatusChangedEventData)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
        }

        ResourceNotificationsHealthResourcesAvailabilityStatusChangedEventData IJsonModel<ResourceNotificationsHealthResourcesAvailabilityStatusChangedEventData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceNotificationsHealthResourcesAvailabilityStatusChangedEventData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ResourceNotificationsHealthResourcesAvailabilityStatusChangedEventData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeResourceNotificationsHealthResourcesAvailabilityStatusChangedEventData(document.RootElement, options);
        }

        internal static ResourceNotificationsHealthResourcesAvailabilityStatusChangedEventData DeserializeResourceNotificationsHealthResourcesAvailabilityStatusChangedEventData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceNotificationsResourceUpdatedDetails resourceInfo = default;
            ResourceNotificationsOperationalDetails operationalInfo = default;
            string apiVersion = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("resourceInfo"u8))
                {
                    resourceInfo = ResourceNotificationsResourceUpdatedDetails.DeserializeResourceNotificationsResourceUpdatedDetails(property.Value, options);
                    continue;
                }
                if (property.NameEquals("operationalInfo"u8))
                {
                    operationalInfo = ResourceNotificationsOperationalDetails.DeserializeResourceNotificationsOperationalDetails(property.Value, options);
                    continue;
                }
                if (property.NameEquals("apiVersion"u8))
                {
                    apiVersion = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ResourceNotificationsHealthResourcesAvailabilityStatusChangedEventData(resourceInfo, operationalInfo, apiVersion, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ResourceNotificationsHealthResourcesAvailabilityStatusChangedEventData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceNotificationsHealthResourcesAvailabilityStatusChangedEventData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ResourceNotificationsHealthResourcesAvailabilityStatusChangedEventData)} does not support writing '{options.Format}' format.");
            }
        }

        ResourceNotificationsHealthResourcesAvailabilityStatusChangedEventData IPersistableModel<ResourceNotificationsHealthResourcesAvailabilityStatusChangedEventData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceNotificationsHealthResourcesAvailabilityStatusChangedEventData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeResourceNotificationsHealthResourcesAvailabilityStatusChangedEventData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ResourceNotificationsHealthResourcesAvailabilityStatusChangedEventData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ResourceNotificationsHealthResourcesAvailabilityStatusChangedEventData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static new ResourceNotificationsHealthResourcesAvailabilityStatusChangedEventData FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeResourceNotificationsHealthResourcesAvailabilityStatusChangedEventData(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal override RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this, ModelSerializationExtensions.WireOptions);
            return content;
        }
    }
}
