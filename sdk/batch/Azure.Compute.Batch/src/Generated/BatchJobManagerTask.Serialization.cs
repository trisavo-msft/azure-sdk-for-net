// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Compute.Batch
{
    public partial class BatchJobManagerTask : IUtf8JsonSerializable, IJsonModel<BatchJobManagerTask>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BatchJobManagerTask>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<BatchJobManagerTask>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchJobManagerTask>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BatchJobManagerTask)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("id"u8);
            writer.WriteStringValue(Id);
            if (Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            writer.WritePropertyName("commandLine"u8);
            writer.WriteStringValue(CommandLine);
            if (Optional.IsDefined(ContainerSettings))
            {
                writer.WritePropertyName("containerSettings"u8);
                writer.WriteObjectValue(ContainerSettings, options);
            }
            if (Optional.IsCollectionDefined(ResourceFiles))
            {
                writer.WritePropertyName("resourceFiles"u8);
                writer.WriteStartArray();
                foreach (var item in ResourceFiles)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(OutputFiles))
            {
                writer.WritePropertyName("outputFiles"u8);
                writer.WriteStartArray();
                foreach (var item in OutputFiles)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(EnvironmentSettings))
            {
                writer.WritePropertyName("environmentSettings"u8);
                writer.WriteStartArray();
                foreach (var item in EnvironmentSettings)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Constraints))
            {
                writer.WritePropertyName("constraints"u8);
                writer.WriteObjectValue(Constraints, options);
            }
            if (Optional.IsDefined(RequiredSlots))
            {
                writer.WritePropertyName("requiredSlots"u8);
                writer.WriteNumberValue(RequiredSlots.Value);
            }
            if (Optional.IsDefined(KillJobOnCompletion))
            {
                writer.WritePropertyName("killJobOnCompletion"u8);
                writer.WriteBooleanValue(KillJobOnCompletion.Value);
            }
            if (Optional.IsDefined(UserIdentity))
            {
                writer.WritePropertyName("userIdentity"u8);
                writer.WriteObjectValue(UserIdentity, options);
            }
            if (Optional.IsDefined(RunExclusive))
            {
                writer.WritePropertyName("runExclusive"u8);
                writer.WriteBooleanValue(RunExclusive.Value);
            }
            if (Optional.IsCollectionDefined(ApplicationPackageReferences))
            {
                writer.WritePropertyName("applicationPackageReferences"u8);
                writer.WriteStartArray();
                foreach (var item in ApplicationPackageReferences)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(AuthenticationTokenSettings))
            {
                writer.WritePropertyName("authenticationTokenSettings"u8);
                writer.WriteObjectValue(AuthenticationTokenSettings, options);
            }
            if (Optional.IsDefined(AllowLowPriorityNode))
            {
                writer.WritePropertyName("allowLowPriorityNode"u8);
                writer.WriteBooleanValue(AllowLowPriorityNode.Value);
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

        BatchJobManagerTask IJsonModel<BatchJobManagerTask>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchJobManagerTask>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BatchJobManagerTask)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBatchJobManagerTask(document.RootElement, options);
        }

        internal static BatchJobManagerTask DeserializeBatchJobManagerTask(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string id = default;
            string displayName = default;
            string commandLine = default;
            BatchTaskContainerSettings containerSettings = default;
            IList<ResourceFile> resourceFiles = default;
            IList<OutputFile> outputFiles = default;
            IList<EnvironmentSetting> environmentSettings = default;
            BatchTaskConstraints constraints = default;
            int? requiredSlots = default;
            bool? killJobOnCompletion = default;
            UserIdentity userIdentity = default;
            bool? runExclusive = default;
            IList<BatchApplicationPackageReference> applicationPackageReferences = default;
            AuthenticationTokenSettings authenticationTokenSettings = default;
            bool? allowLowPriorityNode = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("displayName"u8))
                {
                    displayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("commandLine"u8))
                {
                    commandLine = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("containerSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    containerSettings = BatchTaskContainerSettings.DeserializeBatchTaskContainerSettings(property.Value, options);
                    continue;
                }
                if (property.NameEquals("resourceFiles"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ResourceFile> array = new List<ResourceFile>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ResourceFile.DeserializeResourceFile(item, options));
                    }
                    resourceFiles = array;
                    continue;
                }
                if (property.NameEquals("outputFiles"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<OutputFile> array = new List<OutputFile>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(OutputFile.DeserializeOutputFile(item, options));
                    }
                    outputFiles = array;
                    continue;
                }
                if (property.NameEquals("environmentSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<EnvironmentSetting> array = new List<EnvironmentSetting>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(EnvironmentSetting.DeserializeEnvironmentSetting(item, options));
                    }
                    environmentSettings = array;
                    continue;
                }
                if (property.NameEquals("constraints"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    constraints = BatchTaskConstraints.DeserializeBatchTaskConstraints(property.Value, options);
                    continue;
                }
                if (property.NameEquals("requiredSlots"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    requiredSlots = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("killJobOnCompletion"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    killJobOnCompletion = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("userIdentity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    userIdentity = UserIdentity.DeserializeUserIdentity(property.Value, options);
                    continue;
                }
                if (property.NameEquals("runExclusive"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    runExclusive = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("applicationPackageReferences"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<BatchApplicationPackageReference> array = new List<BatchApplicationPackageReference>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(BatchApplicationPackageReference.DeserializeBatchApplicationPackageReference(item, options));
                    }
                    applicationPackageReferences = array;
                    continue;
                }
                if (property.NameEquals("authenticationTokenSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    authenticationTokenSettings = AuthenticationTokenSettings.DeserializeAuthenticationTokenSettings(property.Value, options);
                    continue;
                }
                if (property.NameEquals("allowLowPriorityNode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    allowLowPriorityNode = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new BatchJobManagerTask(
                id,
                displayName,
                commandLine,
                containerSettings,
                resourceFiles ?? new ChangeTrackingList<ResourceFile>(),
                outputFiles ?? new ChangeTrackingList<OutputFile>(),
                environmentSettings ?? new ChangeTrackingList<EnvironmentSetting>(),
                constraints,
                requiredSlots,
                killJobOnCompletion,
                userIdentity,
                runExclusive,
                applicationPackageReferences ?? new ChangeTrackingList<BatchApplicationPackageReference>(),
                authenticationTokenSettings,
                allowLowPriorityNode,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<BatchJobManagerTask>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchJobManagerTask>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(BatchJobManagerTask)} does not support writing '{options.Format}' format.");
            }
        }

        BatchJobManagerTask IPersistableModel<BatchJobManagerTask>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchJobManagerTask>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeBatchJobManagerTask(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(BatchJobManagerTask)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<BatchJobManagerTask>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static BatchJobManagerTask FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeBatchJobManagerTask(document.RootElement);
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
