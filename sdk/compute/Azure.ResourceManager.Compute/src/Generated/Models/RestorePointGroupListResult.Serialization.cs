// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Compute;

namespace Azure.ResourceManager.Compute.Models
{
    internal partial class RestorePointGroupListResult
    {
        internal static RestorePointGroupListResult DeserializeRestorePointGroupListResult(JsonElement element)
        {
            Optional<IReadOnlyList<RestorePointGroupData>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<RestorePointGroupData> array = new List<RestorePointGroupData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RestorePointGroupData.DeserializeRestorePointGroupData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new RestorePointGroupListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
