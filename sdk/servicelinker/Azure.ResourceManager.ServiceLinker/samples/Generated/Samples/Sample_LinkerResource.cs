// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.ServiceLinker.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.ServiceLinker.Samples
{
    public partial class Sample_LinkerResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_Link()
        {
            // Generated from example definition: specification/servicelinker/resource-manager/Microsoft.ServiceLinker/stable/2022-05-01/examples/Link.json
            // this example is just showing the usage of "Linker_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this LinkerResource created on azure
            // for more information of creating LinkerResource, please refer to the document of LinkerResource
            string resourceUri = "subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/test-rg/providers/Microsoft.Web/sites/test-app";
            string linkerName = "linkName";
            ResourceIdentifier linkerResourceId = LinkerResource.CreateResourceIdentifier(resourceUri, linkerName);
            LinkerResource linkerResource = client.GetLinkerResource(linkerResourceId);

            // invoke the operation
            LinkerResource result = await linkerResource.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            LinkerResourceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_DeleteLink()
        {
            // Generated from example definition: specification/servicelinker/resource-manager/Microsoft.ServiceLinker/stable/2022-05-01/examples/DeleteLink.json
            // this example is just showing the usage of "Linker_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this LinkerResource created on azure
            // for more information of creating LinkerResource, please refer to the document of LinkerResource
            string resourceUri = "subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/test-rg/providers/Microsoft.Web/sites/test-app";
            string linkerName = "linkName";
            ResourceIdentifier linkerResourceId = LinkerResource.CreateResourceIdentifier(resourceUri, linkerName);
            LinkerResource linkerResource = client.GetLinkerResource(linkerResourceId);

            // invoke the operation
            await linkerResource.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_PatchLink()
        {
            // Generated from example definition: specification/servicelinker/resource-manager/Microsoft.ServiceLinker/stable/2022-05-01/examples/PatchLink.json
            // this example is just showing the usage of "Linker_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this LinkerResource created on azure
            // for more information of creating LinkerResource, please refer to the document of LinkerResource
            string resourceUri = "subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/test-rg/providers/Microsoft.Web/sites/test-app";
            string linkerName = "linkName";
            ResourceIdentifier linkerResourceId = LinkerResource.CreateResourceIdentifier(resourceUri, linkerName);
            LinkerResource linkerResource = client.GetLinkerResource(linkerResourceId);

            // invoke the operation
            LinkerResourcePatch patch = new LinkerResourcePatch
            {
                TargetService = new AzureResourceInfo
                {
                    Id = new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/test-rg/providers/Microsoft.DocumentDb/databaseAccounts/test-acc/mongodbDatabases/test-db"),
                },
                AuthInfo = new ServicePrincipalSecretAuthInfo("name", Guid.Parse("id"), "secret"),
            };
            ArmOperation<LinkerResource> lro = await linkerResource.UpdateAsync(WaitUntil.Completed, patch);
            LinkerResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            LinkerResourceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Validate_ValidateLinkSuccess()
        {
            // Generated from example definition: specification/servicelinker/resource-manager/Microsoft.ServiceLinker/stable/2022-05-01/examples/ValidateLinkSuccess.json
            // this example is just showing the usage of "Linker_Validate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this LinkerResource created on azure
            // for more information of creating LinkerResource, please refer to the document of LinkerResource
            string resourceUri = "subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/test-rg/providers/Microsoft.Web/sites/test-app";
            string linkerName = "linkName";
            ResourceIdentifier linkerResourceId = LinkerResource.CreateResourceIdentifier(resourceUri, linkerName);
            LinkerResource linkerResource = client.GetLinkerResource(linkerResourceId);

            // invoke the operation
            ArmOperation<LinkerValidateOperationResult> lro = await linkerResource.ValidateAsync(WaitUntil.Completed);
            LinkerValidateOperationResult result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetConfigurations_GetConfiguration()
        {
            // Generated from example definition: specification/servicelinker/resource-manager/Microsoft.ServiceLinker/stable/2022-05-01/examples/GetConfigurations.json
            // this example is just showing the usage of "Linker_ListConfigurations" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this LinkerResource created on azure
            // for more information of creating LinkerResource, please refer to the document of LinkerResource
            string resourceUri = "subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/test-rg/providers/Microsoft.Web/sites/test-app";
            string linkerName = "linkName";
            ResourceIdentifier linkerResourceId = LinkerResource.CreateResourceIdentifier(resourceUri, linkerName);
            LinkerResource linkerResource = client.GetLinkerResource(linkerResourceId);

            // invoke the operation
            SourceConfigurationResult result = await linkerResource.GetConfigurationsAsync();

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
