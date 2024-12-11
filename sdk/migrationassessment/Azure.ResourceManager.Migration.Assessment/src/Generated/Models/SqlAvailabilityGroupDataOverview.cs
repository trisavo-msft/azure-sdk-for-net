// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Migration.Assessment.Models
{
    /// <summary> Assessed Sql Availability Group Data Overview. </summary>
    public partial class SqlAvailabilityGroupDataOverview
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

        /// <summary> Initializes a new instance of <see cref="SqlAvailabilityGroupDataOverview"/>. </summary>
        internal SqlAvailabilityGroupDataOverview()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SqlAvailabilityGroupDataOverview"/>. </summary>
        /// <param name="availabilityGroupId"> Gets the availability group id. </param>
        /// <param name="availabilityGroupName"> Gets the availability group name. </param>
        /// <param name="sqlAvailabilityGroupSdsArmId"> Gets the availability group arm id. </param>
        /// <param name="sqlAvailabilityGroupEntityId"> Gets the availability group entity id. </param>
        /// <param name="sqlAvailabilityReplicaId"> Gets the availability replica id. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SqlAvailabilityGroupDataOverview(string availabilityGroupId, string availabilityGroupName, ResourceIdentifier sqlAvailabilityGroupSdsArmId, string sqlAvailabilityGroupEntityId, string sqlAvailabilityReplicaId, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            AvailabilityGroupId = availabilityGroupId;
            AvailabilityGroupName = availabilityGroupName;
            SqlAvailabilityGroupSdsArmId = sqlAvailabilityGroupSdsArmId;
            SqlAvailabilityGroupEntityId = sqlAvailabilityGroupEntityId;
            SqlAvailabilityReplicaId = sqlAvailabilityReplicaId;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets the availability group id. </summary>
        public string AvailabilityGroupId { get; }
        /// <summary> Gets the availability group name. </summary>
        public string AvailabilityGroupName { get; }
        /// <summary> Gets the availability group arm id. </summary>
        public ResourceIdentifier SqlAvailabilityGroupSdsArmId { get; }
        /// <summary> Gets the availability group entity id. </summary>
        public string SqlAvailabilityGroupEntityId { get; }
        /// <summary> Gets the availability replica id. </summary>
        public string SqlAvailabilityReplicaId { get; }
    }
}
