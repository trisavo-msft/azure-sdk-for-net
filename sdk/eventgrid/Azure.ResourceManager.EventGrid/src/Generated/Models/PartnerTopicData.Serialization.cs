// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.EventGrid.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.EventGrid
{
    public partial class PartnerTopicData : IUtf8JsonSerializable, IJsonModel<PartnerTopicData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PartnerTopicData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<PartnerTopicData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PartnerTopicData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PartnerTopicData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identity"u8);
                JsonSerializer.Serialize(writer, Identity);
            }
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("location"u8);
            writer.WriteStringValue(Location);
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && Optional.IsDefined(SystemData))
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(PartnerRegistrationImmutableId))
            {
                writer.WritePropertyName("partnerRegistrationImmutableId"u8);
                writer.WriteStringValue(PartnerRegistrationImmutableId.Value);
            }
            if (Optional.IsDefined(Source))
            {
                writer.WritePropertyName("source"u8);
                writer.WriteStringValue(Source);
            }
            if (Optional.IsDefined(EventTypeInfo))
            {
                writer.WritePropertyName("eventTypeInfo"u8);
                writer.WriteObjectValue(EventTypeInfo);
            }
            if (Optional.IsDefined(ExpireOnIfNotActivated))
            {
                writer.WritePropertyName("expirationTimeIfNotActivatedUtc"u8);
                writer.WriteStringValue(ExpireOnIfNotActivated.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (Optional.IsDefined(ActivationState))
            {
                writer.WritePropertyName("activationState"u8);
                writer.WriteStringValue(ActivationState.Value.ToString());
            }
            if (Optional.IsDefined(PartnerTopicFriendlyDescription))
            {
                writer.WritePropertyName("partnerTopicFriendlyDescription"u8);
                writer.WriteStringValue(PartnerTopicFriendlyDescription);
            }
            if (Optional.IsDefined(MessageForActivation))
            {
                writer.WritePropertyName("messageForActivation"u8);
                writer.WriteStringValue(MessageForActivation);
            }
            writer.WriteEndObject();
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

        PartnerTopicData IJsonModel<PartnerTopicData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PartnerTopicData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PartnerTopicData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePartnerTopicData(document.RootElement, options);
        }

        internal static PartnerTopicData DeserializePartnerTopicData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ManagedServiceIdentity> identity = default;
            Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<Guid> partnerRegistrationImmutableId = default;
            Optional<string> source = default;
            Optional<PartnerTopicEventTypeInfo> eventTypeInfo = default;
            Optional<DateTimeOffset> expirationTimeIfNotActivatedUtc = default;
            Optional<PartnerTopicProvisioningState> provisioningState = default;
            Optional<PartnerTopicActivationState> activationState = default;
            Optional<string> partnerTopicFriendlyDescription = default;
            Optional<string> messageForActivation = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("identity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    identity = JsonSerializer.Deserialize<ManagedServiceIdentity>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
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
                        if (property0.NameEquals("partnerRegistrationImmutableId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            partnerRegistrationImmutableId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("source"u8))
                        {
                            source = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("eventTypeInfo"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            eventTypeInfo = PartnerTopicEventTypeInfo.DeserializePartnerTopicEventTypeInfo(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("expirationTimeIfNotActivatedUtc"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            expirationTimeIfNotActivatedUtc = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new PartnerTopicProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("activationState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            activationState = new PartnerTopicActivationState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("partnerTopicFriendlyDescription"u8))
                        {
                            partnerTopicFriendlyDescription = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("messageForActivation"u8))
                        {
                            messageForActivation = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new PartnerTopicData(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, identity, Optional.ToNullable(partnerRegistrationImmutableId), source.Value, eventTypeInfo.Value, Optional.ToNullable(expirationTimeIfNotActivatedUtc), Optional.ToNullable(provisioningState), Optional.ToNullable(activationState), partnerTopicFriendlyDescription.Value, messageForActivation.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PartnerTopicData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PartnerTopicData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(PartnerTopicData)} does not support '{options.Format}' format.");
            }
        }

        PartnerTopicData IPersistableModel<PartnerTopicData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PartnerTopicData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePartnerTopicData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PartnerTopicData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<PartnerTopicData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
