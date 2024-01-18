// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.ResourceHealth;
using Azure.ResourceManager.ResourceHealth.Models;

namespace Azure.ResourceManager.ResourceHealth.Mocking
{
    /// <summary> A class to add extension methods to TenantResource. </summary>
    public partial class MockableResourceHealthTenantResource : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="MockableResourceHealthTenantResource"/> class for mocking. </summary>
        protected MockableResourceHealthTenantResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableResourceHealthTenantResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableResourceHealthTenantResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of ResourceHealthMetadataEntityResources in the TenantResource. </summary>
        /// <returns> An object representing collection of ResourceHealthMetadataEntityResources and their operations over a ResourceHealthMetadataEntityResource. </returns>
        public virtual ResourceHealthMetadataEntityCollection GetResourceHealthMetadataEntities()
        {
            return GetCachedClient(client => new ResourceHealthMetadataEntityCollection(client, Id));
        }

        /// <summary>
        /// Gets the list of metadata entities.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.ResourceHealth/metadata/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Metadata_GetEntity</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ResourceHealthMetadataEntityResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> Name of metadata entity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<ResourceHealthMetadataEntityResource>> GetResourceHealthMetadataEntityAsync(string name, CancellationToken cancellationToken = default)
        {
            return await GetResourceHealthMetadataEntities().GetAsync(name, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the list of metadata entities.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.ResourceHealth/metadata/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Metadata_GetEntity</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ResourceHealthMetadataEntityResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> Name of metadata entity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<ResourceHealthMetadataEntityResource> GetResourceHealthMetadataEntity(string name, CancellationToken cancellationToken = default)
        {
            return GetResourceHealthMetadataEntities().Get(name, cancellationToken);
        }

        /// <summary> Gets a collection of TenantResourceHealthEventResources in the TenantResource. </summary>
        /// <returns> An object representing collection of TenantResourceHealthEventResources and their operations over a TenantResourceHealthEventResource. </returns>
        public virtual TenantResourceHealthEventCollection GetTenantResourceHealthEvents()
        {
            return GetCachedClient(client => new TenantResourceHealthEventCollection(client, Id));
        }

        /// <summary>
        /// Service health event in the tenant by event tracking id
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.ResourceHealth/events/{eventTrackingId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Event_GetByTenantIdAndTrackingId</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="TenantResourceHealthEventResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="eventTrackingId"> Event Id which uniquely identifies ServiceHealth event. </param>
        /// <param name="filter"> The filter to apply on the operation. For more information please see https://docs.microsoft.com/en-us/rest/api/apimanagement/apis?redirectedfrom=MSDN. </param>
        /// <param name="queryStartTime"> Specifies from when to return events, based on the lastUpdateTime property. For example, queryStartTime = 7/24/2020 OR queryStartTime=7%2F24%2F2020. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="eventTrackingId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="eventTrackingId"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<TenantResourceHealthEventResource>> GetTenantResourceHealthEventAsync(string eventTrackingId, string filter = null, string queryStartTime = null, CancellationToken cancellationToken = default)
        {
            return await GetTenantResourceHealthEvents().GetAsync(eventTrackingId, filter, queryStartTime, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Service health event in the tenant by event tracking id
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.ResourceHealth/events/{eventTrackingId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Event_GetByTenantIdAndTrackingId</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="TenantResourceHealthEventResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="eventTrackingId"> Event Id which uniquely identifies ServiceHealth event. </param>
        /// <param name="filter"> The filter to apply on the operation. For more information please see https://docs.microsoft.com/en-us/rest/api/apimanagement/apis?redirectedfrom=MSDN. </param>
        /// <param name="queryStartTime"> Specifies from when to return events, based on the lastUpdateTime property. For example, queryStartTime = 7/24/2020 OR queryStartTime=7%2F24%2F2020. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="eventTrackingId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="eventTrackingId"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<TenantResourceHealthEventResource> GetTenantResourceHealthEvent(string eventTrackingId, string filter = null, string queryStartTime = null, CancellationToken cancellationToken = default)
        {
            return GetTenantResourceHealthEvents().Get(eventTrackingId, filter, queryStartTime, cancellationToken);
        }

        /// <summary> Gets a collection of ServiceEmergingIssueResources in the TenantResource. </summary>
        /// <returns> An object representing collection of ServiceEmergingIssueResources and their operations over a ServiceEmergingIssueResource. </returns>
        public virtual ServiceEmergingIssueCollection GetServiceEmergingIssues()
        {
            return GetCachedClient(client => new ServiceEmergingIssueCollection(client, Id));
        }

        /// <summary>
        /// Gets Azure services' emerging issues.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.ResourceHealth/emergingIssues/{issueName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>EmergingIssues_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ServiceEmergingIssueResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="issueName"> The name of the emerging issue. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public virtual async Task<Response<ServiceEmergingIssueResource>> GetServiceEmergingIssueAsync(EmergingIssueNameContent issueName, CancellationToken cancellationToken = default)
        {
            return await GetServiceEmergingIssues().GetAsync(issueName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets Azure services' emerging issues.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.ResourceHealth/emergingIssues/{issueName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>EmergingIssues_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ServiceEmergingIssueResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="issueName"> The name of the emerging issue. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public virtual Response<ServiceEmergingIssueResource> GetServiceEmergingIssue(EmergingIssueNameContent issueName, CancellationToken cancellationToken = default)
        {
            return GetServiceEmergingIssues().Get(issueName, cancellationToken);
        }
    }
}
