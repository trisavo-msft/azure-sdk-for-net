// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary> The Edifact agreement acknowledgement settings. </summary>
    public partial class EdifactAcknowledgementSettings
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

        /// <summary> Initializes a new instance of <see cref="EdifactAcknowledgementSettings"/>. </summary>
        /// <param name="needTechnicalAcknowledgement"> The value indicating whether technical acknowledgement is needed. </param>
        /// <param name="batchTechnicalAcknowledgement"> The value indicating whether to batch the technical acknowledgements. </param>
        /// <param name="needFunctionalAcknowledgement"> The value indicating whether functional acknowledgement is needed. </param>
        /// <param name="batchFunctionalAcknowledgement"> The value indicating whether to batch functional acknowledgements. </param>
        /// <param name="needLoopForValidMessages"> The value indicating whether a loop is needed for valid messages. </param>
        /// <param name="sendSynchronousAcknowledgement"> The value indicating whether to send synchronous acknowledgement. </param>
        /// <param name="acknowledgementControlNumberLowerBound"> The acknowledgement control number lower bound. </param>
        /// <param name="acknowledgementControlNumberUpperBound"> The acknowledgement control number upper bound. </param>
        /// <param name="rolloverAcknowledgementControlNumber"> The value indicating whether to rollover acknowledgement control number. </param>
        public EdifactAcknowledgementSettings(bool needTechnicalAcknowledgement, bool batchTechnicalAcknowledgement, bool needFunctionalAcknowledgement, bool batchFunctionalAcknowledgement, bool needLoopForValidMessages, bool sendSynchronousAcknowledgement, int acknowledgementControlNumberLowerBound, int acknowledgementControlNumberUpperBound, bool rolloverAcknowledgementControlNumber)
        {
            NeedTechnicalAcknowledgement = needTechnicalAcknowledgement;
            BatchTechnicalAcknowledgement = batchTechnicalAcknowledgement;
            NeedFunctionalAcknowledgement = needFunctionalAcknowledgement;
            BatchFunctionalAcknowledgement = batchFunctionalAcknowledgement;
            NeedLoopForValidMessages = needLoopForValidMessages;
            SendSynchronousAcknowledgement = sendSynchronousAcknowledgement;
            AcknowledgementControlNumberLowerBound = acknowledgementControlNumberLowerBound;
            AcknowledgementControlNumberUpperBound = acknowledgementControlNumberUpperBound;
            RolloverAcknowledgementControlNumber = rolloverAcknowledgementControlNumber;
        }

        /// <summary> Initializes a new instance of <see cref="EdifactAcknowledgementSettings"/>. </summary>
        /// <param name="needTechnicalAcknowledgement"> The value indicating whether technical acknowledgement is needed. </param>
        /// <param name="batchTechnicalAcknowledgement"> The value indicating whether to batch the technical acknowledgements. </param>
        /// <param name="needFunctionalAcknowledgement"> The value indicating whether functional acknowledgement is needed. </param>
        /// <param name="batchFunctionalAcknowledgement"> The value indicating whether to batch functional acknowledgements. </param>
        /// <param name="needLoopForValidMessages"> The value indicating whether a loop is needed for valid messages. </param>
        /// <param name="sendSynchronousAcknowledgement"> The value indicating whether to send synchronous acknowledgement. </param>
        /// <param name="acknowledgementControlNumberPrefix"> The acknowledgement control number prefix. </param>
        /// <param name="acknowledgementControlNumberSuffix"> The acknowledgement control number suffix. </param>
        /// <param name="acknowledgementControlNumberLowerBound"> The acknowledgement control number lower bound. </param>
        /// <param name="acknowledgementControlNumberUpperBound"> The acknowledgement control number upper bound. </param>
        /// <param name="rolloverAcknowledgementControlNumber"> The value indicating whether to rollover acknowledgement control number. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal EdifactAcknowledgementSettings(bool needTechnicalAcknowledgement, bool batchTechnicalAcknowledgement, bool needFunctionalAcknowledgement, bool batchFunctionalAcknowledgement, bool needLoopForValidMessages, bool sendSynchronousAcknowledgement, string acknowledgementControlNumberPrefix, string acknowledgementControlNumberSuffix, int acknowledgementControlNumberLowerBound, int acknowledgementControlNumberUpperBound, bool rolloverAcknowledgementControlNumber, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            NeedTechnicalAcknowledgement = needTechnicalAcknowledgement;
            BatchTechnicalAcknowledgement = batchTechnicalAcknowledgement;
            NeedFunctionalAcknowledgement = needFunctionalAcknowledgement;
            BatchFunctionalAcknowledgement = batchFunctionalAcknowledgement;
            NeedLoopForValidMessages = needLoopForValidMessages;
            SendSynchronousAcknowledgement = sendSynchronousAcknowledgement;
            AcknowledgementControlNumberPrefix = acknowledgementControlNumberPrefix;
            AcknowledgementControlNumberSuffix = acknowledgementControlNumberSuffix;
            AcknowledgementControlNumberLowerBound = acknowledgementControlNumberLowerBound;
            AcknowledgementControlNumberUpperBound = acknowledgementControlNumberUpperBound;
            RolloverAcknowledgementControlNumber = rolloverAcknowledgementControlNumber;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="EdifactAcknowledgementSettings"/> for deserialization. </summary>
        internal EdifactAcknowledgementSettings()
        {
        }

        /// <summary> The value indicating whether technical acknowledgement is needed. </summary>
        public bool NeedTechnicalAcknowledgement { get; set; }
        /// <summary> The value indicating whether to batch the technical acknowledgements. </summary>
        public bool BatchTechnicalAcknowledgement { get; set; }
        /// <summary> The value indicating whether functional acknowledgement is needed. </summary>
        public bool NeedFunctionalAcknowledgement { get; set; }
        /// <summary> The value indicating whether to batch functional acknowledgements. </summary>
        public bool BatchFunctionalAcknowledgement { get; set; }
        /// <summary> The value indicating whether a loop is needed for valid messages. </summary>
        public bool NeedLoopForValidMessages { get; set; }
        /// <summary> The value indicating whether to send synchronous acknowledgement. </summary>
        public bool SendSynchronousAcknowledgement { get; set; }
        /// <summary> The acknowledgement control number prefix. </summary>
        public string AcknowledgementControlNumberPrefix { get; set; }
        /// <summary> The acknowledgement control number suffix. </summary>
        public string AcknowledgementControlNumberSuffix { get; set; }
        /// <summary> The acknowledgement control number lower bound. </summary>
        public int AcknowledgementControlNumberLowerBound { get; set; }
        /// <summary> The acknowledgement control number upper bound. </summary>
        public int AcknowledgementControlNumberUpperBound { get; set; }
        /// <summary> The value indicating whether to rollover acknowledgement control number. </summary>
        public bool RolloverAcknowledgementControlNumber { get; set; }
    }
}
