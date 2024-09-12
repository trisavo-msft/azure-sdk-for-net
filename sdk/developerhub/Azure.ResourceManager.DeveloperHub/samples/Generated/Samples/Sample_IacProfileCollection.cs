// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.DeveloperHub.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.DeveloperHub.Samples
{
    public partial class Sample_IacProfileCollection
    {
        // List IacProfiles
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ListIacProfiles()
        {
            // Generated from example definition: specification/developerhub/resource-manager/Microsoft.DevHub/preview/2024-05-01-preview/examples/IacProfile_ListByResourceGroup.json
            // this example is just showing the usage of "IacProfiles_ListByResourceGroup" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "a0a37f63-7183-4e86-9ac7-ce8036a3ed31";
            string resourceGroupName = "resourceGroup1";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this IacProfileResource
            IacProfileCollection collection = resourceGroupResource.GetIacProfiles();

            // invoke the operation and iterate over the result
            await foreach (IacProfileResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                IacProfileData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Get IacProfile
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetIacProfile()
        {
            // Generated from example definition: specification/developerhub/resource-manager/Microsoft.DevHub/preview/2024-05-01-preview/examples/IacProfile_Get.json
            // this example is just showing the usage of "IacProfiles_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "a0a37f63-7183-4e86-9ac7-ce8036a3ed31";
            string resourceGroupName = "resourceGroup1";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this IacProfileResource
            IacProfileCollection collection = resourceGroupResource.GetIacProfiles();

            // invoke the operation
            string iacProfileName = "iacprofile";
            IacProfileResource result = await collection.GetAsync(iacProfileName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            IacProfileData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get IacProfile
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetIacProfile()
        {
            // Generated from example definition: specification/developerhub/resource-manager/Microsoft.DevHub/preview/2024-05-01-preview/examples/IacProfile_Get.json
            // this example is just showing the usage of "IacProfiles_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "a0a37f63-7183-4e86-9ac7-ce8036a3ed31";
            string resourceGroupName = "resourceGroup1";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this IacProfileResource
            IacProfileCollection collection = resourceGroupResource.GetIacProfiles();

            // invoke the operation
            string iacProfileName = "iacprofile";
            bool result = await collection.ExistsAsync(iacProfileName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Get IacProfile
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_GetIacProfile()
        {
            // Generated from example definition: specification/developerhub/resource-manager/Microsoft.DevHub/preview/2024-05-01-preview/examples/IacProfile_Get.json
            // this example is just showing the usage of "IacProfiles_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "a0a37f63-7183-4e86-9ac7-ce8036a3ed31";
            string resourceGroupName = "resourceGroup1";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this IacProfileResource
            IacProfileCollection collection = resourceGroupResource.GetIacProfiles();

            // invoke the operation
            string iacProfileName = "iacprofile";
            NullableResponse<IacProfileResource> response = await collection.GetIfExistsAsync(iacProfileName);
            IacProfileResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                IacProfileData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // Create IacProfile
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateIacProfile()
        {
            // Generated from example definition: specification/developerhub/resource-manager/Microsoft.DevHub/preview/2024-05-01-preview/examples/IacProfile_CreateOrUpdate.json
            // this example is just showing the usage of "IacProfiles_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "a0a37f63-7183-4e86-9ac7-ce8036a3ed31";
            string resourceGroupName = "resourceGroup1";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this IacProfileResource
            IacProfileCollection collection = resourceGroupResource.GetIacProfiles();

            // invoke the operation
            string iacProfileName = "profile1";
            IacProfileData data = new IacProfileData(new AzureLocation("eastus"))
            {
                Stages =
{
new StageProperties()
{
StageName = "dev",
Dependencies =
{
},
GitEnvironment = "Terraform",
},new StageProperties()
{
StageName = "qa",
Dependencies =
{
"dev"
},
GitEnvironment = "Terraform",
}
},
                Templates =
{
new IacTemplateProperties()
{
TemplateName = "hciaksss",
InstanceStage = "dev",
InstanceName = "quickinstance",
QuickStartTemplateType = QuickStartTemplateType.Hciaks,
}
},
                StorageAccountSubscription = "586c20df-c465-4f10-8673-65aa4859e7ca",
                StorageAccountResourceGroup = "test",
                StorageAccountName = "iacbackend",
                StorageContainerName = "tfbackend",
                RepositoryName = "localtest",
                RepositoryOwner = "qfai",
            };
            ArmOperation<IacProfileResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, iacProfileName, data);
            IacProfileResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            IacProfileData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
