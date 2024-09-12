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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.DeveloperHub
{
    /// <summary>
    /// A class representing a collection of <see cref="GitHubOAuthResponseResource"/> and their operations.
    /// Each <see cref="GitHubOAuthResponseResource"/> in the collection will belong to the same instance of <see cref="SubscriptionResource"/>.
    /// To get a <see cref="GitHubOAuthResponseCollection"/> instance call the GetGitHubOAuthResponses method from an instance of <see cref="SubscriptionResource"/>.
    /// </summary>
    public partial class GitHubOAuthResponseCollection : ArmCollection, IEnumerable<GitHubOAuthResponseResource>, IAsyncEnumerable<GitHubOAuthResponseResource>
    {
        private readonly ClientDiagnostics _gitHubOAuthResponseClientDiagnostics;
        private readonly DeveloperHubServiceRestOperations _gitHubOAuthResponseRestClient;
        private readonly AzureLocation _location;

        /// <summary> Initializes a new instance of the <see cref="GitHubOAuthResponseCollection"/> class for mocking. </summary>
        protected GitHubOAuthResponseCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="GitHubOAuthResponseCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        /// <param name="location"> The name of the Azure region. </param>
        internal GitHubOAuthResponseCollection(ArmClient client, ResourceIdentifier id, AzureLocation location) : base(client, id)
        {
            _location = location;
            _gitHubOAuthResponseClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DeveloperHub", GitHubOAuthResponseResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(GitHubOAuthResponseResource.ResourceType, out string gitHubOAuthResponseApiVersion);
            _gitHubOAuthResponseRestClient = new DeveloperHubServiceRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, gitHubOAuthResponseApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SubscriptionResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SubscriptionResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Callback URL to hit once authenticated with GitHub App to have the service store the OAuth token.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DevHub/locations/{location}/githuboauth/default</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GitHubOAuthCallback</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="GitHubOAuthResponseResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="code"> The code response from authenticating the GitHub App. </param>
        /// <param name="state"> The state response from authenticating the GitHub App. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="code"/> or <paramref name="state"/> is null. </exception>
        public virtual async Task<Response<GitHubOAuthResponseResource>> GetAsync(string code, string state, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(code, nameof(code));
            Argument.AssertNotNull(state, nameof(state));

            using var scope = _gitHubOAuthResponseClientDiagnostics.CreateScope("GitHubOAuthResponseCollection.Get");
            scope.Start();
            try
            {
                var response = await _gitHubOAuthResponseRestClient.GitHubOAuthCallbackAsync(Id.SubscriptionId, new AzureLocation(_location), code, state, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new GitHubOAuthResponseResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Callback URL to hit once authenticated with GitHub App to have the service store the OAuth token.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DevHub/locations/{location}/githuboauth/default</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GitHubOAuthCallback</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="GitHubOAuthResponseResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="code"> The code response from authenticating the GitHub App. </param>
        /// <param name="state"> The state response from authenticating the GitHub App. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="code"/> or <paramref name="state"/> is null. </exception>
        public virtual Response<GitHubOAuthResponseResource> Get(string code, string state, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(code, nameof(code));
            Argument.AssertNotNull(state, nameof(state));

            using var scope = _gitHubOAuthResponseClientDiagnostics.CreateScope("GitHubOAuthResponseCollection.Get");
            scope.Start();
            try
            {
                var response = _gitHubOAuthResponseRestClient.GitHubOAuthCallback(Id.SubscriptionId, new AzureLocation(_location), code, state, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new GitHubOAuthResponseResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Callback URL to hit once authenticated with GitHub App to have the service store the OAuth token.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DevHub/locations/{location}/githuboauth</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ListGitHubOAuth</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="GitHubOAuthResponseResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="GitHubOAuthResponseResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GitHubOAuthResponseResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _gitHubOAuthResponseRestClient.CreateListGitHubOAuthRequest(Id.SubscriptionId, new AzureLocation(_location));
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, e => new GitHubOAuthResponseResource(Client, GitHubOAuthResponseData.DeserializeGitHubOAuthResponseData(e)), _gitHubOAuthResponseClientDiagnostics, Pipeline, "GitHubOAuthResponseCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Callback URL to hit once authenticated with GitHub App to have the service store the OAuth token.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DevHub/locations/{location}/githuboauth</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ListGitHubOAuth</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="GitHubOAuthResponseResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="GitHubOAuthResponseResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GitHubOAuthResponseResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _gitHubOAuthResponseRestClient.CreateListGitHubOAuthRequest(Id.SubscriptionId, new AzureLocation(_location));
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, e => new GitHubOAuthResponseResource(Client, GitHubOAuthResponseData.DeserializeGitHubOAuthResponseData(e)), _gitHubOAuthResponseClientDiagnostics, Pipeline, "GitHubOAuthResponseCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DevHub/locations/{location}/githuboauth/default</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GitHubOAuthCallback</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="GitHubOAuthResponseResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="code"> The code response from authenticating the GitHub App. </param>
        /// <param name="state"> The state response from authenticating the GitHub App. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="code"/> or <paramref name="state"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string code, string state, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(code, nameof(code));
            Argument.AssertNotNull(state, nameof(state));

            using var scope = _gitHubOAuthResponseClientDiagnostics.CreateScope("GitHubOAuthResponseCollection.Exists");
            scope.Start();
            try
            {
                var response = await _gitHubOAuthResponseRestClient.GitHubOAuthCallbackAsync(Id.SubscriptionId, new AzureLocation(_location), code, state, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DevHub/locations/{location}/githuboauth/default</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GitHubOAuthCallback</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="GitHubOAuthResponseResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="code"> The code response from authenticating the GitHub App. </param>
        /// <param name="state"> The state response from authenticating the GitHub App. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="code"/> or <paramref name="state"/> is null. </exception>
        public virtual Response<bool> Exists(string code, string state, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(code, nameof(code));
            Argument.AssertNotNull(state, nameof(state));

            using var scope = _gitHubOAuthResponseClientDiagnostics.CreateScope("GitHubOAuthResponseCollection.Exists");
            scope.Start();
            try
            {
                var response = _gitHubOAuthResponseRestClient.GitHubOAuthCallback(Id.SubscriptionId, new AzureLocation(_location), code, state, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DevHub/locations/{location}/githuboauth/default</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GitHubOAuthCallback</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="GitHubOAuthResponseResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="code"> The code response from authenticating the GitHub App. </param>
        /// <param name="state"> The state response from authenticating the GitHub App. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="code"/> or <paramref name="state"/> is null. </exception>
        public virtual async Task<NullableResponse<GitHubOAuthResponseResource>> GetIfExistsAsync(string code, string state, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(code, nameof(code));
            Argument.AssertNotNull(state, nameof(state));

            using var scope = _gitHubOAuthResponseClientDiagnostics.CreateScope("GitHubOAuthResponseCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _gitHubOAuthResponseRestClient.GitHubOAuthCallbackAsync(Id.SubscriptionId, new AzureLocation(_location), code, state, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<GitHubOAuthResponseResource>(response.GetRawResponse());
                return Response.FromValue(new GitHubOAuthResponseResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DevHub/locations/{location}/githuboauth/default</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GitHubOAuthCallback</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="GitHubOAuthResponseResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="code"> The code response from authenticating the GitHub App. </param>
        /// <param name="state"> The state response from authenticating the GitHub App. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="code"/> or <paramref name="state"/> is null. </exception>
        public virtual NullableResponse<GitHubOAuthResponseResource> GetIfExists(string code, string state, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(code, nameof(code));
            Argument.AssertNotNull(state, nameof(state));

            using var scope = _gitHubOAuthResponseClientDiagnostics.CreateScope("GitHubOAuthResponseCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _gitHubOAuthResponseRestClient.GitHubOAuthCallback(Id.SubscriptionId, new AzureLocation(_location), code, state, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<GitHubOAuthResponseResource>(response.GetRawResponse());
                return Response.FromValue(new GitHubOAuthResponseResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<GitHubOAuthResponseResource> IEnumerable<GitHubOAuthResponseResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<GitHubOAuthResponseResource> IAsyncEnumerable<GitHubOAuthResponseResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
