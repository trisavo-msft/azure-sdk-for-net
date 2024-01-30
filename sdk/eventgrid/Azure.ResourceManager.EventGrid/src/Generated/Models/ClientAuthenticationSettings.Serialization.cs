// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.EventGrid.Models
{
    internal partial class ClientAuthenticationSettings : IUtf8JsonSerializable, IJsonModel<ClientAuthenticationSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ClientAuthenticationSettings>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ClientAuthenticationSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClientAuthenticationSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ClientAuthenticationSettings)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(AlternativeAuthenticationNameSources))
            {
                writer.WritePropertyName("alternativeAuthenticationNameSources"u8);
                writer.WriteStartArray();
                foreach (var item in AlternativeAuthenticationNameSources)
                {
                    writer.WriteStringValue(item.ToString());
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
            writer.WriteEndObject();
        }

        ClientAuthenticationSettings IJsonModel<ClientAuthenticationSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClientAuthenticationSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ClientAuthenticationSettings)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeClientAuthenticationSettings(document.RootElement, options);
        }

        internal static ClientAuthenticationSettings DeserializeClientAuthenticationSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<AlternativeAuthenticationNameSource>> alternativeAuthenticationNameSources = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("alternativeAuthenticationNameSources"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AlternativeAuthenticationNameSource> array = new List<AlternativeAuthenticationNameSource>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new AlternativeAuthenticationNameSource(item.GetString()));
                    }
                    alternativeAuthenticationNameSources = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ClientAuthenticationSettings(Optional.ToList(alternativeAuthenticationNameSources), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ClientAuthenticationSettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClientAuthenticationSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ClientAuthenticationSettings)} does not support '{options.Format}' format.");
            }
        }

        ClientAuthenticationSettings IPersistableModel<ClientAuthenticationSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClientAuthenticationSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeClientAuthenticationSettings(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ClientAuthenticationSettings)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ClientAuthenticationSettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
