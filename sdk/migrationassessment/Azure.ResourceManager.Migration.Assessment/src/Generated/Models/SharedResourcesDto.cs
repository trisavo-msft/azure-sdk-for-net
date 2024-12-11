// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Migration.Assessment.Models
{
    /// <summary> Shared Resources. </summary>
    public partial class SharedResourcesDto
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

        /// <summary> Initializes a new instance of <see cref="SharedResourcesDto"/>. </summary>
        internal SharedResourcesDto()
        {
            SharedDataDisks = new ChangeTrackingList<AzureManagedDiskSkuDto>();
            SharedLogDisks = new ChangeTrackingList<AzureManagedDiskSkuDto>();
            SharedTempDBDisks = new ChangeTrackingList<AzureManagedDiskSkuDto>();
        }

        /// <summary> Initializes a new instance of <see cref="SharedResourcesDto"/>. </summary>
        /// <param name="sharedDataDisks"> Gets the list of shared data disks. </param>
        /// <param name="sharedLogDisks"> Gets the list of shared log disks. </param>
        /// <param name="sharedTempDBDisks"> Gets the list of shared Temporary database disks. </param>
        /// <param name="numberOfMounts"> Gets number of mounts of shared disks. </param>
        /// <param name="quorumWitness"> Gets quorum witness. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SharedResourcesDto(IReadOnlyList<AzureManagedDiskSkuDto> sharedDataDisks, IReadOnlyList<AzureManagedDiskSkuDto> sharedLogDisks, IReadOnlyList<AzureManagedDiskSkuDto> sharedTempDBDisks, int? numberOfMounts, AzureQuorumWitnessDto quorumWitness, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            SharedDataDisks = sharedDataDisks;
            SharedLogDisks = sharedLogDisks;
            SharedTempDBDisks = sharedTempDBDisks;
            NumberOfMounts = numberOfMounts;
            QuorumWitness = quorumWitness;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets the list of shared data disks. </summary>
        public IReadOnlyList<AzureManagedDiskSkuDto> SharedDataDisks { get; }
        /// <summary> Gets the list of shared log disks. </summary>
        public IReadOnlyList<AzureManagedDiskSkuDto> SharedLogDisks { get; }
        /// <summary> Gets the list of shared Temporary database disks. </summary>
        public IReadOnlyList<AzureManagedDiskSkuDto> SharedTempDBDisks { get; }
        /// <summary> Gets number of mounts of shared disks. </summary>
        public int? NumberOfMounts { get; }
        /// <summary> Gets quorum witness. </summary>
        internal AzureQuorumWitnessDto QuorumWitness { get; }
        /// <summary> Gets quorum witness type. </summary>
        public AzureQuorumWitnessDtoQuorumWitnessType? QuorumWitnessType
        {
            get => QuorumWitness?.QuorumWitnessType;
        }
    }
}
