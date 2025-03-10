// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    internal partial class UnknownDataStoreParameters : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("objectType");
            writer.WriteStringValue(ObjectType);
            writer.WritePropertyName("dataStoreType");
            writer.WriteStringValue(DataStoreType.ToString());
            writer.WriteEndObject();
        }

        internal static UnknownDataStoreParameters DeserializeUnknownDataStoreParameters(JsonElement element)
        {
            string objectType = "Unknown";
            DataStoreType dataStoreType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("objectType"))
                {
                    objectType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dataStoreType"))
                {
                    dataStoreType = new DataStoreType(property.Value.GetString());
                    continue;
                }
            }
            return new UnknownDataStoreParameters(objectType, dataStoreType);
        }
    }
}
