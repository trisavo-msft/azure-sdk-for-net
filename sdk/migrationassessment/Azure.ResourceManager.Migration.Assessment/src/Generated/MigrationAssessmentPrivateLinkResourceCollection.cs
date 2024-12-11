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
    /// A class representing a collection of <see cref="MigrationAssessmentPrivateLinkResource"/> and their operations.
    /// Each <see cref="MigrationAssessmentPrivateLinkResource"/> in the collection will belong to the same instance of <see cref="MigrationAssessmentAssessmentProjectResource"/>.
    /// To get a <see cref="MigrationAssessmentPrivateLinkResourceCollection"/> instance call the GetMigrationAssessmentPrivateLinkResources method from an instance of <see cref="MigrationAssessmentAssessmentProjectResource"/>.
    /// </summary>
    public partial class MigrationAssessmentPrivateLinkResourceCollection : ArmCollection, IEnumerable<MigrationAssessmentPrivateLinkResource>, IAsyncEnumerable<MigrationAssessmentPrivateLinkResource>
    {
        private readonly ClientDiagnostics _migrationAssessmentPrivateLinkResourcePrivateLinkResourceOperationsClientDiagnostics;
        private readonly PrivateLinkResourceRestOperations _migrationAssessmentPrivateLinkResourcePrivateLinkResourceOperationsRestClient;

        /// <summary> Initializes a new instance of the <see cref="MigrationAssessmentPrivateLinkResourceCollection"/> class for mocking. </summary>
        protected MigrationAssessmentPrivateLinkResourceCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MigrationAssessmentPrivateLinkResourceCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal MigrationAssessmentPrivateLinkResourceCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _migrationAssessmentPrivateLinkResourcePrivateLinkResourceOperationsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Migration.Assessment", MigrationAssessmentPrivateLinkResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(MigrationAssessmentPrivateLinkResource.ResourceType, out string migrationAssessmentPrivateLinkResourcePrivateLinkResourceOperationsApiVersion);
            _migrationAssessmentPrivateLinkResourcePrivateLinkResourceOperationsRestClient = new PrivateLinkResourceRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, migrationAssessmentPrivateLinkResourcePrivateLinkResourceOperationsApiVersion);
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
        /// Get a PrivateLinkResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Migrate/assessmentProjects/{projectName}/privateLinkResources/{privateLinkResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateLinkResourceOperations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MigrationAssessmentPrivateLinkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="privateLinkResourceName"> Private link resource ARM name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateLinkResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateLinkResourceName"/> is null. </exception>
        public virtual async Task<Response<MigrationAssessmentPrivateLinkResource>> GetAsync(string privateLinkResourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateLinkResourceName, nameof(privateLinkResourceName));

            using var scope = _migrationAssessmentPrivateLinkResourcePrivateLinkResourceOperationsClientDiagnostics.CreateScope("MigrationAssessmentPrivateLinkResourceCollection.Get");
            scope.Start();
            try
            {
                var response = await _migrationAssessmentPrivateLinkResourcePrivateLinkResourceOperationsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, privateLinkResourceName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MigrationAssessmentPrivateLinkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a PrivateLinkResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Migrate/assessmentProjects/{projectName}/privateLinkResources/{privateLinkResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateLinkResourceOperations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MigrationAssessmentPrivateLinkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="privateLinkResourceName"> Private link resource ARM name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateLinkResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateLinkResourceName"/> is null. </exception>
        public virtual Response<MigrationAssessmentPrivateLinkResource> Get(string privateLinkResourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateLinkResourceName, nameof(privateLinkResourceName));

            using var scope = _migrationAssessmentPrivateLinkResourcePrivateLinkResourceOperationsClientDiagnostics.CreateScope("MigrationAssessmentPrivateLinkResourceCollection.Get");
            scope.Start();
            try
            {
                var response = _migrationAssessmentPrivateLinkResourcePrivateLinkResourceOperationsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, privateLinkResourceName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MigrationAssessmentPrivateLinkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List PrivateLinkResource resources by AssessmentProject
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Migrate/assessmentProjects/{projectName}/privateLinkResources</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateLinkResourceOperations_ListByAssessmentProject</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MigrationAssessmentPrivateLinkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="MigrationAssessmentPrivateLinkResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<MigrationAssessmentPrivateLinkResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _migrationAssessmentPrivateLinkResourcePrivateLinkResourceOperationsRestClient.CreateListByAssessmentProjectRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _migrationAssessmentPrivateLinkResourcePrivateLinkResourceOperationsRestClient.CreateListByAssessmentProjectNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new MigrationAssessmentPrivateLinkResource(Client, MigrationAssessmentPrivateLinkResourceData.DeserializeMigrationAssessmentPrivateLinkResourceData(e)), _migrationAssessmentPrivateLinkResourcePrivateLinkResourceOperationsClientDiagnostics, Pipeline, "MigrationAssessmentPrivateLinkResourceCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List PrivateLinkResource resources by AssessmentProject
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Migrate/assessmentProjects/{projectName}/privateLinkResources</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateLinkResourceOperations_ListByAssessmentProject</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MigrationAssessmentPrivateLinkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="MigrationAssessmentPrivateLinkResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<MigrationAssessmentPrivateLinkResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _migrationAssessmentPrivateLinkResourcePrivateLinkResourceOperationsRestClient.CreateListByAssessmentProjectRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _migrationAssessmentPrivateLinkResourcePrivateLinkResourceOperationsRestClient.CreateListByAssessmentProjectNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new MigrationAssessmentPrivateLinkResource(Client, MigrationAssessmentPrivateLinkResourceData.DeserializeMigrationAssessmentPrivateLinkResourceData(e)), _migrationAssessmentPrivateLinkResourcePrivateLinkResourceOperationsClientDiagnostics, Pipeline, "MigrationAssessmentPrivateLinkResourceCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Migrate/assessmentProjects/{projectName}/privateLinkResources/{privateLinkResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateLinkResourceOperations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MigrationAssessmentPrivateLinkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="privateLinkResourceName"> Private link resource ARM name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateLinkResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateLinkResourceName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string privateLinkResourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateLinkResourceName, nameof(privateLinkResourceName));

            using var scope = _migrationAssessmentPrivateLinkResourcePrivateLinkResourceOperationsClientDiagnostics.CreateScope("MigrationAssessmentPrivateLinkResourceCollection.Exists");
            scope.Start();
            try
            {
                var response = await _migrationAssessmentPrivateLinkResourcePrivateLinkResourceOperationsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, privateLinkResourceName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Migrate/assessmentProjects/{projectName}/privateLinkResources/{privateLinkResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateLinkResourceOperations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MigrationAssessmentPrivateLinkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="privateLinkResourceName"> Private link resource ARM name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateLinkResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateLinkResourceName"/> is null. </exception>
        public virtual Response<bool> Exists(string privateLinkResourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateLinkResourceName, nameof(privateLinkResourceName));

            using var scope = _migrationAssessmentPrivateLinkResourcePrivateLinkResourceOperationsClientDiagnostics.CreateScope("MigrationAssessmentPrivateLinkResourceCollection.Exists");
            scope.Start();
            try
            {
                var response = _migrationAssessmentPrivateLinkResourcePrivateLinkResourceOperationsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, privateLinkResourceName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Migrate/assessmentProjects/{projectName}/privateLinkResources/{privateLinkResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateLinkResourceOperations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MigrationAssessmentPrivateLinkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="privateLinkResourceName"> Private link resource ARM name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateLinkResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateLinkResourceName"/> is null. </exception>
        public virtual async Task<NullableResponse<MigrationAssessmentPrivateLinkResource>> GetIfExistsAsync(string privateLinkResourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateLinkResourceName, nameof(privateLinkResourceName));

            using var scope = _migrationAssessmentPrivateLinkResourcePrivateLinkResourceOperationsClientDiagnostics.CreateScope("MigrationAssessmentPrivateLinkResourceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _migrationAssessmentPrivateLinkResourcePrivateLinkResourceOperationsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, privateLinkResourceName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<MigrationAssessmentPrivateLinkResource>(response.GetRawResponse());
                return Response.FromValue(new MigrationAssessmentPrivateLinkResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Migrate/assessmentProjects/{projectName}/privateLinkResources/{privateLinkResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateLinkResourceOperations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MigrationAssessmentPrivateLinkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="privateLinkResourceName"> Private link resource ARM name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateLinkResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateLinkResourceName"/> is null. </exception>
        public virtual NullableResponse<MigrationAssessmentPrivateLinkResource> GetIfExists(string privateLinkResourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateLinkResourceName, nameof(privateLinkResourceName));

            using var scope = _migrationAssessmentPrivateLinkResourcePrivateLinkResourceOperationsClientDiagnostics.CreateScope("MigrationAssessmentPrivateLinkResourceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _migrationAssessmentPrivateLinkResourcePrivateLinkResourceOperationsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, privateLinkResourceName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<MigrationAssessmentPrivateLinkResource>(response.GetRawResponse());
                return Response.FromValue(new MigrationAssessmentPrivateLinkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<MigrationAssessmentPrivateLinkResource> IEnumerable<MigrationAssessmentPrivateLinkResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<MigrationAssessmentPrivateLinkResource> IAsyncEnumerable<MigrationAssessmentPrivateLinkResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
