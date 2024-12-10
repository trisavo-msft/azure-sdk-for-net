// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.ResourceManager.RecoveryServicesDataReplication.Samples
{
    public partial class Sample_DataReplicationWorkflowCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_WorkflowGet()
        {
            // Generated from example definition: specification/recoveryservicesdatareplication/resource-manager/Microsoft.DataReplication/preview/2021-02-16-preview/examples/Workflow_Get.json
            // this example is just showing the usage of "Workflow_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataReplicationVaultResource created on azure
            // for more information of creating DataReplicationVaultResource, please refer to the document of DataReplicationVaultResource
            string subscriptionId = "930CEC23-4430-4513-B855-DBA237E2F3BF";
            string resourceGroupName = "rgrecoveryservicesdatareplication";
            string vaultName = "4";
            ResourceIdentifier dataReplicationVaultResourceId = DataReplicationVaultResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, vaultName);
            DataReplicationVaultResource dataReplicationVault = client.GetDataReplicationVaultResource(dataReplicationVaultResourceId);

            // get the collection of this DataReplicationWorkflowResource
            DataReplicationWorkflowCollection collection = dataReplicationVault.GetDataReplicationWorkflows();

            // invoke the operation
            string jobName = "ZGH4y";
            DataReplicationWorkflowResource result = await collection.GetAsync(jobName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DataReplicationWorkflowData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_WorkflowList()
        {
            // Generated from example definition: specification/recoveryservicesdatareplication/resource-manager/Microsoft.DataReplication/preview/2021-02-16-preview/examples/Workflow_List.json
            // this example is just showing the usage of "Workflow_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataReplicationVaultResource created on azure
            // for more information of creating DataReplicationVaultResource, please refer to the document of DataReplicationVaultResource
            string subscriptionId = "930CEC23-4430-4513-B855-DBA237E2F3BF";
            string resourceGroupName = "rgrecoveryservicesdatareplication";
            string vaultName = "4";
            ResourceIdentifier dataReplicationVaultResourceId = DataReplicationVaultResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, vaultName);
            DataReplicationVaultResource dataReplicationVault = client.GetDataReplicationVaultResource(dataReplicationVaultResourceId);

            // get the collection of this DataReplicationWorkflowResource
            DataReplicationWorkflowCollection collection = dataReplicationVault.GetDataReplicationWorkflows();

            // invoke the operation and iterate over the result
            string filter = "mnebpgmjcitjleipnttx";
            string continuationToken = "rdavrzbethhslmkqgajontnxsue";
            await foreach (DataReplicationWorkflowResource item in collection.GetAllAsync(filter: filter, continuationToken: continuationToken))
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                DataReplicationWorkflowData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_WorkflowGet()
        {
            // Generated from example definition: specification/recoveryservicesdatareplication/resource-manager/Microsoft.DataReplication/preview/2021-02-16-preview/examples/Workflow_Get.json
            // this example is just showing the usage of "Workflow_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataReplicationVaultResource created on azure
            // for more information of creating DataReplicationVaultResource, please refer to the document of DataReplicationVaultResource
            string subscriptionId = "930CEC23-4430-4513-B855-DBA237E2F3BF";
            string resourceGroupName = "rgrecoveryservicesdatareplication";
            string vaultName = "4";
            ResourceIdentifier dataReplicationVaultResourceId = DataReplicationVaultResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, vaultName);
            DataReplicationVaultResource dataReplicationVault = client.GetDataReplicationVaultResource(dataReplicationVaultResourceId);

            // get the collection of this DataReplicationWorkflowResource
            DataReplicationWorkflowCollection collection = dataReplicationVault.GetDataReplicationWorkflows();

            // invoke the operation
            string jobName = "ZGH4y";
            bool result = await collection.ExistsAsync(jobName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_WorkflowGet()
        {
            // Generated from example definition: specification/recoveryservicesdatareplication/resource-manager/Microsoft.DataReplication/preview/2021-02-16-preview/examples/Workflow_Get.json
            // this example is just showing the usage of "Workflow_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataReplicationVaultResource created on azure
            // for more information of creating DataReplicationVaultResource, please refer to the document of DataReplicationVaultResource
            string subscriptionId = "930CEC23-4430-4513-B855-DBA237E2F3BF";
            string resourceGroupName = "rgrecoveryservicesdatareplication";
            string vaultName = "4";
            ResourceIdentifier dataReplicationVaultResourceId = DataReplicationVaultResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, vaultName);
            DataReplicationVaultResource dataReplicationVault = client.GetDataReplicationVaultResource(dataReplicationVaultResourceId);

            // get the collection of this DataReplicationWorkflowResource
            DataReplicationWorkflowCollection collection = dataReplicationVault.GetDataReplicationWorkflows();

            // invoke the operation
            string jobName = "ZGH4y";
            NullableResponse<DataReplicationWorkflowResource> response = await collection.GetIfExistsAsync(jobName);
            DataReplicationWorkflowResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                DataReplicationWorkflowData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
