// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;

namespace Azure.ResourceManager.HealthcareApis
{
    public partial class Sample_HealthcareApisServicePrivateLinkResourceCollection
    {
        // PrivateLinkResources_ListGroupIds
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_PrivateLinkResourcesListGroupIds()
        {
            // Generated from example definition: specification/healthcareapis/resource-manager/Microsoft.HealthcareApis/stable/2022-06-01/examples/legacy/PrivateLinkResourcesListByService.json
            // this example is just showing the usage of "PrivateLinkResources_ListByService" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this HealthcareApisServiceResource created on azure
            // for more information of creating HealthcareApisServiceResource, please refer to the document of HealthcareApisServiceResource
            string subscriptionId = "subid";
            string resourceGroupName = "rgname";
            string resourceName = "service1";
            ResourceIdentifier healthcareApisServiceResourceId = HealthcareApisServiceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, resourceName);
            HealthcareApisServiceResource healthcareApisService = client.GetHealthcareApisServiceResource(healthcareApisServiceResourceId);

            // get the collection of this HealthcareApisServicePrivateLinkResource
            HealthcareApisServicePrivateLinkResourceCollection collection = healthcareApisService.GetHealthcareApisServicePrivateLinkResources();

            // invoke the operation and iterate over the result
            await foreach (HealthcareApisServicePrivateLinkResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                HealthcareApisPrivateLinkResourceData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // PrivateLinkResources_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_PrivateLinkResourcesGet()
        {
            // Generated from example definition: specification/healthcareapis/resource-manager/Microsoft.HealthcareApis/stable/2022-06-01/examples/legacy/PrivateLinkResourceGet.json
            // this example is just showing the usage of "PrivateLinkResources_Get" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this HealthcareApisServiceResource created on azure
            // for more information of creating HealthcareApisServiceResource, please refer to the document of HealthcareApisServiceResource
            string subscriptionId = "subid";
            string resourceGroupName = "rgname";
            string resourceName = "service1";
            ResourceIdentifier healthcareApisServiceResourceId = HealthcareApisServiceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, resourceName);
            HealthcareApisServiceResource healthcareApisService = client.GetHealthcareApisServiceResource(healthcareApisServiceResourceId);

            // get the collection of this HealthcareApisServicePrivateLinkResource
            HealthcareApisServicePrivateLinkResourceCollection collection = healthcareApisService.GetHealthcareApisServicePrivateLinkResources();

            // invoke the operation
            string groupName = "fhir";
            HealthcareApisServicePrivateLinkResource result = await collection.GetAsync(groupName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            HealthcareApisPrivateLinkResourceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // PrivateLinkResources_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_PrivateLinkResourcesGet()
        {
            // Generated from example definition: specification/healthcareapis/resource-manager/Microsoft.HealthcareApis/stable/2022-06-01/examples/legacy/PrivateLinkResourceGet.json
            // this example is just showing the usage of "PrivateLinkResources_Get" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this HealthcareApisServiceResource created on azure
            // for more information of creating HealthcareApisServiceResource, please refer to the document of HealthcareApisServiceResource
            string subscriptionId = "subid";
            string resourceGroupName = "rgname";
            string resourceName = "service1";
            ResourceIdentifier healthcareApisServiceResourceId = HealthcareApisServiceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, resourceName);
            HealthcareApisServiceResource healthcareApisService = client.GetHealthcareApisServiceResource(healthcareApisServiceResourceId);

            // get the collection of this HealthcareApisServicePrivateLinkResource
            HealthcareApisServicePrivateLinkResourceCollection collection = healthcareApisService.GetHealthcareApisServicePrivateLinkResources();

            // invoke the operation
            string groupName = "fhir";
            bool result = await collection.ExistsAsync(groupName);

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
