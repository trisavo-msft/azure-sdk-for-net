// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.ResourceManager.Automanage.Samples
{
    public partial class Sample_AutomanageHciClusterConfigurationProfileAssignmentReportResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetAReportForAHCIConfigurationProfileAssignment()
        {
            // Generated from example definition: specification/automanage/resource-manager/Microsoft.Automanage/stable/2022-05-04/examples/getHCIReport.json
            // this example is just showing the usage of "HCIReports_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AutomanageHciClusterConfigurationProfileAssignmentReportResource created on azure
            // for more information of creating AutomanageHciClusterConfigurationProfileAssignmentReportResource, please refer to the document of AutomanageHciClusterConfigurationProfileAssignmentReportResource
            string subscriptionId = "mySubscriptionId";
            string resourceGroupName = "myResourceGroupName";
            string clusterName = "myClusterName";
            string configurationProfileAssignmentName = "default";
            string reportName = "b4e9ee6b-1717-4ff0-a8d2-e6d72c33d5f4";
            ResourceIdentifier automanageHciClusterConfigurationProfileAssignmentReportResourceId = AutomanageHciClusterConfigurationProfileAssignmentReportResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName, configurationProfileAssignmentName, reportName);
            AutomanageHciClusterConfigurationProfileAssignmentReportResource automanageHciClusterConfigurationProfileAssignmentReport = client.GetAutomanageHciClusterConfigurationProfileAssignmentReportResource(automanageHciClusterConfigurationProfileAssignmentReportResourceId);

            // invoke the operation
            AutomanageHciClusterConfigurationProfileAssignmentReportResource result = await automanageHciClusterConfigurationProfileAssignmentReport.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AutomanageConfigurationProfileAssignmentReportData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
