// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.KeyVault.Models;

namespace Azure.ResourceManager.KeyVault
{
    public partial class Sample_KeyVaultPrivateEndpointConnectionCollection
    {
        // KeyVaultGetPrivateEndpointConnection
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_KeyVaultGetPrivateEndpointConnection()
        {
            // Generated from example definition: specification/keyvault/resource-manager/Microsoft.KeyVault/stable/2021-10-01/examples/getPrivateEndpointConnection.json
            // this example is just showing the usage of "PrivateEndpointConnections_Get" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this KeyVaultResource created on azure
            // for more information of creating KeyVaultResource, please refer to the document of KeyVaultResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "sample-group";
            string vaultName = "sample-vault";
            ResourceIdentifier keyVaultResourceId = KeyVaultResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, vaultName);
            KeyVaultResource keyVault = client.GetKeyVaultResource(keyVaultResourceId);

            // get the collection of this KeyVaultPrivateEndpointConnectionResource
            KeyVaultPrivateEndpointConnectionCollection collection = keyVault.GetKeyVaultPrivateEndpointConnections();

            // invoke the operation
            string privateEndpointConnectionName = "sample-pec";
            KeyVaultPrivateEndpointConnectionResource result = await collection.GetAsync(privateEndpointConnectionName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            KeyVaultPrivateEndpointConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // KeyVaultGetPrivateEndpointConnection
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_KeyVaultGetPrivateEndpointConnection()
        {
            // Generated from example definition: specification/keyvault/resource-manager/Microsoft.KeyVault/stable/2021-10-01/examples/getPrivateEndpointConnection.json
            // this example is just showing the usage of "PrivateEndpointConnections_Get" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this KeyVaultResource created on azure
            // for more information of creating KeyVaultResource, please refer to the document of KeyVaultResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "sample-group";
            string vaultName = "sample-vault";
            ResourceIdentifier keyVaultResourceId = KeyVaultResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, vaultName);
            KeyVaultResource keyVault = client.GetKeyVaultResource(keyVaultResourceId);

            // get the collection of this KeyVaultPrivateEndpointConnectionResource
            KeyVaultPrivateEndpointConnectionCollection collection = keyVault.GetKeyVaultPrivateEndpointConnections();

            // invoke the operation
            string privateEndpointConnectionName = "sample-pec";
            bool result = await collection.ExistsAsync(privateEndpointConnectionName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // KeyVaultPutPrivateEndpointConnection
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_KeyVaultPutPrivateEndpointConnection()
        {
            // Generated from example definition: specification/keyvault/resource-manager/Microsoft.KeyVault/stable/2021-10-01/examples/putPrivateEndpointConnection.json
            // this example is just showing the usage of "PrivateEndpointConnections_Put" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this KeyVaultResource created on azure
            // for more information of creating KeyVaultResource, please refer to the document of KeyVaultResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "sample-group";
            string vaultName = "sample-vault";
            ResourceIdentifier keyVaultResourceId = KeyVaultResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, vaultName);
            KeyVaultResource keyVault = client.GetKeyVaultResource(keyVaultResourceId);

            // get the collection of this KeyVaultPrivateEndpointConnectionResource
            KeyVaultPrivateEndpointConnectionCollection collection = keyVault.GetKeyVaultPrivateEndpointConnections();

            // invoke the operation
            string privateEndpointConnectionName = "sample-pec";
            KeyVaultPrivateEndpointConnectionData data = new KeyVaultPrivateEndpointConnectionData()
            {
                ETag = new ETag(""),
                ConnectionState = new KeyVaultPrivateLinkServiceConnectionState()
                {
                    Status = KeyVaultPrivateEndpointServiceConnectionStatus.Approved,
                    Description = "My name is Joe and I'm approving this.",
                },
            };
            ArmOperation<KeyVaultPrivateEndpointConnectionResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, privateEndpointConnectionName, data);
            KeyVaultPrivateEndpointConnectionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            KeyVaultPrivateEndpointConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // KeyVaultListPrivateEndpointConnection
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_KeyVaultListPrivateEndpointConnection()
        {
            // Generated from example definition: specification/keyvault/resource-manager/Microsoft.KeyVault/stable/2021-10-01/examples/listPrivateEndpointConnection.json
            // this example is just showing the usage of "PrivateEndpointConnections_ListByResource" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this KeyVaultResource created on azure
            // for more information of creating KeyVaultResource, please refer to the document of KeyVaultResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "sample-group";
            string vaultName = "sample-vault";
            ResourceIdentifier keyVaultResourceId = KeyVaultResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, vaultName);
            KeyVaultResource keyVault = client.GetKeyVaultResource(keyVaultResourceId);

            // get the collection of this KeyVaultPrivateEndpointConnectionResource
            KeyVaultPrivateEndpointConnectionCollection collection = keyVault.GetKeyVaultPrivateEndpointConnections();

            // invoke the operation and iterate over the result
            await foreach (KeyVaultPrivateEndpointConnectionResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                KeyVaultPrivateEndpointConnectionData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
