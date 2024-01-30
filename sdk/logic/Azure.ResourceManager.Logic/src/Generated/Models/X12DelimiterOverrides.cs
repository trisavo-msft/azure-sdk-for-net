// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary> The X12 delimiter override settings. </summary>
    public partial class X12DelimiterOverrides
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

        /// <summary> Initializes a new instance of <see cref="X12DelimiterOverrides"/>. </summary>
        /// <param name="dataElementSeparator"> The data element separator. </param>
        /// <param name="componentSeparator"> The component separator. </param>
        /// <param name="segmentTerminator"> The segment terminator. </param>
        /// <param name="segmentTerminatorSuffix"> The segment terminator suffix. </param>
        /// <param name="replaceCharacter"> The replacement character. </param>
        /// <param name="replaceSeparatorsInPayload"> The value indicating whether to replace separators in payload. </param>
        public X12DelimiterOverrides(int dataElementSeparator, int componentSeparator, int segmentTerminator, SegmentTerminatorSuffix segmentTerminatorSuffix, int replaceCharacter, bool replaceSeparatorsInPayload)
        {
            DataElementSeparator = dataElementSeparator;
            ComponentSeparator = componentSeparator;
            SegmentTerminator = segmentTerminator;
            SegmentTerminatorSuffix = segmentTerminatorSuffix;
            ReplaceCharacter = replaceCharacter;
            ReplaceSeparatorsInPayload = replaceSeparatorsInPayload;
        }

        /// <summary> Initializes a new instance of <see cref="X12DelimiterOverrides"/>. </summary>
        /// <param name="protocolVersion"> The protocol version. </param>
        /// <param name="messageId"> The message id. </param>
        /// <param name="dataElementSeparator"> The data element separator. </param>
        /// <param name="componentSeparator"> The component separator. </param>
        /// <param name="segmentTerminator"> The segment terminator. </param>
        /// <param name="segmentTerminatorSuffix"> The segment terminator suffix. </param>
        /// <param name="replaceCharacter"> The replacement character. </param>
        /// <param name="replaceSeparatorsInPayload"> The value indicating whether to replace separators in payload. </param>
        /// <param name="targetNamespace"> The target namespace on which this delimiter settings has to be applied. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal X12DelimiterOverrides(string protocolVersion, string messageId, int dataElementSeparator, int componentSeparator, int segmentTerminator, SegmentTerminatorSuffix segmentTerminatorSuffix, int replaceCharacter, bool replaceSeparatorsInPayload, string targetNamespace, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ProtocolVersion = protocolVersion;
            MessageId = messageId;
            DataElementSeparator = dataElementSeparator;
            ComponentSeparator = componentSeparator;
            SegmentTerminator = segmentTerminator;
            SegmentTerminatorSuffix = segmentTerminatorSuffix;
            ReplaceCharacter = replaceCharacter;
            ReplaceSeparatorsInPayload = replaceSeparatorsInPayload;
            TargetNamespace = targetNamespace;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="X12DelimiterOverrides"/> for deserialization. </summary>
        internal X12DelimiterOverrides()
        {
        }

        /// <summary> The protocol version. </summary>
        public string ProtocolVersion { get; set; }
        /// <summary> The message id. </summary>
        public string MessageId { get; set; }
        /// <summary> The data element separator. </summary>
        public int DataElementSeparator { get; set; }
        /// <summary> The component separator. </summary>
        public int ComponentSeparator { get; set; }
        /// <summary> The segment terminator. </summary>
        public int SegmentTerminator { get; set; }
        /// <summary> The segment terminator suffix. </summary>
        public SegmentTerminatorSuffix SegmentTerminatorSuffix { get; set; }
        /// <summary> The replacement character. </summary>
        public int ReplaceCharacter { get; set; }
        /// <summary> The value indicating whether to replace separators in payload. </summary>
        public bool ReplaceSeparatorsInPayload { get; set; }
        /// <summary> The target namespace on which this delimiter settings has to be applied. </summary>
        public string TargetNamespace { get; set; }
    }
}
