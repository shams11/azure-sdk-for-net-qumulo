// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DigitalTwins.Models
{
    public partial class DataExplorerConnectionProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("adxResourceId");
            writer.WriteStringValue(AdxResourceId);
            writer.WritePropertyName("adxEndpointUri");
            writer.WriteStringValue(AdxEndpointUri.AbsoluteUri);
            writer.WritePropertyName("adxDatabaseName");
            writer.WriteStringValue(AdxDatabaseName);
            if (Optional.IsDefined(AdxTableName))
            {
                if (AdxTableName != null)
                {
                    writer.WritePropertyName("adxTableName");
                    writer.WriteStringValue(AdxTableName);
                }
                else
                {
                    writer.WriteNull("adxTableName");
                }
            }
            writer.WritePropertyName("eventHubEndpointUri");
            writer.WriteStringValue(EventHubEndpointUri.AbsoluteUri);
            writer.WritePropertyName("eventHubEntityPath");
            writer.WriteStringValue(EventHubEntityPath);
            writer.WritePropertyName("eventHubNamespaceResourceId");
            writer.WriteStringValue(EventHubNamespaceResourceId);
            if (Optional.IsDefined(EventHubConsumerGroup))
            {
                if (EventHubConsumerGroup != null)
                {
                    writer.WritePropertyName("eventHubConsumerGroup");
                    writer.WriteStringValue(EventHubConsumerGroup);
                }
                else
                {
                    writer.WriteNull("eventHubConsumerGroup");
                }
            }
            writer.WritePropertyName("connectionType");
            writer.WriteStringValue(ConnectionType.ToString());
            if (Optional.IsDefined(Identity))
            {
                if (Identity != null)
                {
                    writer.WritePropertyName("identity");
                    writer.WriteObjectValue(Identity);
                }
                else
                {
                    writer.WriteNull("identity");
                }
            }
            writer.WriteEndObject();
        }

        internal static DataExplorerConnectionProperties DeserializeDataExplorerConnectionProperties(JsonElement element)
        {
            ResourceIdentifier adxResourceId = default;
            Uri adxEndpointUri = default;
            string adxDatabaseName = default;
            Optional<string> adxTableName = default;
            Uri eventHubEndpointUri = default;
            string eventHubEntityPath = default;
            ResourceIdentifier eventHubNamespaceResourceId = default;
            Optional<string> eventHubConsumerGroup = default;
            ConnectionType connectionType = default;
            Optional<TimeSeriesDatabaseConnectionState> provisioningState = default;
            Optional<DigitalTwinsManagedIdentityReference> identity = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("adxResourceId"))
                {
                    adxResourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("adxEndpointUri"))
                {
                    adxEndpointUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("adxDatabaseName"))
                {
                    adxDatabaseName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("adxTableName"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        adxTableName = null;
                        continue;
                    }
                    adxTableName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("eventHubEndpointUri"))
                {
                    eventHubEndpointUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("eventHubEntityPath"))
                {
                    eventHubEntityPath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("eventHubNamespaceResourceId"))
                {
                    eventHubNamespaceResourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("eventHubConsumerGroup"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        eventHubConsumerGroup = null;
                        continue;
                    }
                    eventHubConsumerGroup = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("connectionType"))
                {
                    connectionType = new ConnectionType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("provisioningState"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    provisioningState = new TimeSeriesDatabaseConnectionState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("identity"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        identity = null;
                        continue;
                    }
                    identity = DigitalTwinsManagedIdentityReference.DeserializeDigitalTwinsManagedIdentityReference(property.Value);
                    continue;
                }
            }
            return new DataExplorerConnectionProperties(connectionType, Optional.ToNullable(provisioningState), identity.Value, adxResourceId, adxEndpointUri, adxDatabaseName, adxTableName.Value, eventHubEndpointUri, eventHubEntityPath, eventHubNamespaceResourceId, eventHubConsumerGroup.Value);
        }
    }
}
