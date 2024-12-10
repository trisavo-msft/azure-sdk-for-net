// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.ResourceManager.Logic.Samples
{
    public partial class Sample_IntegrationAccountSessionCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_CreateOrUpdateAnIntegrationAccountSession()
        {
            // Generated from example definition: specification/logic/resource-manager/Microsoft.Logic/stable/2019-05-01/examples/IntegrationAccountSessions_CreateOrUpdate.json
            // this example is just showing the usage of "IntegrationAccountSessions_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this IntegrationAccountResource created on azure
            // for more information of creating IntegrationAccountResource, please refer to the document of IntegrationAccountResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "testrg123";
            string integrationAccountName = "testia123";
            ResourceIdentifier integrationAccountResourceId = IntegrationAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, integrationAccountName);
            IntegrationAccountResource integrationAccount = client.GetIntegrationAccountResource(integrationAccountResourceId);

            // get the collection of this IntegrationAccountSessionResource
            IntegrationAccountSessionCollection collection = integrationAccount.GetIntegrationAccountSessions();

            // invoke the operation
            string sessionName = "testsession123-ICN";
            IntegrationAccountSessionData data = new IntegrationAccountSessionData(default)
            {
                Content = BinaryData.FromObjectAsJson(new
                {
                    controlNumber = "1234",
                    controlNumberChangedTime = "2017-02-21T22:30:11.9923759Z",
                }),
            };
            ArmOperation<IntegrationAccountSessionResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, sessionName, data);
            IntegrationAccountSessionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            IntegrationAccountSessionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetAnIntegrationAccountSession()
        {
            // Generated from example definition: specification/logic/resource-manager/Microsoft.Logic/stable/2019-05-01/examples/IntegrationAccountSessions_Get.json
            // this example is just showing the usage of "IntegrationAccountSessions_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this IntegrationAccountResource created on azure
            // for more information of creating IntegrationAccountResource, please refer to the document of IntegrationAccountResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "testrg123";
            string integrationAccountName = "testia123";
            ResourceIdentifier integrationAccountResourceId = IntegrationAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, integrationAccountName);
            IntegrationAccountResource integrationAccount = client.GetIntegrationAccountResource(integrationAccountResourceId);

            // get the collection of this IntegrationAccountSessionResource
            IntegrationAccountSessionCollection collection = integrationAccount.GetIntegrationAccountSessions();

            // invoke the operation
            string sessionName = "testsession123-ICN";
            IntegrationAccountSessionResource result = await collection.GetAsync(sessionName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            IntegrationAccountSessionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_GetAListOfIntegrationAccountSessions()
        {
            // Generated from example definition: specification/logic/resource-manager/Microsoft.Logic/stable/2019-05-01/examples/IntegrationAccountSessions_List.json
            // this example is just showing the usage of "IntegrationAccountSessions_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this IntegrationAccountResource created on azure
            // for more information of creating IntegrationAccountResource, please refer to the document of IntegrationAccountResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "testrg123";
            string integrationAccountName = "testia123";
            ResourceIdentifier integrationAccountResourceId = IntegrationAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, integrationAccountName);
            IntegrationAccountResource integrationAccount = client.GetIntegrationAccountResource(integrationAccountResourceId);

            // get the collection of this IntegrationAccountSessionResource
            IntegrationAccountSessionCollection collection = integrationAccount.GetIntegrationAccountSessions();

            // invoke the operation and iterate over the result
            await foreach (IntegrationAccountSessionResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                IntegrationAccountSessionData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_GetAnIntegrationAccountSession()
        {
            // Generated from example definition: specification/logic/resource-manager/Microsoft.Logic/stable/2019-05-01/examples/IntegrationAccountSessions_Get.json
            // this example is just showing the usage of "IntegrationAccountSessions_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this IntegrationAccountResource created on azure
            // for more information of creating IntegrationAccountResource, please refer to the document of IntegrationAccountResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "testrg123";
            string integrationAccountName = "testia123";
            ResourceIdentifier integrationAccountResourceId = IntegrationAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, integrationAccountName);
            IntegrationAccountResource integrationAccount = client.GetIntegrationAccountResource(integrationAccountResourceId);

            // get the collection of this IntegrationAccountSessionResource
            IntegrationAccountSessionCollection collection = integrationAccount.GetIntegrationAccountSessions();

            // invoke the operation
            string sessionName = "testsession123-ICN";
            bool result = await collection.ExistsAsync(sessionName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_GetAnIntegrationAccountSession()
        {
            // Generated from example definition: specification/logic/resource-manager/Microsoft.Logic/stable/2019-05-01/examples/IntegrationAccountSessions_Get.json
            // this example is just showing the usage of "IntegrationAccountSessions_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this IntegrationAccountResource created on azure
            // for more information of creating IntegrationAccountResource, please refer to the document of IntegrationAccountResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "testrg123";
            string integrationAccountName = "testia123";
            ResourceIdentifier integrationAccountResourceId = IntegrationAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, integrationAccountName);
            IntegrationAccountResource integrationAccount = client.GetIntegrationAccountResource(integrationAccountResourceId);

            // get the collection of this IntegrationAccountSessionResource
            IntegrationAccountSessionCollection collection = integrationAccount.GetIntegrationAccountSessions();

            // invoke the operation
            string sessionName = "testsession123-ICN";
            NullableResponse<IntegrationAccountSessionResource> response = await collection.GetIfExistsAsync(sessionName);
            IntegrationAccountSessionResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                IntegrationAccountSessionData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
