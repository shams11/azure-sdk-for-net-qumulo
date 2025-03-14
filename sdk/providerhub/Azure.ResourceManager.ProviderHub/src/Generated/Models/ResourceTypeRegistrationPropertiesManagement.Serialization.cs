// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ProviderHub.Models
{
    public partial class ResourceTypeRegistrationPropertiesManagement : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(SchemaOwners))
            {
                writer.WritePropertyName("schemaOwners");
                writer.WriteStartArray();
                foreach (var item in SchemaOwners)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ManifestOwners))
            {
                writer.WritePropertyName("manifestOwners");
                writer.WriteStartArray();
                foreach (var item in ManifestOwners)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(IncidentRoutingService))
            {
                writer.WritePropertyName("incidentRoutingService");
                writer.WriteStringValue(IncidentRoutingService);
            }
            if (Optional.IsDefined(IncidentRoutingTeam))
            {
                writer.WritePropertyName("incidentRoutingTeam");
                writer.WriteStringValue(IncidentRoutingTeam);
            }
            if (Optional.IsDefined(IncidentContactEmail))
            {
                writer.WritePropertyName("incidentContactEmail");
                writer.WriteStringValue(IncidentContactEmail);
            }
            if (Optional.IsCollectionDefined(ServiceTreeInfos))
            {
                writer.WritePropertyName("serviceTreeInfos");
                writer.WriteStartArray();
                foreach (var item in ServiceTreeInfos)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(ResourceAccessPolicy))
            {
                writer.WritePropertyName("resourceAccessPolicy");
                writer.WriteStringValue(ResourceAccessPolicy.Value.ToString());
            }
            if (Optional.IsCollectionDefined(ResourceAccessRoles))
            {
                writer.WritePropertyName("resourceAccessRoles");
                writer.WriteStartArray();
                foreach (var item in ResourceAccessRoles)
                {
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item);
#else
                    JsonSerializer.Serialize(writer, JsonDocument.Parse(item.ToString()).RootElement);
#endif
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static ResourceTypeRegistrationPropertiesManagement DeserializeResourceTypeRegistrationPropertiesManagement(JsonElement element)
        {
            Optional<IList<string>> schemaOwners = default;
            Optional<IList<string>> manifestOwners = default;
            Optional<string> incidentRoutingService = default;
            Optional<string> incidentRoutingTeam = default;
            Optional<string> incidentContactEmail = default;
            Optional<IList<ServiceTreeInfo>> serviceTreeInfos = default;
            Optional<ResourceProviderManagementResourceAccessPolicy> resourceAccessPolicy = default;
            Optional<IList<BinaryData>> resourceAccessRoles = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("schemaOwners"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    schemaOwners = array;
                    continue;
                }
                if (property.NameEquals("manifestOwners"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    manifestOwners = array;
                    continue;
                }
                if (property.NameEquals("incidentRoutingService"))
                {
                    incidentRoutingService = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("incidentRoutingTeam"))
                {
                    incidentRoutingTeam = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("incidentContactEmail"))
                {
                    incidentContactEmail = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("serviceTreeInfos"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ServiceTreeInfo> array = new List<ServiceTreeInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ServiceTreeInfo.DeserializeServiceTreeInfo(item));
                    }
                    serviceTreeInfos = array;
                    continue;
                }
                if (property.NameEquals("resourceAccessPolicy"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    resourceAccessPolicy = new ResourceProviderManagementResourceAccessPolicy(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("resourceAccessRoles"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<BinaryData> array = new List<BinaryData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(BinaryData.FromString(item.GetRawText()));
                    }
                    resourceAccessRoles = array;
                    continue;
                }
            }
            return new ResourceTypeRegistrationPropertiesManagement(Optional.ToList(schemaOwners), Optional.ToList(manifestOwners), incidentRoutingService.Value, incidentRoutingTeam.Value, incidentContactEmail.Value, Optional.ToList(serviceTreeInfos), Optional.ToNullable(resourceAccessPolicy), Optional.ToList(resourceAccessRoles));
        }
    }
}
