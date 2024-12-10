// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.ResourceManager.DataBoxEdge.Samples
{
    public partial class Sample_DataBoxEdgeAlertCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_AlertGet()
        {
            // Generated from example definition: specification/databoxedge/resource-manager/Microsoft.DataBoxEdge/stable/2022-03-01/examples/AlertGet.json
            // this example is just showing the usage of "Alerts_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataBoxEdgeDeviceResource created on azure
            // for more information of creating DataBoxEdgeDeviceResource, please refer to the document of DataBoxEdgeDeviceResource
            string subscriptionId = "4385cf00-2d3a-425a-832f-f4285b1c9dce";
            string resourceGroupName = "GroupForEdgeAutomation";
            string deviceName = "testedgedevice";
            ResourceIdentifier dataBoxEdgeDeviceResourceId = DataBoxEdgeDeviceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, deviceName);
            DataBoxEdgeDeviceResource dataBoxEdgeDevice = client.GetDataBoxEdgeDeviceResource(dataBoxEdgeDeviceResourceId);

            // get the collection of this DataBoxEdgeAlertResource
            DataBoxEdgeAlertCollection collection = dataBoxEdgeDevice.GetDataBoxEdgeAlerts();

            // invoke the operation
            string name = "159a00c7-8543-4343-9435-263ac87df3bb";
            DataBoxEdgeAlertResource result = await collection.GetAsync(name);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DataBoxEdgeAlertData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_AlertGetAllInDevice()
        {
            // Generated from example definition: specification/databoxedge/resource-manager/Microsoft.DataBoxEdge/stable/2022-03-01/examples/AlertGetAllInDevice.json
            // this example is just showing the usage of "Alerts_ListByDataBoxEdgeDevice" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataBoxEdgeDeviceResource created on azure
            // for more information of creating DataBoxEdgeDeviceResource, please refer to the document of DataBoxEdgeDeviceResource
            string subscriptionId = "4385cf00-2d3a-425a-832f-f4285b1c9dce";
            string resourceGroupName = "GroupForEdgeAutomation";
            string deviceName = "testedgedevice";
            ResourceIdentifier dataBoxEdgeDeviceResourceId = DataBoxEdgeDeviceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, deviceName);
            DataBoxEdgeDeviceResource dataBoxEdgeDevice = client.GetDataBoxEdgeDeviceResource(dataBoxEdgeDeviceResourceId);

            // get the collection of this DataBoxEdgeAlertResource
            DataBoxEdgeAlertCollection collection = dataBoxEdgeDevice.GetDataBoxEdgeAlerts();

            // invoke the operation and iterate over the result
            await foreach (DataBoxEdgeAlertResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                DataBoxEdgeAlertData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_AlertGet()
        {
            // Generated from example definition: specification/databoxedge/resource-manager/Microsoft.DataBoxEdge/stable/2022-03-01/examples/AlertGet.json
            // this example is just showing the usage of "Alerts_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataBoxEdgeDeviceResource created on azure
            // for more information of creating DataBoxEdgeDeviceResource, please refer to the document of DataBoxEdgeDeviceResource
            string subscriptionId = "4385cf00-2d3a-425a-832f-f4285b1c9dce";
            string resourceGroupName = "GroupForEdgeAutomation";
            string deviceName = "testedgedevice";
            ResourceIdentifier dataBoxEdgeDeviceResourceId = DataBoxEdgeDeviceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, deviceName);
            DataBoxEdgeDeviceResource dataBoxEdgeDevice = client.GetDataBoxEdgeDeviceResource(dataBoxEdgeDeviceResourceId);

            // get the collection of this DataBoxEdgeAlertResource
            DataBoxEdgeAlertCollection collection = dataBoxEdgeDevice.GetDataBoxEdgeAlerts();

            // invoke the operation
            string name = "159a00c7-8543-4343-9435-263ac87df3bb";
            bool result = await collection.ExistsAsync(name);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_AlertGet()
        {
            // Generated from example definition: specification/databoxedge/resource-manager/Microsoft.DataBoxEdge/stable/2022-03-01/examples/AlertGet.json
            // this example is just showing the usage of "Alerts_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataBoxEdgeDeviceResource created on azure
            // for more information of creating DataBoxEdgeDeviceResource, please refer to the document of DataBoxEdgeDeviceResource
            string subscriptionId = "4385cf00-2d3a-425a-832f-f4285b1c9dce";
            string resourceGroupName = "GroupForEdgeAutomation";
            string deviceName = "testedgedevice";
            ResourceIdentifier dataBoxEdgeDeviceResourceId = DataBoxEdgeDeviceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, deviceName);
            DataBoxEdgeDeviceResource dataBoxEdgeDevice = client.GetDataBoxEdgeDeviceResource(dataBoxEdgeDeviceResourceId);

            // get the collection of this DataBoxEdgeAlertResource
            DataBoxEdgeAlertCollection collection = dataBoxEdgeDevice.GetDataBoxEdgeAlerts();

            // invoke the operation
            string name = "159a00c7-8543-4343-9435-263ac87df3bb";
            NullableResponse<DataBoxEdgeAlertResource> response = await collection.GetIfExistsAsync(name);
            DataBoxEdgeAlertResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                DataBoxEdgeAlertData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
