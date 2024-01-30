// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    public partial class KubernetesClusterRestoreCriteria : IUtf8JsonSerializable, IJsonModel<KubernetesClusterRestoreCriteria>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<KubernetesClusterRestoreCriteria>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<KubernetesClusterRestoreCriteria>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KubernetesClusterRestoreCriteria>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(KubernetesClusterRestoreCriteria)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("includeClusterScopeResources"u8);
            writer.WriteBooleanValue(IsClusterScopeResourcesIncluded);
            if (Optional.IsCollectionDefined(IncludedNamespaces))
            {
                writer.WritePropertyName("includedNamespaces"u8);
                writer.WriteStartArray();
                foreach (var item in IncludedNamespaces)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ExcludedNamespaces))
            {
                writer.WritePropertyName("excludedNamespaces"u8);
                writer.WriteStartArray();
                foreach (var item in ExcludedNamespaces)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(IncludedResourceTypes))
            {
                writer.WritePropertyName("includedResourceTypes"u8);
                writer.WriteStartArray();
                foreach (var item in IncludedResourceTypes)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ExcludedResourceTypes))
            {
                writer.WritePropertyName("excludedResourceTypes"u8);
                writer.WriteStartArray();
                foreach (var item in ExcludedResourceTypes)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(LabelSelectors))
            {
                writer.WritePropertyName("labelSelectors"u8);
                writer.WriteStartArray();
                foreach (var item in LabelSelectors)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(PersistentVolumeRestoreMode))
            {
                writer.WritePropertyName("persistentVolumeRestoreMode"u8);
                writer.WriteStringValue(PersistentVolumeRestoreMode.Value.ToString());
            }
            if (Optional.IsDefined(ConflictPolicy))
            {
                writer.WritePropertyName("conflictPolicy"u8);
                writer.WriteStringValue(ConflictPolicy.Value.ToString());
            }
            if (Optional.IsCollectionDefined(NamespaceMappings))
            {
                writer.WritePropertyName("namespaceMappings"u8);
                writer.WriteStartObject();
                foreach (var item in NamespaceMappings)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(RestoreHookReferences))
            {
                writer.WritePropertyName("restoreHookReferences"u8);
                writer.WriteStartArray();
                foreach (var item in RestoreHookReferences)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("objectType"u8);
            writer.WriteStringValue(ObjectType);
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

        KubernetesClusterRestoreCriteria IJsonModel<KubernetesClusterRestoreCriteria>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KubernetesClusterRestoreCriteria>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(KubernetesClusterRestoreCriteria)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeKubernetesClusterRestoreCriteria(document.RootElement, options);
        }

        internal static KubernetesClusterRestoreCriteria DeserializeKubernetesClusterRestoreCriteria(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool includeClusterScopeResources = default;
            Optional<IList<string>> includedNamespaces = default;
            Optional<IList<string>> excludedNamespaces = default;
            Optional<IList<string>> includedResourceTypes = default;
            Optional<IList<string>> excludedResourceTypes = default;
            Optional<IList<string>> labelSelectors = default;
            Optional<PersistentVolumeRestoreMode> persistentVolumeRestoreMode = default;
            Optional<KubernetesClusterRestoreExistingResourcePolicy> conflictPolicy = default;
            Optional<IDictionary<string, string>> namespaceMappings = default;
            Optional<IList<NamespacedName>> restoreHookReferences = default;
            string objectType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("includeClusterScopeResources"u8))
                {
                    includeClusterScopeResources = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("includedNamespaces"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    includedNamespaces = array;
                    continue;
                }
                if (property.NameEquals("excludedNamespaces"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    excludedNamespaces = array;
                    continue;
                }
                if (property.NameEquals("includedResourceTypes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    includedResourceTypes = array;
                    continue;
                }
                if (property.NameEquals("excludedResourceTypes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    excludedResourceTypes = array;
                    continue;
                }
                if (property.NameEquals("labelSelectors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    labelSelectors = array;
                    continue;
                }
                if (property.NameEquals("persistentVolumeRestoreMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    persistentVolumeRestoreMode = new PersistentVolumeRestoreMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("conflictPolicy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    conflictPolicy = new KubernetesClusterRestoreExistingResourcePolicy(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("namespaceMappings"u8))
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
                    namespaceMappings = dictionary;
                    continue;
                }
                if (property.NameEquals("restoreHookReferences"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<NamespacedName> array = new List<NamespacedName>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(NamespacedName.DeserializeNamespacedName(item));
                    }
                    restoreHookReferences = array;
                    continue;
                }
                if (property.NameEquals("objectType"u8))
                {
                    objectType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new KubernetesClusterRestoreCriteria(objectType, serializedAdditionalRawData, includeClusterScopeResources, Optional.ToList(includedNamespaces), Optional.ToList(excludedNamespaces), Optional.ToList(includedResourceTypes), Optional.ToList(excludedResourceTypes), Optional.ToList(labelSelectors), Optional.ToNullable(persistentVolumeRestoreMode), Optional.ToNullable(conflictPolicy), Optional.ToDictionary(namespaceMappings), Optional.ToList(restoreHookReferences));
        }

        BinaryData IPersistableModel<KubernetesClusterRestoreCriteria>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KubernetesClusterRestoreCriteria>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(KubernetesClusterRestoreCriteria)} does not support '{options.Format}' format.");
            }
        }

        KubernetesClusterRestoreCriteria IPersistableModel<KubernetesClusterRestoreCriteria>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KubernetesClusterRestoreCriteria>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeKubernetesClusterRestoreCriteria(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(KubernetesClusterRestoreCriteria)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<KubernetesClusterRestoreCriteria>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
