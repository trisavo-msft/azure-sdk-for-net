// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Developer.DevCenter.Models
{
    public partial class DevBoxAction : IUtf8JsonSerializable, IJsonModel<DevBoxAction>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DevBoxAction>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DevBoxAction>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevBoxAction>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DevBoxAction)} does not support writing '{format}' format.");
            }

            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            writer.WritePropertyName("actionType"u8);
            writer.WriteStringValue(ActionType.ToString());
            writer.WritePropertyName("sourceId"u8);
            writer.WriteStringValue(SourceId);
            if (Optional.IsDefined(SuspendedUntil))
            {
                writer.WritePropertyName("suspendedUntil"u8);
                writer.WriteStringValue(SuspendedUntil.Value, "O");
            }
            if (Optional.IsDefined(NextAction))
            {
                writer.WritePropertyName("next"u8);
                writer.WriteObjectValue(NextAction, options);
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

        DevBoxAction IJsonModel<DevBoxAction>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevBoxAction>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DevBoxAction)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDevBoxAction(document.RootElement, options);
        }

        internal static DevBoxAction DeserializeDevBoxAction(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            DevBoxActionType actionType = default;
            string sourceId = default;
            DateTimeOffset? suspendedUntil = default;
            DevBoxNextAction next = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("actionType"u8))
                {
                    actionType = new DevBoxActionType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sourceId"u8))
                {
                    sourceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("suspendedUntil"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    suspendedUntil = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("next"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    next = DevBoxNextAction.DeserializeDevBoxNextAction(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new DevBoxAction(
                name,
                actionType,
                sourceId,
                suspendedUntil,
                next,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DevBoxAction>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevBoxAction>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DevBoxAction)} does not support writing '{options.Format}' format.");
            }
        }

        DevBoxAction IPersistableModel<DevBoxAction>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevBoxAction>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDevBoxAction(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DevBoxAction)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DevBoxAction>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static DevBoxAction FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeDevBoxAction(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this, ModelSerializationExtensions.WireOptions);
            return content;
        }
    }
}
