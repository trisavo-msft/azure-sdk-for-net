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
    /// A class representing a collection of <see cref="MigrationAssessmentAssessmentProjectSummaryResource"/> and their operations.
    /// Each <see cref="MigrationAssessmentAssessmentProjectSummaryResource"/> in the collection will belong to the same instance of <see cref="MigrationAssessmentAssessmentProjectResource"/>.
    /// To get a <see cref="MigrationAssessmentAssessmentProjectSummaryCollection"/> instance call the GetMigrationAssessmentAssessmentProjectSummaries method from an instance of <see cref="MigrationAssessmentAssessmentProjectResource"/>.
    /// </summary>
    public partial class MigrationAssessmentAssessmentProjectSummaryCollection : ArmCollection, IEnumerable<MigrationAssessmentAssessmentProjectSummaryResource>, IAsyncEnumerable<MigrationAssessmentAssessmentProjectSummaryResource>
    {
        private readonly ClientDiagnostics _migrationAssessmentAssessmentProjectSummaryAssessmentProjectSummaryOperationsClientDiagnostics;
        private readonly AssessmentProjectSummaryRestOperations _migrationAssessmentAssessmentProjectSummaryAssessmentProjectSummaryOperationsRestClient;

        /// <summary> Initializes a new instance of the <see cref="MigrationAssessmentAssessmentProjectSummaryCollection"/> class for mocking. </summary>
        protected MigrationAssessmentAssessmentProjectSummaryCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MigrationAssessmentAssessmentProjectSummaryCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal MigrationAssessmentAssessmentProjectSummaryCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _migrationAssessmentAssessmentProjectSummaryAssessmentProjectSummaryOperationsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Migration.Assessment", MigrationAssessmentAssessmentProjectSummaryResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(MigrationAssessmentAssessmentProjectSummaryResource.ResourceType, out string migrationAssessmentAssessmentProjectSummaryAssessmentProjectSummaryOperationsApiVersion);
            _migrationAssessmentAssessmentProjectSummaryAssessmentProjectSummaryOperationsRestClient = new AssessmentProjectSummaryRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, migrationAssessmentAssessmentProjectSummaryAssessmentProjectSummaryOperationsApiVersion);
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
        /// Get a AssessmentProjectSummary
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Migrate/assessmentProjects/{projectName}/projectSummary/{projectSummaryName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AssessmentProjectSummaryOperations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MigrationAssessmentAssessmentProjectSummaryResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="projectSummaryName"> Group ARM name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="projectSummaryName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="projectSummaryName"/> is null. </exception>
        public virtual async Task<Response<MigrationAssessmentAssessmentProjectSummaryResource>> GetAsync(string projectSummaryName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(projectSummaryName, nameof(projectSummaryName));

            using var scope = _migrationAssessmentAssessmentProjectSummaryAssessmentProjectSummaryOperationsClientDiagnostics.CreateScope("MigrationAssessmentAssessmentProjectSummaryCollection.Get");
            scope.Start();
            try
            {
                var response = await _migrationAssessmentAssessmentProjectSummaryAssessmentProjectSummaryOperationsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, projectSummaryName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MigrationAssessmentAssessmentProjectSummaryResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a AssessmentProjectSummary
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Migrate/assessmentProjects/{projectName}/projectSummary/{projectSummaryName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AssessmentProjectSummaryOperations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MigrationAssessmentAssessmentProjectSummaryResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="projectSummaryName"> Group ARM name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="projectSummaryName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="projectSummaryName"/> is null. </exception>
        public virtual Response<MigrationAssessmentAssessmentProjectSummaryResource> Get(string projectSummaryName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(projectSummaryName, nameof(projectSummaryName));

            using var scope = _migrationAssessmentAssessmentProjectSummaryAssessmentProjectSummaryOperationsClientDiagnostics.CreateScope("MigrationAssessmentAssessmentProjectSummaryCollection.Get");
            scope.Start();
            try
            {
                var response = _migrationAssessmentAssessmentProjectSummaryAssessmentProjectSummaryOperationsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, projectSummaryName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MigrationAssessmentAssessmentProjectSummaryResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List AssessmentProjectSummary resources by AssessmentProject
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Migrate/assessmentProjects/{projectName}/projectSummary</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AssessmentProjectSummaryOperations_ListByAssessmentProject</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MigrationAssessmentAssessmentProjectSummaryResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="MigrationAssessmentAssessmentProjectSummaryResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<MigrationAssessmentAssessmentProjectSummaryResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _migrationAssessmentAssessmentProjectSummaryAssessmentProjectSummaryOperationsRestClient.CreateListByAssessmentProjectRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _migrationAssessmentAssessmentProjectSummaryAssessmentProjectSummaryOperationsRestClient.CreateListByAssessmentProjectNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new MigrationAssessmentAssessmentProjectSummaryResource(Client, MigrationAssessmentAssessmentProjectSummaryData.DeserializeMigrationAssessmentAssessmentProjectSummaryData(e)), _migrationAssessmentAssessmentProjectSummaryAssessmentProjectSummaryOperationsClientDiagnostics, Pipeline, "MigrationAssessmentAssessmentProjectSummaryCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List AssessmentProjectSummary resources by AssessmentProject
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Migrate/assessmentProjects/{projectName}/projectSummary</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AssessmentProjectSummaryOperations_ListByAssessmentProject</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MigrationAssessmentAssessmentProjectSummaryResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="MigrationAssessmentAssessmentProjectSummaryResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<MigrationAssessmentAssessmentProjectSummaryResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _migrationAssessmentAssessmentProjectSummaryAssessmentProjectSummaryOperationsRestClient.CreateListByAssessmentProjectRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _migrationAssessmentAssessmentProjectSummaryAssessmentProjectSummaryOperationsRestClient.CreateListByAssessmentProjectNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new MigrationAssessmentAssessmentProjectSummaryResource(Client, MigrationAssessmentAssessmentProjectSummaryData.DeserializeMigrationAssessmentAssessmentProjectSummaryData(e)), _migrationAssessmentAssessmentProjectSummaryAssessmentProjectSummaryOperationsClientDiagnostics, Pipeline, "MigrationAssessmentAssessmentProjectSummaryCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Migrate/assessmentProjects/{projectName}/projectSummary/{projectSummaryName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AssessmentProjectSummaryOperations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MigrationAssessmentAssessmentProjectSummaryResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="projectSummaryName"> Group ARM name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="projectSummaryName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="projectSummaryName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string projectSummaryName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(projectSummaryName, nameof(projectSummaryName));

            using var scope = _migrationAssessmentAssessmentProjectSummaryAssessmentProjectSummaryOperationsClientDiagnostics.CreateScope("MigrationAssessmentAssessmentProjectSummaryCollection.Exists");
            scope.Start();
            try
            {
                var response = await _migrationAssessmentAssessmentProjectSummaryAssessmentProjectSummaryOperationsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, projectSummaryName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Migrate/assessmentProjects/{projectName}/projectSummary/{projectSummaryName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AssessmentProjectSummaryOperations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MigrationAssessmentAssessmentProjectSummaryResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="projectSummaryName"> Group ARM name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="projectSummaryName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="projectSummaryName"/> is null. </exception>
        public virtual Response<bool> Exists(string projectSummaryName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(projectSummaryName, nameof(projectSummaryName));

            using var scope = _migrationAssessmentAssessmentProjectSummaryAssessmentProjectSummaryOperationsClientDiagnostics.CreateScope("MigrationAssessmentAssessmentProjectSummaryCollection.Exists");
            scope.Start();
            try
            {
                var response = _migrationAssessmentAssessmentProjectSummaryAssessmentProjectSummaryOperationsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, projectSummaryName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Migrate/assessmentProjects/{projectName}/projectSummary/{projectSummaryName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AssessmentProjectSummaryOperations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MigrationAssessmentAssessmentProjectSummaryResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="projectSummaryName"> Group ARM name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="projectSummaryName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="projectSummaryName"/> is null. </exception>
        public virtual async Task<NullableResponse<MigrationAssessmentAssessmentProjectSummaryResource>> GetIfExistsAsync(string projectSummaryName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(projectSummaryName, nameof(projectSummaryName));

            using var scope = _migrationAssessmentAssessmentProjectSummaryAssessmentProjectSummaryOperationsClientDiagnostics.CreateScope("MigrationAssessmentAssessmentProjectSummaryCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _migrationAssessmentAssessmentProjectSummaryAssessmentProjectSummaryOperationsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, projectSummaryName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<MigrationAssessmentAssessmentProjectSummaryResource>(response.GetRawResponse());
                return Response.FromValue(new MigrationAssessmentAssessmentProjectSummaryResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Migrate/assessmentProjects/{projectName}/projectSummary/{projectSummaryName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AssessmentProjectSummaryOperations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MigrationAssessmentAssessmentProjectSummaryResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="projectSummaryName"> Group ARM name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="projectSummaryName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="projectSummaryName"/> is null. </exception>
        public virtual NullableResponse<MigrationAssessmentAssessmentProjectSummaryResource> GetIfExists(string projectSummaryName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(projectSummaryName, nameof(projectSummaryName));

            using var scope = _migrationAssessmentAssessmentProjectSummaryAssessmentProjectSummaryOperationsClientDiagnostics.CreateScope("MigrationAssessmentAssessmentProjectSummaryCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _migrationAssessmentAssessmentProjectSummaryAssessmentProjectSummaryOperationsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, projectSummaryName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<MigrationAssessmentAssessmentProjectSummaryResource>(response.GetRawResponse());
                return Response.FromValue(new MigrationAssessmentAssessmentProjectSummaryResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<MigrationAssessmentAssessmentProjectSummaryResource> IEnumerable<MigrationAssessmentAssessmentProjectSummaryResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<MigrationAssessmentAssessmentProjectSummaryResource> IAsyncEnumerable<MigrationAssessmentAssessmentProjectSummaryResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
