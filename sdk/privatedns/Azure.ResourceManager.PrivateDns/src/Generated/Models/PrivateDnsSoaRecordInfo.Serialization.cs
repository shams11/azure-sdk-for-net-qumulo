// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.PrivateDns.Models
{
    public partial class PrivateDnsSoaRecordInfo : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Host))
            {
                writer.WritePropertyName("host");
                writer.WriteStringValue(Host);
            }
            if (Optional.IsDefined(Email))
            {
                writer.WritePropertyName("email");
                writer.WriteStringValue(Email);
            }
            if (Optional.IsDefined(SerialNumber))
            {
                writer.WritePropertyName("serialNumber");
                writer.WriteNumberValue(SerialNumber.Value);
            }
            if (Optional.IsDefined(RefreshTimeInSeconds))
            {
                writer.WritePropertyName("refreshTime");
                writer.WriteNumberValue(RefreshTimeInSeconds.Value);
            }
            if (Optional.IsDefined(RetryTimeInSeconds))
            {
                writer.WritePropertyName("retryTime");
                writer.WriteNumberValue(RetryTimeInSeconds.Value);
            }
            if (Optional.IsDefined(ExpireTimeInSeconds))
            {
                writer.WritePropertyName("expireTime");
                writer.WriteNumberValue(ExpireTimeInSeconds.Value);
            }
            if (Optional.IsDefined(MinimumTtlInSeconds))
            {
                writer.WritePropertyName("minimumTtl");
                writer.WriteNumberValue(MinimumTtlInSeconds.Value);
            }
            writer.WriteEndObject();
        }

        internal static PrivateDnsSoaRecordInfo DeserializePrivateDnsSoaRecordInfo(JsonElement element)
        {
            Optional<string> host = default;
            Optional<string> email = default;
            Optional<long> serialNumber = default;
            Optional<long> refreshTime = default;
            Optional<long> retryTime = default;
            Optional<long> expireTime = default;
            Optional<long> minimumTtl = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("host"))
                {
                    host = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("email"))
                {
                    email = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("serialNumber"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    serialNumber = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("refreshTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    refreshTime = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("retryTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    retryTime = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("expireTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    expireTime = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("minimumTtl"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    minimumTtl = property.Value.GetInt64();
                    continue;
                }
            }
            return new PrivateDnsSoaRecordInfo(host.Value, email.Value, Optional.ToNullable(serialNumber), Optional.ToNullable(refreshTime), Optional.ToNullable(retryTime), Optional.ToNullable(expireTime), Optional.ToNullable(minimumTtl));
        }
    }
}
