// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.CosmosDB.Models;

namespace Azure.ResourceManager.CosmosDB
{
    /// <summary>
    /// A class representing a collection of <see cref="GremlinDatabaseResource"/> and their operations.
    /// Each <see cref="GremlinDatabaseResource"/> in the collection will belong to the same instance of <see cref="CosmosDBAccountResource"/>.
    /// To get a <see cref="GremlinDatabaseCollection"/> instance call the GetGremlinDatabases method from an instance of <see cref="CosmosDBAccountResource"/>.
    /// </summary>
    public partial class GremlinDatabaseCollection : ArmCollection, IEnumerable<GremlinDatabaseResource>, IAsyncEnumerable<GremlinDatabaseResource>
    {
        private readonly ClientDiagnostics _gremlinDatabaseGremlinResourcesClientDiagnostics;
        private readonly GremlinResourcesRestOperations _gremlinDatabaseGremlinResourcesRestClient;

        /// <summary> Initializes a new instance of the <see cref="GremlinDatabaseCollection"/> class for mocking. </summary>
        protected GremlinDatabaseCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="GremlinDatabaseCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal GremlinDatabaseCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _gremlinDatabaseGremlinResourcesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.CosmosDB", GremlinDatabaseResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(GremlinDatabaseResource.ResourceType, out string gremlinDatabaseGremlinResourcesApiVersion);
            _gremlinDatabaseGremlinResourcesRestClient = new GremlinResourcesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, gremlinDatabaseGremlinResourcesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != CosmosDBAccountResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, CosmosDBAccountResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or update an Azure Cosmos DB Gremlin database
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/gremlinDatabases/{databaseName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GremlinResources_CreateUpdateGremlinDatabase</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="GremlinDatabaseResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="databaseName"> Cosmos DB database name. </param>
        /// <param name="content"> The parameters to provide for the current Gremlin database. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="databaseName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="databaseName"/> or <paramref name="content"/> is null. </exception>
        public virtual async Task<ArmOperation<GremlinDatabaseResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string databaseName, GremlinDatabaseCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(databaseName, nameof(databaseName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _gremlinDatabaseGremlinResourcesClientDiagnostics.CreateScope("GremlinDatabaseCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _gremlinDatabaseGremlinResourcesRestClient.CreateUpdateGremlinDatabaseAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, databaseName, content, cancellationToken).ConfigureAwait(false);
                var operation = new CosmosDBArmOperation<GremlinDatabaseResource>(new GremlinDatabaseOperationSource(Client), _gremlinDatabaseGremlinResourcesClientDiagnostics, Pipeline, _gremlinDatabaseGremlinResourcesRestClient.CreateCreateUpdateGremlinDatabaseRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, databaseName, content).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Create or update an Azure Cosmos DB Gremlin database
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/gremlinDatabases/{databaseName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GremlinResources_CreateUpdateGremlinDatabase</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="GremlinDatabaseResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="databaseName"> Cosmos DB database name. </param>
        /// <param name="content"> The parameters to provide for the current Gremlin database. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="databaseName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="databaseName"/> or <paramref name="content"/> is null. </exception>
        public virtual ArmOperation<GremlinDatabaseResource> CreateOrUpdate(WaitUntil waitUntil, string databaseName, GremlinDatabaseCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(databaseName, nameof(databaseName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _gremlinDatabaseGremlinResourcesClientDiagnostics.CreateScope("GremlinDatabaseCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _gremlinDatabaseGremlinResourcesRestClient.CreateUpdateGremlinDatabase(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, databaseName, content, cancellationToken);
                var operation = new CosmosDBArmOperation<GremlinDatabaseResource>(new GremlinDatabaseOperationSource(Client), _gremlinDatabaseGremlinResourcesClientDiagnostics, Pipeline, _gremlinDatabaseGremlinResourcesRestClient.CreateCreateUpdateGremlinDatabaseRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, databaseName, content).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the Gremlin databases under an existing Azure Cosmos DB database account with the provided name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/gremlinDatabases/{databaseName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GremlinResources_GetGremlinDatabase</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="GremlinDatabaseResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="databaseName"> Cosmos DB database name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="databaseName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="databaseName"/> is null. </exception>
        public virtual async Task<Response<GremlinDatabaseResource>> GetAsync(string databaseName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(databaseName, nameof(databaseName));

            using var scope = _gremlinDatabaseGremlinResourcesClientDiagnostics.CreateScope("GremlinDatabaseCollection.Get");
            scope.Start();
            try
            {
                var response = await _gremlinDatabaseGremlinResourcesRestClient.GetGremlinDatabaseAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, databaseName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new GremlinDatabaseResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the Gremlin databases under an existing Azure Cosmos DB database account with the provided name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/gremlinDatabases/{databaseName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GremlinResources_GetGremlinDatabase</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="GremlinDatabaseResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="databaseName"> Cosmos DB database name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="databaseName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="databaseName"/> is null. </exception>
        public virtual Response<GremlinDatabaseResource> Get(string databaseName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(databaseName, nameof(databaseName));

            using var scope = _gremlinDatabaseGremlinResourcesClientDiagnostics.CreateScope("GremlinDatabaseCollection.Get");
            scope.Start();
            try
            {
                var response = _gremlinDatabaseGremlinResourcesRestClient.GetGremlinDatabase(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, databaseName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new GremlinDatabaseResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists the Gremlin databases under an existing Azure Cosmos DB database account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/gremlinDatabases</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GremlinResources_ListGremlinDatabases</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="GremlinDatabaseResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="GremlinDatabaseResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GremlinDatabaseResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _gremlinDatabaseGremlinResourcesRestClient.CreateListGremlinDatabasesRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, e => new GremlinDatabaseResource(Client, GremlinDatabaseData.DeserializeGremlinDatabaseData(e)), _gremlinDatabaseGremlinResourcesClientDiagnostics, Pipeline, "GremlinDatabaseCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Lists the Gremlin databases under an existing Azure Cosmos DB database account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/gremlinDatabases</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GremlinResources_ListGremlinDatabases</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="GremlinDatabaseResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="GremlinDatabaseResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GremlinDatabaseResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _gremlinDatabaseGremlinResourcesRestClient.CreateListGremlinDatabasesRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, e => new GremlinDatabaseResource(Client, GremlinDatabaseData.DeserializeGremlinDatabaseData(e)), _gremlinDatabaseGremlinResourcesClientDiagnostics, Pipeline, "GremlinDatabaseCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/gremlinDatabases/{databaseName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GremlinResources_GetGremlinDatabase</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="GremlinDatabaseResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="databaseName"> Cosmos DB database name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="databaseName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="databaseName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string databaseName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(databaseName, nameof(databaseName));

            using var scope = _gremlinDatabaseGremlinResourcesClientDiagnostics.CreateScope("GremlinDatabaseCollection.Exists");
            scope.Start();
            try
            {
                var response = await _gremlinDatabaseGremlinResourcesRestClient.GetGremlinDatabaseAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, databaseName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/gremlinDatabases/{databaseName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GremlinResources_GetGremlinDatabase</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="GremlinDatabaseResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="databaseName"> Cosmos DB database name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="databaseName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="databaseName"/> is null. </exception>
        public virtual Response<bool> Exists(string databaseName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(databaseName, nameof(databaseName));

            using var scope = _gremlinDatabaseGremlinResourcesClientDiagnostics.CreateScope("GremlinDatabaseCollection.Exists");
            scope.Start();
            try
            {
                var response = _gremlinDatabaseGremlinResourcesRestClient.GetGremlinDatabase(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, databaseName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/gremlinDatabases/{databaseName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GremlinResources_GetGremlinDatabase</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="GremlinDatabaseResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="databaseName"> Cosmos DB database name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="databaseName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="databaseName"/> is null. </exception>
        public virtual async Task<NullableResponse<GremlinDatabaseResource>> GetIfExistsAsync(string databaseName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(databaseName, nameof(databaseName));

            using var scope = _gremlinDatabaseGremlinResourcesClientDiagnostics.CreateScope("GremlinDatabaseCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _gremlinDatabaseGremlinResourcesRestClient.GetGremlinDatabaseAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, databaseName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<GremlinDatabaseResource>(response.GetRawResponse());
                return Response.FromValue(new GremlinDatabaseResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/gremlinDatabases/{databaseName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GremlinResources_GetGremlinDatabase</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="GremlinDatabaseResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="databaseName"> Cosmos DB database name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="databaseName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="databaseName"/> is null. </exception>
        public virtual NullableResponse<GremlinDatabaseResource> GetIfExists(string databaseName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(databaseName, nameof(databaseName));

            using var scope = _gremlinDatabaseGremlinResourcesClientDiagnostics.CreateScope("GremlinDatabaseCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _gremlinDatabaseGremlinResourcesRestClient.GetGremlinDatabase(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, databaseName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<GremlinDatabaseResource>(response.GetRawResponse());
                return Response.FromValue(new GremlinDatabaseResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<GremlinDatabaseResource> IEnumerable<GremlinDatabaseResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<GremlinDatabaseResource> IAsyncEnumerable<GremlinDatabaseResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
