// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;

namespace Azure.ResourceManager.Migration.Assessment.Samples
{
    public partial class Sample_MigrationAssessmentAvsAssessedMachineResource
    {
        // AvsAssessedMachinesOperations_Get_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_AvsAssessedMachinesOperationsGetMaximumSetGen()
        {
            // Generated from example definition: specification/migrate/resource-manager/Microsoft.Migrate/AssessmentProjects/stable/2023-03-15/examples/AvsAssessedMachinesOperations_Get_MaximumSet_Gen.json
            // this example is just showing the usage of "AvsAssessedMachinesOperations_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MigrationAssessmentAvsAssessedMachineResource created on azure
            // for more information of creating MigrationAssessmentAvsAssessedMachineResource, please refer to the document of MigrationAssessmentAvsAssessedMachineResource
            string subscriptionId = "4bd2aa0f-2bd2-4d67-91a8-5a4533d58600";
            string resourceGroupName = "ayagrawrg";
            string projectName = "app18700project";
            string groupName = "kuchatur-test";
            string assessmentName = "asm2";
            string avsAssessedMachineName = "b6d6fc6f-796f-4c16-96af-a6d22e0f12f7";
            ResourceIdentifier migrationAssessmentAvsAssessedMachineResourceId = MigrationAssessmentAvsAssessedMachineResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, projectName, groupName, assessmentName, avsAssessedMachineName);
            MigrationAssessmentAvsAssessedMachineResource migrationAssessmentAvsAssessedMachine = client.GetMigrationAssessmentAvsAssessedMachineResource(migrationAssessmentAvsAssessedMachineResourceId);

            // invoke the operation
            MigrationAssessmentAvsAssessedMachineResource result = await migrationAssessmentAvsAssessedMachine.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MigrationAssessmentAvsAssessedMachineData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
