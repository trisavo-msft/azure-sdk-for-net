// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.EdgeOrder.Models
{
    /// <summary> Return order item request body. </summary>
    public partial class EdgeOrderItemReturnContent
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

        /// <summary> Initializes a new instance of <see cref="EdgeOrderItemReturnContent"/>. </summary>
        /// <param name="returnReason"> Return Reason. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="returnReason"/> is null. </exception>
        public EdgeOrderItemReturnContent(string returnReason)
        {
            Argument.AssertNotNull(returnReason, nameof(returnReason));

            ReturnReason = returnReason;
        }

        /// <summary> Initializes a new instance of <see cref="EdgeOrderItemReturnContent"/>. </summary>
        /// <param name="returnAddress"> customer return address. </param>
        /// <param name="returnReason"> Return Reason. </param>
        /// <param name="serviceTag"> Service tag (located on the bottom-right corner of the device). </param>
        /// <param name="isShippingBoxRequired"> Shipping Box required. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal EdgeOrderItemReturnContent(EdgeOrderItemAddressProperties returnAddress, string returnReason, string serviceTag, bool? isShippingBoxRequired, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ReturnAddress = returnAddress;
            ReturnReason = returnReason;
            ServiceTag = serviceTag;
            IsShippingBoxRequired = isShippingBoxRequired;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="EdgeOrderItemReturnContent"/> for deserialization. </summary>
        internal EdgeOrderItemReturnContent()
        {
        }

        /// <summary> customer return address. </summary>
        public EdgeOrderItemAddressProperties ReturnAddress { get; set; }
        /// <summary> Return Reason. </summary>
        public string ReturnReason { get; }
        /// <summary> Service tag (located on the bottom-right corner of the device). </summary>
        public string ServiceTag { get; set; }
        /// <summary> Shipping Box required. </summary>
        public bool? IsShippingBoxRequired { get; set; }
    }
}
