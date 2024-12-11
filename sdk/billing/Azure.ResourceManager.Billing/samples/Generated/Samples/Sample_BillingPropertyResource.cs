// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Billing.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.Billing.Samples
{
    public partial class Sample_BillingPropertyResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_BillingPropertyGetMCA()
        {
            // Generated from example definition: specification/billing/resource-manager/Microsoft.Billing/stable/2024-04-01/examples/billingPropertyGetMCA.json
            // this example is just showing the usage of "BillingProperty_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BillingPropertyResource created on azure
            // for more information of creating BillingPropertyResource, please refer to the document of BillingPropertyResource
            string subscriptionId = "11111111-1111-1111-1111-111111111111";
            ResourceIdentifier billingPropertyResourceId = BillingPropertyResource.CreateResourceIdentifier(subscriptionId);
            BillingPropertyResource billingProperty = client.GetBillingPropertyResource(billingPropertyResourceId);

            // invoke the operation
            BillingPropertyResource result = await billingProperty.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            BillingPropertyData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_BillingPropertyGetMOSP()
        {
            // Generated from example definition: specification/billing/resource-manager/Microsoft.Billing/stable/2024-04-01/examples/billingPropertyGetMOSP.json
            // this example is just showing the usage of "BillingProperty_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BillingPropertyResource created on azure
            // for more information of creating BillingPropertyResource, please refer to the document of BillingPropertyResource
            string subscriptionId = "11111111-1111-1111-1111-111111111111";
            ResourceIdentifier billingPropertyResourceId = BillingPropertyResource.CreateResourceIdentifier(subscriptionId);
            BillingPropertyResource billingProperty = client.GetBillingPropertyResource(billingPropertyResourceId);

            // invoke the operation
            BillingPropertyResource result = await billingProperty.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            BillingPropertyData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_BillingPropertyGetMPA()
        {
            // Generated from example definition: specification/billing/resource-manager/Microsoft.Billing/stable/2024-04-01/examples/billingPropertyGetMPA.json
            // this example is just showing the usage of "BillingProperty_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BillingPropertyResource created on azure
            // for more information of creating BillingPropertyResource, please refer to the document of BillingPropertyResource
            string subscriptionId = "11111111-1111-1111-1111-111111111111";
            ResourceIdentifier billingPropertyResourceId = BillingPropertyResource.CreateResourceIdentifier(subscriptionId);
            BillingPropertyResource billingProperty = client.GetBillingPropertyResource(billingPropertyResourceId);

            // invoke the operation
            BillingPropertyResource result = await billingProperty.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            BillingPropertyData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_BillingPropertyPatchCostCenter()
        {
            // Generated from example definition: specification/billing/resource-manager/Microsoft.Billing/stable/2024-04-01/examples/billingPropertyPatchCostCenter.json
            // this example is just showing the usage of "BillingProperty_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BillingPropertyResource created on azure
            // for more information of creating BillingPropertyResource, please refer to the document of BillingPropertyResource
            string subscriptionId = "11111111-1111-1111-1111-111111111111";
            ResourceIdentifier billingPropertyResourceId = BillingPropertyResource.CreateResourceIdentifier(subscriptionId);
            BillingPropertyResource billingProperty = client.GetBillingPropertyResource(billingPropertyResourceId);

            // invoke the operation
            BillingPropertyData data = new BillingPropertyData
            {
                Properties = new BillingPropertyProperties
                {
                    CostCenter = "1010",
                },
            };
            BillingPropertyResource result = await billingProperty.UpdateAsync(data);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            BillingPropertyData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_BillingPropertyPatchSubscriptionServiceUsageAddress()
        {
            // Generated from example definition: specification/billing/resource-manager/Microsoft.Billing/stable/2024-04-01/examples/billingPropertyPatchSubscriptionServiceUsageAddress.json
            // this example is just showing the usage of "BillingProperty_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BillingPropertyResource created on azure
            // for more information of creating BillingPropertyResource, please refer to the document of BillingPropertyResource
            string subscriptionId = "11111111-1111-1111-1111-111111111111";
            ResourceIdentifier billingPropertyResourceId = BillingPropertyResource.CreateResourceIdentifier(subscriptionId);
            BillingPropertyResource billingProperty = client.GetBillingPropertyResource(billingPropertyResourceId);

            // invoke the operation
            BillingPropertyData data = new BillingPropertyData
            {
                Properties = new BillingPropertyProperties
                {
                    SubscriptionServiceUsageAddress = new BillingAddressDetails("Address line 1", "US")
                    {
                        AddressLine2 = "Address line 2",
                        City = "City",
                        FirstName = "Jenny",
                        LastName = "Doe",
                        MiddleName = "Ann",
                        PostalCode = "12345",
                        Region = "State",
                    },
                },
            };
            BillingPropertyResource result = await billingProperty.UpdateAsync(data);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            BillingPropertyData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
