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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Network
{
    /// <summary>
    /// A class representing a collection of <see cref="CloudServiceSwapResource"/> and their operations.
    /// Each <see cref="CloudServiceSwapResource"/> in the collection will belong to the same instance of <see cref="ResourceGroupResource"/>.
    /// To get a <see cref="CloudServiceSwapCollection"/> instance call the GetCloudServiceSwaps method from an instance of <see cref="ResourceGroupResource"/>.
    /// </summary>
    public partial class CloudServiceSwapCollection : ArmCollection, IEnumerable<CloudServiceSwapResource>, IAsyncEnumerable<CloudServiceSwapResource>
    {
        private readonly ClientDiagnostics _cloudServiceSwapVipSwapClientDiagnostics;
        private readonly VipSwapRestOperations _cloudServiceSwapVipSwapRestClient;
        private readonly string _resourceName;

        /// <summary> Initializes a new instance of the <see cref="CloudServiceSwapCollection"/> class for mocking. </summary>
        protected CloudServiceSwapCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="CloudServiceSwapCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        /// <param name="resourceName"> The name of the cloud service. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        internal CloudServiceSwapCollection(ArmClient client, ResourceIdentifier id, string resourceName) : base(client, id)
        {
            _resourceName = resourceName;
            _cloudServiceSwapVipSwapClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", CloudServiceSwapResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(CloudServiceSwapResource.ResourceType, out string cloudServiceSwapVipSwapApiVersion);
            _cloudServiceSwapVipSwapRestClient = new VipSwapRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, cloudServiceSwapVipSwapApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Performs vip swap operation on swappable cloud services.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{groupName}/providers/Microsoft.Compute/cloudServices/{resourceName}/providers/Microsoft.Network/cloudServiceSlots/{singletonResource}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VipSwap_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CloudServiceSwapResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> SwapResource object where slot type should be the target slot after vip swap for the specified cloud service. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation> CreateOrUpdateAsync(WaitUntil waitUntil, CloudServiceSwapData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _cloudServiceSwapVipSwapClientDiagnostics.CreateScope("CloudServiceSwapCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _cloudServiceSwapVipSwapRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, _resourceName, data, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkArmOperation(_cloudServiceSwapVipSwapClientDiagnostics, Pipeline, _cloudServiceSwapVipSwapRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, _resourceName, data).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Performs vip swap operation on swappable cloud services.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{groupName}/providers/Microsoft.Compute/cloudServices/{resourceName}/providers/Microsoft.Network/cloudServiceSlots/{singletonResource}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VipSwap_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CloudServiceSwapResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> SwapResource object where slot type should be the target slot after vip swap for the specified cloud service. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation CreateOrUpdate(WaitUntil waitUntil, CloudServiceSwapData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _cloudServiceSwapVipSwapClientDiagnostics.CreateScope("CloudServiceSwapCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _cloudServiceSwapVipSwapRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, _resourceName, data, cancellationToken);
                var operation = new NetworkArmOperation(_cloudServiceSwapVipSwapClientDiagnostics, Pipeline, _cloudServiceSwapVipSwapRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, _resourceName, data).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the SwapResource which identifies the slot type for the specified cloud service. The slot type on a cloud service can either be Staging or Production
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{groupName}/providers/Microsoft.Compute/cloudServices/{resourceName}/providers/Microsoft.Network/cloudServiceSlots/{singletonResource}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VipSwap_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CloudServiceSwapResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<CloudServiceSwapResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _cloudServiceSwapVipSwapClientDiagnostics.CreateScope("CloudServiceSwapCollection.Get");
            scope.Start();
            try
            {
                var response = await _cloudServiceSwapVipSwapRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, _resourceName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CloudServiceSwapResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the SwapResource which identifies the slot type for the specified cloud service. The slot type on a cloud service can either be Staging or Production
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{groupName}/providers/Microsoft.Compute/cloudServices/{resourceName}/providers/Microsoft.Network/cloudServiceSlots/{singletonResource}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VipSwap_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CloudServiceSwapResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<CloudServiceSwapResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _cloudServiceSwapVipSwapClientDiagnostics.CreateScope("CloudServiceSwapCollection.Get");
            scope.Start();
            try
            {
                var response = _cloudServiceSwapVipSwapRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, _resourceName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CloudServiceSwapResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the list of SwapResource which identifies the slot type for the specified cloud service. The slot type on a cloud service can either be Staging or Production
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{groupName}/providers/Microsoft.Compute/cloudServices/{resourceName}/providers/Microsoft.Network/cloudServiceSlots</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VipSwap_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CloudServiceSwapResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="CloudServiceSwapResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<CloudServiceSwapResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _cloudServiceSwapVipSwapRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, _resourceName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, e => new CloudServiceSwapResource(Client, CloudServiceSwapData.DeserializeCloudServiceSwapData(e)), _cloudServiceSwapVipSwapClientDiagnostics, Pipeline, "CloudServiceSwapCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Gets the list of SwapResource which identifies the slot type for the specified cloud service. The slot type on a cloud service can either be Staging or Production
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{groupName}/providers/Microsoft.Compute/cloudServices/{resourceName}/providers/Microsoft.Network/cloudServiceSlots</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VipSwap_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CloudServiceSwapResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="CloudServiceSwapResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<CloudServiceSwapResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _cloudServiceSwapVipSwapRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, _resourceName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, e => new CloudServiceSwapResource(Client, CloudServiceSwapData.DeserializeCloudServiceSwapData(e)), _cloudServiceSwapVipSwapClientDiagnostics, Pipeline, "CloudServiceSwapCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{groupName}/providers/Microsoft.Compute/cloudServices/{resourceName}/providers/Microsoft.Network/cloudServiceSlots/{singletonResource}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VipSwap_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CloudServiceSwapResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<bool>> ExistsAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _cloudServiceSwapVipSwapClientDiagnostics.CreateScope("CloudServiceSwapCollection.Exists");
            scope.Start();
            try
            {
                var response = await _cloudServiceSwapVipSwapRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, _resourceName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{groupName}/providers/Microsoft.Compute/cloudServices/{resourceName}/providers/Microsoft.Network/cloudServiceSlots/{singletonResource}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VipSwap_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CloudServiceSwapResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<bool> Exists(CancellationToken cancellationToken = default)
        {
            using var scope = _cloudServiceSwapVipSwapClientDiagnostics.CreateScope("CloudServiceSwapCollection.Exists");
            scope.Start();
            try
            {
                var response = _cloudServiceSwapVipSwapRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, _resourceName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{groupName}/providers/Microsoft.Compute/cloudServices/{resourceName}/providers/Microsoft.Network/cloudServiceSlots/{singletonResource}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VipSwap_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CloudServiceSwapResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<NullableResponse<CloudServiceSwapResource>> GetIfExistsAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _cloudServiceSwapVipSwapClientDiagnostics.CreateScope("CloudServiceSwapCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _cloudServiceSwapVipSwapRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, _resourceName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<CloudServiceSwapResource>(response.GetRawResponse());
                return Response.FromValue(new CloudServiceSwapResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{groupName}/providers/Microsoft.Compute/cloudServices/{resourceName}/providers/Microsoft.Network/cloudServiceSlots/{singletonResource}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VipSwap_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CloudServiceSwapResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual NullableResponse<CloudServiceSwapResource> GetIfExists(CancellationToken cancellationToken = default)
        {
            using var scope = _cloudServiceSwapVipSwapClientDiagnostics.CreateScope("CloudServiceSwapCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _cloudServiceSwapVipSwapRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, _resourceName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<CloudServiceSwapResource>(response.GetRawResponse());
                return Response.FromValue(new CloudServiceSwapResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<CloudServiceSwapResource> IEnumerable<CloudServiceSwapResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<CloudServiceSwapResource> IAsyncEnumerable<CloudServiceSwapResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
