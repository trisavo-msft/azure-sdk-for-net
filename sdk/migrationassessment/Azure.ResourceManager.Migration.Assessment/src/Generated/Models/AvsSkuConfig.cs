// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Migration.Assessment.Models
{
    /// <summary> AVS SKU specific options. </summary>
    public partial class AvsSkuConfig
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

        /// <summary> Initializes a new instance of <see cref="AvsSkuConfig"/>. </summary>
        public AvsSkuConfig()
        {
            TargetLocations = new ChangeTrackingList<AzureLocation>();
        }

        /// <summary> Initializes a new instance of <see cref="AvsSkuConfig"/>. </summary>
        /// <param name="nodeType"> AVS Node type. </param>
        /// <param name="targetLocations"> List of locations where this node type is available. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AvsSkuConfig(AvsNodeType? nodeType, IList<AzureLocation> targetLocations, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            NodeType = nodeType;
            TargetLocations = targetLocations;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> AVS Node type. </summary>
        public AvsNodeType? NodeType { get; set; }
        /// <summary> List of locations where this node type is available. </summary>
        public IList<AzureLocation> TargetLocations { get; }
    }
}
