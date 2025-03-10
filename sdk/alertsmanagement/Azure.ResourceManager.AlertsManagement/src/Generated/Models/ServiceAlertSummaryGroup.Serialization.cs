// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AlertsManagement.Models
{
    public partial class ServiceAlertSummaryGroup : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Total))
            {
                writer.WritePropertyName("total");
                writer.WriteNumberValue(Total.Value);
            }
            if (Optional.IsDefined(SmartGroupsCount))
            {
                writer.WritePropertyName("smartGroupsCount");
                writer.WriteNumberValue(SmartGroupsCount.Value);
            }
            if (Optional.IsDefined(GroupedBy))
            {
                writer.WritePropertyName("groupedby");
                writer.WriteStringValue(GroupedBy);
            }
            if (Optional.IsCollectionDefined(Values))
            {
                writer.WritePropertyName("values");
                writer.WriteStartArray();
                foreach (var item in Values)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static ServiceAlertSummaryGroup DeserializeServiceAlertSummaryGroup(JsonElement element)
        {
            Optional<long> total = default;
            Optional<long> smartGroupsCount = default;
            Optional<string> groupedby = default;
            Optional<IList<ServiceAlertSummaryGroupItemInfo>> values = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("total"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    total = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("smartGroupsCount"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    smartGroupsCount = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("groupedby"))
                {
                    groupedby = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("values"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ServiceAlertSummaryGroupItemInfo> array = new List<ServiceAlertSummaryGroupItemInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ServiceAlertSummaryGroupItemInfo.DeserializeServiceAlertSummaryGroupItemInfo(item));
                    }
                    values = array;
                    continue;
                }
            }
            return new ServiceAlertSummaryGroup(Optional.ToNullable(total), Optional.ToNullable(smartGroupsCount), groupedby.Value, Optional.ToList(values));
        }
    }
}
