// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Synapse.Models
{
    public partial class SynapseIntegrationRuntimePatch : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(AutoUpdate))
            {
                writer.WritePropertyName("autoUpdate");
                writer.WriteStringValue(AutoUpdate.Value.ToString());
            }
            if (Optional.IsDefined(UpdateDelayOffset))
            {
                writer.WritePropertyName("updateDelayOffset");
                writer.WriteStringValue(UpdateDelayOffset);
            }
            writer.WriteEndObject();
        }
    }
}
