// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.AI.OpenAI
{
    /// <summary>
    /// A tool call to a function tool, issued by the model in evaluation of a configured function tool, that represents
    /// a function invocation needed for a subsequent chat completions request to resolve.
    /// </summary>
    public partial class ChatCompletionsFunctionToolCall : ChatCompletionsToolCall
    {
        /// <summary> Initializes a new instance of <see cref="ChatCompletionsFunctionToolCall"/>. </summary>
        /// <param name="type"> The object type. </param>
        /// <param name="id"> The ID of the tool call. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="function"> The details of the function invocation requested by the tool call. </param>
        internal ChatCompletionsFunctionToolCall(string type, string id, IDictionary<string, BinaryData> serializedAdditionalRawData, FunctionCall function) : base(type, id, serializedAdditionalRawData)
        {
            Function = function;
        }

        /// <summary> Initializes a new instance of <see cref="ChatCompletionsFunctionToolCall"/> for deserialization. </summary>
        internal ChatCompletionsFunctionToolCall()
        {
        }
    }
}
