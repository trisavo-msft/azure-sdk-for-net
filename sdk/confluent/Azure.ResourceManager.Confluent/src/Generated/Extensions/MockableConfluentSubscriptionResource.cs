// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Confluent;
using Azure.ResourceManager.Confluent.Models;

namespace Azure.ResourceManager.Confluent.Mocking
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    public partial class MockableConfluentSubscriptionResource : ArmResource
    {
        private ClientDiagnostics _marketplaceAgreementsClientDiagnostics;
        private MarketplaceAgreementsRestOperations _marketplaceAgreementsRestClient;
        private ClientDiagnostics _confluentOrganizationOrganizationClientDiagnostics;
        private OrganizationRestOperations _confluentOrganizationOrganizationRestClient;

        /// <summary> Initializes a new instance of the <see cref="MockableConfluentSubscriptionResource"/> class for mocking. </summary>
        protected MockableConfluentSubscriptionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableConfluentSubscriptionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableConfluentSubscriptionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics MarketplaceAgreementsClientDiagnostics => _marketplaceAgreementsClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.Confluent", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private MarketplaceAgreementsRestOperations MarketplaceAgreementsRestClient => _marketplaceAgreementsRestClient ??= new MarketplaceAgreementsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
        private ClientDiagnostics ConfluentOrganizationOrganizationClientDiagnostics => _confluentOrganizationOrganizationClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.Confluent", ConfluentOrganizationResource.ResourceType.Namespace, Diagnostics);
        private OrganizationRestOperations ConfluentOrganizationOrganizationRestClient => _confluentOrganizationOrganizationRestClient ??= new OrganizationRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(ConfluentOrganizationResource.ResourceType));

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// List Confluent marketplace agreements in the subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Confluent/agreements</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MarketplaceAgreements_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-12-01</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ConfluentAgreement"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ConfluentAgreement> GetMarketplaceAgreementsAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => MarketplaceAgreementsRestClient.CreateListRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => MarketplaceAgreementsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, ConfluentAgreement.DeserializeConfluentAgreement, MarketplaceAgreementsClientDiagnostics, Pipeline, "MockableConfluentSubscriptionResource.GetMarketplaceAgreements", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List Confluent marketplace agreements in the subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Confluent/agreements</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MarketplaceAgreements_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-12-01</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ConfluentAgreement"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ConfluentAgreement> GetMarketplaceAgreements(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => MarketplaceAgreementsRestClient.CreateListRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => MarketplaceAgreementsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, ConfluentAgreement.DeserializeConfluentAgreement, MarketplaceAgreementsClientDiagnostics, Pipeline, "MockableConfluentSubscriptionResource.GetMarketplaceAgreements", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Create Confluent Marketplace agreement in the subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Confluent/agreements/default</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MarketplaceAgreements_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-12-01</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="body"> Confluent Marketplace Agreement resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ConfluentAgreement>> CreateMarketplaceAgreementAsync(ConfluentAgreement body = null, CancellationToken cancellationToken = default)
        {
            using var scope = MarketplaceAgreementsClientDiagnostics.CreateScope("MockableConfluentSubscriptionResource.CreateMarketplaceAgreement");
            scope.Start();
            try
            {
                var response = await MarketplaceAgreementsRestClient.CreateAsync(Id.SubscriptionId, body, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Create Confluent Marketplace agreement in the subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Confluent/agreements/default</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MarketplaceAgreements_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-12-01</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="body"> Confluent Marketplace Agreement resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ConfluentAgreement> CreateMarketplaceAgreement(ConfluentAgreement body = null, CancellationToken cancellationToken = default)
        {
            using var scope = MarketplaceAgreementsClientDiagnostics.CreateScope("MockableConfluentSubscriptionResource.CreateMarketplaceAgreement");
            scope.Start();
            try
            {
                var response = MarketplaceAgreementsRestClient.Create(Id.SubscriptionId, body, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List all organizations under the specified subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Confluent/organizations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Organization_ListBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ConfluentOrganizationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ConfluentOrganizationResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ConfluentOrganizationResource> GetConfluentOrganizationsAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => ConfluentOrganizationOrganizationRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => ConfluentOrganizationOrganizationRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ConfluentOrganizationResource(Client, ConfluentOrganizationData.DeserializeConfluentOrganizationData(e)), ConfluentOrganizationOrganizationClientDiagnostics, Pipeline, "MockableConfluentSubscriptionResource.GetConfluentOrganizations", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List all organizations under the specified subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Confluent/organizations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Organization_ListBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ConfluentOrganizationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ConfluentOrganizationResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ConfluentOrganizationResource> GetConfluentOrganizations(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => ConfluentOrganizationOrganizationRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => ConfluentOrganizationOrganizationRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ConfluentOrganizationResource(Client, ConfluentOrganizationData.DeserializeConfluentOrganizationData(e)), ConfluentOrganizationOrganizationClientDiagnostics, Pipeline, "MockableConfluentSubscriptionResource.GetConfluentOrganizations", "value", "nextLink", cancellationToken);
        }
    }
}
