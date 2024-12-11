// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.AI.DocumentIntelligence.Samples
{
    public partial class Samples_DocumentIntelligenceClient
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_DocumentIntelligenceClient_GetAnalyzeBatchResults_ListAnalyzeBatchDocumentsResults()
        {
            Uri endpoint = new Uri("<endpoint>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            DocumentIntelligenceClient client = new DocumentIntelligenceClient(endpoint, credential);

            foreach (BinaryData item in client.GetAnalyzeBatchResults("prebuilt-invoice", null))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.GetProperty("status").ToString());
                Console.WriteLine(result.GetProperty("createdDateTime").ToString());
                Console.WriteLine(result.GetProperty("lastUpdatedDateTime").ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_DocumentIntelligenceClient_GetAnalyzeBatchResults_ListAnalyzeBatchDocumentsResults_Async()
        {
            Uri endpoint = new Uri("<endpoint>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            DocumentIntelligenceClient client = new DocumentIntelligenceClient(endpoint, credential);

            await foreach (BinaryData item in client.GetAnalyzeBatchResultsAsync("prebuilt-invoice", null))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.GetProperty("status").ToString());
                Console.WriteLine(result.GetProperty("createdDateTime").ToString());
                Console.WriteLine(result.GetProperty("lastUpdatedDateTime").ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_DocumentIntelligenceClient_GetAnalyzeBatchResults_ListAnalyzeBatchDocumentsResults_Convenience()
        {
            Uri endpoint = new Uri("<endpoint>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            DocumentIntelligenceClient client = new DocumentIntelligenceClient(endpoint, credential);

            foreach (AnalyzeBatchOperationDetails item in client.GetAnalyzeBatchResults("prebuilt-invoice"))
            {
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_DocumentIntelligenceClient_GetAnalyzeBatchResults_ListAnalyzeBatchDocumentsResults_Convenience_Async()
        {
            Uri endpoint = new Uri("<endpoint>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            DocumentIntelligenceClient client = new DocumentIntelligenceClient(endpoint, credential);

            await foreach (AnalyzeBatchOperationDetails item in client.GetAnalyzeBatchResultsAsync("prebuilt-invoice"))
            {
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_DocumentIntelligenceClient_AnalyzeDocument_AnalyzeDocumentFromBase64()
        {
            Uri endpoint = new Uri("<endpoint>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            DocumentIntelligenceClient client = new DocumentIntelligenceClient(endpoint, credential);

            using RequestContent content = RequestContent.Create(new
            {
                base64Source = "e2Jhc2U2NEVuY29kZWRQZGZ9",
            });
            Operation<BinaryData> operation = client.AnalyzeDocument(WaitUntil.Completed, "prebuilt-layout", content);
            BinaryData responseData = operation.Value;

            JsonElement result = JsonDocument.Parse(responseData.ToStream()).RootElement;
            Console.WriteLine(result.GetProperty("apiVersion").ToString());
            Console.WriteLine(result.GetProperty("modelId").ToString());
            Console.WriteLine(result.GetProperty("stringIndexType").ToString());
            Console.WriteLine(result.GetProperty("content").ToString());
            Console.WriteLine(result.GetProperty("pages")[0].GetProperty("pageNumber").ToString());
            Console.WriteLine(result.GetProperty("pages")[0].GetProperty("spans")[0].GetProperty("offset").ToString());
            Console.WriteLine(result.GetProperty("pages")[0].GetProperty("spans")[0].GetProperty("length").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_DocumentIntelligenceClient_AnalyzeDocument_AnalyzeDocumentFromBase64_Async()
        {
            Uri endpoint = new Uri("<endpoint>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            DocumentIntelligenceClient client = new DocumentIntelligenceClient(endpoint, credential);

            using RequestContent content = RequestContent.Create(new
            {
                base64Source = "e2Jhc2U2NEVuY29kZWRQZGZ9",
            });
            Operation<BinaryData> operation = await client.AnalyzeDocumentAsync(WaitUntil.Completed, "prebuilt-layout", content);
            BinaryData responseData = operation.Value;

            JsonElement result = JsonDocument.Parse(responseData.ToStream()).RootElement;
            Console.WriteLine(result.GetProperty("apiVersion").ToString());
            Console.WriteLine(result.GetProperty("modelId").ToString());
            Console.WriteLine(result.GetProperty("stringIndexType").ToString());
            Console.WriteLine(result.GetProperty("content").ToString());
            Console.WriteLine(result.GetProperty("pages")[0].GetProperty("pageNumber").ToString());
            Console.WriteLine(result.GetProperty("pages")[0].GetProperty("spans")[0].GetProperty("offset").ToString());
            Console.WriteLine(result.GetProperty("pages")[0].GetProperty("spans")[0].GetProperty("length").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_DocumentIntelligenceClient_AnalyzeDocument_AnalyzeDocumentFromBase64_Convenience()
        {
            Uri endpoint = new Uri("<endpoint>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            DocumentIntelligenceClient client = new DocumentIntelligenceClient(endpoint, credential);

            Operation<AnalyzeResult> operation = client.AnalyzeDocument(WaitUntil.Completed, "prebuilt-layout");
            AnalyzeResult responseData = operation.Value;
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_DocumentIntelligenceClient_AnalyzeDocument_AnalyzeDocumentFromBase64_Convenience_Async()
        {
            Uri endpoint = new Uri("<endpoint>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            DocumentIntelligenceClient client = new DocumentIntelligenceClient(endpoint, credential);

            Operation<AnalyzeResult> operation = await client.AnalyzeDocumentAsync(WaitUntil.Completed, "prebuilt-layout");
            AnalyzeResult responseData = operation.Value;
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_DocumentIntelligenceClient_AnalyzeDocument_AnalyzeDocumentFromUrl()
        {
            Uri endpoint = new Uri("<endpoint>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            DocumentIntelligenceClient client = new DocumentIntelligenceClient(endpoint, credential);

            using RequestContent content = RequestContent.Create(new
            {
                urlSource = "http://host.com/doc.pdf",
            });
            Operation<BinaryData> operation = client.AnalyzeDocument(WaitUntil.Completed, "customModel", content);
            BinaryData responseData = operation.Value;

            JsonElement result = JsonDocument.Parse(responseData.ToStream()).RootElement;
            Console.WriteLine(result.GetProperty("apiVersion").ToString());
            Console.WriteLine(result.GetProperty("modelId").ToString());
            Console.WriteLine(result.GetProperty("stringIndexType").ToString());
            Console.WriteLine(result.GetProperty("content").ToString());
            Console.WriteLine(result.GetProperty("pages")[0].GetProperty("pageNumber").ToString());
            Console.WriteLine(result.GetProperty("pages")[0].GetProperty("spans")[0].GetProperty("offset").ToString());
            Console.WriteLine(result.GetProperty("pages")[0].GetProperty("spans")[0].GetProperty("length").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_DocumentIntelligenceClient_AnalyzeDocument_AnalyzeDocumentFromUrl_Async()
        {
            Uri endpoint = new Uri("<endpoint>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            DocumentIntelligenceClient client = new DocumentIntelligenceClient(endpoint, credential);

            using RequestContent content = RequestContent.Create(new
            {
                urlSource = "http://host.com/doc.pdf",
            });
            Operation<BinaryData> operation = await client.AnalyzeDocumentAsync(WaitUntil.Completed, "customModel", content);
            BinaryData responseData = operation.Value;

            JsonElement result = JsonDocument.Parse(responseData.ToStream()).RootElement;
            Console.WriteLine(result.GetProperty("apiVersion").ToString());
            Console.WriteLine(result.GetProperty("modelId").ToString());
            Console.WriteLine(result.GetProperty("stringIndexType").ToString());
            Console.WriteLine(result.GetProperty("content").ToString());
            Console.WriteLine(result.GetProperty("pages")[0].GetProperty("pageNumber").ToString());
            Console.WriteLine(result.GetProperty("pages")[0].GetProperty("spans")[0].GetProperty("offset").ToString());
            Console.WriteLine(result.GetProperty("pages")[0].GetProperty("spans")[0].GetProperty("length").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_DocumentIntelligenceClient_AnalyzeDocument_AnalyzeDocumentFromUrl_Convenience()
        {
            Uri endpoint = new Uri("<endpoint>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            DocumentIntelligenceClient client = new DocumentIntelligenceClient(endpoint, credential);

            Operation<AnalyzeResult> operation = client.AnalyzeDocument(WaitUntil.Completed, "customModel");
            AnalyzeResult responseData = operation.Value;
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_DocumentIntelligenceClient_AnalyzeDocument_AnalyzeDocumentFromUrl_Convenience_Async()
        {
            Uri endpoint = new Uri("<endpoint>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            DocumentIntelligenceClient client = new DocumentIntelligenceClient(endpoint, credential);

            Operation<AnalyzeResult> operation = await client.AnalyzeDocumentAsync(WaitUntil.Completed, "customModel");
            AnalyzeResult responseData = operation.Value;
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_DocumentIntelligenceClient_AnalyzeBatchDocuments_AnalyzeBatchDocuments()
        {
            Uri endpoint = new Uri("<endpoint>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            DocumentIntelligenceClient client = new DocumentIntelligenceClient(endpoint, credential);

            using RequestContent content = RequestContent.Create(new
            {
                azureBlobSource = new
                {
                    containerUrl = "https://myStorageAccount.blob.core.windows.net/myContainer?mySasToken",
                    prefix = "trainingDocs/",
                },
                resultContainerUrl = "https://myStorageAccount.blob.core.windows.net/myOutputContainer?mySasToken",
                resultPrefix = "trainingDocsResult/",
                overwriteExisting = true,
            });
            Operation<BinaryData> operation = client.AnalyzeBatchDocuments(WaitUntil.Completed, "customModel", content);
            BinaryData responseData = operation.Value;

            JsonElement result = JsonDocument.Parse(responseData.ToStream()).RootElement;
            Console.WriteLine(result.GetProperty("succeededCount").ToString());
            Console.WriteLine(result.GetProperty("failedCount").ToString());
            Console.WriteLine(result.GetProperty("skippedCount").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_DocumentIntelligenceClient_AnalyzeBatchDocuments_AnalyzeBatchDocuments_Async()
        {
            Uri endpoint = new Uri("<endpoint>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            DocumentIntelligenceClient client = new DocumentIntelligenceClient(endpoint, credential);

            using RequestContent content = RequestContent.Create(new
            {
                azureBlobSource = new
                {
                    containerUrl = "https://myStorageAccount.blob.core.windows.net/myContainer?mySasToken",
                    prefix = "trainingDocs/",
                },
                resultContainerUrl = "https://myStorageAccount.blob.core.windows.net/myOutputContainer?mySasToken",
                resultPrefix = "trainingDocsResult/",
                overwriteExisting = true,
            });
            Operation<BinaryData> operation = await client.AnalyzeBatchDocumentsAsync(WaitUntil.Completed, "customModel", content);
            BinaryData responseData = operation.Value;

            JsonElement result = JsonDocument.Parse(responseData.ToStream()).RootElement;
            Console.WriteLine(result.GetProperty("succeededCount").ToString());
            Console.WriteLine(result.GetProperty("failedCount").ToString());
            Console.WriteLine(result.GetProperty("skippedCount").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_DocumentIntelligenceClient_AnalyzeBatchDocuments_AnalyzeBatchDocuments_Convenience()
        {
            Uri endpoint = new Uri("<endpoint>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            DocumentIntelligenceClient client = new DocumentIntelligenceClient(endpoint, credential);

            Operation<AnalyzeBatchResult> operation = client.AnalyzeBatchDocuments(WaitUntil.Completed, "customModel");
            AnalyzeBatchResult responseData = operation.Value;
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_DocumentIntelligenceClient_AnalyzeBatchDocuments_AnalyzeBatchDocuments_Convenience_Async()
        {
            Uri endpoint = new Uri("<endpoint>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            DocumentIntelligenceClient client = new DocumentIntelligenceClient(endpoint, credential);

            Operation<AnalyzeBatchResult> operation = await client.AnalyzeBatchDocumentsAsync(WaitUntil.Completed, "customModel");
            AnalyzeBatchResult responseData = operation.Value;
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_DocumentIntelligenceClient_ClassifyDocument_ClassifyDocumentFromUrl()
        {
            Uri endpoint = new Uri("<endpoint>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            DocumentIntelligenceClient client = new DocumentIntelligenceClient(endpoint, credential);

            using RequestContent content = RequestContent.Create(new
            {
                urlSource = "http://host.com/doc.pdf",
            });
            Operation<BinaryData> operation = client.ClassifyDocument(WaitUntil.Completed, "classifierId", content);
            BinaryData responseData = operation.Value;

            JsonElement result = JsonDocument.Parse(responseData.ToStream()).RootElement;
            Console.WriteLine(result.GetProperty("apiVersion").ToString());
            Console.WriteLine(result.GetProperty("modelId").ToString());
            Console.WriteLine(result.GetProperty("stringIndexType").ToString());
            Console.WriteLine(result.GetProperty("content").ToString());
            Console.WriteLine(result.GetProperty("pages")[0].GetProperty("pageNumber").ToString());
            Console.WriteLine(result.GetProperty("pages")[0].GetProperty("spans")[0].GetProperty("offset").ToString());
            Console.WriteLine(result.GetProperty("pages")[0].GetProperty("spans")[0].GetProperty("length").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_DocumentIntelligenceClient_ClassifyDocument_ClassifyDocumentFromUrl_Async()
        {
            Uri endpoint = new Uri("<endpoint>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            DocumentIntelligenceClient client = new DocumentIntelligenceClient(endpoint, credential);

            using RequestContent content = RequestContent.Create(new
            {
                urlSource = "http://host.com/doc.pdf",
            });
            Operation<BinaryData> operation = await client.ClassifyDocumentAsync(WaitUntil.Completed, "classifierId", content);
            BinaryData responseData = operation.Value;

            JsonElement result = JsonDocument.Parse(responseData.ToStream()).RootElement;
            Console.WriteLine(result.GetProperty("apiVersion").ToString());
            Console.WriteLine(result.GetProperty("modelId").ToString());
            Console.WriteLine(result.GetProperty("stringIndexType").ToString());
            Console.WriteLine(result.GetProperty("content").ToString());
            Console.WriteLine(result.GetProperty("pages")[0].GetProperty("pageNumber").ToString());
            Console.WriteLine(result.GetProperty("pages")[0].GetProperty("spans")[0].GetProperty("offset").ToString());
            Console.WriteLine(result.GetProperty("pages")[0].GetProperty("spans")[0].GetProperty("length").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_DocumentIntelligenceClient_ClassifyDocument_ClassifyDocumentFromUrl_Convenience()
        {
            Uri endpoint = new Uri("<endpoint>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            DocumentIntelligenceClient client = new DocumentIntelligenceClient(endpoint, credential);

            ClassifyDocumentOptions classifyRequest = new ClassifyDocumentOptions
            {
                UriSource = new Uri("http://host.com/doc.pdf"),
            };
            Operation<AnalyzeResult> operation = client.ClassifyDocument(WaitUntil.Completed, "classifierId", classifyRequest);
            AnalyzeResult responseData = operation.Value;
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_DocumentIntelligenceClient_ClassifyDocument_ClassifyDocumentFromUrl_Convenience_Async()
        {
            Uri endpoint = new Uri("<endpoint>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            DocumentIntelligenceClient client = new DocumentIntelligenceClient(endpoint, credential);

            ClassifyDocumentOptions classifyRequest = new ClassifyDocumentOptions
            {
                UriSource = new Uri("http://host.com/doc.pdf"),
            };
            Operation<AnalyzeResult> operation = await client.ClassifyDocumentAsync(WaitUntil.Completed, "classifierId", classifyRequest);
            AnalyzeResult responseData = operation.Value;
        }
    }
}
