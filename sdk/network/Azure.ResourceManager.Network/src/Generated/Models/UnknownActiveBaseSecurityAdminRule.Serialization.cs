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
    internal partial class UnknownActiveBaseSecurityAdminRule : IUtf8JsonSerializable, IJsonModel<ActiveBaseSecurityAdminRule>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ActiveBaseSecurityAdminRule>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ActiveBaseSecurityAdminRule>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ActiveBaseSecurityAdminRule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ActiveBaseSecurityAdminRule)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (Optional.IsDefined(CommitOn))
            {
                writer.WritePropertyName("commitTime"u8);
                writer.WriteStringValue(CommitOn.Value, "O");
            }
            if (Optional.IsDefined(Region))
            {
                writer.WritePropertyName("region"u8);
                writer.WriteStringValue(Region);
            }
            if (Optional.IsDefined(ConfigurationDescription))
            {
                writer.WritePropertyName("configurationDescription"u8);
                writer.WriteStringValue(ConfigurationDescription);
            }
            if (Optional.IsDefined(RuleCollectionDescription))
            {
                writer.WritePropertyName("ruleCollectionDescription"u8);
                writer.WriteStringValue(RuleCollectionDescription);
            }
            if (Optional.IsCollectionDefined(RuleCollectionAppliesToGroups))
            {
                writer.WritePropertyName("ruleCollectionAppliesToGroups"u8);
                writer.WriteStartArray();
                foreach (var item in RuleCollectionAppliesToGroups)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(RuleGroups))
            {
                writer.WritePropertyName("ruleGroups"u8);
                writer.WriteStartArray();
                foreach (var item in RuleGroups)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind.ToString());
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

        ActiveBaseSecurityAdminRule IJsonModel<ActiveBaseSecurityAdminRule>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ActiveBaseSecurityAdminRule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ActiveBaseSecurityAdminRule)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeUnknownActiveBaseSecurityAdminRule(document.RootElement, options);
        }

        internal static UnknownActiveBaseSecurityAdminRule DeserializeUnknownActiveBaseSecurityAdminRule(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> id = default;
            Optional<DateTimeOffset> commitTime = default;
            Optional<string> region = default;
            Optional<string> configurationDescription = default;
            Optional<string> ruleCollectionDescription = default;
            Optional<IReadOnlyList<NetworkManagerSecurityGroupItem>> ruleCollectionAppliesToGroups = default;
            Optional<IReadOnlyList<NetworkConfigurationGroup>> ruleGroups = default;
            EffectiveAdminRuleKind kind = "Unknown";
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("commitTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    commitTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("region"u8))
                {
                    region = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("configurationDescription"u8))
                {
                    configurationDescription = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ruleCollectionDescription"u8))
                {
                    ruleCollectionDescription = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ruleCollectionAppliesToGroups"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<NetworkManagerSecurityGroupItem> array = new List<NetworkManagerSecurityGroupItem>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(NetworkManagerSecurityGroupItem.DeserializeNetworkManagerSecurityGroupItem(item));
                    }
                    ruleCollectionAppliesToGroups = array;
                    continue;
                }
                if (property.NameEquals("ruleGroups"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<NetworkConfigurationGroup> array = new List<NetworkConfigurationGroup>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(NetworkConfigurationGroup.DeserializeNetworkConfigurationGroup(item));
                    }
                    ruleGroups = array;
                    continue;
                }
                if (property.NameEquals("kind"u8))
                {
                    kind = new EffectiveAdminRuleKind(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new UnknownActiveBaseSecurityAdminRule(id.Value, Optional.ToNullable(commitTime), region.Value, configurationDescription.Value, ruleCollectionDescription.Value, Optional.ToList(ruleCollectionAppliesToGroups), Optional.ToList(ruleGroups), kind, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ActiveBaseSecurityAdminRule>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ActiveBaseSecurityAdminRule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ActiveBaseSecurityAdminRule)} does not support '{options.Format}' format.");
            }
        }

        ActiveBaseSecurityAdminRule IPersistableModel<ActiveBaseSecurityAdminRule>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ActiveBaseSecurityAdminRule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeUnknownActiveBaseSecurityAdminRule(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ActiveBaseSecurityAdminRule)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ActiveBaseSecurityAdminRule>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
