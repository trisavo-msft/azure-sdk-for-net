// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.SecurityCenter.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.SecurityCenter.Samples
{
    public partial class Sample_DevOpsRepositoryResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetAzureDevOpsRepos()
        {
            // Generated from example definition: specification/security/resource-manager/Microsoft.Security/preview/2023-09-01-preview/examples/SecurityConnectorsDevOps/GetAzureDevOpsRepos_example.json
            // this example is just showing the usage of "AzureDevOpsRepos_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DevOpsRepositoryResource created on azure
            // for more information of creating DevOpsRepositoryResource, please refer to the document of DevOpsRepositoryResource
            string subscriptionId = "0806e1cd-cfda-4ff8-b99c-2b0af42cffd3";
            string resourceGroupName = "myRg";
            string securityConnectorName = "mySecurityConnectorName";
            string orgName = "myAzDevOpsOrg";
            string projectName = "myAzDevOpsProject";
            string repoName = "myAzDevOpsRepo";
            ResourceIdentifier devOpsRepositoryResourceId = DevOpsRepositoryResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, securityConnectorName, orgName, projectName, repoName);
            DevOpsRepositoryResource devOpsRepository = client.GetDevOpsRepositoryResource(devOpsRepositoryResourceId);

            // invoke the operation
            DevOpsRepositoryResource result = await devOpsRepository.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DevOpsRepositoryData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_UpdateAzureDevOpsRepos()
        {
            // Generated from example definition: specification/security/resource-manager/Microsoft.Security/preview/2023-09-01-preview/examples/SecurityConnectorsDevOps/UpdateAzureDevOpsRepos_example.json
            // this example is just showing the usage of "AzureDevOpsRepos_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DevOpsRepositoryResource created on azure
            // for more information of creating DevOpsRepositoryResource, please refer to the document of DevOpsRepositoryResource
            string subscriptionId = "0806e1cd-cfda-4ff8-b99c-2b0af42cffd3";
            string resourceGroupName = "myRg";
            string securityConnectorName = "mySecurityConnectorName";
            string orgName = "myAzDevOpsOrg";
            string projectName = "myAzDevOpsProject";
            string repoName = "myAzDevOpsRepo";
            ResourceIdentifier devOpsRepositoryResourceId = DevOpsRepositoryResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, securityConnectorName, orgName, projectName, repoName);
            DevOpsRepositoryResource devOpsRepository = client.GetDevOpsRepositoryResource(devOpsRepositoryResourceId);

            // invoke the operation
            DevOpsRepositoryData data = new DevOpsRepositoryData
            {
                Properties = new DevOpsRepositoryProperties
                {
                    OnboardingState = ResourceOnboardingState.NotApplicable,
                    ActionableRemediation = new ActionableRemediation
                    {
                        State = ActionableRemediationState.Enabled,
                    },
                },
            };
            ArmOperation<DevOpsRepositoryResource> lro = await devOpsRepository.UpdateAsync(WaitUntil.Completed, data);
            DevOpsRepositoryResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DevOpsRepositoryData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
