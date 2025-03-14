// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class EventProperties
    {
        internal static EventProperties DeserializeEventProperties(JsonElement element)
        {
            Optional<string> eventCode = default;
            Optional<string> description = default;
            Optional<string> eventType = default;
            Optional<string> affectedObjectFriendlyName = default;
            Optional<string> affectedObjectCorrelationId = default;
            Optional<string> severity = default;
            Optional<DateTimeOffset> timeOfOccurrence = default;
            Optional<string> fabricId = default;
            Optional<EventProviderSpecificDetails> providerSpecificDetails = default;
            Optional<EventSpecificDetails> eventSpecificDetails = default;
            Optional<IReadOnlyList<HealthError>> healthErrors = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("eventCode"))
                {
                    eventCode = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("eventType"))
                {
                    eventType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("affectedObjectFriendlyName"))
                {
                    affectedObjectFriendlyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("affectedObjectCorrelationId"))
                {
                    affectedObjectCorrelationId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("severity"))
                {
                    severity = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("timeOfOccurrence"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    timeOfOccurrence = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("fabricId"))
                {
                    fabricId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("providerSpecificDetails"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    providerSpecificDetails = EventProviderSpecificDetails.DeserializeEventProviderSpecificDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("eventSpecificDetails"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    eventSpecificDetails = EventSpecificDetails.DeserializeEventSpecificDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("healthErrors"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<HealthError> array = new List<HealthError>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(HealthError.DeserializeHealthError(item));
                    }
                    healthErrors = array;
                    continue;
                }
            }
            return new EventProperties(eventCode.Value, description.Value, eventType.Value, affectedObjectFriendlyName.Value, affectedObjectCorrelationId.Value, severity.Value, Optional.ToNullable(timeOfOccurrence), fabricId.Value, providerSpecificDetails.Value, eventSpecificDetails.Value, Optional.ToList(healthErrors));
        }
    }
}
