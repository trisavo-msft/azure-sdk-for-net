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
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.ResourceManager.Migration.Assessment
{
    /// <summary>
    /// A class representing a collection of <see cref="MigrationAssessmentHyperVCollectorResource"/> and their operations.
    /// Each <see cref="MigrationAssessmentHyperVCollectorResource"/> in the collection will belong to the same instance of <see cref="MigrationAssessmentAssessmentProjectResource"/>.
    /// To get a <see cref="MigrationAssessmentHyperVCollectorCollection"/> instance call the GetMigrationAssessmentHyperVCollectors method from an instance of <see cref="MigrationAssessmentAssessmentProjectResource"/>.
    /// </summary>
    public partial class MigrationAssessmentHyperVCollectorCollection : ArmCollection, IEnumerable<MigrationAssessmentHyperVCollectorResource>, IAsyncEnumerable<MigrationAssessmentHyperVCollectorResource>
    {
        private readonly ClientDiagnostics _migrationAssessmentHyperVCollectorHyperVCollectorsOperationsClientDiagnostics;
        private readonly HypervCollectorsRestOperations _migrationAssessmentHyperVCollectorHyperVCollectorsOperationsRestClient;

        /// <summary> Initializes a new instance of the <see cref="MigrationAssessmentHyperVCollectorCollection"/> class for mocking. </summary>
        protected MigrationAssessmentHyperVCollectorCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MigrationAssessmentHyperVCollectorCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal MigrationAssessmentHyperVCollectorCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _migrationAssessmentHyperVCollectorHyperVCollectorsOperationsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Migration.Assessment", MigrationAssessmentHyperVCollectorResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(MigrationAssessmentHyperVCollectorResource.ResourceType, out string migrationAssessmentHyperVCollectorHyperVCollectorsOperationsApiVersion);
            _migrationAssessmentHyperVCollectorHyperVCollectorsOperationsRestClient = new HypervCollectorsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, migrationAssessmentHyperVCollectorHyperVCollectorsOperationsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != MigrationAssessmentAssessmentProjectResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, MigrationAssessmentAssessmentProjectResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create a HypervCollector
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Migrate/assessmentProjects/{projectName}/hypervcollectors/{hypervCollectorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>HypervCollectorsOperations_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MigrationAssessmentHyperVCollectorResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="hyperVCollectorName"> Hyper-V collector ARM name. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="hyperVCollectorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="hyperVCollectorName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<MigrationAssessmentHyperVCollectorResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string hyperVCollectorName, MigrationAssessmentHyperVCollectorData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(hyperVCollectorName, nameof(hyperVCollectorName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _migrationAssessmentHyperVCollectorHyperVCollectorsOperationsClientDiagnostics.CreateScope("MigrationAssessmentHyperVCollectorCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _migrationAssessmentHyperVCollectorHyperVCollectorsOperationsRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, hyperVCollectorName, data, cancellationToken).ConfigureAwait(false);
                var operation = new AssessmentArmOperation<MigrationAssessmentHyperVCollectorResource>(new MigrationAssessmentHyperVCollectorOperationSource(Client), _migrationAssessmentHyperVCollectorHyperVCollectorsOperationsClientDiagnostics, Pipeline, _migrationAssessmentHyperVCollectorHyperVCollectorsOperationsRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, hyperVCollectorName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Create a HypervCollector
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Migrate/assessmentProjects/{projectName}/hypervcollectors/{hypervCollectorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>HypervCollectorsOperations_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MigrationAssessmentHyperVCollectorResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="hyperVCollectorName"> Hyper-V collector ARM name. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="hyperVCollectorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="hyperVCollectorName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<MigrationAssessmentHyperVCollectorResource> CreateOrUpdate(WaitUntil waitUntil, string hyperVCollectorName, MigrationAssessmentHyperVCollectorData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(hyperVCollectorName, nameof(hyperVCollectorName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _migrationAssessmentHyperVCollectorHyperVCollectorsOperationsClientDiagnostics.CreateScope("MigrationAssessmentHyperVCollectorCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _migrationAssessmentHyperVCollectorHyperVCollectorsOperationsRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, hyperVCollectorName, data, cancellationToken);
                var operation = new AssessmentArmOperation<MigrationAssessmentHyperVCollectorResource>(new MigrationAssessmentHyperVCollectorOperationSource(Client), _migrationAssessmentHyperVCollectorHyperVCollectorsOperationsClientDiagnostics, Pipeline, _migrationAssessmentHyperVCollectorHyperVCollectorsOperationsRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, hyperVCollectorName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Get a HypervCollector
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Migrate/assessmentProjects/{projectName}/hypervcollectors/{hypervCollectorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>HypervCollectorsOperations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MigrationAssessmentHyperVCollectorResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="hyperVCollectorName"> Hyper-V collector ARM name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="hyperVCollectorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="hyperVCollectorName"/> is null. </exception>
        public virtual async Task<Response<MigrationAssessmentHyperVCollectorResource>> GetAsync(string hyperVCollectorName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(hyperVCollectorName, nameof(hyperVCollectorName));

            using var scope = _migrationAssessmentHyperVCollectorHyperVCollectorsOperationsClientDiagnostics.CreateScope("MigrationAssessmentHyperVCollectorCollection.Get");
            scope.Start();
            try
            {
                var response = await _migrationAssessmentHyperVCollectorHyperVCollectorsOperationsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, hyperVCollectorName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MigrationAssessmentHyperVCollectorResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a HypervCollector
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Migrate/assessmentProjects/{projectName}/hypervcollectors/{hypervCollectorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>HypervCollectorsOperations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MigrationAssessmentHyperVCollectorResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="hyperVCollectorName"> Hyper-V collector ARM name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="hyperVCollectorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="hyperVCollectorName"/> is null. </exception>
        public virtual Response<MigrationAssessmentHyperVCollectorResource> Get(string hyperVCollectorName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(hyperVCollectorName, nameof(hyperVCollectorName));

            using var scope = _migrationAssessmentHyperVCollectorHyperVCollectorsOperationsClientDiagnostics.CreateScope("MigrationAssessmentHyperVCollectorCollection.Get");
            scope.Start();
            try
            {
                var response = _migrationAssessmentHyperVCollectorHyperVCollectorsOperationsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, hyperVCollectorName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MigrationAssessmentHyperVCollectorResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List HypervCollector resources by AssessmentProject
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Migrate/assessmentProjects/{projectName}/hypervcollectors</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>HypervCollectorsOperations_ListByAssessmentProject</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MigrationAssessmentHyperVCollectorResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="MigrationAssessmentHyperVCollectorResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<MigrationAssessmentHyperVCollectorResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _migrationAssessmentHyperVCollectorHyperVCollectorsOperationsRestClient.CreateListByAssessmentProjectRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _migrationAssessmentHyperVCollectorHyperVCollectorsOperationsRestClient.CreateListByAssessmentProjectNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new MigrationAssessmentHyperVCollectorResource(Client, MigrationAssessmentHyperVCollectorData.DeserializeMigrationAssessmentHyperVCollectorData(e)), _migrationAssessmentHyperVCollectorHyperVCollectorsOperationsClientDiagnostics, Pipeline, "MigrationAssessmentHyperVCollectorCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List HypervCollector resources by AssessmentProject
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Migrate/assessmentProjects/{projectName}/hypervcollectors</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>HypervCollectorsOperations_ListByAssessmentProject</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MigrationAssessmentHyperVCollectorResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="MigrationAssessmentHyperVCollectorResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<MigrationAssessmentHyperVCollectorResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _migrationAssessmentHyperVCollectorHyperVCollectorsOperationsRestClient.CreateListByAssessmentProjectRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _migrationAssessmentHyperVCollectorHyperVCollectorsOperationsRestClient.CreateListByAssessmentProjectNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new MigrationAssessmentHyperVCollectorResource(Client, MigrationAssessmentHyperVCollectorData.DeserializeMigrationAssessmentHyperVCollectorData(e)), _migrationAssessmentHyperVCollectorHyperVCollectorsOperationsClientDiagnostics, Pipeline, "MigrationAssessmentHyperVCollectorCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Migrate/assessmentProjects/{projectName}/hypervcollectors/{hypervCollectorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>HypervCollectorsOperations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MigrationAssessmentHyperVCollectorResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="hyperVCollectorName"> Hyper-V collector ARM name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="hyperVCollectorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="hyperVCollectorName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string hyperVCollectorName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(hyperVCollectorName, nameof(hyperVCollectorName));

            using var scope = _migrationAssessmentHyperVCollectorHyperVCollectorsOperationsClientDiagnostics.CreateScope("MigrationAssessmentHyperVCollectorCollection.Exists");
            scope.Start();
            try
            {
                var response = await _migrationAssessmentHyperVCollectorHyperVCollectorsOperationsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, hyperVCollectorName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Migrate/assessmentProjects/{projectName}/hypervcollectors/{hypervCollectorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>HypervCollectorsOperations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MigrationAssessmentHyperVCollectorResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="hyperVCollectorName"> Hyper-V collector ARM name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="hyperVCollectorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="hyperVCollectorName"/> is null. </exception>
        public virtual Response<bool> Exists(string hyperVCollectorName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(hyperVCollectorName, nameof(hyperVCollectorName));

            using var scope = _migrationAssessmentHyperVCollectorHyperVCollectorsOperationsClientDiagnostics.CreateScope("MigrationAssessmentHyperVCollectorCollection.Exists");
            scope.Start();
            try
            {
                var response = _migrationAssessmentHyperVCollectorHyperVCollectorsOperationsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, hyperVCollectorName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Migrate/assessmentProjects/{projectName}/hypervcollectors/{hypervCollectorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>HypervCollectorsOperations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MigrationAssessmentHyperVCollectorResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="hyperVCollectorName"> Hyper-V collector ARM name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="hyperVCollectorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="hyperVCollectorName"/> is null. </exception>
        public virtual async Task<NullableResponse<MigrationAssessmentHyperVCollectorResource>> GetIfExistsAsync(string hyperVCollectorName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(hyperVCollectorName, nameof(hyperVCollectorName));

            using var scope = _migrationAssessmentHyperVCollectorHyperVCollectorsOperationsClientDiagnostics.CreateScope("MigrationAssessmentHyperVCollectorCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _migrationAssessmentHyperVCollectorHyperVCollectorsOperationsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, hyperVCollectorName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<MigrationAssessmentHyperVCollectorResource>(response.GetRawResponse());
                return Response.FromValue(new MigrationAssessmentHyperVCollectorResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Migrate/assessmentProjects/{projectName}/hypervcollectors/{hypervCollectorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>HypervCollectorsOperations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MigrationAssessmentHyperVCollectorResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="hyperVCollectorName"> Hyper-V collector ARM name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="hyperVCollectorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="hyperVCollectorName"/> is null. </exception>
        public virtual NullableResponse<MigrationAssessmentHyperVCollectorResource> GetIfExists(string hyperVCollectorName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(hyperVCollectorName, nameof(hyperVCollectorName));

            using var scope = _migrationAssessmentHyperVCollectorHyperVCollectorsOperationsClientDiagnostics.CreateScope("MigrationAssessmentHyperVCollectorCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _migrationAssessmentHyperVCollectorHyperVCollectorsOperationsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, hyperVCollectorName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<MigrationAssessmentHyperVCollectorResource>(response.GetRawResponse());
                return Response.FromValue(new MigrationAssessmentHyperVCollectorResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<MigrationAssessmentHyperVCollectorResource> IEnumerable<MigrationAssessmentHyperVCollectorResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<MigrationAssessmentHyperVCollectorResource> IAsyncEnumerable<MigrationAssessmentHyperVCollectorResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
