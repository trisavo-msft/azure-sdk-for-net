// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.NetApp
{
    /// <summary>
    /// A class representing the NetAppVolumeSnapshot data model.
    /// Snapshot of a Volume
    /// </summary>
    public partial class NetAppVolumeSnapshotData : ResourceData
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

        /// <summary> Initializes a new instance of <see cref="NetAppVolumeSnapshotData"/>. </summary>
        /// <param name="location"> Resource location. </param>
        public NetAppVolumeSnapshotData(AzureLocation location)
        {
            Location = location;
        }

        /// <summary> Initializes a new instance of <see cref="NetAppVolumeSnapshotData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="snapshotId"> UUID v4 used to identify the Snapshot. </param>
        /// <param name="created"> The creation date of the snapshot. </param>
        /// <param name="provisioningState"> Azure lifecycle management. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal NetAppVolumeSnapshotData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, AzureLocation location, string snapshotId, DateTimeOffset? created, string provisioningState, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            Location = location;
            SnapshotId = snapshotId;
            Created = created;
            ProvisioningState = provisioningState;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="NetAppVolumeSnapshotData"/> for deserialization. </summary>
        internal NetAppVolumeSnapshotData()
        {
        }

        /// <summary> Resource location. </summary>
        public AzureLocation Location { get; set; }
        /// <summary> UUID v4 used to identify the Snapshot. </summary>
        public string SnapshotId { get; }
        /// <summary> The creation date of the snapshot. </summary>
        public DateTimeOffset? Created { get; }
        /// <summary> Azure lifecycle management. </summary>
        public string ProvisioningState { get; }
    }
}
