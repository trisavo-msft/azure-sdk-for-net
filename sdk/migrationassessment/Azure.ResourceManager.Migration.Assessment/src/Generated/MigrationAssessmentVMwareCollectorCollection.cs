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
    /// A class representing a collection of <see cref="MigrationAssessmentVMwareCollectorResource"/> and their operations.
    /// Each <see cref="MigrationAssessmentVMwareCollectorResource"/> in the collection will belong to the same instance of <see cref="MigrationAssessmentAssessmentProjectResource"/>.
    /// To get a <see cref="MigrationAssessmentVMwareCollectorCollection"/> instance call the GetMigrationAssessmentVMwareCollectors method from an instance of <see cref="MigrationAssessmentAssessmentProjectResource"/>.
    /// </summary>
    public partial class MigrationAssessmentVMwareCollectorCollection : ArmCollection, IEnumerable<MigrationAssessmentVMwareCollectorResource>, IAsyncEnumerable<MigrationAssessmentVMwareCollectorResource>
    {
        private readonly ClientDiagnostics _migrationAssessmentVMwareCollectorVMwareCollectorsOperationsClientDiagnostics;
        private readonly VmwareCollectorsRestOperations _migrationAssessmentVMwareCollectorVMwareCollectorsOperationsRestClient;

        /// <summary> Initializes a new instance of the <see cref="MigrationAssessmentVMwareCollectorCollection"/> class for mocking. </summary>
        protected MigrationAssessmentVMwareCollectorCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MigrationAssessmentVMwareCollectorCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal MigrationAssessmentVMwareCollectorCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _migrationAssessmentVMwareCollectorVMwareCollectorsOperationsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Migration.Assessment", MigrationAssessmentVMwareCollectorResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(MigrationAssessmentVMwareCollectorResource.ResourceType, out string migrationAssessmentVMwareCollectorVMwareCollectorsOperationsApiVersion);
            _migrationAssessmentVMwareCollectorVMwareCollectorsOperationsRestClient = new VmwareCollectorsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, migrationAssessmentVMwareCollectorVMwareCollectorsOperationsApiVersion);
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
        /// Create a VmwareCollector
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Migrate/assessmentProjects/{projectName}/vmwarecollectors/{vmWareCollectorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VmwareCollectorsOperations_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MigrationAssessmentVMwareCollectorResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="vmWareCollectorName"> VMware collector ARM name. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vmWareCollectorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vmWareCollectorName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<MigrationAssessmentVMwareCollectorResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string vmWareCollectorName, MigrationAssessmentVMwareCollectorData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vmWareCollectorName, nameof(vmWareCollectorName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _migrationAssessmentVMwareCollectorVMwareCollectorsOperationsClientDiagnostics.CreateScope("MigrationAssessmentVMwareCollectorCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _migrationAssessmentVMwareCollectorVMwareCollectorsOperationsRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, vmWareCollectorName, data, cancellationToken).ConfigureAwait(false);
                var operation = new AssessmentArmOperation<MigrationAssessmentVMwareCollectorResource>(new MigrationAssessmentVMwareCollectorOperationSource(Client), _migrationAssessmentVMwareCollectorVMwareCollectorsOperationsClientDiagnostics, Pipeline, _migrationAssessmentVMwareCollectorVMwareCollectorsOperationsRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, vmWareCollectorName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Create a VmwareCollector
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Migrate/assessmentProjects/{projectName}/vmwarecollectors/{vmWareCollectorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VmwareCollectorsOperations_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MigrationAssessmentVMwareCollectorResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="vmWareCollectorName"> VMware collector ARM name. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vmWareCollectorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vmWareCollectorName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<MigrationAssessmentVMwareCollectorResource> CreateOrUpdate(WaitUntil waitUntil, string vmWareCollectorName, MigrationAssessmentVMwareCollectorData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vmWareCollectorName, nameof(vmWareCollectorName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _migrationAssessmentVMwareCollectorVMwareCollectorsOperationsClientDiagnostics.CreateScope("MigrationAssessmentVMwareCollectorCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _migrationAssessmentVMwareCollectorVMwareCollectorsOperationsRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, vmWareCollectorName, data, cancellationToken);
                var operation = new AssessmentArmOperation<MigrationAssessmentVMwareCollectorResource>(new MigrationAssessmentVMwareCollectorOperationSource(Client), _migrationAssessmentVMwareCollectorVMwareCollectorsOperationsClientDiagnostics, Pipeline, _migrationAssessmentVMwareCollectorVMwareCollectorsOperationsRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, vmWareCollectorName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Get a VmwareCollector
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Migrate/assessmentProjects/{projectName}/vmwarecollectors/{vmWareCollectorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VmwareCollectorsOperations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MigrationAssessmentVMwareCollectorResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="vmWareCollectorName"> VMware collector ARM name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vmWareCollectorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vmWareCollectorName"/> is null. </exception>
        public virtual async Task<Response<MigrationAssessmentVMwareCollectorResource>> GetAsync(string vmWareCollectorName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vmWareCollectorName, nameof(vmWareCollectorName));

            using var scope = _migrationAssessmentVMwareCollectorVMwareCollectorsOperationsClientDiagnostics.CreateScope("MigrationAssessmentVMwareCollectorCollection.Get");
            scope.Start();
            try
            {
                var response = await _migrationAssessmentVMwareCollectorVMwareCollectorsOperationsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, vmWareCollectorName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MigrationAssessmentVMwareCollectorResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a VmwareCollector
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Migrate/assessmentProjects/{projectName}/vmwarecollectors/{vmWareCollectorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VmwareCollectorsOperations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MigrationAssessmentVMwareCollectorResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="vmWareCollectorName"> VMware collector ARM name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vmWareCollectorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vmWareCollectorName"/> is null. </exception>
        public virtual Response<MigrationAssessmentVMwareCollectorResource> Get(string vmWareCollectorName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vmWareCollectorName, nameof(vmWareCollectorName));

            using var scope = _migrationAssessmentVMwareCollectorVMwareCollectorsOperationsClientDiagnostics.CreateScope("MigrationAssessmentVMwareCollectorCollection.Get");
            scope.Start();
            try
            {
                var response = _migrationAssessmentVMwareCollectorVMwareCollectorsOperationsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, vmWareCollectorName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MigrationAssessmentVMwareCollectorResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List VmwareCollector resources by AssessmentProject
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Migrate/assessmentProjects/{projectName}/vmwarecollectors</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VmwareCollectorsOperations_ListByAssessmentProject</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MigrationAssessmentVMwareCollectorResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="MigrationAssessmentVMwareCollectorResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<MigrationAssessmentVMwareCollectorResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _migrationAssessmentVMwareCollectorVMwareCollectorsOperationsRestClient.CreateListByAssessmentProjectRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _migrationAssessmentVMwareCollectorVMwareCollectorsOperationsRestClient.CreateListByAssessmentProjectNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new MigrationAssessmentVMwareCollectorResource(Client, MigrationAssessmentVMwareCollectorData.DeserializeMigrationAssessmentVMwareCollectorData(e)), _migrationAssessmentVMwareCollectorVMwareCollectorsOperationsClientDiagnostics, Pipeline, "MigrationAssessmentVMwareCollectorCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List VmwareCollector resources by AssessmentProject
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Migrate/assessmentProjects/{projectName}/vmwarecollectors</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VmwareCollectorsOperations_ListByAssessmentProject</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MigrationAssessmentVMwareCollectorResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="MigrationAssessmentVMwareCollectorResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<MigrationAssessmentVMwareCollectorResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _migrationAssessmentVMwareCollectorVMwareCollectorsOperationsRestClient.CreateListByAssessmentProjectRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _migrationAssessmentVMwareCollectorVMwareCollectorsOperationsRestClient.CreateListByAssessmentProjectNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new MigrationAssessmentVMwareCollectorResource(Client, MigrationAssessmentVMwareCollectorData.DeserializeMigrationAssessmentVMwareCollectorData(e)), _migrationAssessmentVMwareCollectorVMwareCollectorsOperationsClientDiagnostics, Pipeline, "MigrationAssessmentVMwareCollectorCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Migrate/assessmentProjects/{projectName}/vmwarecollectors/{vmWareCollectorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VmwareCollectorsOperations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MigrationAssessmentVMwareCollectorResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="vmWareCollectorName"> VMware collector ARM name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vmWareCollectorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vmWareCollectorName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string vmWareCollectorName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vmWareCollectorName, nameof(vmWareCollectorName));

            using var scope = _migrationAssessmentVMwareCollectorVMwareCollectorsOperationsClientDiagnostics.CreateScope("MigrationAssessmentVMwareCollectorCollection.Exists");
            scope.Start();
            try
            {
                var response = await _migrationAssessmentVMwareCollectorVMwareCollectorsOperationsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, vmWareCollectorName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Migrate/assessmentProjects/{projectName}/vmwarecollectors/{vmWareCollectorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VmwareCollectorsOperations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MigrationAssessmentVMwareCollectorResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="vmWareCollectorName"> VMware collector ARM name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vmWareCollectorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vmWareCollectorName"/> is null. </exception>
        public virtual Response<bool> Exists(string vmWareCollectorName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vmWareCollectorName, nameof(vmWareCollectorName));

            using var scope = _migrationAssessmentVMwareCollectorVMwareCollectorsOperationsClientDiagnostics.CreateScope("MigrationAssessmentVMwareCollectorCollection.Exists");
            scope.Start();
            try
            {
                var response = _migrationAssessmentVMwareCollectorVMwareCollectorsOperationsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, vmWareCollectorName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Migrate/assessmentProjects/{projectName}/vmwarecollectors/{vmWareCollectorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VmwareCollectorsOperations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MigrationAssessmentVMwareCollectorResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="vmWareCollectorName"> VMware collector ARM name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vmWareCollectorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vmWareCollectorName"/> is null. </exception>
        public virtual async Task<NullableResponse<MigrationAssessmentVMwareCollectorResource>> GetIfExistsAsync(string vmWareCollectorName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vmWareCollectorName, nameof(vmWareCollectorName));

            using var scope = _migrationAssessmentVMwareCollectorVMwareCollectorsOperationsClientDiagnostics.CreateScope("MigrationAssessmentVMwareCollectorCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _migrationAssessmentVMwareCollectorVMwareCollectorsOperationsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, vmWareCollectorName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<MigrationAssessmentVMwareCollectorResource>(response.GetRawResponse());
                return Response.FromValue(new MigrationAssessmentVMwareCollectorResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Migrate/assessmentProjects/{projectName}/vmwarecollectors/{vmWareCollectorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VmwareCollectorsOperations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MigrationAssessmentVMwareCollectorResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="vmWareCollectorName"> VMware collector ARM name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vmWareCollectorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vmWareCollectorName"/> is null. </exception>
        public virtual NullableResponse<MigrationAssessmentVMwareCollectorResource> GetIfExists(string vmWareCollectorName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vmWareCollectorName, nameof(vmWareCollectorName));

            using var scope = _migrationAssessmentVMwareCollectorVMwareCollectorsOperationsClientDiagnostics.CreateScope("MigrationAssessmentVMwareCollectorCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _migrationAssessmentVMwareCollectorVMwareCollectorsOperationsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, vmWareCollectorName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<MigrationAssessmentVMwareCollectorResource>(response.GetRawResponse());
                return Response.FromValue(new MigrationAssessmentVMwareCollectorResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<MigrationAssessmentVMwareCollectorResource> IEnumerable<MigrationAssessmentVMwareCollectorResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<MigrationAssessmentVMwareCollectorResource> IAsyncEnumerable<MigrationAssessmentVMwareCollectorResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
