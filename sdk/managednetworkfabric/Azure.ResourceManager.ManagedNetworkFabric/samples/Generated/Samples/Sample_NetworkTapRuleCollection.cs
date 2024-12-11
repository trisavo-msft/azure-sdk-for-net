// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.ManagedNetworkFabric.Models;
using Azure.ResourceManager.Resources;
using NUnit.Framework;

namespace Azure.ResourceManager.ManagedNetworkFabric.Samples
{
    public partial class Sample_NetworkTapRuleCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_NetworkTapRulesCreateMaximumSetGen()
        {
            // Generated from example definition: specification/managednetworkfabric/resource-manager/Microsoft.ManagedNetworkFabric/stable/2023-06-15/examples/NetworkTapRules_Create_MaximumSet_Gen.json
            // this example is just showing the usage of "NetworkTapRules_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "1234ABCD-0A1B-1234-5678-123456ABCDEF";
            string resourceGroupName = "example-rg";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this NetworkTapRuleResource
            NetworkTapRuleCollection collection = resourceGroupResource.GetNetworkTapRules();

            // invoke the operation
            string networkTapRuleName = "example-tapRule";
            NetworkTapRuleData data = new NetworkTapRuleData(new AzureLocation("eastus"))
            {
                Annotation = "annotation",
                ConfigurationType = NetworkFabricConfigurationType.File,
                TapRulesUri = new Uri("https://microsoft.com/a"),
                MatchConfigurations = {new NetworkTapRuleMatchConfiguration
{
MatchConfigurationName = "config1",
SequenceNumber = 10L,
IPAddressType = NetworkFabricIPAddressType.IPv4,
MatchConditions = {new NetworkTapRuleMatchCondition
{
EncapsulationType = NetworkTapEncapsulationType.None,
PortCondition = new NetworkFabricPortCondition(Layer4Protocol.Tcp)
{
PortType = NetworkFabricPortType.SourcePort,
Ports = {"100"},
PortGroupNames = {"example-portGroup1"},
},
ProtocolTypes = {"TCP"},
VlanMatchCondition = new VlanMatchCondition
{
Vlans = {"10"},
InnerVlans = {"11-20"},
VlanGroupNames = {"exmaple-vlanGroup"},
},
IPCondition = new IPMatchCondition
{
SourceDestinationType = SourceDestinationType.SourceIP,
PrefixType = IPMatchConditionPrefixType.Prefix,
IPPrefixValues = {"10.10.10.10/20"},
IPGroupNames = {"example-ipGroup"},
},
}},
Actions = {new NetworkTapRuleAction
{
TapRuleActionType = TapRuleActionType.Drop,
Truncate = "100",
IsTimestampEnabled = NetworkFabricBooleanValue.True,
DestinationId = new ResourceIdentifier("/subscriptions/1234ABCD-0A1B-1234-5678-123456ABCDEF/resourcegroups/example-rg/providers/Microsoft.ManagedNetworkFabric/neighborGroups/example-neighborGroup"),
MatchConfigurationName = "match1",
}},
}},
                DynamicMatchConfigurations = {new CommonDynamicMatchConfiguration
{
IPGroups = {new MatchConfigurationIPGroupProperties
{
Name = "example-ipGroup1",
IPAddressType = NetworkFabricIPAddressType.IPv4,
IPPrefixes = {"10.10.10.10/30"},
}},
VlanGroups = {new VlanGroupProperties
{
Name = "exmaple-vlanGroup",
Vlans = {"10", "100-200"},
}},
PortGroups = {new PortGroupProperties
{
Name = "example-portGroup1",
Ports = {"100-200"},
}, new PortGroupProperties
{
Name = "example-portGroup2",
Ports = {"900", "1000-2000"},
}},
}},
                PollingIntervalInSeconds = PollingIntervalInSecond.Thirty,
                Tags =
{
["keyID"] = "keyValue"
},
            };
            ArmOperation<NetworkTapRuleResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, networkTapRuleName, data);
            NetworkTapRuleResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NetworkTapRuleData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_NetworkTapRulesGetMaximumSetGen()
        {
            // Generated from example definition: specification/managednetworkfabric/resource-manager/Microsoft.ManagedNetworkFabric/stable/2023-06-15/examples/NetworkTapRules_Get_MaximumSet_Gen.json
            // this example is just showing the usage of "NetworkTapRules_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "1234ABCD-0A1B-1234-5678-123456ABCDEF";
            string resourceGroupName = "example-rg";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this NetworkTapRuleResource
            NetworkTapRuleCollection collection = resourceGroupResource.GetNetworkTapRules();

            // invoke the operation
            string networkTapRuleName = "example-tapRule";
            NetworkTapRuleResource result = await collection.GetAsync(networkTapRuleName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NetworkTapRuleData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_NetworkTapRulesListByResourceGroupMaximumSetGen()
        {
            // Generated from example definition: specification/managednetworkfabric/resource-manager/Microsoft.ManagedNetworkFabric/stable/2023-06-15/examples/NetworkTapRules_ListByResourceGroup_MaximumSet_Gen.json
            // this example is just showing the usage of "NetworkTapRules_ListByResourceGroup" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "1234ABCD-0A1B-1234-5678-123456ABCDEF";
            string resourceGroupName = "example-rg";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this NetworkTapRuleResource
            NetworkTapRuleCollection collection = resourceGroupResource.GetNetworkTapRules();

            // invoke the operation and iterate over the result
            await foreach (NetworkTapRuleResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                NetworkTapRuleData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_NetworkTapRulesGetMaximumSetGen()
        {
            // Generated from example definition: specification/managednetworkfabric/resource-manager/Microsoft.ManagedNetworkFabric/stable/2023-06-15/examples/NetworkTapRules_Get_MaximumSet_Gen.json
            // this example is just showing the usage of "NetworkTapRules_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "1234ABCD-0A1B-1234-5678-123456ABCDEF";
            string resourceGroupName = "example-rg";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this NetworkTapRuleResource
            NetworkTapRuleCollection collection = resourceGroupResource.GetNetworkTapRules();

            // invoke the operation
            string networkTapRuleName = "example-tapRule";
            bool result = await collection.ExistsAsync(networkTapRuleName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_NetworkTapRulesGetMaximumSetGen()
        {
            // Generated from example definition: specification/managednetworkfabric/resource-manager/Microsoft.ManagedNetworkFabric/stable/2023-06-15/examples/NetworkTapRules_Get_MaximumSet_Gen.json
            // this example is just showing the usage of "NetworkTapRules_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "1234ABCD-0A1B-1234-5678-123456ABCDEF";
            string resourceGroupName = "example-rg";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this NetworkTapRuleResource
            NetworkTapRuleCollection collection = resourceGroupResource.GetNetworkTapRules();

            // invoke the operation
            string networkTapRuleName = "example-tapRule";
            NullableResponse<NetworkTapRuleResource> response = await collection.GetIfExistsAsync(networkTapRuleName);
            NetworkTapRuleResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                NetworkTapRuleData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
