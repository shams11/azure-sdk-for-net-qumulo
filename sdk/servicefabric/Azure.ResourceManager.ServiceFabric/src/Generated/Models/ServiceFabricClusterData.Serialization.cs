// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.ServiceFabric.Models;

namespace Azure.ResourceManager.ServiceFabric
{
    public partial class ServiceFabricClusterData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags");
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("location");
            writer.WriteStringValue(Location);
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(AddOnFeatures))
            {
                writer.WritePropertyName("addOnFeatures");
                writer.WriteStartArray();
                foreach (var item in AddOnFeatures)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(AzureActiveDirectory))
            {
                writer.WritePropertyName("azureActiveDirectory");
                writer.WriteObjectValue(AzureActiveDirectory);
            }
            if (Optional.IsDefined(Certificate))
            {
                writer.WritePropertyName("certificate");
                writer.WriteObjectValue(Certificate);
            }
            if (Optional.IsDefined(CertificateCommonNames))
            {
                writer.WritePropertyName("certificateCommonNames");
                writer.WriteObjectValue(CertificateCommonNames);
            }
            if (Optional.IsCollectionDefined(ClientCertificateCommonNames))
            {
                writer.WritePropertyName("clientCertificateCommonNames");
                writer.WriteStartArray();
                foreach (var item in ClientCertificateCommonNames)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ClientCertificateThumbprints))
            {
                writer.WritePropertyName("clientCertificateThumbprints");
                writer.WriteStartArray();
                foreach (var item in ClientCertificateThumbprints)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(ClusterCodeVersion))
            {
                writer.WritePropertyName("clusterCodeVersion");
                writer.WriteStringValue(ClusterCodeVersion);
            }
            if (Optional.IsDefined(DiagnosticsStorageAccountConfig))
            {
                writer.WritePropertyName("diagnosticsStorageAccountConfig");
                writer.WriteObjectValue(DiagnosticsStorageAccountConfig);
            }
            if (Optional.IsDefined(IsEventStoreServiceEnabled))
            {
                writer.WritePropertyName("eventStoreServiceEnabled");
                writer.WriteBooleanValue(IsEventStoreServiceEnabled.Value);
            }
            if (Optional.IsCollectionDefined(FabricSettings))
            {
                writer.WritePropertyName("fabricSettings");
                writer.WriteStartArray();
                foreach (var item in FabricSettings)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(ManagementEndpoint))
            {
                writer.WritePropertyName("managementEndpoint");
                writer.WriteStringValue(ManagementEndpoint.AbsoluteUri);
            }
            if (Optional.IsCollectionDefined(NodeTypes))
            {
                writer.WritePropertyName("nodeTypes");
                writer.WriteStartArray();
                foreach (var item in NodeTypes)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(ReliabilityLevel))
            {
                writer.WritePropertyName("reliabilityLevel");
                writer.WriteStringValue(ReliabilityLevel.Value.ToString());
            }
            if (Optional.IsDefined(ReverseProxyCertificate))
            {
                writer.WritePropertyName("reverseProxyCertificate");
                writer.WriteObjectValue(ReverseProxyCertificate);
            }
            if (Optional.IsDefined(ReverseProxyCertificateCommonNames))
            {
                writer.WritePropertyName("reverseProxyCertificateCommonNames");
                writer.WriteObjectValue(ReverseProxyCertificateCommonNames);
            }
            if (Optional.IsDefined(UpgradeDescription))
            {
                writer.WritePropertyName("upgradeDescription");
                writer.WriteObjectValue(UpgradeDescription);
            }
            if (Optional.IsDefined(UpgradeMode))
            {
                writer.WritePropertyName("upgradeMode");
                writer.WriteStringValue(UpgradeMode.Value.ToString());
            }
            if (Optional.IsDefined(ApplicationTypeVersionsCleanupPolicy))
            {
                writer.WritePropertyName("applicationTypeVersionsCleanupPolicy");
                writer.WriteObjectValue(ApplicationTypeVersionsCleanupPolicy);
            }
            if (Optional.IsDefined(VmImage))
            {
                writer.WritePropertyName("vmImage");
                writer.WriteStringValue(VmImage);
            }
            if (Optional.IsDefined(ServiceFabricZonalUpgradeMode))
            {
                writer.WritePropertyName("sfZonalUpgradeMode");
                writer.WriteStringValue(ServiceFabricZonalUpgradeMode.Value.ToString());
            }
            if (Optional.IsDefined(VmssZonalUpgradeMode))
            {
                writer.WritePropertyName("vmssZonalUpgradeMode");
                writer.WriteStringValue(VmssZonalUpgradeMode.Value.ToString());
            }
            if (Optional.IsDefined(IsInfrastructureServiceManagerEnabled))
            {
                writer.WritePropertyName("infrastructureServiceManager");
                writer.WriteBooleanValue(IsInfrastructureServiceManagerEnabled.Value);
            }
            if (Optional.IsDefined(UpgradeWave))
            {
                writer.WritePropertyName("upgradeWave");
                writer.WriteStringValue(UpgradeWave.Value.ToString());
            }
            if (Optional.IsDefined(UpgradePauseStartOn))
            {
                writer.WritePropertyName("upgradePauseStartTimestampUtc");
                writer.WriteStringValue(UpgradePauseStartOn.Value, "O");
            }
            if (Optional.IsDefined(UpgradePauseEndOn))
            {
                writer.WritePropertyName("upgradePauseEndTimestampUtc");
                writer.WriteStringValue(UpgradePauseEndOn.Value, "O");
            }
            if (Optional.IsDefined(IsWaveUpgradePaused))
            {
                writer.WritePropertyName("waveUpgradePaused");
                writer.WriteBooleanValue(IsWaveUpgradePaused.Value);
            }
            if (Optional.IsCollectionDefined(Notifications))
            {
                writer.WritePropertyName("notifications");
                writer.WriteStartArray();
                foreach (var item in Notifications)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static ServiceFabricClusterData DeserializeServiceFabricClusterData(JsonElement element)
        {
            Optional<ETag> etag = default;
            Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<IList<ClusterAddOnFeature>> addOnFeatures = default;
            Optional<IReadOnlyList<ClusterVersionDetails>> availableClusterVersions = default;
            Optional<ClusterAadSetting> azureActiveDirectory = default;
            Optional<ClusterCertificateDescription> certificate = default;
            Optional<ClusterServerCertificateCommonNames> certificateCommonNames = default;
            Optional<IList<ClusterClientCertificateCommonName>> clientCertificateCommonNames = default;
            Optional<IList<ClusterClientCertificateThumbprint>> clientCertificateThumbprints = default;
            Optional<string> clusterCodeVersion = default;
            Optional<Uri> clusterEndpoint = default;
            Optional<Guid> clusterId = default;
            Optional<ServiceFabricClusterState> clusterState = default;
            Optional<DiagnosticsStorageAccountConfig> diagnosticsStorageAccountConfig = default;
            Optional<bool> eventStoreServiceEnabled = default;
            Optional<IList<SettingsSectionDescription>> fabricSettings = default;
            Optional<Uri> managementEndpoint = default;
            Optional<IList<ClusterNodeTypeDescription>> nodeTypes = default;
            Optional<ServiceFabricProvisioningState> provisioningState = default;
            Optional<ClusterReliabilityLevel> reliabilityLevel = default;
            Optional<ClusterCertificateDescription> reverseProxyCertificate = default;
            Optional<ClusterServerCertificateCommonNames> reverseProxyCertificateCommonNames = default;
            Optional<ClusterUpgradePolicy> upgradeDescription = default;
            Optional<ClusterUpgradeMode> upgradeMode = default;
            Optional<ApplicationTypeVersionsCleanupPolicy> applicationTypeVersionsCleanupPolicy = default;
            Optional<string> vmImage = default;
            Optional<SfZonalUpgradeMode> sfZonalUpgradeMode = default;
            Optional<VmssZonalUpgradeMode> vmssZonalUpgradeMode = default;
            Optional<bool> infrastructureServiceManager = default;
            Optional<ClusterUpgradeCadence> upgradeWave = default;
            Optional<DateTimeOffset> upgradePauseStartTimestampUtc = default;
            Optional<DateTimeOffset> upgradePauseEndTimestampUtc = default;
            Optional<bool> waveUpgradePaused = default;
            Optional<IList<ClusterNotification>> notifications = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("etag"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    etag = new ETag(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("tags"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"))
                {
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("addOnFeatures"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<ClusterAddOnFeature> array = new List<ClusterAddOnFeature>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(new ClusterAddOnFeature(item.GetString()));
                            }
                            addOnFeatures = array;
                            continue;
                        }
                        if (property0.NameEquals("availableClusterVersions"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<ClusterVersionDetails> array = new List<ClusterVersionDetails>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ClusterVersionDetails.DeserializeClusterVersionDetails(item));
                            }
                            availableClusterVersions = array;
                            continue;
                        }
                        if (property0.NameEquals("azureActiveDirectory"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            azureActiveDirectory = ClusterAadSetting.DeserializeClusterAadSetting(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("certificate"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            certificate = ClusterCertificateDescription.DeserializeClusterCertificateDescription(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("certificateCommonNames"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            certificateCommonNames = ClusterServerCertificateCommonNames.DeserializeClusterServerCertificateCommonNames(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("clientCertificateCommonNames"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<ClusterClientCertificateCommonName> array = new List<ClusterClientCertificateCommonName>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ClusterClientCertificateCommonName.DeserializeClusterClientCertificateCommonName(item));
                            }
                            clientCertificateCommonNames = array;
                            continue;
                        }
                        if (property0.NameEquals("clientCertificateThumbprints"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<ClusterClientCertificateThumbprint> array = new List<ClusterClientCertificateThumbprint>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ClusterClientCertificateThumbprint.DeserializeClusterClientCertificateThumbprint(item));
                            }
                            clientCertificateThumbprints = array;
                            continue;
                        }
                        if (property0.NameEquals("clusterCodeVersion"))
                        {
                            clusterCodeVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("clusterEndpoint"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                clusterEndpoint = null;
                                continue;
                            }
                            clusterEndpoint = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("clusterId"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            clusterId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("clusterState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            clusterState = new ServiceFabricClusterState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("diagnosticsStorageAccountConfig"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            diagnosticsStorageAccountConfig = DiagnosticsStorageAccountConfig.DeserializeDiagnosticsStorageAccountConfig(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("eventStoreServiceEnabled"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            eventStoreServiceEnabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("fabricSettings"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<SettingsSectionDescription> array = new List<SettingsSectionDescription>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(SettingsSectionDescription.DeserializeSettingsSectionDescription(item));
                            }
                            fabricSettings = array;
                            continue;
                        }
                        if (property0.NameEquals("managementEndpoint"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                managementEndpoint = null;
                                continue;
                            }
                            managementEndpoint = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("nodeTypes"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<ClusterNodeTypeDescription> array = new List<ClusterNodeTypeDescription>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ClusterNodeTypeDescription.DeserializeClusterNodeTypeDescription(item));
                            }
                            nodeTypes = array;
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            provisioningState = new ServiceFabricProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("reliabilityLevel"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            reliabilityLevel = new ClusterReliabilityLevel(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("reverseProxyCertificate"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            reverseProxyCertificate = ClusterCertificateDescription.DeserializeClusterCertificateDescription(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("reverseProxyCertificateCommonNames"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            reverseProxyCertificateCommonNames = ClusterServerCertificateCommonNames.DeserializeClusterServerCertificateCommonNames(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("upgradeDescription"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            upgradeDescription = ClusterUpgradePolicy.DeserializeClusterUpgradePolicy(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("upgradeMode"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            upgradeMode = new ClusterUpgradeMode(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("applicationTypeVersionsCleanupPolicy"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            applicationTypeVersionsCleanupPolicy = ApplicationTypeVersionsCleanupPolicy.DeserializeApplicationTypeVersionsCleanupPolicy(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("vmImage"))
                        {
                            vmImage = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("sfZonalUpgradeMode"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            sfZonalUpgradeMode = new SfZonalUpgradeMode(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("vmssZonalUpgradeMode"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            vmssZonalUpgradeMode = new VmssZonalUpgradeMode(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("infrastructureServiceManager"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            infrastructureServiceManager = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("upgradeWave"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            upgradeWave = new ClusterUpgradeCadence(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("upgradePauseStartTimestampUtc"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            upgradePauseStartTimestampUtc = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("upgradePauseEndTimestampUtc"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            upgradePauseEndTimestampUtc = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("waveUpgradePaused"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            waveUpgradePaused = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("notifications"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<ClusterNotification> array = new List<ClusterNotification>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ClusterNotification.DeserializeClusterNotification(item));
                            }
                            notifications = array;
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ServiceFabricClusterData(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, Optional.ToList(addOnFeatures), Optional.ToList(availableClusterVersions), azureActiveDirectory.Value, certificate.Value, certificateCommonNames.Value, Optional.ToList(clientCertificateCommonNames), Optional.ToList(clientCertificateThumbprints), clusterCodeVersion.Value, clusterEndpoint.Value, Optional.ToNullable(clusterId), Optional.ToNullable(clusterState), diagnosticsStorageAccountConfig.Value, Optional.ToNullable(eventStoreServiceEnabled), Optional.ToList(fabricSettings), managementEndpoint.Value, Optional.ToList(nodeTypes), Optional.ToNullable(provisioningState), Optional.ToNullable(reliabilityLevel), reverseProxyCertificate.Value, reverseProxyCertificateCommonNames.Value, upgradeDescription.Value, Optional.ToNullable(upgradeMode), applicationTypeVersionsCleanupPolicy.Value, vmImage.Value, Optional.ToNullable(sfZonalUpgradeMode), Optional.ToNullable(vmssZonalUpgradeMode), Optional.ToNullable(infrastructureServiceManager), Optional.ToNullable(upgradeWave), Optional.ToNullable(upgradePauseStartTimestampUtc), Optional.ToNullable(upgradePauseEndTimestampUtc), Optional.ToNullable(waveUpgradePaused), Optional.ToList(notifications), Optional.ToNullable(etag));
        }
    }
}
