// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppPlatform.Models
{
    public partial class AppPersistentDisk : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(SizeInGB))
            {
                writer.WritePropertyName("sizeInGB");
                writer.WriteNumberValue(SizeInGB.Value);
            }
            if (Optional.IsDefined(MountPath))
            {
                writer.WritePropertyName("mountPath");
                writer.WriteStringValue(MountPath);
            }
            writer.WriteEndObject();
        }

        internal static AppPersistentDisk DeserializeAppPersistentDisk(JsonElement element)
        {
            Optional<int> sizeInGB = default;
            Optional<int> usedInGB = default;
            Optional<string> mountPath = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sizeInGB"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    sizeInGB = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("usedInGB"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    usedInGB = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("mountPath"))
                {
                    mountPath = property.Value.GetString();
                    continue;
                }
            }
            return new AppPersistentDisk(Optional.ToNullable(sizeInGB), Optional.ToNullable(usedInGB), mountPath.Value);
        }
    }
}
