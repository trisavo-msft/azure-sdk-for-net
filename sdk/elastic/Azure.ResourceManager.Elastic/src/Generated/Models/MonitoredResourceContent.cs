// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Elastic.Models
{
    /// <summary> The properties of a resource currently being monitored by the Elastic monitor resource. </summary>
    public partial class MonitoredResourceContent
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

        /// <summary> Initializes a new instance of <see cref="MonitoredResourceContent"/>. </summary>
        internal MonitoredResourceContent()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MonitoredResourceContent"/>. </summary>
        /// <param name="id"> The ARM id of the resource. </param>
        /// <param name="sendingLogs"> Flag indicating the status of the resource for sending logs operation to Elastic. </param>
        /// <param name="reasonForLogsStatus"> Reason for why the resource is sending logs (or why it is not sending). </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MonitoredResourceContent(string id, SendingLog? sendingLogs, string reasonForLogsStatus, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Id = id;
            SendingLogs = sendingLogs;
            ReasonForLogsStatus = reasonForLogsStatus;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The ARM id of the resource. </summary>
        public string Id { get; }
        /// <summary> Flag indicating the status of the resource for sending logs operation to Elastic. </summary>
        public SendingLog? SendingLogs { get; }
        /// <summary> Reason for why the resource is sending logs (or why it is not sending). </summary>
        public string ReasonForLogsStatus { get; }
    }
}
