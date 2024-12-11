// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Migration.Assessment.Models;

namespace Azure.ResourceManager.Migration.Assessment.Samples
{
    public partial class Sample_MigrationAssessmentServerCollectorResource
    {
        // ServerCollectorsOperations_Get_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_ServerCollectorsOperationsGetMaximumSetGen()
        {
            // Generated from example definition: specification/migrate/resource-manager/Microsoft.Migrate/AssessmentProjects/stable/2023-03-15/examples/ServerCollectorsOperations_Get_MaximumSet_Gen.json
            // this example is just showing the usage of "ServerCollectorsOperations_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MigrationAssessmentServerCollectorResource created on azure
            // for more information of creating MigrationAssessmentServerCollectorResource, please refer to the document of MigrationAssessmentServerCollectorResource
            string subscriptionId = "4bd2aa0f-2bd2-4d67-91a8-5a4533d58600";
            string resourceGroupName = "ayagrawRG";
            string projectName = "app18700project";
            string serverCollectorName = "walter389fcollector";
            ResourceIdentifier migrationAssessmentServerCollectorResourceId = MigrationAssessmentServerCollectorResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, projectName, serverCollectorName);
            MigrationAssessmentServerCollectorResource migrationAssessmentServerCollector = client.GetMigrationAssessmentServerCollectorResource(migrationAssessmentServerCollectorResourceId);

            // invoke the operation
            MigrationAssessmentServerCollectorResource result = await migrationAssessmentServerCollector.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MigrationAssessmentServerCollectorData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // ServerCollectorsOperations_Create_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_ServerCollectorsOperationsCreateMaximumSetGen()
        {
            // Generated from example definition: specification/migrate/resource-manager/Microsoft.Migrate/AssessmentProjects/stable/2023-03-15/examples/ServerCollectorsOperations_Create_MaximumSet_Gen.json
            // this example is just showing the usage of "ServerCollectorsOperations_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MigrationAssessmentServerCollectorResource created on azure
            // for more information of creating MigrationAssessmentServerCollectorResource, please refer to the document of MigrationAssessmentServerCollectorResource
            string subscriptionId = "4bd2aa0f-2bd2-4d67-91a8-5a4533d58600";
            string resourceGroupName = "ayagrawRG";
            string projectName = "app18700project";
            string serverCollectorName = "walter389fcollector";
            ResourceIdentifier migrationAssessmentServerCollectorResourceId = MigrationAssessmentServerCollectorResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, projectName, serverCollectorName);
            MigrationAssessmentServerCollectorResource migrationAssessmentServerCollector = client.GetMigrationAssessmentServerCollectorResource(migrationAssessmentServerCollectorResourceId);

            // invoke the operation
            MigrationAssessmentServerCollectorData data = new MigrationAssessmentServerCollectorData()
            {
                ProvisioningState = MigrationAssessmentProvisioningState.Succeeded,
                AgentProperties = new CollectorAgentPropertiesBase()
                {
                    Id = "498e4965-bbb1-47c2-8613-345baff9c509",
                    Version = null,
                    LastHeartbeatOn = null,
                    SpnDetails = new CollectorAgentSpnPropertiesBase()
                    {
                        Authority = "https://login.windows.net/72f988bf-86f1-41af-91ab-2d7cd011db47",
                        ApplicationId = "65153d2f-9afb-44e8-b3ca-1369150b7354",
                        Audience = "65153d2f-9afb-44e8-b3ca-1369150b7354",
                        ObjectId = "ddde6f96-87c8-420b-9d4d-f16a5090519e",
                        TenantId = Guid.Parse("72f988bf-86f1-41af-91ab-2d7cd011db47"),
                    },
                },
                DiscoverySiteId = "/subscriptions/4bd2aa0f-2bd2-4d67-91a8-5a4533d58600/resourceGroups/ayagrawRG/providers/Microsoft.OffAzure/ServerSites/walter7155site",
            };
            ArmOperation<MigrationAssessmentServerCollectorResource> lro = await migrationAssessmentServerCollector.UpdateAsync(WaitUntil.Completed, data);
            MigrationAssessmentServerCollectorResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MigrationAssessmentServerCollectorData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // ServerCollectorsOperations_Delete_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_ServerCollectorsOperationsDeleteMaximumSetGen()
        {
            // Generated from example definition: specification/migrate/resource-manager/Microsoft.Migrate/AssessmentProjects/stable/2023-03-15/examples/ServerCollectorsOperations_Delete_MaximumSet_Gen.json
            // this example is just showing the usage of "ServerCollectorsOperations_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MigrationAssessmentServerCollectorResource created on azure
            // for more information of creating MigrationAssessmentServerCollectorResource, please refer to the document of MigrationAssessmentServerCollectorResource
            string subscriptionId = "4bd2aa0f-2bd2-4d67-91a8-5a4533d58600";
            string resourceGroupName = "ayagrawRG";
            string projectName = "app18700project";
            string serverCollectorName = "walter389fcollector";
            ResourceIdentifier migrationAssessmentServerCollectorResourceId = MigrationAssessmentServerCollectorResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, projectName, serverCollectorName);
            MigrationAssessmentServerCollectorResource migrationAssessmentServerCollector = client.GetMigrationAssessmentServerCollectorResource(migrationAssessmentServerCollectorResourceId);

            // invoke the operation
            await migrationAssessmentServerCollector.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }
    }
}
