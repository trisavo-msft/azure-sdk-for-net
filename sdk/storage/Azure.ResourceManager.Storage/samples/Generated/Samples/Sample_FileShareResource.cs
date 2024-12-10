// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Storage.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.Storage.Samples
{
    public partial class Sample_FileShareResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetShareStats()
        {
            // Generated from example definition: specification/storage/resource-manager/Microsoft.Storage/stable/2023-05-01/examples/FileSharesGet_Stats.json
            // this example is just showing the usage of "FileShares_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this FileShareResource created on azure
            // for more information of creating FileShareResource, please refer to the document of FileShareResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "res9871";
            string accountName = "sto6217";
            string shareName = "share1634";
            ResourceIdentifier fileShareResourceId = FileShareResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, shareName);
            FileShareResource fileShare = client.GetFileShareResource(fileShareResourceId);

            // invoke the operation
            string expand = "stats";
            FileShareResource result = await fileShare.GetAsync(expand: expand);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            FileShareData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetShares()
        {
            // Generated from example definition: specification/storage/resource-manager/Microsoft.Storage/stable/2023-05-01/examples/FileSharesGet.json
            // this example is just showing the usage of "FileShares_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this FileShareResource created on azure
            // for more information of creating FileShareResource, please refer to the document of FileShareResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "res9871";
            string accountName = "sto6217";
            string shareName = "share1634";
            ResourceIdentifier fileShareResourceId = FileShareResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, shareName);
            FileShareResource fileShare = client.GetFileShareResource(fileShareResourceId);

            // invoke the operation
            FileShareResource result = await fileShare.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            FileShareData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_DeleteShares()
        {
            // Generated from example definition: specification/storage/resource-manager/Microsoft.Storage/stable/2023-05-01/examples/FileSharesDelete.json
            // this example is just showing the usage of "FileShares_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this FileShareResource created on azure
            // for more information of creating FileShareResource, please refer to the document of FileShareResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "res4079";
            string accountName = "sto4506";
            string shareName = "share9689";
            ResourceIdentifier fileShareResourceId = FileShareResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, shareName);
            FileShareResource fileShare = client.GetFileShareResource(fileShareResourceId);

            // invoke the operation
            await fileShare.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_UpdateShareAcls()
        {
            // Generated from example definition: specification/storage/resource-manager/Microsoft.Storage/stable/2023-05-01/examples/FileShareAclsPatch.json
            // this example is just showing the usage of "FileShares_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this FileShareResource created on azure
            // for more information of creating FileShareResource, please refer to the document of FileShareResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "res3376";
            string accountName = "sto328";
            string shareName = "share6185";
            ResourceIdentifier fileShareResourceId = FileShareResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, shareName);
            FileShareResource fileShare = client.GetFileShareResource(fileShareResourceId);

            // invoke the operation
            FileShareData data = new FileShareData
            {
                SignedIdentifiers = {new StorageSignedIdentifier
{
Id = "MTIzNDU2Nzg5MDEyMzQ1Njc4OTAxMjM0NTY3ODkwMTI",
AccessPolicy = new StorageServiceAccessPolicy
{
StartOn = DateTimeOffset.Parse("2021-04-01T08:49:37.0000000Z"),
ExpireOn = DateTimeOffset.Parse("2021-05-01T08:49:37.0000000Z"),
Permission = "rwd",
},
}},
            };
            FileShareResource result = await fileShare.UpdateAsync(data);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            FileShareData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_UpdateShares()
        {
            // Generated from example definition: specification/storage/resource-manager/Microsoft.Storage/stable/2023-05-01/examples/FileSharesPatch.json
            // this example is just showing the usage of "FileShares_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this FileShareResource created on azure
            // for more information of creating FileShareResource, please refer to the document of FileShareResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "res3376";
            string accountName = "sto328";
            string shareName = "share6185";
            ResourceIdentifier fileShareResourceId = FileShareResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, shareName);
            FileShareResource fileShare = client.GetFileShareResource(fileShareResourceId);

            // invoke the operation
            FileShareData data = new FileShareData
            {
                Metadata =
{
["type"] = "image"
},
            };
            FileShareResource result = await fileShare.UpdateAsync(data);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            FileShareData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Restore_RestoreShares()
        {
            // Generated from example definition: specification/storage/resource-manager/Microsoft.Storage/stable/2023-05-01/examples/FileSharesRestore.json
            // this example is just showing the usage of "FileShares_Restore" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this FileShareResource created on azure
            // for more information of creating FileShareResource, please refer to the document of FileShareResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "res3376";
            string accountName = "sto328";
            string shareName = "share1249";
            ResourceIdentifier fileShareResourceId = FileShareResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, shareName);
            FileShareResource fileShare = client.GetFileShareResource(fileShareResourceId);

            // invoke the operation
            DeletedShare deletedShare = new DeletedShare("share1249", "1234567890");
            await fileShare.RestoreAsync(deletedShare);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Lease_AcquireALeaseOnAShare()
        {
            // Generated from example definition: specification/storage/resource-manager/Microsoft.Storage/stable/2023-05-01/examples/FileSharesLease_Acquire.json
            // this example is just showing the usage of "FileShares_Lease" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this FileShareResource created on azure
            // for more information of creating FileShareResource, please refer to the document of FileShareResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "res3376";
            string accountName = "sto328";
            string shareName = "share124";
            ResourceIdentifier fileShareResourceId = FileShareResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, shareName);
            FileShareResource fileShare = client.GetFileShareResource(fileShareResourceId);

            // invoke the operation
            LeaseShareContent content = new LeaseShareContent(LeaseShareAction.Acquire)
            {
                LeaseId = null,
                BreakPeriod = default,
                LeaseDuration = -1,
                ProposedLeaseId = null,
            };
            LeaseShareResponse result = await fileShare.LeaseAsync(content: content);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Lease_BreakALeaseOnAShare()
        {
            // Generated from example definition: specification/storage/resource-manager/Microsoft.Storage/stable/2023-05-01/examples/FileSharesLease_Break.json
            // this example is just showing the usage of "FileShares_Lease" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this FileShareResource created on azure
            // for more information of creating FileShareResource, please refer to the document of FileShareResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "res3376";
            string accountName = "sto328";
            string shareName = "share12";
            ResourceIdentifier fileShareResourceId = FileShareResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, shareName);
            FileShareResource fileShare = client.GetFileShareResource(fileShareResourceId);

            // invoke the operation
            LeaseShareContent content = new LeaseShareContent(LeaseShareAction.Break)
            {
                LeaseId = "8698f513-fa75-44a1-b8eb-30ba336af27d",
                BreakPeriod = default,
                LeaseDuration = default,
                ProposedLeaseId = null,
            };
            LeaseShareResponse result = await fileShare.LeaseAsync(content: content);

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
