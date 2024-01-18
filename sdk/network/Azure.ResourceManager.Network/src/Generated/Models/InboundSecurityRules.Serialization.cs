// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class InboundSecurityRules : IUtf8JsonSerializable, IJsonModel<InboundSecurityRules>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<InboundSecurityRules>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<InboundSecurityRules>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InboundSecurityRules>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InboundSecurityRules)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Protocol))
            {
                writer.WritePropertyName("protocol"u8);
                writer.WriteStringValue(Protocol.Value.ToString());
            }
            if (Optional.IsDefined(SourceAddressPrefix))
            {
                writer.WritePropertyName("sourceAddressPrefix"u8);
                writer.WriteStringValue(SourceAddressPrefix);
            }
            if (Optional.IsDefined(DestinationPortRange))
            {
                writer.WritePropertyName("destinationPortRange"u8);
                writer.WriteNumberValue(DestinationPortRange.Value);
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

        InboundSecurityRules IJsonModel<InboundSecurityRules>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InboundSecurityRules>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InboundSecurityRules)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInboundSecurityRules(document.RootElement, options);
        }

        internal static InboundSecurityRules DeserializeInboundSecurityRules(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<InboundSecurityRulesProtocol> protocol = default;
            Optional<string> sourceAddressPrefix = default;
            Optional<int> destinationPortRange = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("protocol"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    protocol = new InboundSecurityRulesProtocol(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sourceAddressPrefix"u8))
                {
                    sourceAddressPrefix = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("destinationPortRange"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    destinationPortRange = property.Value.GetInt32();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new InboundSecurityRules(Optional.ToNullable(protocol), sourceAddressPrefix.Value, Optional.ToNullable(destinationPortRange), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<InboundSecurityRules>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InboundSecurityRules>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(InboundSecurityRules)} does not support '{options.Format}' format.");
            }
        }

        InboundSecurityRules IPersistableModel<InboundSecurityRules>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InboundSecurityRules>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeInboundSecurityRules(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InboundSecurityRules)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<InboundSecurityRules>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
