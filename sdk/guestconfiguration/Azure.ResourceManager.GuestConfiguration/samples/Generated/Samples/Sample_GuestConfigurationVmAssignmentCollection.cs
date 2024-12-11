// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.GuestConfiguration.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.GuestConfiguration.Samples
{
    public partial class Sample_GuestConfigurationVmAssignmentCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_CreateOrUpdateGuestConfigurationAssignment()
        {
            // Generated from example definition: specification/guestconfiguration/resource-manager/Microsoft.GuestConfiguration/stable/2024-04-05/examples/createOrUpdateGuestConfigurationAssignment.json
            // this example is just showing the usage of "GuestConfigurationAssignments_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // get the collection of this GuestConfigurationVmAssignmentResource
            string subscriptionId = "mySubscriptionId";
            string resourceGroupName = "myResourceGroupName";
            string vmName = "myVMName";
            string scope = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachines/{vmName}";
            GuestConfigurationVmAssignmentCollection collection = client.GetGuestConfigurationVmAssignments(new ResourceIdentifier(scope));

            // invoke the operation
            string guestConfigurationAssignmentName = "NotInstalledApplicationForWindows";
            GuestConfigurationAssignmentData data = new GuestConfigurationAssignmentData
            {
                Properties = new GuestConfigurationAssignmentProperties
                {
                    GuestConfiguration = new GuestConfigurationNavigation
                    {
                        Name = "NotInstalledApplicationForWindows",
                        Version = "1.0.0.3",
                        ContentUri = new Uri("https://thisisfake/pacakge"),
                        ContentHash = "123contenthash",
                        ContentManagedIdentity = "test_identity",
                        AssignmentType = GuestConfigurationAssignmentType.ApplyAndAutoCorrect,
                        ConfigurationParameters = {new GuestConfigurationParameter
{
Name = "[InstalledApplication]NotInstalledApplicationResource1;Name",
Value = "NotePad,sql",
}},
                    },
                    Context = "Azure policy",
                },
                Name = "NotInstalledApplicationForWindows",
                Location = new AzureLocation("westcentralus"),
            };
            ArmOperation<GuestConfigurationVmAssignmentResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, guestConfigurationAssignmentName, data);
            GuestConfigurationVmAssignmentResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            GuestConfigurationAssignmentData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetAGuestConfigurationAssignment()
        {
            // Generated from example definition: specification/guestconfiguration/resource-manager/Microsoft.GuestConfiguration/stable/2024-04-05/examples/getGuestConfigurationAssignment.json
            // this example is just showing the usage of "GuestConfigurationAssignments_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // get the collection of this GuestConfigurationVmAssignmentResource
            string subscriptionId = "mySubscriptionId";
            string resourceGroupName = "myResourceGroupName";
            string vmName = "myVMName";
            string scope = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachines/{vmName}";
            GuestConfigurationVmAssignmentCollection collection = client.GetGuestConfigurationVmAssignments(new ResourceIdentifier(scope));

            // invoke the operation
            string guestConfigurationAssignmentName = "SecureProtocol";
            GuestConfigurationVmAssignmentResource result = await collection.GetAsync(guestConfigurationAssignmentName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            GuestConfigurationAssignmentData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_ListAllGuestConfigurationAssignmentsForAVirtualMachine()
        {
            // Generated from example definition: specification/guestconfiguration/resource-manager/Microsoft.GuestConfiguration/stable/2024-04-05/examples/listGuestConfigurationAssignments.json
            // this example is just showing the usage of "GuestConfigurationAssignments_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // get the collection of this GuestConfigurationVmAssignmentResource
            string subscriptionId = "mySubscriptionId";
            string resourceGroupName = "myResourceGroupName";
            string vmName = "myVMName";
            string scope = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachines/{vmName}";
            GuestConfigurationVmAssignmentCollection collection = client.GetGuestConfigurationVmAssignments(new ResourceIdentifier(scope));

            // invoke the operation and iterate over the result
            await foreach (GuestConfigurationVmAssignmentResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                GuestConfigurationAssignmentData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_GetAGuestConfigurationAssignment()
        {
            // Generated from example definition: specification/guestconfiguration/resource-manager/Microsoft.GuestConfiguration/stable/2024-04-05/examples/getGuestConfigurationAssignment.json
            // this example is just showing the usage of "GuestConfigurationAssignments_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // get the collection of this GuestConfigurationVmAssignmentResource
            string subscriptionId = "mySubscriptionId";
            string resourceGroupName = "myResourceGroupName";
            string vmName = "myVMName";
            string scope = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachines/{vmName}";
            GuestConfigurationVmAssignmentCollection collection = client.GetGuestConfigurationVmAssignments(new ResourceIdentifier(scope));

            // invoke the operation
            string guestConfigurationAssignmentName = "SecureProtocol";
            bool result = await collection.ExistsAsync(guestConfigurationAssignmentName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_GetAGuestConfigurationAssignment()
        {
            // Generated from example definition: specification/guestconfiguration/resource-manager/Microsoft.GuestConfiguration/stable/2024-04-05/examples/getGuestConfigurationAssignment.json
            // this example is just showing the usage of "GuestConfigurationAssignments_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // get the collection of this GuestConfigurationVmAssignmentResource
            string subscriptionId = "mySubscriptionId";
            string resourceGroupName = "myResourceGroupName";
            string vmName = "myVMName";
            string scope = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachines/{vmName}";
            GuestConfigurationVmAssignmentCollection collection = client.GetGuestConfigurationVmAssignments(new ResourceIdentifier(scope));

            // invoke the operation
            string guestConfigurationAssignmentName = "SecureProtocol";
            NullableResponse<GuestConfigurationVmAssignmentResource> response = await collection.GetIfExistsAsync(guestConfigurationAssignmentName);
            GuestConfigurationVmAssignmentResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                GuestConfigurationAssignmentData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
