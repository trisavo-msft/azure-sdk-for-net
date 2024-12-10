// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.ContainerOrchestratorRuntime.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.ContainerOrchestratorRuntime.Samples
{
    public partial class Sample_ConnectedClusterBgpPeerResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_BgpPeersGet()
        {
            // Generated from example definition: 2024-03-01/BgpPeers_Get.json
            // this example is just showing the usage of "BgpPeer_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ConnectedClusterBgpPeerResource created on azure
            // for more information of creating ConnectedClusterBgpPeerResource, please refer to the document of ConnectedClusterBgpPeerResource
            string resourceUri = "subscriptions/00000000-1111-2222-3333-444444444444/resourceGroups/example/providers/Microsoft.Kubernetes/connectedClusters/cluster1";
            string bgpPeerName = "testpeer";
            ResourceIdentifier connectedClusterBgpPeerResourceId = ConnectedClusterBgpPeerResource.CreateResourceIdentifier(resourceUri, bgpPeerName);
            ConnectedClusterBgpPeerResource connectedClusterBgpPeer = client.GetConnectedClusterBgpPeerResource(connectedClusterBgpPeerResourceId);

            // invoke the operation
            ConnectedClusterBgpPeerResource result = await connectedClusterBgpPeer.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ConnectedClusterBgpPeerData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_BgpPeersDelete()
        {
            // Generated from example definition: 2024-03-01/BgpPeers_Delete.json
            // this example is just showing the usage of "BgpPeer_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ConnectedClusterBgpPeerResource created on azure
            // for more information of creating ConnectedClusterBgpPeerResource, please refer to the document of ConnectedClusterBgpPeerResource
            string resourceUri = "subscriptions/00000000-1111-2222-3333-444444444444/resourceGroups/example/providers/Microsoft.Kubernetes/connectedClusters/cluster1";
            string bgpPeerName = "testpeer";
            ResourceIdentifier connectedClusterBgpPeerResourceId = ConnectedClusterBgpPeerResource.CreateResourceIdentifier(resourceUri, bgpPeerName);
            ConnectedClusterBgpPeerResource connectedClusterBgpPeer = client.GetConnectedClusterBgpPeerResource(connectedClusterBgpPeerResourceId);

            // invoke the operation
            await connectedClusterBgpPeer.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_BgpPeersCreateOrUpdate()
        {
            // Generated from example definition: 2024-03-01/BgpPeers_CreateOrUpdate.json
            // this example is just showing the usage of "BgpPeer_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ConnectedClusterBgpPeerResource created on azure
            // for more information of creating ConnectedClusterBgpPeerResource, please refer to the document of ConnectedClusterBgpPeerResource
            string resourceUri = "subscriptions/00000000-1111-2222-3333-444444444444/resourceGroups/example/providers/Microsoft.Kubernetes/connectedClusters/cluster1";
            string bgpPeerName = "testpeer";
            ResourceIdentifier connectedClusterBgpPeerResourceId = ConnectedClusterBgpPeerResource.CreateResourceIdentifier(resourceUri, bgpPeerName);
            ConnectedClusterBgpPeerResource connectedClusterBgpPeer = client.GetConnectedClusterBgpPeerResource(connectedClusterBgpPeerResourceId);

            // invoke the operation
            ConnectedClusterBgpPeerData data = new ConnectedClusterBgpPeerData
            {
                Properties = new ConnectedClusterBgpPeerProperties(64500, 64501, "10.0.0.1"),
            };
            ArmOperation<ConnectedClusterBgpPeerResource> lro = await connectedClusterBgpPeer.UpdateAsync(WaitUntil.Completed, data);
            ConnectedClusterBgpPeerResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ConnectedClusterBgpPeerData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
