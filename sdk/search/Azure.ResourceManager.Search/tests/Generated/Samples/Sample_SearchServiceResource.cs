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
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.Search.Models;

namespace Azure.ResourceManager.Search
{
    public partial class Sample_SearchServiceResource
    {
        // SearchGetAdminKeys
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAdminKey_SearchGetAdminKeys()
        {
            // Generated from example definition: specification/search/resource-manager/Microsoft.Search/stable/2020-08-01/examples/SearchGetAdminKeys.json
            // this example is just showing the usage of "AdminKeys_Get" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this SearchServiceResource created on azure
            // for more information of creating SearchServiceResource, please refer to the document of SearchServiceResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string searchServiceName = "mysearchservice";
            ResourceIdentifier searchServiceResourceId = SearchServiceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, searchServiceName);
            SearchServiceResource searchService = client.GetSearchServiceResource(searchServiceResourceId);

            // invoke the operation
            SearchServiceAdminKeyResult result = await searchService.GetAdminKeyAsync();

            Console.WriteLine($"Succeeded: {result}");
        }

        // SearchRegenerateAdminKey
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task RegenerateAdminKey_SearchRegenerateAdminKey()
        {
            // Generated from example definition: specification/search/resource-manager/Microsoft.Search/stable/2020-08-01/examples/SearchRegenerateAdminKey.json
            // this example is just showing the usage of "AdminKeys_Regenerate" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this SearchServiceResource created on azure
            // for more information of creating SearchServiceResource, please refer to the document of SearchServiceResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string searchServiceName = "mysearchservice";
            ResourceIdentifier searchServiceResourceId = SearchServiceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, searchServiceName);
            SearchServiceResource searchService = client.GetSearchServiceResource(searchServiceResourceId);

            // invoke the operation
            SearchServiceAdminKeyKind keyKind = SearchServiceAdminKeyKind.Primary;
            SearchServiceAdminKeyResult result = await searchService.RegenerateAdminKeyAsync(keyKind);

