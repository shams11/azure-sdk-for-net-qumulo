// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Automation.Models
{
    public partial class AutomationSourceControlPatch : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(Branch))
            {
                writer.WritePropertyName("branch");
                writer.WriteStringValue(Branch);
            }
            if (Optional.IsDefined(FolderPath))
            {
                writer.WritePropertyName("folderPath");
                writer.WriteStringValue(FolderPath);
            }
            if (Optional.IsDefined(IsAutoSyncEnabled))
            {
                writer.WritePropertyName("autoSync");
                writer.WriteBooleanValue(IsAutoSyncEnabled.Value);
            }
            if (Optional.IsDefined(IsAutoPublishRunbookEnabled))
            {
                writer.WritePropertyName("publishRunbook");
                writer.WriteBooleanValue(IsAutoPublishRunbookEnabled.Value);
            }
            if (Optional.IsDefined(SecurityToken))
            {
                writer.WritePropertyName("securityToken");
                writer.WriteObjectValue(SecurityToken);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description");
                writer.WriteStringValue(Description);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }
    }
}
