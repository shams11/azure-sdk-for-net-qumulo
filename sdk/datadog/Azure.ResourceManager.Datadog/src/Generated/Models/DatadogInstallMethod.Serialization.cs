// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Datadog.Models
{
    public partial class DatadogInstallMethod
    {
        internal static DatadogInstallMethod DeserializeDatadogInstallMethod(JsonElement element)
        {
            Optional<string> tool = default;
            Optional<string> toolVersion = default;
            Optional<string> installerVersion = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tool"))
                {
                    tool = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("toolVersion"))
                {
                    toolVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("installerVersion"))
                {
                    installerVersion = property.Value.GetString();
                    continue;
                }
            }
            return new DatadogInstallMethod(tool.Value, toolVersion.Value, installerVersion.Value);
        }
    }
}
