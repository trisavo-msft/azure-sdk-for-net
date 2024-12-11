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
    /// A class representing the AssessedSqlInstanceV2 data model.
    /// Assessed SQL instance web model class.
    /// </summary>
    public partial class AssessedSqlInstanceV2Data : ResourceData
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

        /// <summary> Initializes a new instance of <see cref="AssessedSqlInstanceV2Data"/>. </summary>
        public AssessedSqlInstanceV2Data()
        {
            StorageTypeBasedDetails = new ChangeTrackingList<AssessedSqlInstanceStorageDetails>();
            RecommendedTargetReasonings = new ChangeTrackingList<SqlRecommendationReasoning>();
            LogicalDisks = new ChangeTrackingList<AssessedSqlInstanceDiskDetails>();
        }

        /// <summary> Initializes a new instance of <see cref="AssessedSqlInstanceV2Data"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="memoryInUseInMB"> Gets or sets the memory used by SQL instance in megabytes. </param>
        /// <param name="hasScanOccurred"> Gets or sets a value indicating whether SQL instance has been deep discovered. </param>
        /// <param name="recommendedAzureSqlTargetType"> Gets or sets the recommended azure SQL target type. </param>
        /// <param name="recommendedSuitability"> Gets or sets the recommended azure SQL suitability. </param>
        /// <param name="azureSqlMISuitabilityDetails"> SQL instance azure SQL MI suitability details. </param>
        /// <param name="azureSqlDBSuitabilityDetails"> SQL instance azure SQL DB suitability details. </param>
        /// <param name="azureSqlVmSuitabilityDetails"> SQL instance azure SQL VM suitability details. </param>
        /// <param name="storageTypeBasedDetails"> Gets the storage details. </param>
        /// <param name="productSupportStatus"> Gets the product support status related details. </param>
        /// <param name="fciMetadata"> Gets the FCI metadata if this instance represents an FCI instance. </param>
        /// <param name="availabilityReplicaSummary">
        /// Gets the overview counts of availability replicas in the assessed instance, by
        /// commit mode and read type.
        /// </param>
        /// <param name="isClustered"> Gets a value indicating whether the SQL instance is clustered or not. </param>
        /// <param name="isHighAvailabilityEnabled"> Gets a value indicating whether the high availability is enabled or not. </param>
        /// <param name="recommendedTargetReasonings"> Gets the list of recommended target reasoning. </param>
        /// <param name="machineArmId"> Machine arm id. </param>
        /// <param name="machineName"> Machine display name. </param>
        /// <param name="instanceName"> SQL instance name. </param>
        /// <param name="sqlInstanceSdsArmId"> SQL instance SDS arm id. </param>
        /// <param name="sqlEdition"> SQL instance edition. </param>
        /// <param name="sqlVersion"> SQL instance version. </param>
        /// <param name="numberOfCoresAllocated"> Number of CPU cores assigned to the SQL instance. </param>
        /// <param name="percentageCoresUtilization"> The percentage of the total number of cores being utilized by the SQL instance. </param>
        /// <param name="logicalDisks"> The logical disk details. </param>
        /// <param name="databaseSummary"> The databases summary. </param>
        /// <param name="confidenceRatingInPercentage"> Confidence Rating in Percentage. </param>
        /// <param name="sizingCriterion"> Assessment sizing criterion. </param>
        /// <param name="createdOn"> When was assessed SQL instance first created. </param>
        /// <param name="updatedOn"> When was assessed SQL instance last updated. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AssessedSqlInstanceV2Data(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, double? memoryInUseInMB, bool? hasScanOccurred, MigrationAssessmentTargetType? recommendedAzureSqlTargetType, RecommendedSuitability? recommendedSuitability, SqlAssessmentV2PaasSuitabilityDetails azureSqlMISuitabilityDetails, SqlAssessmentV2PaasSuitabilityDetails azureSqlDBSuitabilityDetails, SqlAssessmentV2IaasSuitabilityDetails azureSqlVmSuitabilityDetails, IReadOnlyList<AssessedSqlInstanceStorageDetails> storageTypeBasedDetails, ProductSupportStatus productSupportStatus, SqlFciMetadata fciMetadata, SqlAvailabilityReplicaSummary availabilityReplicaSummary, bool? isClustered, bool? isHighAvailabilityEnabled, IReadOnlyList<SqlRecommendationReasoning> recommendedTargetReasonings, ResourceIdentifier machineArmId, string machineName, string instanceName, ResourceIdentifier sqlInstanceSdsArmId, string sqlEdition, string sqlVersion, int? numberOfCoresAllocated, double? percentageCoresUtilization, IReadOnlyList<AssessedSqlInstanceDiskDetails> logicalDisks, AssessedSqlInstanceDatabaseSummary databaseSummary, double? confidenceRatingInPercentage, AssessmentSizingCriterion? sizingCriterion, DateTimeOffset? createdOn, DateTimeOffset? updatedOn, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            MemoryInUseInMB = memoryInUseInMB;
            HasScanOccurred = hasScanOccurred;
            RecommendedAzureSqlTargetType = recommendedAzureSqlTargetType;
            RecommendedSuitability = recommendedSuitability;
            AzureSqlMISuitabilityDetails = azureSqlMISuitabilityDetails;
            AzureSqlDBSuitabilityDetails = azureSqlDBSuitabilityDetails;
            AzureSqlVmSuitabilityDetails = azureSqlVmSuitabilityDetails;
            StorageTypeBasedDetails = storageTypeBasedDetails;
            ProductSupportStatus = productSupportStatus;
            FciMetadata = fciMetadata;
            AvailabilityReplicaSummary = availabilityReplicaSummary;
            IsClustered = isClustered;
            IsHighAvailabilityEnabled = isHighAvailabilityEnabled;
            RecommendedTargetReasonings = recommendedTargetReasonings;
            MachineArmId = machineArmId;
            MachineName = machineName;
            InstanceName = instanceName;
            SqlInstanceSdsArmId = sqlInstanceSdsArmId;
            SqlEdition = sqlEdition;
            SqlVersion = sqlVersion;
            NumberOfCoresAllocated = numberOfCoresAllocated;
            PercentageCoresUtilization = percentageCoresUtilization;
            LogicalDisks = logicalDisks;
            DatabaseSummary = databaseSummary;
            ConfidenceRatingInPercentage = confidenceRatingInPercentage;
            SizingCriterion = sizingCriterion;
            CreatedOn = createdOn;
            UpdatedOn = updatedOn;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets or sets the memory used by SQL instance in megabytes. </summary>
        public double? MemoryInUseInMB { get; }
        /// <summary> Gets or sets a value indicating whether SQL instance has been deep discovered. </summary>
        public bool? HasScanOccurred { get; }
        /// <summary> Gets or sets the recommended azure SQL target type. </summary>
        public MigrationAssessmentTargetType? RecommendedAzureSqlTargetType { get; }
        /// <summary> Gets or sets the recommended azure SQL suitability. </summary>
        public RecommendedSuitability? RecommendedSuitability { get; }
        /// <summary> SQL instance azure SQL MI suitability details. </summary>
        public SqlAssessmentV2PaasSuitabilityDetails AzureSqlMISuitabilityDetails { get; }
        /// <summary> SQL instance azure SQL DB suitability details. </summary>
        public SqlAssessmentV2PaasSuitabilityDetails AzureSqlDBSuitabilityDetails { get; }
        /// <summary> SQL instance azure SQL VM suitability details. </summary>
        public SqlAssessmentV2IaasSuitabilityDetails AzureSqlVmSuitabilityDetails { get; }
        /// <summary> Gets the storage details. </summary>
        public IReadOnlyList<AssessedSqlInstanceStorageDetails> StorageTypeBasedDetails { get; }
        /// <summary> Gets the product support status related details. </summary>
        public ProductSupportStatus ProductSupportStatus { get; }
        /// <summary> Gets the FCI metadata if this instance represents an FCI instance. </summary>
        public SqlFciMetadata FciMetadata { get; }
        /// <summary>
        /// Gets the overview counts of availability replicas in the assessed instance, by
        /// commit mode and read type.
        /// </summary>
        public SqlAvailabilityReplicaSummary AvailabilityReplicaSummary { get; }
        /// <summary> Gets a value indicating whether the SQL instance is clustered or not. </summary>
        public bool? IsClustered { get; }
        /// <summary> Gets a value indicating whether the high availability is enabled or not. </summary>
        public bool? IsHighAvailabilityEnabled { get; }
        /// <summary> Gets the list of recommended target reasoning. </summary>
        public IReadOnlyList<SqlRecommendationReasoning> RecommendedTargetReasonings { get; }
        /// <summary> Machine arm id. </summary>
        public ResourceIdentifier MachineArmId { get; }
        /// <summary> Machine display name. </summary>
        public string MachineName { get; }
        /// <summary> SQL instance name. </summary>
        public string InstanceName { get; }
        /// <summary> SQL instance SDS arm id. </summary>
        public ResourceIdentifier SqlInstanceSdsArmId { get; }
        /// <summary> SQL instance edition. </summary>
        public string SqlEdition { get; }
        /// <summary> SQL instance version. </summary>
        public string SqlVersion { get; }
        /// <summary> Number of CPU cores assigned to the SQL instance. </summary>
        public int? NumberOfCoresAllocated { get; }
        /// <summary> The percentage of the total number of cores being utilized by the SQL instance. </summary>
        public double? PercentageCoresUtilization { get; }
        /// <summary> The logical disk details. </summary>
        public IReadOnlyList<AssessedSqlInstanceDiskDetails> LogicalDisks { get; }
        /// <summary> The databases summary. </summary>
        public AssessedSqlInstanceDatabaseSummary DatabaseSummary { get; }
        /// <summary> Confidence Rating in Percentage. </summary>
        public double? ConfidenceRatingInPercentage { get; }
        /// <summary> Assessment sizing criterion. </summary>
        public AssessmentSizingCriterion? SizingCriterion { get; }
        /// <summary> When was assessed SQL instance first created. </summary>
        public DateTimeOffset? CreatedOn { get; }
        /// <summary> When was assessed SQL instance last updated. </summary>
        public DateTimeOffset? UpdatedOn { get; }
    }
}
