// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Authorization.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Authorization
{
    public partial class AuthorizationProviderOperationsMetadataData
    {
        internal static AuthorizationProviderOperationsMetadataData DeserializeAuthorizationProviderOperationsMetadataData(JsonElement element)
        {
            Optional<string> displayName = default;
            Optional<IReadOnlyList<AuthorizationProviderResourceType>> resourceTypes = default;
            Optional<IReadOnlyList<AuthorizationProviderOperationInfo>> operations = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("displayName"))
                {
                    displayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceTypes"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<AuthorizationProviderResourceType> array = new List<AuthorizationProviderResourceType>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AuthorizationProviderResourceType.DeserializeAuthorizationProviderResourceType(item));
                    }
                    resourceTypes = array;
                    continue;
                }
                if (property.NameEquals("operations"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<AuthorizationProviderOperationInfo> array = new List<AuthorizationProviderOperationInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AuthorizationProviderOperationInfo.DeserializeAuthorizationProviderOperationInfo(item));
                    }
                    operations = array;
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
            }
            return new AuthorizationProviderOperationsMetadataData(id, name, type, systemData.Value, displayName.Value, Optional.ToList(resourceTypes), Optional.ToList(operations));
        }
    }
}
