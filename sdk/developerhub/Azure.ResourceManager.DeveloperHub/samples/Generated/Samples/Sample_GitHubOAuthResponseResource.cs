// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.DeveloperHub.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.DeveloperHub.Samples
{
    public partial class Sample_GitHubOAuthResponseResource
    {
        // GitHub OAuth
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GitHubOAuth_GitHubOAuth()
        {
            // Generated from example definition: specification/developerhub/resource-manager/Microsoft.DevHub/preview/2024-05-01-preview/examples/GitHubOAuth.json
            // this example is just showing the usage of "GitHubOAuth" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this GitHubOAuthResponseResource created on azure
            // for more information of creating GitHubOAuthResponseResource, please refer to the document of GitHubOAuthResponseResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            AzureLocation location = new AzureLocation("eastus2euap");
            ResourceIdentifier gitHubOAuthResponseResourceId = GitHubOAuthResponseResource.CreateResourceIdentifier(subscriptionId, location);
            GitHubOAuthResponseResource gitHubOAuthResponse = client.GetGitHubOAuthResponseResource(gitHubOAuthResponseResourceId);

            // invoke the operation
            GitHubOAuthCallContent content = new GitHubOAuthCallContent()
            {
                RedirectUri = new Uri("https://ms.portal.azure.com/aks"),
            };
            GitHubOAuthInfoResult result = await gitHubOAuthResponse.GitHubOAuthAsync(content: content);

            Console.WriteLine($"Succeeded: {result}");
        }

        // GitHub OAuth Callback
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GitHubOAuthCallback()
        {
            // Generated from example definition: specification/developerhub/resource-manager/Microsoft.DevHub/preview/2024-05-01-preview/examples/GitHubOAuthCallback.json
            // this example is just showing the usage of "GitHubOAuthCallback" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this GitHubOAuthResponseResource created on azure
            // for more information of creating GitHubOAuthResponseResource, please refer to the document of GitHubOAuthResponseResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            AzureLocation location = new AzureLocation("eastus2euap");
            ResourceIdentifier gitHubOAuthResponseResourceId = GitHubOAuthResponseResource.CreateResourceIdentifier(subscriptionId, location);
            GitHubOAuthResponseResource gitHubOAuthResponse = client.GetGitHubOAuthResponseResource(gitHubOAuthResponseResourceId);

            // invoke the operation
            string code = "3584d83530557fdd1f46af8289938c8ef79f9dc5";
            string state = "12345678-3456-7890-5678-012345678901";
            GitHubOAuthResponseResource result = await gitHubOAuthResponse.GetAsync(code, state);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            GitHubOAuthResponseData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Artifact Generation Properties
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GeneratePreviewArtifacts_ArtifactGenerationProperties()
        {
            // Generated from example definition: specification/developerhub/resource-manager/Microsoft.DevHub/preview/2024-05-01-preview/examples/GeneratePreviewArtifacts.json
            // this example is just showing the usage of "GeneratePreviewArtifacts" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation
            ArtifactGenerationProperties artifactGenerationProperties = new ArtifactGenerationProperties()
            {
                GenerationLanguage = GenerationLanguage.Javascript,
                LanguageVersion = "14",
                Port = "80",
                AppName = "my-app",
                DockerfileOutputDirectory = "./",
                ManifestOutputDirectory = "./",
                DockerfileGenerationMode = DockerfileGenerationMode.Enabled,
                ManifestGenerationMode = ManifestGenerationMode.Enabled,
                ManifestType = GenerationManifestType.Kube,
                ImageName = "myimage",
                Namespace = "my-namespace",
                ImageTag = "latest",
            };
            Response<IReadOnlyDictionary<string, string>> response = await subscriptionResource.GeneratePreviewArtifactsAsync(artifactGenerationProperties);
            IReadOnlyDictionary<string, string> result = response.Value;

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