            Console.WriteLine($"Succeeded: {result}");
        }

        // SearchCreateQueryKey
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateQueryKey_SearchCreateQueryKey()
        {
            // Generated from example definition: specification/search/resource-manager/Microsoft.Search/stable/2020-08-01/examples/SearchCreateQueryKey.json
            // this example is just showing the usage of "QueryKeys_Create" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this SearchServiceResource created on azure
            // for more information of creating SearchServiceResource, please refer to the document of SearchServiceResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string searchServiceName = "mysearchservice";
            ResourceIdentifier searchServiceResourceId = SearchServiceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, searchServiceName);
            SearchServiceResource searchService = client.GetSearchServiceResource(searchServiceResourceId);

            // invoke the operation
            string name = "Query key for browser-based clients";
            SearchServiceQueryKey result = await searchService.CreateQueryKeyAsync(name);

            Console.WriteLine($"Succeeded: {result}");
        }

        // SearchListQueryKeysBySearchService
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetQueryKeysBySearchService_SearchListQueryKeysBySearchService()
        {
            // Generated from example definition: specification/search/resource-manager/Microsoft.Search/stable/2020-08-01/examples/SearchListQueryKeysBySearchService.json
            // this example is just showing the usage of "QueryKeys_ListBySearchService" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this SearchServiceResource created on azure
            // for more information of creating SearchServiceResource, please refer to the document of SearchServiceResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string searchServiceName = "mysearchservice";
            ResourceIdentifier searchServiceResourceId = SearchServiceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, searchServiceName);
            SearchServiceResource searchService = client.GetSearchServiceResource(searchServiceResourceId);

            // invoke the operation and iterate over the result
            await foreach (SearchServiceQueryKey item in searchService.GetQueryKeysBySearchServiceAsync())
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine($"Succeeded");
        }

        // SearchDeleteQueryKey
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task DeleteQueryKey_SearchDeleteQueryKey()
        {
            // Generated from example definition: specification/search/resource-manager/Microsoft.Search/stable/2020-08-01/examples/SearchDeleteQueryKey.json
            // this example is just showing the usage of "QueryKeys_Delete" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this SearchServiceResource created on azure
            // for more information of creating SearchServiceResource, please refer to the document of SearchServiceResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string searchServiceName = "mysearchservice";
            ResourceIdentifier searchServiceResourceId = SearchServiceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, searchServiceName);
            SearchServiceResource searchService = client.GetSearchServiceResource(searchServiceResourceId);

            // invoke the operation
            string key = "<a query API key>";
            await searchService.DeleteQueryKeyAsync(key);

            Console.WriteLine($"Succeeded");
        }

        // SearchUpdateService
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_SearchUpdateService()
        {
            // Generated from example definition: specification/search/resource-manager/Microsoft.Search/stable/2020-08-01/examples/SearchUpdateService.json
            // this example is just showing the usage of "Services_Update" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this SearchServiceResource created on azure
            // for more information of creating SearchServiceResource, please refer to the document of SearchServiceResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string searchServiceName = "mysearchservice";
            ResourceIdentifier searchServiceResourceId = SearchServiceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, searchServiceName);
            SearchServiceResource searchService = client.GetSearchServiceResource(searchServiceResourceId);

            // invoke the operation
            SearchServicePatch patch = new SearchServicePatch(new AzureLocation("placeholder"))
            {
                ReplicaCount = 2,
                Tags =
{
["app-name"] = "My e-commerce app",
["new-tag"] = "Adding a new tag",
},
            };
            SearchServiceResource result = await searchService.UpdateAsync(patch);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SearchServiceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // SearchUpdateServiceToRemoveIdentity
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_SearchUpdateServiceToRemoveIdentity()
        {
            // Generated from example definition: specification/search/resource-manager/Microsoft.Search/stable/2020-08-01/examples/SearchUpdateServiceToRemoveIdentity.json
            // this example is just showing the usage of "Services_Update" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this SearchServiceResource created on azure
            // for more information of creating SearchServiceResource, please refer to the document of SearchServiceResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string searchServiceName = "mysearchservice";
            ResourceIdentifier searchServiceResourceId = SearchServiceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, searchServiceName);
            SearchServiceResource searchService = client.GetSearchServiceResource(searchServiceResourceId);

            // invoke the operation
            SearchServicePatch patch = new SearchServicePatch(new AzureLocation("placeholder"))
            {
                SkuName = SearchSkuName.Standard,
                Identity = new ManagedServiceIdentity("None"),
            };
            SearchServiceResource result = await searchService.UpdateAsync(patch);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SearchServiceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // searchUpdateServiceToAllowAccessFromPrivateEndpoints
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_SearchUpdateServiceToAllowAccessFromPrivateEndpoints()
        {
            // Generated from example definition: specification/search/resource-manager/Microsoft.Search/stable/2020-08-01/examples/SearchUpdateServiceToAllowAccessFromPrivateEndpoints.json
            // this example is just showing the usage of "Services_Update" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this SearchServiceResource created on azure
            // for more information of creating SearchServiceResource, please refer to the document of SearchServiceResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string searchServiceName = "mysearchservice";
            ResourceIdentifier searchServiceResourceId = SearchServiceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, searchServiceName);
            SearchServiceResource searchService = client.GetSearchServiceResource(searchServiceResourceId);

            // invoke the operation
            SearchServicePatch patch = new SearchServicePatch(new AzureLocation("placeholder"))
            {
                ReplicaCount = 1,
                PartitionCount = 1,
                PublicNetworkAccess = SearchServicePublicNetworkAccess.Disabled,
            };
            SearchServiceResource result = await searchService.UpdateAsync(patch);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SearchServiceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // searchUpdateServiceToAllowAccessFromPublicCustomIPs
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_SearchUpdateServiceToAllowAccessFromPublicCustomIPs()
        {
            // Generated from example definition: specification/search/resource-manager/Microsoft.Search/stable/2020-08-01/examples/SearchUpdateServiceToAllowAccessFromPublicCustomIPs.json
            // this example is just showing the usage of "Services_Update" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this SearchServiceResource created on azure
            // for more information of creating SearchServiceResource, please refer to the document of SearchServiceResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string searchServiceName = "mysearchservice";
            ResourceIdentifier searchServiceResourceId = SearchServiceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, searchServiceName);
            SearchServiceResource searchService = client.GetSearchServiceResource(searchServiceResourceId);

            // invoke the operation
            SearchServicePatch patch = new SearchServicePatch(new AzureLocation("placeholder"))
            {
                ReplicaCount = 3,
                PartitionCount = 1,
                PublicNetworkAccess = SearchServicePublicNetworkAccess.Enabled,
                IPRules =
{
new SearchServiceIPRule()
{
Value = "123.4.5.6",
},new SearchServiceIPRule()
{
Value = "123.4.6.0/18",
}
},
            };
            SearchServiceResource result = await searchService.UpdateAsync(patch);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SearchServiceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // SearchGetService
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_SearchGetService()
        {
            // Generated from example definition: specification/search/resource-manager/Microsoft.Search/stable/2020-08-01/examples/SearchGetService.json
            // this example is just showing the usage of "Services_Get" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this SearchServiceResource created on azure
            // for more information of creating SearchServiceResource, please refer to the document of SearchServiceResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string searchServiceName = "mysearchservice";
            ResourceIdentifier searchServiceResourceId = SearchServiceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, searchServiceName);
            SearchServiceResource searchService = client.GetSearchServiceResource(searchServiceResourceId);

            // invoke the operation
            SearchServiceResource result = await searchService.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SearchServiceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // SearchDeleteService
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_SearchDeleteService()
        {
            // Generated from example definition: specification/search/resource-manager/Microsoft.Search/stable/2020-08-01/examples/SearchDeleteService.json
            // this example is just showing the usage of "Services_Delete" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this SearchServiceResource created on azure
            // for more information of creating SearchServiceResource, please refer to the document of SearchServiceResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string searchServiceName = "mysearchservice";
            ResourceIdentifier searchServiceResourceId = SearchServiceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, searchServiceName);
            SearchServiceResource searchService = client.GetSearchServiceResource(searchServiceResourceId);

            // invoke the operation
            await searchService.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // SearchListServicesBySubscription
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetSearchServices_SearchListServicesBySubscription()
        {
            // Generated from example definition: specification/search/resource-manager/Microsoft.Search/stable/2020-08-01/examples/SearchListServicesBySubscription.json
            // this example is just showing the usage of "Services_ListBySubscription" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "subid";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation and iterate over the result
            await foreach (SearchServiceResource item in subscriptionResource.GetSearchServicesAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                SearchServiceData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // SearchCheckNameAvailability
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CheckSearchServiceNameAvailability_SearchCheckNameAvailability()
        {
            // Generated from example definition: specification/search/resource-manager/Microsoft.Search/stable/2020-08-01/examples/SearchCheckNameAvailability.json
            // this example is just showing the usage of "Services_CheckNameAvailability" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "subid";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation
            SearchServiceNameAvailabilityContent content = new SearchServiceNameAvailabilityContent("mysearchservice");
            SearchServiceNameAvailabilityResult result = await subscriptionResource.CheckSearchServiceNameAvailabilityAsync(content);

            Console.WriteLine($"Succeeded: {result}");
        }

        // ListSupportedPrivateLinkResources
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetSupportedPrivateLinkResources_ListSupportedPrivateLinkResources()
        {
            // Generated from example definition: specification/search/resource-manager/Microsoft.Search/stable/2020-08-01/examples/ListSupportedPrivateLinkResources.json
            // this example is just showing the usage of "PrivateLinkResources_ListSupported" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this SearchServiceResource created on azure
            // for more information of creating SearchServiceResource, please refer to the document of SearchServiceResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string searchServiceName = "mysearchservice";
            ResourceIdentifier searchServiceResourceId = SearchServiceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, searchServiceName);
            SearchServiceResource searchService = client.GetSearchServiceResource(searchServiceResourceId);

            // invoke the operation and iterate over the result
            await foreach (SearchPrivateLinkResource item in searchService.GetSupportedPrivateLinkResourcesAsync())
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
