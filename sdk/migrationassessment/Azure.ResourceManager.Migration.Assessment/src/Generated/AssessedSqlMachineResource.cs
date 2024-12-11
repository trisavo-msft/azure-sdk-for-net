// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.ResourceManager.Migration.Assessment
{
    /// <summary>
    /// A Class representing an AssessedSqlMachine along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct an <see cref="AssessedSqlMachineResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetAssessedSqlMachineResource method.
    /// Otherwise you can get one from its parent resource <see cref="MigrationAssessmentSqlAssessmentV2Resource"/> using the GetAssessedSqlMachine method.
    /// </summary>
    public partial class AssessedSqlMachineResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="AssessedSqlMachineResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="projectName"> The projectName. </param>
        /// <param name="groupName"> The groupName. </param>
        /// <param name="assessmentName"> The assessmentName. </param>
        /// <param name="assessedSqlMachineName"> The assessedSqlMachineName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string projectName, string groupName, string assessmentName, string assessedSqlMachineName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Migrate/assessmentProjects/{projectName}/groups/{groupName}/sqlAssessments/{assessmentName}/assessedSqlMachines/{assessedSqlMachineName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _assessedSqlMachineAssessedSqlMachinesOperationsClientDiagnostics;
        private readonly AssessedSqlMachinesRestOperations _assessedSqlMachineAssessedSqlMachinesOperationsRestClient;
        private readonly AssessedSqlMachineData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Migrate/assessmentProjects/groups/sqlAssessments/assessedSqlMachines";

        /// <summary> Initializes a new instance of the <see cref="AssessedSqlMachineResource"/> class for mocking. </summary>
        protected AssessedSqlMachineResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="AssessedSqlMachineResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal AssessedSqlMachineResource(ArmClient client, AssessedSqlMachineData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="AssessedSqlMachineResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal AssessedSqlMachineResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _assessedSqlMachineAssessedSqlMachinesOperationsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Migration.Assessment", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string assessedSqlMachineAssessedSqlMachinesOperationsApiVersion);
            _assessedSqlMachineAssessedSqlMachinesOperationsRestClient = new AssessedSqlMachinesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, assessedSqlMachineAssessedSqlMachinesOperationsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual AssessedSqlMachineData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Get a AssessedSqlMachine
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Migrate/assessmentProjects/{projectName}/groups/{groupName}/sqlAssessments/{assessmentName}/assessedSqlMachines/{assessedSqlMachineName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AssessedSqlMachinesOperations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AssessedSqlMachineResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<AssessedSqlMachineResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _assessedSqlMachineAssessedSqlMachinesOperationsClientDiagnostics.CreateScope("AssessedSqlMachineResource.Get");
            scope.Start();
            try
            {
                var response = await _assessedSqlMachineAssessedSqlMachinesOperationsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AssessedSqlMachineResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a AssessedSqlMachine
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Migrate/assessmentProjects/{projectName}/groups/{groupName}/sqlAssessments/{assessmentName}/assessedSqlMachines/{assessedSqlMachineName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AssessedSqlMachinesOperations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-03-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AssessedSqlMachineResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<AssessedSqlMachineResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _assessedSqlMachineAssessedSqlMachinesOperationsClientDiagnostics.CreateScope("AssessedSqlMachineResource.Get");
            scope.Start();
            try
            {
                var response = _assessedSqlMachineAssessedSqlMachinesOperationsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AssessedSqlMachineResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
