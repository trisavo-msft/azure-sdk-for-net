// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    public partial class AutomationActionWorkspace : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(WorkspaceResourceId))
            {
                writer.WritePropertyName("workspaceResourceId");
                writer.WriteStringValue(WorkspaceResourceId);
            }
            writer.WritePropertyName("actionType");
            writer.WriteStringValue(ActionType.ToString());
            writer.WriteEndObject();
        }

        internal static AutomationActionWorkspace DeserializeAutomationActionWorkspace(JsonElement element)
        {
            Optional<string> workspaceResourceId = default;
            ActionType actionType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("workspaceResourceId"))
                {
                    workspaceResourceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("actionType"))
                {
                    actionType = new ActionType(property.Value.GetString());
                    continue;
                }
            }
            return new AutomationActionWorkspace(actionType, workspaceResourceId.Value);
        }
    }
}
