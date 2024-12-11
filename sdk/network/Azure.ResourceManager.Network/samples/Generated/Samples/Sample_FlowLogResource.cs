// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Network.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.Network.Samples
{
    public partial class Sample_FlowLogResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetFlowLog()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/NetworkWatcherFlowLogGet.json
            // this example is just showing the usage of "FlowLogs_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this FlowLogResource created on azure
            // for more information of creating FlowLogResource, please refer to the document of FlowLogResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string networkWatcherName = "nw1";
            string flowLogName = "flowLog1";
            ResourceIdentifier flowLogResourceId = FlowLogResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkWatcherName, flowLogName);
            FlowLogResource flowLog = client.GetFlowLogResource(flowLogResourceId);

            // invoke the operation
            FlowLogResource result = await flowLog.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            FlowLogData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_DeleteFlowLog()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/NetworkWatcherFlowLogDelete.json
            // this example is just showing the usage of "FlowLogs_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this FlowLogResource created on azure
            // for more information of creating FlowLogResource, please refer to the document of FlowLogResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string networkWatcherName = "nw1";
            string flowLogName = "fl";
            ResourceIdentifier flowLogResourceId = FlowLogResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkWatcherName, flowLogName);
            FlowLogResource flowLog = client.GetFlowLogResource(flowLogResourceId);

            // invoke the operation
            await flowLog.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_UpdateFlowLogTags()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/NetworkWatcherFlowLogUpdateTags.json
            // this example is just showing the usage of "FlowLogs_UpdateTags" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this FlowLogResource created on azure
            // for more information of creating FlowLogResource, please refer to the document of FlowLogResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string networkWatcherName = "nw";
            string flowLogName = "fl";
            ResourceIdentifier flowLogResourceId = FlowLogResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkWatcherName, flowLogName);
            FlowLogResource flowLog = client.GetFlowLogResource(flowLogResourceId);

            // invoke the operation
            NetworkTagsObject networkTagsObject = new NetworkTagsObject
            {
                Tags =
{
["tag1"] = "value1",
["tag2"] = "value2"
},
            };
            FlowLogResource result = await flowLog.UpdateAsync(networkTagsObject);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            FlowLogData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
