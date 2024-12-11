// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.Projects
{
    /// <summary> Evaluator Configuration. </summary>
    public partial class EvaluatorConfiguration
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

        /// <summary> Initializes a new instance of <see cref="EvaluatorConfiguration"/>. </summary>
        /// <param name="id"> Identifier of the evaluator. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public EvaluatorConfiguration(string id)
        {
            Argument.AssertNotNull(id, nameof(id));

            Id = id;
            InitParams = new ChangeTrackingDictionary<string, BinaryData>();
            DataMapping = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="EvaluatorConfiguration"/>. </summary>
        /// <param name="id"> Identifier of the evaluator. </param>
        /// <param name="initParams"> Initialization parameters of the evaluator. </param>
        /// <param name="dataMapping"> Data parameters of the evaluator. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal EvaluatorConfiguration(string id, IDictionary<string, BinaryData> initParams, IDictionary<string, string> dataMapping, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Id = id;
            InitParams = initParams;
            DataMapping = dataMapping;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="EvaluatorConfiguration"/> for deserialization. </summary>
        internal EvaluatorConfiguration()
        {
        }

        /// <summary> Identifier of the evaluator. </summary>
        public string Id { get; set; }
        /// <summary>
        /// Initialization parameters of the evaluator.
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
        public IDictionary<string, BinaryData> InitParams { get; }
        /// <summary> Data parameters of the evaluator. </summary>
        public IDictionary<string, string> DataMapping { get; }
    }
}
