// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.Projects
{
    public partial class VectorStoreFile : IUtf8JsonSerializable, IJsonModel<VectorStoreFile>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VectorStoreFile>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<VectorStoreFile>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VectorStoreFile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VectorStoreFile)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("id"u8);
            writer.WriteStringValue(Id);
            writer.WritePropertyName("object"u8);
            writer.WriteStringValue(Object.ToString());
            writer.WritePropertyName("usage_bytes"u8);
            writer.WriteNumberValue(UsageBytes);
            writer.WritePropertyName("created_at"u8);
            writer.WriteNumberValue(CreatedAt, "U");
            writer.WritePropertyName("vector_store_id"u8);
            writer.WriteStringValue(VectorStoreId);
            writer.WritePropertyName("status"u8);
            writer.WriteStringValue(Status.ToString());
            if (LastError != null)
            {
                writer.WritePropertyName("last_error"u8);
                writer.WriteObjectValue(LastError, options);
            }
            else
            {
                writer.WriteNull("last_error");
            }
            writer.WritePropertyName("chunking_strategy"u8);
            writer.WriteObjectValue(ChunkingStrategy, options);
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

        VectorStoreFile IJsonModel<VectorStoreFile>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VectorStoreFile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VectorStoreFile)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVectorStoreFile(document.RootElement, options);
        }

        internal static VectorStoreFile DeserializeVectorStoreFile(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string id = default;
            VectorStoreFileObject @object = default;
            int usageBytes = default;
            DateTimeOffset createdAt = default;
            string vectorStoreId = default;
            VectorStoreFileStatus status = default;
            VectorStoreFileError lastError = default;
            VectorStoreChunkingStrategyResponse chunkingStrategy = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("object"u8))
                {
                    @object = new VectorStoreFileObject(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("usage_bytes"u8))
                {
                    usageBytes = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("created_at"u8))
                {
                    createdAt = DateTimeOffset.FromUnixTimeSeconds(property.Value.GetInt64());
                    continue;
                }
                if (property.NameEquals("vector_store_id"u8))
                {
                    vectorStoreId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    status = new VectorStoreFileStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("last_error"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        lastError = null;
                        continue;
                    }
                    lastError = VectorStoreFileError.DeserializeVectorStoreFileError(property.Value, options);
                    continue;
                }
                if (property.NameEquals("chunking_strategy"u8))
                {
                    chunkingStrategy = VectorStoreChunkingStrategyResponse.DeserializeVectorStoreChunkingStrategyResponse(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new VectorStoreFile(
                id,
                @object,
                usageBytes,
                createdAt,
                vectorStoreId,
                status,
                lastError,
                chunkingStrategy,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<VectorStoreFile>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VectorStoreFile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(VectorStoreFile)} does not support writing '{options.Format}' format.");
            }
        }

        VectorStoreFile IPersistableModel<VectorStoreFile>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VectorStoreFile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeVectorStoreFile(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(VectorStoreFile)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<VectorStoreFile>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static VectorStoreFile FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeVectorStoreFile(document.RootElement);
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
