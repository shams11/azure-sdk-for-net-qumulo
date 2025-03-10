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
using Azure.ResourceManager.ArcScVmm.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.ArcScVmm
{
    public partial class Sample_ScVmmVirtualMachineResource
    {
        // GetVirtualMachine
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetVirtualMachine()
        {
            // Generated from example definition: specification/scvmm/resource-manager/Microsoft.ScVmm/preview/2020-06-05-preview/examples/GetVirtualMachine.json
            // this example is just showing the usage of "VirtualMachines_Get" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this ScVmmVirtualMachineResource created on azure
            // for more information of creating ScVmmVirtualMachineResource, please refer to the document of ScVmmVirtualMachineResource
            string subscriptionId = "fd3c3665-1729-4b7b-9a38-238e83b0f98b";
            string resourceGroupName = "testrg";
            string virtualMachineName = "DemoVM";
            ResourceIdentifier scVmmVirtualMachineResourceId = ScVmmVirtualMachineResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualMachineName);
            ScVmmVirtualMachineResource scVmmVirtualMachine = client.GetScVmmVirtualMachineResource(scVmmVirtualMachineResourceId);

            // invoke the operation
            ScVmmVirtualMachineResource result = await scVmmVirtualMachine.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ScVmmVirtualMachineData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // DeleteVirtualMachine
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DeleteVirtualMachine()
        {
            // Generated from example definition: specification/scvmm/resource-manager/Microsoft.ScVmm/preview/2020-06-05-preview/examples/DeleteVirtualMachine.json
            // this example is just showing the usage of "VirtualMachines_Delete" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this ScVmmVirtualMachineResource created on azure
            // for more information of creating ScVmmVirtualMachineResource, please refer to the document of ScVmmVirtualMachineResource
            string subscriptionId = "fd3c3665-1729-4b7b-9a38-238e83b0f98b";
            string resourceGroupName = "testrg";
            string virtualMachineName = "DemoVM";
            ResourceIdentifier scVmmVirtualMachineResourceId = ScVmmVirtualMachineResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualMachineName);
            ScVmmVirtualMachineResource scVmmVirtualMachine = client.GetScVmmVirtualMachineResource(scVmmVirtualMachineResourceId);

            // invoke the operation
            await scVmmVirtualMachine.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // UpdateVirtualMachine
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_UpdateVirtualMachine()
        {
            // Generated from example definition: specification/scvmm/resource-manager/Microsoft.ScVmm/preview/2020-06-05-preview/examples/UpdateVirtualMachine.json
            // this example is just showing the usage of "VirtualMachines_Update" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this ScVmmVirtualMachineResource created on azure
            // for more information of creating ScVmmVirtualMachineResource, please refer to the document of ScVmmVirtualMachineResource
            string subscriptionId = "fd3c3665-1729-4b7b-9a38-238e83b0f98b";
            string resourceGroupName = "testrg";
            string virtualMachineName = "DemoVM";
            ResourceIdentifier scVmmVirtualMachineResourceId = ScVmmVirtualMachineResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualMachineName);
            ScVmmVirtualMachineResource scVmmVirtualMachine = client.GetScVmmVirtualMachineResource(scVmmVirtualMachineResourceId);

            // invoke the operation
            ScVmmVirtualMachinePatch patch = new ScVmmVirtualMachinePatch()
            {
                Properties = new VirtualMachineUpdateProperties()
                {
                    HardwareProfile = new HardwareProfileUpdate()
                    {
                        MemoryMB = 4096,
                        CpuCount = 4,
                    },
                    StorageDisks =
{
new VirtualDiskUpdate()
{
Name = "test",
DiskSizeGB = 10,
}
},
                    NetworkInterfaces =
{
new NetworkInterfacesUpdate()
{
Name = "test",
IPv4AddressType = AllocationMethod.Dynamic,
IPv6AddressType = AllocationMethod.Dynamic,
MacAddressType = AllocationMethod.Static,
}
},
                },
                Tags =
{
["tag1"] = "value1",
["tag2"] = "value2",
},
            };
            ArmOperation<ScVmmVirtualMachineResource> lro = await scVmmVirtualMachine.UpdateAsync(WaitUntil.Completed, patch);
            ScVmmVirtualMachineResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ScVmmVirtualMachineData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // StopVirtualMachine
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Stop_StopVirtualMachine()
        {
            // Generated from example definition: specification/scvmm/resource-manager/Microsoft.ScVmm/preview/2020-06-05-preview/examples/StopVirtualMachine.json
            // this example is just showing the usage of "VirtualMachines_Stop" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this ScVmmVirtualMachineResource created on azure
            // for more information of creating ScVmmVirtualMachineResource, please refer to the document of ScVmmVirtualMachineResource
            string subscriptionId = "fd3c3665-1729-4b7b-9a38-238e83b0f98b";
            string resourceGroupName = "testrg";
            string virtualMachineName = "DemoVM";
            ResourceIdentifier scVmmVirtualMachineResourceId = ScVmmVirtualMachineResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualMachineName);
            ScVmmVirtualMachineResource scVmmVirtualMachine = client.GetScVmmVirtualMachineResource(scVmmVirtualMachineResourceId);

            // invoke the operation
            StopVirtualMachineContent content = new StopVirtualMachineContent()
            {
                SkipShutdown = true,
            };
            await scVmmVirtualMachine.StopAsync(WaitUntil.Completed, content: content);

            Console.WriteLine($"Succeeded");
        }

        // StartVirtualMachine
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Start_StartVirtualMachine()
        {
            // Generated from example definition: specification/scvmm/resource-manager/Microsoft.ScVmm/preview/2020-06-05-preview/examples/StartVirtualMachine.json
            // this example is just showing the usage of "VirtualMachines_Start" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this ScVmmVirtualMachineResource created on azure
            // for more information of creating ScVmmVirtualMachineResource, please refer to the document of ScVmmVirtualMachineResource
            string subscriptionId = "fd3c3665-1729-4b7b-9a38-238e83b0f98b";
            string resourceGroupName = "testrg";
            string virtualMachineName = "DemoVM";
            ResourceIdentifier scVmmVirtualMachineResourceId = ScVmmVirtualMachineResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualMachineName);
            ScVmmVirtualMachineResource scVmmVirtualMachine = client.GetScVmmVirtualMachineResource(scVmmVirtualMachineResourceId);

            // invoke the operation
            await scVmmVirtualMachine.StartAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // RestartVirtualMachine
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Restart_RestartVirtualMachine()
        {
            // Generated from example definition: specification/scvmm/resource-manager/Microsoft.ScVmm/preview/2020-06-05-preview/examples/RestartVirtualMachine.json
            // this example is just showing the usage of "VirtualMachines_Restart" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this ScVmmVirtualMachineResource created on azure
            // for more information of creating ScVmmVirtualMachineResource, please refer to the document of ScVmmVirtualMachineResource
            string subscriptionId = "fd3c3665-1729-4b7b-9a38-238e83b0f98b";
            string resourceGroupName = "testrg";
            string virtualMachineName = "DemoVM";
            ResourceIdentifier scVmmVirtualMachineResourceId = ScVmmVirtualMachineResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualMachineName);
            ScVmmVirtualMachineResource scVmmVirtualMachine = client.GetScVmmVirtualMachineResource(scVmmVirtualMachineResourceId);

            // invoke the operation
            await scVmmVirtualMachine.RestartAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // CreateCheckpointVirtualMachine
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateCheckpoint_CreateCheckpointVirtualMachine()
        {
            // Generated from example definition: specification/scvmm/resource-manager/Microsoft.ScVmm/preview/2020-06-05-preview/examples/CreateCheckpointVirtualMachine.json
            // this example is just showing the usage of "VirtualMachines_CreateCheckpoint" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this ScVmmVirtualMachineResource created on azure
            // for more information of creating ScVmmVirtualMachineResource, please refer to the document of ScVmmVirtualMachineResource
            string subscriptionId = "fd3c3665-1729-4b7b-9a38-238e83b0f98b";
            string resourceGroupName = "testrg";
            string virtualMachineName = "DemoVM";
            ResourceIdentifier scVmmVirtualMachineResourceId = ScVmmVirtualMachineResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualMachineName);
            ScVmmVirtualMachineResource scVmmVirtualMachine = client.GetScVmmVirtualMachineResource(scVmmVirtualMachineResourceId);

            // invoke the operation
            VirtualMachineCreateCheckpoint body = new VirtualMachineCreateCheckpoint()
            {
                Name = "Demo Checkpoint name",
                Description = "Demo Checkpoint description",
            };
            await scVmmVirtualMachine.CreateCheckpointAsync(WaitUntil.Completed, body: body);

            Console.WriteLine($"Succeeded");
        }

        // DeleteCheckpointVirtualMachine
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task DeleteCheckpoint_DeleteCheckpointVirtualMachine()
        {
            // Generated from example definition: specification/scvmm/resource-manager/Microsoft.ScVmm/preview/2020-06-05-preview/examples/DeleteCheckpointVirtualMachine.json
            // this example is just showing the usage of "VirtualMachines_DeleteCheckpoint" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this ScVmmVirtualMachineResource created on azure
            // for more information of creating ScVmmVirtualMachineResource, please refer to the document of ScVmmVirtualMachineResource
            string subscriptionId = "fd3c3665-1729-4b7b-9a38-238e83b0f98b";
            string resourceGroupName = "testrg";
            string virtualMachineName = "DemoVM";
            ResourceIdentifier scVmmVirtualMachineResourceId = ScVmmVirtualMachineResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualMachineName);
            ScVmmVirtualMachineResource scVmmVirtualMachine = client.GetScVmmVirtualMachineResource(scVmmVirtualMachineResourceId);

            // invoke the operation
            VirtualMachineDeleteCheckpoint body = new VirtualMachineDeleteCheckpoint()
            {
                Id = "Demo CheckpointID",
            };
            await scVmmVirtualMachine.DeleteCheckpointAsync(WaitUntil.Completed, body: body);

            Console.WriteLine($"Succeeded");
        }

        // RestoreCheckpointVirtualMachine
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task RestoreCheckpoint_RestoreCheckpointVirtualMachine()
        {
            // Generated from example definition: specification/scvmm/resource-manager/Microsoft.ScVmm/preview/2020-06-05-preview/examples/RestoreCheckpointVirtualMachine.json
            // this example is just showing the usage of "VirtualMachines_RestoreCheckpoint" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this ScVmmVirtualMachineResource created on azure
            // for more information of creating ScVmmVirtualMachineResource, please refer to the document of ScVmmVirtualMachineResource
            string subscriptionId = "fd3c3665-1729-4b7b-9a38-238e83b0f98b";
            string resourceGroupName = "testrg";
            string virtualMachineName = "DemoVM";
            ResourceIdentifier scVmmVirtualMachineResourceId = ScVmmVirtualMachineResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualMachineName);
            ScVmmVirtualMachineResource scVmmVirtualMachine = client.GetScVmmVirtualMachineResource(scVmmVirtualMachineResourceId);

            // invoke the operation
            VirtualMachineRestoreCheckpoint body = new VirtualMachineRestoreCheckpoint()
            {
                Id = "Demo CheckpointID",
            };
            await scVmmVirtualMachine.RestoreCheckpointAsync(WaitUntil.Completed, body: body);

            Console.WriteLine($"Succeeded");
        }

        // ListVirtualMachinesBySubscription
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetScVmmVirtualMachines_ListVirtualMachinesBySubscription()
        {
            // Generated from example definition: specification/scvmm/resource-manager/Microsoft.ScVmm/preview/2020-06-05-preview/examples/ListVirtualMachinesBySubscription.json
            // this example is just showing the usage of "VirtualMachines_ListBySubscription" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "fd3c3665-1729-4b7b-9a38-238e83b0f98b";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation and iterate over the result
            await foreach (ScVmmVirtualMachineResource item in subscriptionResource.GetScVmmVirtualMachinesAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ScVmmVirtualMachineData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
