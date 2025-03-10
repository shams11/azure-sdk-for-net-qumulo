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
using Azure.ResourceManager.CustomerInsights.Models;

namespace Azure.ResourceManager.CustomerInsights
{
    public partial class Sample_RelationshipResourceFormatResource
    {
        // Relationships_CreateOrUpdate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_RelationshipsCreateOrUpdate()
        {
            // Generated from example definition: specification/customer-insights/resource-manager/Microsoft.CustomerInsights/stable/2017-04-26/examples/RelationshipsCreateOrUpdate.json
            // this example is just showing the usage of "Relationships_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this RelationshipResourceFormatResource created on azure
            // for more information of creating RelationshipResourceFormatResource, please refer to the document of RelationshipResourceFormatResource
            string subscriptionId = "subid";
            string resourceGroupName = "TestHubRG";
            string hubName = "sdkTestHub";
            string relationshipName = "SomeRelationship";
            ResourceIdentifier relationshipResourceFormatResourceId = RelationshipResourceFormatResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, hubName, relationshipName);
            RelationshipResourceFormatResource relationshipResourceFormat = client.GetRelationshipResourceFormatResource(relationshipResourceFormatResourceId);

            // invoke the operation
            RelationshipResourceFormatData data = new RelationshipResourceFormatData()
            {
                Cardinality = CardinalityType.OneToOne,
                DisplayName =
{
["en-us"] = "Relationship DisplayName",
},
                Description =
{
["en-us"] = "Relationship Description",
},
                Fields =
{
},
                ProfileType = "testProfile2326994",
                RelatedProfileType = "testProfile2326994",
            };
            ArmOperation<RelationshipResourceFormatResource> lro = await relationshipResourceFormat.UpdateAsync(WaitUntil.Completed, data);
            RelationshipResourceFormatResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            RelationshipResourceFormatData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Relationships_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_RelationshipsGet()
        {
            // Generated from example definition: specification/customer-insights/resource-manager/Microsoft.CustomerInsights/stable/2017-04-26/examples/RelationshipsGet.json
            // this example is just showing the usage of "Relationships_Get" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this RelationshipResourceFormatResource created on azure
            // for more information of creating RelationshipResourceFormatResource, please refer to the document of RelationshipResourceFormatResource
            string subscriptionId = "subid";
            string resourceGroupName = "TestHubRG";
            string hubName = "sdkTestHub";
            string relationshipName = "SomeRelationship";
            ResourceIdentifier relationshipResourceFormatResourceId = RelationshipResourceFormatResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, hubName, relationshipName);
            RelationshipResourceFormatResource relationshipResourceFormat = client.GetRelationshipResourceFormatResource(relationshipResourceFormatResourceId);

            // invoke the operation
            RelationshipResourceFormatResource result = await relationshipResourceFormat.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            RelationshipResourceFormatData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Relationships_Delete
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_RelationshipsDelete()
        {
            // Generated from example definition: specification/customer-insights/resource-manager/Microsoft.CustomerInsights/stable/2017-04-26/examples/RelationshipsDelete.json
            // this example is just showing the usage of "Relationships_Delete" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this RelationshipResourceFormatResource created on azure
            // for more information of creating RelationshipResourceFormatResource, please refer to the document of RelationshipResourceFormatResource
            string subscriptionId = "subid";
            string resourceGroupName = "TestHubRG";
            string hubName = "sdkTestHub";
            string relationshipName = "SomeRelationship";
            ResourceIdentifier relationshipResourceFormatResourceId = RelationshipResourceFormatResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, hubName, relationshipName);
            RelationshipResourceFormatResource relationshipResourceFormat = client.GetRelationshipResourceFormatResource(relationshipResourceFormatResourceId);

            // invoke the operation
            await relationshipResourceFormat.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }
    }
}
