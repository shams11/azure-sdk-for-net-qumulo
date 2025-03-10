// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CognitiveServices.Models
{
    public partial class ServiceAccountQuotaLimit
    {
        internal static ServiceAccountQuotaLimit DeserializeServiceAccountQuotaLimit(JsonElement element)
        {
            Optional<float> count = default;
            Optional<float> renewalPeriod = default;
            Optional<IReadOnlyList<ServiceAccountThrottlingRule>> rules = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("count"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    count = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("renewalPeriod"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    renewalPeriod = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("rules"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ServiceAccountThrottlingRule> array = new List<ServiceAccountThrottlingRule>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ServiceAccountThrottlingRule.DeserializeServiceAccountThrottlingRule(item));
                    }
                    rules = array;
                    continue;
                }
            }
            return new ServiceAccountQuotaLimit(Optional.ToNullable(count), Optional.ToNullable(renewalPeriod), Optional.ToList(rules));
        }
    }
}
