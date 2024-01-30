// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The UnknownOutboundRule. </summary>
    internal partial class UnknownOutboundRule : MachineLearningOutboundRule
    {
        /// <summary> Initializes a new instance of <see cref="UnknownOutboundRule"/>. </summary>
        /// <param name="category"> Category of a managed network Outbound Rule of a machine learning workspace. </param>
        /// <param name="status"> Type of a managed network Outbound Rule of a machine learning workspace. </param>
        /// <param name="outboundRuleType"> Type of a managed network Outbound Rule of a machine learning workspace. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UnknownOutboundRule(OutboundRuleCategory? category, OutboundRuleStatus? status, OutboundRuleType outboundRuleType, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(category, status, outboundRuleType, serializedAdditionalRawData)
        {
            OutboundRuleType = outboundRuleType;
        }

        /// <summary> Initializes a new instance of <see cref="UnknownOutboundRule"/> for deserialization. </summary>
        internal UnknownOutboundRule()
        {
        }
    }
}
