// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Communication.MediaComposition.Models;
using Azure.Core;

namespace Azure.Communication.MediaComposition
{
    public partial class PresenterLayout : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("presenterId");
            writer.WriteStringValue(PresenterId);
            writer.WritePropertyName("supportId");
            writer.WriteStringValue(SupportId);
            if (Optional.IsDefined(SupportPosition))
            {
                writer.WritePropertyName("supportPosition");
                writer.WriteStringValue(SupportPosition.Value.ToString());
            }
            if (Optional.IsDefined(SupportAspectRatio))
            {
                writer.WritePropertyName("supportAspectRatio");
                writer.WriteNumberValue(SupportAspectRatio.Value);
            }
            writer.WritePropertyName("kind");
            writer.WriteStringValue(Kind.ToString());
            if (Optional.IsDefined(Resolution))
            {
                writer.WritePropertyName("resolution");
                writer.WriteObjectValue(Resolution);
            }
            if (Optional.IsDefined(PlaceholderImageUri))
            {
                writer.WritePropertyName("placeholderImageUri");
                writer.WriteStringValue(PlaceholderImageUri);
            }
            if (Optional.IsDefined(ScalingMode))
            {
                writer.WritePropertyName("scalingMode");
                writer.WriteStringValue(ScalingMode.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static PresenterLayout DeserializePresenterLayout(JsonElement element)
        {
            string presenterId = default;
            string supportId = default;
            Optional<SupportPosition> supportPosition = default;
            Optional<double> supportAspectRatio = default;
            LayoutType kind = default;
            Optional<LayoutResolution> resolution = default;
            Optional<string> placeholderImageUri = default;
            Optional<ScalingMode> scalingMode = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("presenterId"))
                {
                    presenterId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("supportId"))
                {
                    supportId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("supportPosition"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    supportPosition = new SupportPosition(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("supportAspectRatio"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    supportAspectRatio = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("kind"))
                {
                    kind = new LayoutType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("resolution"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    resolution = LayoutResolution.DeserializeLayoutResolution(property.Value);
                    continue;
                }
                if (property.NameEquals("placeholderImageUri"))
                {
                    placeholderImageUri = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("scalingMode"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    scalingMode = new ScalingMode(property.Value.GetString());
                    continue;
                }
            }
            return new PresenterLayout(kind, resolution.Value, placeholderImageUri.Value, Optional.ToNullable(scalingMode), presenterId, supportId, Optional.ToNullable(supportPosition), Optional.ToNullable(supportAspectRatio));
        }
    }
}
