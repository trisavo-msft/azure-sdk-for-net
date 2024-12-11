// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.ResourceManager.Relay.Samples
{
    public partial class Sample_RelayHybridConnectionResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_RelayHybridConnectionGet()
        {
            // Generated from example definition: specification/relay/resource-manager/Microsoft.Relay/stable/2021-11-01/examples/HybridConnection/RelayHybridConnectionGet.json
            // this example is just showing the usage of "HybridConnections_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this RelayHybridConnectionResource created on azure
            // for more information of creating RelayHybridConnectionResource, please refer to the document of RelayHybridConnectionResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            string resourceGroupName = "resourcegroup";
            string namespaceName = "example-RelayNamespace-01";
            string hybridConnectionName = "example-Relay-Hybrid-01";
            ResourceIdentifier relayHybridConnectionResourceId = RelayHybridConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, namespaceName, hybridConnectionName);
            RelayHybridConnectionResource relayHybridConnection = client.GetRelayHybridConnectionResource(relayHybridConnectionResourceId);

            // invoke the operation
            RelayHybridConnectionResource result = await relayHybridConnection.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            RelayHybridConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_RelayHybridconnectionDelete()
        {
            // Generated from example definition: specification/relay/resource-manager/Microsoft.Relay/stable/2021-11-01/examples/HybridConnection/RelayHybridconnectionDelete.json
            // this example is just showing the usage of "HybridConnections_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this RelayHybridConnectionResource created on azure
            // for more information of creating RelayHybridConnectionResource, please refer to the document of RelayHybridConnectionResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            string resourceGroupName = "resourcegroup";
            string namespaceName = "example-RelayNamespace-01";
            string hybridConnectionName = "example-Relay-Hybrid-01";
            ResourceIdentifier relayHybridConnectionResourceId = RelayHybridConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, namespaceName, hybridConnectionName);
            RelayHybridConnectionResource relayHybridConnection = client.GetRelayHybridConnectionResource(relayHybridConnectionResourceId);

            // invoke the operation
            await relayHybridConnection.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_RelayHybridConnectionCreate()
        {
            // Generated from example definition: specification/relay/resource-manager/Microsoft.Relay/stable/2021-11-01/examples/HybridConnection/RelayHybridConnectionCreate.json
            // this example is just showing the usage of "HybridConnections_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this RelayHybridConnectionResource created on azure
            // for more information of creating RelayHybridConnectionResource, please refer to the document of RelayHybridConnectionResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            string resourceGroupName = "resourcegroup";
            string namespaceName = "example-RelayNamespace-01";
            string hybridConnectionName = "example-Relay-Hybrid-01";
            ResourceIdentifier relayHybridConnectionResourceId = RelayHybridConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, namespaceName, hybridConnectionName);
            RelayHybridConnectionResource relayHybridConnection = client.GetRelayHybridConnectionResource(relayHybridConnectionResourceId);

            // invoke the operation
            RelayHybridConnectionData data = new RelayHybridConnectionData
            {
                IsClientAuthorizationRequired = true,
            };
            ArmOperation<RelayHybridConnectionResource> lro = await relayHybridConnection.UpdateAsync(WaitUntil.Completed, data);
            RelayHybridConnectionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            RelayHybridConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
