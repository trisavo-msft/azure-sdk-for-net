// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.ResourceManager.Batch.Samples
{
    public partial class Sample_NetworkSecurityPerimeterConfigurationCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetNspConfiguration()
        {
            // Generated from example definition: specification/batch/resource-manager/Microsoft.Batch/stable/2024-07-01/examples/NspConfigurationGet.json
            // this example is just showing the usage of "NetworkSecurityPerimeter_GetConfiguration" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BatchAccountResource created on azure
            // for more information of creating BatchAccountResource, please refer to the document of BatchAccountResource
            string subscriptionId = "subid";
            string resourceGroupName = "default-azurebatch-japaneast";
            string accountName = "sampleacct";
            ResourceIdentifier batchAccountResourceId = BatchAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            BatchAccountResource batchAccount = client.GetBatchAccountResource(batchAccountResourceId);

            // get the collection of this NetworkSecurityPerimeterConfigurationResource
            NetworkSecurityPerimeterConfigurationCollection collection = batchAccount.GetNetworkSecurityPerimeterConfigurations();

            // invoke the operation
            string networkSecurityPerimeterConfigurationName = "00000000-0000-0000-0000-000000000000.sampleassociation";
            NetworkSecurityPerimeterConfigurationResource result = await collection.GetAsync(networkSecurityPerimeterConfigurationName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NetworkSecurityPerimeterConfigurationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_ListNspConfigurations()
        {
            // Generated from example definition: specification/batch/resource-manager/Microsoft.Batch/stable/2024-07-01/examples/NspConfigurationsList.json
            // this example is just showing the usage of "NetworkSecurityPerimeter_ListConfigurations" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BatchAccountResource created on azure
            // for more information of creating BatchAccountResource, please refer to the document of BatchAccountResource
            string subscriptionId = "subid";
            string resourceGroupName = "default-azurebatch-japaneast";
            string accountName = "sampleacct";
            ResourceIdentifier batchAccountResourceId = BatchAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            BatchAccountResource batchAccount = client.GetBatchAccountResource(batchAccountResourceId);

            // get the collection of this NetworkSecurityPerimeterConfigurationResource
            NetworkSecurityPerimeterConfigurationCollection collection = batchAccount.GetNetworkSecurityPerimeterConfigurations();

            // invoke the operation and iterate over the result
            await foreach (NetworkSecurityPerimeterConfigurationResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                NetworkSecurityPerimeterConfigurationData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_GetNspConfiguration()
        {
            // Generated from example definition: specification/batch/resource-manager/Microsoft.Batch/stable/2024-07-01/examples/NspConfigurationGet.json
            // this example is just showing the usage of "NetworkSecurityPerimeter_GetConfiguration" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BatchAccountResource created on azure
            // for more information of creating BatchAccountResource, please refer to the document of BatchAccountResource
            string subscriptionId = "subid";
            string resourceGroupName = "default-azurebatch-japaneast";
            string accountName = "sampleacct";
            ResourceIdentifier batchAccountResourceId = BatchAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            BatchAccountResource batchAccount = client.GetBatchAccountResource(batchAccountResourceId);

            // get the collection of this NetworkSecurityPerimeterConfigurationResource
            NetworkSecurityPerimeterConfigurationCollection collection = batchAccount.GetNetworkSecurityPerimeterConfigurations();

            // invoke the operation
            string networkSecurityPerimeterConfigurationName = "00000000-0000-0000-0000-000000000000.sampleassociation";
            bool result = await collection.ExistsAsync(networkSecurityPerimeterConfigurationName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_GetNspConfiguration()
        {
            // Generated from example definition: specification/batch/resource-manager/Microsoft.Batch/stable/2024-07-01/examples/NspConfigurationGet.json
            // this example is just showing the usage of "NetworkSecurityPerimeter_GetConfiguration" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BatchAccountResource created on azure
            // for more information of creating BatchAccountResource, please refer to the document of BatchAccountResource
            string subscriptionId = "subid";
            string resourceGroupName = "default-azurebatch-japaneast";
            string accountName = "sampleacct";
            ResourceIdentifier batchAccountResourceId = BatchAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            BatchAccountResource batchAccount = client.GetBatchAccountResource(batchAccountResourceId);

            // get the collection of this NetworkSecurityPerimeterConfigurationResource
            NetworkSecurityPerimeterConfigurationCollection collection = batchAccount.GetNetworkSecurityPerimeterConfigurations();

            // invoke the operation
            string networkSecurityPerimeterConfigurationName = "00000000-0000-0000-0000-000000000000.sampleassociation";
            NullableResponse<NetworkSecurityPerimeterConfigurationResource> response = await collection.GetIfExistsAsync(networkSecurityPerimeterConfigurationName);
            NetworkSecurityPerimeterConfigurationResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                NetworkSecurityPerimeterConfigurationData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
