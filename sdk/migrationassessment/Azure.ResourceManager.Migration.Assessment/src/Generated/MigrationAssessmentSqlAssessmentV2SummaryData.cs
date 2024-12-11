// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Migration.Assessment.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Migration.Assessment
{
    /// <summary>
    /// A class representing the MigrationAssessmentSqlAssessmentV2Summary data model.
    /// SQL Assessment REST resource.
    /// </summary>
    public partial class MigrationAssessmentSqlAssessmentV2SummaryData : ResourceData
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="MigrationAssessmentSqlAssessmentV2SummaryData"/>. </summary>
        public MigrationAssessmentSqlAssessmentV2SummaryData()
        {
            AssessmentSummary = new ChangeTrackingDictionary<string, SqlAssessmentV2SummaryDetails>();
            DistributionBySupportStatus = new ChangeTrackingDictionary<string, int>();
            DistributionByServicePackInsight = new ChangeTrackingDictionary<string, int>();
            DistributionBySqlVersion = new ChangeTrackingDictionary<string, int>();
            DistributionBySqlEdition = new ChangeTrackingDictionary<string, int>();
            InstanceDistributionBySizingCriterion = new ChangeTrackingDictionary<string, int>();
            DatabaseDistributionBySizingCriterion = new ChangeTrackingDictionary<string, int>();
        }

        /// <summary> Initializes a new instance of <see cref="MigrationAssessmentSqlAssessmentV2SummaryData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="assessmentSummary"> Gets or sets the Assessment summary. </param>
        /// <param name="distributionBySupportStatus"> Gets the distribution of sqlInstances by support status. </param>
        /// <param name="distributionByServicePackInsight"> Gets the distribution distribution of sqlInstances by service pack insight. </param>
        /// <param name="distributionBySqlVersion"> Gets the distribution of sqlInstances by sql version. </param>
        /// <param name="distributionBySqlEdition"> Gets the distribution of sqlInstances by sql edition. </param>
        /// <param name="instanceDistributionBySizingCriterion"> Gets the instance distribution by sizing criterion. </param>
        /// <param name="databaseDistributionBySizingCriterion"> Gets the database distribution by sizing criterion. </param>
        /// <param name="numberOfMachines"> Number of machines part of the assessment. </param>
        /// <param name="numberOfSqlInstances"> Number of sql instances part of the assessment. </param>
        /// <param name="numberOfSuccessfullyDiscoveredSqlInstances"> Number of successfully discovered sql instances part of the assessment. </param>
        /// <param name="numberOfSqlDatabases"> Number of sql databases part of the assessment. </param>
        /// <param name="numberOfFciInstances"> Number of sql failover cluster instances part of the assessment. </param>
        /// <param name="numberOfSqlAvailabilityGroups"> Number of sql availability groups part of the assessment. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MigrationAssessmentSqlAssessmentV2SummaryData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IReadOnlyDictionary<string, SqlAssessmentV2SummaryDetails> assessmentSummary, IReadOnlyDictionary<string, int> distributionBySupportStatus, IReadOnlyDictionary<string, int> distributionByServicePackInsight, IReadOnlyDictionary<string, int> distributionBySqlVersion, IReadOnlyDictionary<string, int> distributionBySqlEdition, IReadOnlyDictionary<string, int> instanceDistributionBySizingCriterion, IReadOnlyDictionary<string, int> databaseDistributionBySizingCriterion, int? numberOfMachines, int? numberOfSqlInstances, int? numberOfSuccessfullyDiscoveredSqlInstances, int? numberOfSqlDatabases, int? numberOfFciInstances, int? numberOfSqlAvailabilityGroups, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            AssessmentSummary = assessmentSummary;
            DistributionBySupportStatus = distributionBySupportStatus;
            DistributionByServicePackInsight = distributionByServicePackInsight;
            DistributionBySqlVersion = distributionBySqlVersion;
            DistributionBySqlEdition = distributionBySqlEdition;
            InstanceDistributionBySizingCriterion = instanceDistributionBySizingCriterion;
            DatabaseDistributionBySizingCriterion = databaseDistributionBySizingCriterion;
            NumberOfMachines = numberOfMachines;
            NumberOfSqlInstances = numberOfSqlInstances;
            NumberOfSuccessfullyDiscoveredSqlInstances = numberOfSuccessfullyDiscoveredSqlInstances;
            NumberOfSqlDatabases = numberOfSqlDatabases;
            NumberOfFciInstances = numberOfFciInstances;
            NumberOfSqlAvailabilityGroups = numberOfSqlAvailabilityGroups;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets or sets the Assessment summary. </summary>
        public IReadOnlyDictionary<string, SqlAssessmentV2SummaryDetails> AssessmentSummary { get; }
        /// <summary> Gets the distribution of sqlInstances by support status. </summary>
        public IReadOnlyDictionary<string, int> DistributionBySupportStatus { get; }
        /// <summary> Gets the distribution distribution of sqlInstances by service pack insight. </summary>
        public IReadOnlyDictionary<string, int> DistributionByServicePackInsight { get; }
        /// <summary> Gets the distribution of sqlInstances by sql version. </summary>
        public IReadOnlyDictionary<string, int> DistributionBySqlVersion { get; }
        /// <summary> Gets the distribution of sqlInstances by sql edition. </summary>
        public IReadOnlyDictionary<string, int> DistributionBySqlEdition { get; }
        /// <summary> Gets the instance distribution by sizing criterion. </summary>
        public IReadOnlyDictionary<string, int> InstanceDistributionBySizingCriterion { get; }
        /// <summary> Gets the database distribution by sizing criterion. </summary>
        public IReadOnlyDictionary<string, int> DatabaseDistributionBySizingCriterion { get; }
        /// <summary> Number of machines part of the assessment. </summary>
        public int? NumberOfMachines { get; }
        /// <summary> Number of sql instances part of the assessment. </summary>
        public int? NumberOfSqlInstances { get; }
        /// <summary> Number of successfully discovered sql instances part of the assessment. </summary>
        public int? NumberOfSuccessfullyDiscoveredSqlInstances { get; }
        /// <summary> Number of sql databases part of the assessment. </summary>
        public int? NumberOfSqlDatabases { get; }
        /// <summary> Number of sql failover cluster instances part of the assessment. </summary>
        public int? NumberOfFciInstances { get; }
        /// <summary> Number of sql availability groups part of the assessment. </summary>
        public int? NumberOfSqlAvailabilityGroups { get; }
    }
}
