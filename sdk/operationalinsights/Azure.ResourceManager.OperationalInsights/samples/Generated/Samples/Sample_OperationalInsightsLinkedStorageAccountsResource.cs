// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.OperationalInsights.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.OperationalInsights.Samples
{
    public partial class Sample_OperationalInsightsLinkedStorageAccountsResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_LinkedStorageAccountsGet()
        {
            // Generated from example definition: specification/operationalinsights/resource-manager/Microsoft.OperationalInsights/stable/2020-08-01/examples/LinkedStorageAccountsGet.json
            // this example is just showing the usage of "LinkedStorageAccounts_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this OperationalInsightsLinkedStorageAccountsResource created on azure
            // for more information of creating OperationalInsightsLinkedStorageAccountsResource, please refer to the document of OperationalInsightsLinkedStorageAccountsResource
            string subscriptionId = "00000000-0000-0000-0000-00000000000";
            string resourceGroupName = "mms-eus";
            string workspaceName = "testLinkStorageAccountsWS";
            OperationalInsightsDataSourceType dataSourceType = OperationalInsightsDataSourceType.CustomLogs;
            ResourceIdentifier operationalInsightsLinkedStorageAccountsResourceId = OperationalInsightsLinkedStorageAccountsResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, dataSourceType);
            OperationalInsightsLinkedStorageAccountsResource operationalInsightsLinkedStorageAccounts = client.GetOperationalInsightsLinkedStorageAccountsResource(operationalInsightsLinkedStorageAccountsResourceId);

            // invoke the operation
            OperationalInsightsLinkedStorageAccountsResource result = await operationalInsightsLinkedStorageAccounts.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            OperationalInsightsLinkedStorageAccountsData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_LinkedStorageAccountsDelete()
        {
            // Generated from example definition: specification/operationalinsights/resource-manager/Microsoft.OperationalInsights/stable/2020-08-01/examples/LinkedStorageAccountsDelete.json
            // this example is just showing the usage of "LinkedStorageAccounts_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this OperationalInsightsLinkedStorageAccountsResource created on azure
            // for more information of creating OperationalInsightsLinkedStorageAccountsResource, please refer to the document of OperationalInsightsLinkedStorageAccountsResource
            string subscriptionId = "00000000-0000-0000-0000-00000000000";
            string resourceGroupName = "mms-eus";
            string workspaceName = "testLinkStorageAccountsWS";
            OperationalInsightsDataSourceType dataSourceType = OperationalInsightsDataSourceType.CustomLogs;
            ResourceIdentifier operationalInsightsLinkedStorageAccountsResourceId = OperationalInsightsLinkedStorageAccountsResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, dataSourceType);
            OperationalInsightsLinkedStorageAccountsResource operationalInsightsLinkedStorageAccounts = client.GetOperationalInsightsLinkedStorageAccountsResource(operationalInsightsLinkedStorageAccountsResourceId);

            // invoke the operation
            await operationalInsightsLinkedStorageAccounts.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_LinkedStorageAccountsCreate()
        {
            // Generated from example definition: specification/operationalinsights/resource-manager/Microsoft.OperationalInsights/stable/2020-08-01/examples/LinkedStorageAccountsCreate.json
            // this example is just showing the usage of "LinkedStorageAccounts_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this OperationalInsightsLinkedStorageAccountsResource created on azure
            // for more information of creating OperationalInsightsLinkedStorageAccountsResource, please refer to the document of OperationalInsightsLinkedStorageAccountsResource
            string subscriptionId = "00000000-0000-0000-0000-00000000000";
            string resourceGroupName = "mms-eus";
            string workspaceName = "testLinkStorageAccountsWS";
            OperationalInsightsDataSourceType dataSourceType = OperationalInsightsDataSourceType.CustomLogs;
            ResourceIdentifier operationalInsightsLinkedStorageAccountsResourceId = OperationalInsightsLinkedStorageAccountsResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, dataSourceType);
            OperationalInsightsLinkedStorageAccountsResource operationalInsightsLinkedStorageAccounts = client.GetOperationalInsightsLinkedStorageAccountsResource(operationalInsightsLinkedStorageAccountsResourceId);

            // invoke the operation
            OperationalInsightsLinkedStorageAccountsData data = new OperationalInsightsLinkedStorageAccountsData
            {
                StorageAccountIds = { new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-00000000000/resourceGroups/mms-eus/providers/Microsoft.Storage/storageAccounts/testStorageA"), new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-00000000000/resourceGroups/mms-eus/providers/Microsoft.Storage/storageAccounts/testStorageB") },
            };
            ArmOperation<OperationalInsightsLinkedStorageAccountsResource> lro = await operationalInsightsLinkedStorageAccounts.UpdateAsync(WaitUntil.Completed, data);
            OperationalInsightsLinkedStorageAccountsResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            OperationalInsightsLinkedStorageAccountsData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
