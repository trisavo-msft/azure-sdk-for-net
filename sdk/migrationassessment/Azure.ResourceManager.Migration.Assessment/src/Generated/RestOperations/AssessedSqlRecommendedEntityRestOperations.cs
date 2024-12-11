// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Migration.Assessment.Models;

namespace Azure.ResourceManager.Migration.Assessment
{
    internal partial class AssessedSqlRecommendedEntityRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of AssessedSqlRecommendedEntityRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public AssessedSqlRecommendedEntityRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2023-03-15";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal RequestUriBuilder CreateListBySqlAssessmentV2RequestUri(string subscriptionId, string resourceGroupName, string projectName, string groupName, string assessmentName, string filter, int? pageSize, string continuationToken, int? totalRecordCount)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Migrate/assessmentProjects/", false);
            uri.AppendPath(projectName, true);
            uri.AppendPath("/groups/", false);
            uri.AppendPath(groupName, true);
            uri.AppendPath("/sqlAssessments/", false);
            uri.AppendPath(assessmentName, true);
            uri.AppendPath("/recommendedAssessedEntities", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            if (filter != null)
            {
                uri.AppendQuery("$filter", filter, true);
            }
            if (pageSize != null)
            {
                uri.AppendQuery("pageSize", pageSize.Value, true);
            }
            if (continuationToken != null)
            {
                uri.AppendQuery("continuationToken", continuationToken, true);
            }
            if (totalRecordCount != null)
            {
                uri.AppendQuery("totalRecordCount", totalRecordCount.Value, true);
            }
            return uri;
        }

        internal HttpMessage CreateListBySqlAssessmentV2Request(string subscriptionId, string resourceGroupName, string projectName, string groupName, string assessmentName, string filter, int? pageSize, string continuationToken, int? totalRecordCount)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Migrate/assessmentProjects/", false);
            uri.AppendPath(projectName, true);
            uri.AppendPath("/groups/", false);
            uri.AppendPath(groupName, true);
            uri.AppendPath("/sqlAssessments/", false);
            uri.AppendPath(assessmentName, true);
            uri.AppendPath("/recommendedAssessedEntities", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            if (filter != null)
            {
                uri.AppendQuery("$filter", filter, true);
            }
            if (pageSize != null)
            {
                uri.AppendQuery("pageSize", pageSize.Value, true);
            }
            if (continuationToken != null)
            {
                uri.AppendQuery("continuationToken", continuationToken, true);
            }
            if (totalRecordCount != null)
            {
                uri.AppendQuery("totalRecordCount", totalRecordCount.Value, true);
            }
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> List AssessedSqlRecommendedEntity resources by SqlAssessmentV2. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="projectName"> Assessment Project Name. </param>
        /// <param name="groupName"> Group ARM name. </param>
        /// <param name="assessmentName"> SQL Assessment arm name. </param>
        /// <param name="filter"> Filter query. </param>
        /// <param name="pageSize"> Optional parameter for page size. </param>
        /// <param name="continuationToken"> Optional parameter for continuation token. </param>
        /// <param name="totalRecordCount"> Total record count. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="projectName"/>, <paramref name="groupName"/> or <paramref name="assessmentName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="projectName"/>, <paramref name="groupName"/> or <paramref name="assessmentName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<AssessedSqlRecommendedEntityListResult>> ListBySqlAssessmentV2Async(string subscriptionId, string resourceGroupName, string projectName, string groupName, string assessmentName, string filter = null, int? pageSize = null, string continuationToken = null, int? totalRecordCount = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(projectName, nameof(projectName));
            Argument.AssertNotNullOrEmpty(groupName, nameof(groupName));
            Argument.AssertNotNullOrEmpty(assessmentName, nameof(assessmentName));

            using var message = CreateListBySqlAssessmentV2Request(subscriptionId, resourceGroupName, projectName, groupName, assessmentName, filter, pageSize, continuationToken, totalRecordCount);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AssessedSqlRecommendedEntityListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = AssessedSqlRecommendedEntityListResult.DeserializeAssessedSqlRecommendedEntityListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> List AssessedSqlRecommendedEntity resources by SqlAssessmentV2. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="projectName"> Assessment Project Name. </param>
        /// <param name="groupName"> Group ARM name. </param>
        /// <param name="assessmentName"> SQL Assessment arm name. </param>
        /// <param name="filter"> Filter query. </param>
        /// <param name="pageSize"> Optional parameter for page size. </param>
        /// <param name="continuationToken"> Optional parameter for continuation token. </param>
        /// <param name="totalRecordCount"> Total record count. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="projectName"/>, <paramref name="groupName"/> or <paramref name="assessmentName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="projectName"/>, <paramref name="groupName"/> or <paramref name="assessmentName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<AssessedSqlRecommendedEntityListResult> ListBySqlAssessmentV2(string subscriptionId, string resourceGroupName, string projectName, string groupName, string assessmentName, string filter = null, int? pageSize = null, string continuationToken = null, int? totalRecordCount = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(projectName, nameof(projectName));
            Argument.AssertNotNullOrEmpty(groupName, nameof(groupName));
            Argument.AssertNotNullOrEmpty(assessmentName, nameof(assessmentName));

            using var message = CreateListBySqlAssessmentV2Request(subscriptionId, resourceGroupName, projectName, groupName, assessmentName, filter, pageSize, continuationToken, totalRecordCount);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AssessedSqlRecommendedEntityListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = AssessedSqlRecommendedEntityListResult.DeserializeAssessedSqlRecommendedEntityListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateGetRequestUri(string subscriptionId, string resourceGroupName, string projectName, string groupName, string assessmentName, string recommendedAssessedEntityName)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Migrate/assessmentProjects/", false);
            uri.AppendPath(projectName, true);
            uri.AppendPath("/groups/", false);
            uri.AppendPath(groupName, true);
            uri.AppendPath("/sqlAssessments/", false);
            uri.AppendPath(assessmentName, true);
            uri.AppendPath("/recommendedAssessedEntities/", false);
            uri.AppendPath(recommendedAssessedEntityName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateGetRequest(string subscriptionId, string resourceGroupName, string projectName, string groupName, string assessmentName, string recommendedAssessedEntityName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Migrate/assessmentProjects/", false);
            uri.AppendPath(projectName, true);
            uri.AppendPath("/groups/", false);
            uri.AppendPath(groupName, true);
            uri.AppendPath("/sqlAssessments/", false);
            uri.AppendPath(assessmentName, true);
            uri.AppendPath("/recommendedAssessedEntities/", false);
            uri.AppendPath(recommendedAssessedEntityName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Get a AssessedSqlRecommendedEntity. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="projectName"> Assessment Project Name. </param>
        /// <param name="groupName"> Group ARM name. </param>
        /// <param name="assessmentName"> SQL Assessment arm name. </param>
        /// <param name="recommendedAssessedEntityName"> Sql assessment Assessed Recommended Entity ARM name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="projectName"/>, <paramref name="groupName"/>, <paramref name="assessmentName"/> or <paramref name="recommendedAssessedEntityName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="projectName"/>, <paramref name="groupName"/>, <paramref name="assessmentName"/> or <paramref name="recommendedAssessedEntityName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<AssessedSqlRecommendedEntityData>> GetAsync(string subscriptionId, string resourceGroupName, string projectName, string groupName, string assessmentName, string recommendedAssessedEntityName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(projectName, nameof(projectName));
            Argument.AssertNotNullOrEmpty(groupName, nameof(groupName));
            Argument.AssertNotNullOrEmpty(assessmentName, nameof(assessmentName));
            Argument.AssertNotNullOrEmpty(recommendedAssessedEntityName, nameof(recommendedAssessedEntityName));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, projectName, groupName, assessmentName, recommendedAssessedEntityName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AssessedSqlRecommendedEntityData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = AssessedSqlRecommendedEntityData.DeserializeAssessedSqlRecommendedEntityData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((AssessedSqlRecommendedEntityData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get a AssessedSqlRecommendedEntity. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="projectName"> Assessment Project Name. </param>
        /// <param name="groupName"> Group ARM name. </param>
        /// <param name="assessmentName"> SQL Assessment arm name. </param>
        /// <param name="recommendedAssessedEntityName"> Sql assessment Assessed Recommended Entity ARM name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="projectName"/>, <paramref name="groupName"/>, <paramref name="assessmentName"/> or <paramref name="recommendedAssessedEntityName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="projectName"/>, <paramref name="groupName"/>, <paramref name="assessmentName"/> or <paramref name="recommendedAssessedEntityName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<AssessedSqlRecommendedEntityData> Get(string subscriptionId, string resourceGroupName, string projectName, string groupName, string assessmentName, string recommendedAssessedEntityName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(projectName, nameof(projectName));
            Argument.AssertNotNullOrEmpty(groupName, nameof(groupName));
            Argument.AssertNotNullOrEmpty(assessmentName, nameof(assessmentName));
            Argument.AssertNotNullOrEmpty(recommendedAssessedEntityName, nameof(recommendedAssessedEntityName));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, projectName, groupName, assessmentName, recommendedAssessedEntityName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AssessedSqlRecommendedEntityData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = AssessedSqlRecommendedEntityData.DeserializeAssessedSqlRecommendedEntityData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((AssessedSqlRecommendedEntityData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateListBySqlAssessmentV2NextPageRequestUri(string nextLink, string subscriptionId, string resourceGroupName, string projectName, string groupName, string assessmentName, string filter, int? pageSize, string continuationToken, int? totalRecordCount)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            return uri;
        }

        internal HttpMessage CreateListBySqlAssessmentV2NextPageRequest(string nextLink, string subscriptionId, string resourceGroupName, string projectName, string groupName, string assessmentName, string filter, int? pageSize, string continuationToken, int? totalRecordCount)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> List AssessedSqlRecommendedEntity resources by SqlAssessmentV2. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="projectName"> Assessment Project Name. </param>
        /// <param name="groupName"> Group ARM name. </param>
        /// <param name="assessmentName"> SQL Assessment arm name. </param>
        /// <param name="filter"> Filter query. </param>
        /// <param name="pageSize"> Optional parameter for page size. </param>
        /// <param name="continuationToken"> Optional parameter for continuation token. </param>
        /// <param name="totalRecordCount"> Total record count. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="projectName"/>, <paramref name="groupName"/> or <paramref name="assessmentName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="projectName"/>, <paramref name="groupName"/> or <paramref name="assessmentName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<AssessedSqlRecommendedEntityListResult>> ListBySqlAssessmentV2NextPageAsync(string nextLink, string subscriptionId, string resourceGroupName, string projectName, string groupName, string assessmentName, string filter = null, int? pageSize = null, string continuationToken = null, int? totalRecordCount = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(projectName, nameof(projectName));
            Argument.AssertNotNullOrEmpty(groupName, nameof(groupName));
            Argument.AssertNotNullOrEmpty(assessmentName, nameof(assessmentName));

            using var message = CreateListBySqlAssessmentV2NextPageRequest(nextLink, subscriptionId, resourceGroupName, projectName, groupName, assessmentName, filter, pageSize, continuationToken, totalRecordCount);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AssessedSqlRecommendedEntityListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = AssessedSqlRecommendedEntityListResult.DeserializeAssessedSqlRecommendedEntityListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> List AssessedSqlRecommendedEntity resources by SqlAssessmentV2. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="projectName"> Assessment Project Name. </param>
        /// <param name="groupName"> Group ARM name. </param>
        /// <param name="assessmentName"> SQL Assessment arm name. </param>
        /// <param name="filter"> Filter query. </param>
        /// <param name="pageSize"> Optional parameter for page size. </param>
        /// <param name="continuationToken"> Optional parameter for continuation token. </param>
        /// <param name="totalRecordCount"> Total record count. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="projectName"/>, <paramref name="groupName"/> or <paramref name="assessmentName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="projectName"/>, <paramref name="groupName"/> or <paramref name="assessmentName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<AssessedSqlRecommendedEntityListResult> ListBySqlAssessmentV2NextPage(string nextLink, string subscriptionId, string resourceGroupName, string projectName, string groupName, string assessmentName, string filter = null, int? pageSize = null, string continuationToken = null, int? totalRecordCount = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(projectName, nameof(projectName));
            Argument.AssertNotNullOrEmpty(groupName, nameof(groupName));
            Argument.AssertNotNullOrEmpty(assessmentName, nameof(assessmentName));

            using var message = CreateListBySqlAssessmentV2NextPageRequest(nextLink, subscriptionId, resourceGroupName, projectName, groupName, assessmentName, filter, pageSize, continuationToken, totalRecordCount);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AssessedSqlRecommendedEntityListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = AssessedSqlRecommendedEntityListResult.DeserializeAssessedSqlRecommendedEntityListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
