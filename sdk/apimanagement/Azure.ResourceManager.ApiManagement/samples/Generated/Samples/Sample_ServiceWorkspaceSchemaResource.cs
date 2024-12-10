// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.ApiManagement.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.ApiManagement.Samples
{
    public partial class Sample_ServiceWorkspaceSchemaResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_ApiManagementGetWorkspaceSchema()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/preview/2023-03-01-preview/examples/ApiManagementGetWorkspaceSchema.json
            // this example is just showing the usage of "WorkspaceGlobalSchema_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceWorkspaceSchemaResource created on azure
            // for more information of creating ServiceWorkspaceSchemaResource, please refer to the document of ServiceWorkspaceSchemaResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string workspaceId = "wks1";
            string schemaId = "schema1";
            ResourceIdentifier serviceWorkspaceSchemaResourceId = ServiceWorkspaceSchemaResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, workspaceId, schemaId);
            ServiceWorkspaceSchemaResource serviceWorkspaceSchema = client.GetServiceWorkspaceSchemaResource(serviceWorkspaceSchemaResourceId);

            // invoke the operation
            ServiceWorkspaceSchemaResource result = await serviceWorkspaceSchema.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ApiManagementGlobalSchemaData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_ApiManagementDeleteWorkspaceSchema()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/preview/2023-03-01-preview/examples/ApiManagementDeleteWorkspaceSchema.json
            // this example is just showing the usage of "WorkspaceGlobalSchema_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceWorkspaceSchemaResource created on azure
            // for more information of creating ServiceWorkspaceSchemaResource, please refer to the document of ServiceWorkspaceSchemaResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string workspaceId = "wks1";
            string schemaId = "schema1";
            ResourceIdentifier serviceWorkspaceSchemaResourceId = ServiceWorkspaceSchemaResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, workspaceId, schemaId);
            ServiceWorkspaceSchemaResource serviceWorkspaceSchema = client.GetServiceWorkspaceSchemaResource(serviceWorkspaceSchemaResourceId);

            // invoke the operation
            ETag ifMatch = new ETag("*");
            await serviceWorkspaceSchema.DeleteAsync(WaitUntil.Completed, ifMatch);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_ApiManagementCreateWorkspaceSchema()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/preview/2023-03-01-preview/examples/ApiManagementCreateWorkspaceSchema.json
            // this example is just showing the usage of "WorkspaceGlobalSchema_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceWorkspaceSchemaResource created on azure
            // for more information of creating ServiceWorkspaceSchemaResource, please refer to the document of ServiceWorkspaceSchemaResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string workspaceId = "wks1";
            string schemaId = "schema1";
            ResourceIdentifier serviceWorkspaceSchemaResourceId = ServiceWorkspaceSchemaResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, workspaceId, schemaId);
            ServiceWorkspaceSchemaResource serviceWorkspaceSchema = client.GetServiceWorkspaceSchemaResource(serviceWorkspaceSchemaResourceId);

            // invoke the operation
            ApiManagementGlobalSchemaData data = new ApiManagementGlobalSchemaData
            {
                SchemaType = ApiSchemaType.Xml,
                Description = "sample schema description",
                Value = BinaryData.FromObjectAsJson("<xsd:schema xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\"\r\n           xmlns:tns=\"http://tempuri.org/PurchaseOrderSchema.xsd\"\r\n           targetNamespace=\"http://tempuri.org/PurchaseOrderSchema.xsd\"\r\n           elementFormDefault=\"qualified\">\r\n <xsd:element name=\"PurchaseOrder\" type=\"tns:PurchaseOrderType\"/>\r\n <xsd:complexType name=\"PurchaseOrderType\">\r\n  <xsd:sequence>\r\n   <xsd:element name=\"ShipTo\" type=\"tns:USAddress\" maxOccurs=\"2\"/>\r\n   <xsd:element name=\"BillTo\" type=\"tns:USAddress\"/>\r\n  </xsd:sequence>\r\n  <xsd:attribute name=\"OrderDate\" type=\"xsd:date\"/>\r\n </xsd:complexType>\r\n\r\n <xsd:complexType name=\"USAddress\">\r\n  <xsd:sequence>\r\n   <xsd:element name=\"name\"   type=\"xsd:string\"/>\r\n   <xsd:element name=\"street\" type=\"xsd:string\"/>\r\n   <xsd:element name=\"city\"   type=\"xsd:string\"/>\r\n   <xsd:element name=\"state\"  type=\"xsd:string\"/>\r\n   <xsd:element name=\"zip\"    type=\"xsd:integer\"/>\r\n  </xsd:sequence>\r\n  <xsd:attribute name=\"country\" type=\"xsd:NMTOKEN\" fixed=\"US\"/>\r\n </xsd:complexType>\r\n</xsd:schema>"),
            };
            ArmOperation<ServiceWorkspaceSchemaResource> lro = await serviceWorkspaceSchema.UpdateAsync(WaitUntil.Completed, data);
            ServiceWorkspaceSchemaResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ApiManagementGlobalSchemaData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetEntityTag_ApiManagementHeadWorkspaceSchema()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/preview/2023-03-01-preview/examples/ApiManagementHeadWorkspaceSchema.json
            // this example is just showing the usage of "WorkspaceGlobalSchema_GetEntityTag" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceWorkspaceSchemaResource created on azure
            // for more information of creating ServiceWorkspaceSchemaResource, please refer to the document of ServiceWorkspaceSchemaResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string workspaceId = "wks1";
            string schemaId = "myschema";
            ResourceIdentifier serviceWorkspaceSchemaResourceId = ServiceWorkspaceSchemaResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, workspaceId, schemaId);
            ServiceWorkspaceSchemaResource serviceWorkspaceSchema = client.GetServiceWorkspaceSchemaResource(serviceWorkspaceSchemaResourceId);

            // invoke the operation
            bool result = await serviceWorkspaceSchema.GetEntityTagAsync();

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
