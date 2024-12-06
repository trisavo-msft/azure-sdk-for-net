// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.PlaywrightTesting.Models;
using Azure.ResourceManager.Resources;
using NUnit.Framework;

namespace Azure.ResourceManager.PlaywrightTesting.Samples
{
    public partial class Sample_SubscriptionResourceExtensions
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CheckPlaywrightTestingNameAvailability_AccountsCheckNameAvailability()
        {
            // Generated from example definition: 2024-12-01/Accounts_CheckNameAvailability.json
            // this example is just showing the usage of "Accounts_CheckPlaywrightTestingNameAvailability" operation, for the dependent resources, they will have to be created separately.

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
            PlaywrightTestingNameAvailabilityContent content = new PlaywrightTestingNameAvailabilityContent
            {
                Name = "dummyName",
                Type = "Microsoft.AzurePlaywrightService/Accounts",
            };
            PlaywrightTestingNameAvailabilityResult result = await subscriptionResource.CheckPlaywrightTestingNameAvailabilityAsync(content);

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
