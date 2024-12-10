// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Avs.Models;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Avs
{
    /// <summary>
    /// A class representing the AvsPrivateCloudDatastore data model.
    /// A datastore resource
    /// </summary>
    public partial class AvsPrivateCloudDatastoreData : ResourceData
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

        /// <summary> Initializes a new instance of <see cref="AvsPrivateCloudDatastoreData"/>. </summary>
        public AvsPrivateCloudDatastoreData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AvsPrivateCloudDatastoreData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="provisioningState"> The state of the datastore provisioning. </param>
        /// <param name="netAppVolume"> An Azure NetApp Files volume. </param>
        /// <param name="diskPoolVolume"> An iSCSI volume. </param>
        /// <param name="elasticSanVolume"> An Elastic SAN volume. </param>
        /// <param name="status"> The operational status of the datastore. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AvsPrivateCloudDatastoreData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, AvsPrivateCloudDatastoreProvisioningState? provisioningState, WritableSubResource netAppVolume, DiskPoolVolume diskPoolVolume, ElasticSanVolume elasticSanVolume, DatastoreStatus? status, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            ProvisioningState = provisioningState;
            NetAppVolume = netAppVolume;
            DiskPoolVolume = diskPoolVolume;
            ElasticSanVolume = elasticSanVolume;
            Status = status;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The state of the datastore provisioning. </summary>
        public AvsPrivateCloudDatastoreProvisioningState? ProvisioningState { get; }
        /// <summary> An Azure NetApp Files volume. </summary>
        internal WritableSubResource NetAppVolume { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier NetAppVolumeId
        {
            get => NetAppVolume is null ? default : NetAppVolume.Id;
            set
            {
                if (NetAppVolume is null)
                    NetAppVolume = new WritableSubResource();
                NetAppVolume.Id = value;
            }
        }

        /// <summary> An iSCSI volume. </summary>
        public DiskPoolVolume DiskPoolVolume { get; set; }
        /// <summary> An Elastic SAN volume. </summary>
        internal ElasticSanVolume ElasticSanVolume { get; set; }
        /// <summary> Azure resource ID of the Elastic SAN Volume. </summary>
        public ResourceIdentifier ElasticSanVolumeTargetId
        {
            get => ElasticSanVolume is null ? default : ElasticSanVolume.TargetId;
            set => ElasticSanVolume = new ElasticSanVolume(value);
        }

        /// <summary> The operational status of the datastore. </summary>
        public DatastoreStatus? Status { get; }
    }
}
