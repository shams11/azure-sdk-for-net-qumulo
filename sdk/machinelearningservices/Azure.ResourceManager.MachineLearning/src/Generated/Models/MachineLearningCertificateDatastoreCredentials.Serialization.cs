// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class MachineLearningCertificateDatastoreCredentials : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(AuthorityUri))
            {
                if (AuthorityUri != null)
                {
                    writer.WritePropertyName("authorityUrl");
                    writer.WriteStringValue(AuthorityUri.AbsoluteUri);
                }
                else
                {
                    writer.WriteNull("authorityUrl");
                }
            }
            writer.WritePropertyName("clientId");
            writer.WriteStringValue(ClientId);
            if (Optional.IsDefined(ResourceUri))
            {
                if (ResourceUri != null)
                {
                    writer.WritePropertyName("resourceUrl");
                    writer.WriteStringValue(ResourceUri.AbsoluteUri);
                }
                else
                {
                    writer.WriteNull("resourceUrl");
                }
            }
            writer.WritePropertyName("secrets");
            writer.WriteObjectValue(Secrets);
            writer.WritePropertyName("tenantId");
            writer.WriteStringValue(TenantId);
            writer.WritePropertyName("thumbprint");
            writer.WriteStringValue(Thumbprint);
            writer.WritePropertyName("credentialsType");
            writer.WriteStringValue(CredentialsType.ToString());
            writer.WriteEndObject();
        }

        internal static MachineLearningCertificateDatastoreCredentials DeserializeMachineLearningCertificateDatastoreCredentials(JsonElement element)
        {
            Optional<Uri> authorityUrl = default;
            Guid clientId = default;
            Optional<Uri> resourceUrl = default;
            MachineLearningCertificateDatastoreSecrets secrets = default;
            Guid tenantId = default;
            string thumbprint = default;
            CredentialsType credentialsType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("authorityUrl"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        authorityUrl = null;
                        continue;
                    }
                    authorityUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("clientId"))
                {
                    clientId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("resourceUrl"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        resourceUrl = null;
                        continue;
                    }
                    resourceUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("secrets"))
                {
                    secrets = MachineLearningCertificateDatastoreSecrets.DeserializeMachineLearningCertificateDatastoreSecrets(property.Value);
                    continue;
                }
                if (property.NameEquals("tenantId"))
                {
                    tenantId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("thumbprint"))
                {
                    thumbprint = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("credentialsType"))
                {
                    credentialsType = new CredentialsType(property.Value.GetString());
                    continue;
                }
            }
            return new MachineLearningCertificateDatastoreCredentials(credentialsType, authorityUrl.Value, clientId, resourceUrl.Value, secrets, tenantId, thumbprint);
        }
    }
}
