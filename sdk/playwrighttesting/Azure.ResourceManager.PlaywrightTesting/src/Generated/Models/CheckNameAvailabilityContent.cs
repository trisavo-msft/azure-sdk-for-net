// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.PlaywrightTesting.Models
{
    /// <summary> The check availability request body. </summary>
    public partial class CheckNameAvailabilityContent
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

        /// <summary> Initializes a new instance of <see cref="CheckNameAvailabilityContent"/>. </summary>
        public CheckNameAvailabilityContent()
        {
        }

        /// <summary> Initializes a new instance of <see cref="CheckNameAvailabilityContent"/>. </summary>
        /// <param name="name"> The name of the resource for which availability needs to be checked. </param>
        /// <param name="resourceType"> The resource type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CheckNameAvailabilityContent(string name, string resourceType, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            ResourceType = resourceType;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The name of the resource for which availability needs to be checked. </summary>
        public string Name { get; set; }
        /// <summary> The resource type. </summary>
        public string ResourceType { get; set; }
    }
}
