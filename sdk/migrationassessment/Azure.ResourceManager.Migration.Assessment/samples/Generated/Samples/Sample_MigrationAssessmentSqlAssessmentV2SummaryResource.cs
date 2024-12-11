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
    public partial class Sample_MigrationAssessmentSqlAssessmentV2SummaryResource
    {
        // SqlAssessmentV2SummaryOperations_Get_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_SqlAssessmentV2SummaryOperationsGetMaximumSetGen()
        {
            // Generated from example definition: specification/migrate/resource-manager/Microsoft.Migrate/AssessmentProjects/stable/2023-03-15/examples/SqlAssessmentV2SummaryOperations_Get_MaximumSet_Gen.json
            // this example is just showing the usage of "SqlAssessmentV2SummaryOperations_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MigrationAssessmentSqlAssessmentV2SummaryResource created on azure
            // for more information of creating MigrationAssessmentSqlAssessmentV2SummaryResource, please refer to the document of MigrationAssessmentSqlAssessmentV2SummaryResource
            string subscriptionId = "4bd2aa0f-2bd2-4d67-91a8-5a4533d58600";
            string resourceGroupName = "rgmigrate";
            string projectName = "fci-test6904project";
            string groupName = "test_fci_hadr";
            string assessmentName = "test_swagger_1";
            string summaryName = "default";
            ResourceIdentifier migrationAssessmentSqlAssessmentV2SummaryResourceId = MigrationAssessmentSqlAssessmentV2SummaryResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, projectName, groupName, assessmentName, summaryName);
            MigrationAssessmentSqlAssessmentV2SummaryResource migrationAssessmentSqlAssessmentV2Summary = client.GetMigrationAssessmentSqlAssessmentV2SummaryResource(migrationAssessmentSqlAssessmentV2SummaryResourceId);

            // invoke the operation
            MigrationAssessmentSqlAssessmentV2SummaryResource result = await migrationAssessmentSqlAssessmentV2Summary.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MigrationAssessmentSqlAssessmentV2SummaryData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
