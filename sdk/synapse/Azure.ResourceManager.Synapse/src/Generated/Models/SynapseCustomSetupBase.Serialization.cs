// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Synapse.Models
{
    public partial class SynapseCustomSetupBase : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("type");
            writer.WriteStringValue(CustomSetupBaseType);
            writer.WriteEndObject();
        }

        internal static SynapseCustomSetupBase DeserializeSynapseCustomSetupBase(JsonElement element)
        {
            if (element.TryGetProperty("type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "CmdkeySetup": return SynapseCmdkeySetup.DeserializeSynapseCmdkeySetup(element);
                    case "ComponentSetup": return SynapseComponentSetup.DeserializeSynapseComponentSetup(element);
                    case "EnvironmentVariableSetup": return SynapseEnvironmentVariableSetup.DeserializeSynapseEnvironmentVariableSetup(element);
                }
            }
            return UnknownCustomSetupBase.DeserializeUnknownCustomSetupBase(element);
        }
    }
}
