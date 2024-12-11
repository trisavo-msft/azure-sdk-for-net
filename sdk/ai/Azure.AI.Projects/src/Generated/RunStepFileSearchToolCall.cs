// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.Projects
{
    /// <summary>
    /// A record of a call to a file search tool, issued by the model in evaluation of a defined tool, that represents
    /// executed file search.
    /// </summary>
    public partial class RunStepFileSearchToolCall : RunStepToolCall
    {
        /// <summary> Initializes a new instance of <see cref="RunStepFileSearchToolCall"/>. </summary>
        /// <param name="id"> The ID of the tool call. This ID must be referenced when you submit tool outputs. </param>
        /// <param name="fileSearch"> Reserved for future use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> or <paramref name="fileSearch"/> is null. </exception>
        internal RunStepFileSearchToolCall(string id, IReadOnlyDictionary<string, string> fileSearch) : base(id)
        {
            Argument.AssertNotNull(id, nameof(id));
            Argument.AssertNotNull(fileSearch, nameof(fileSearch));

            Type = "file_search";
            FileSearch = fileSearch;
        }

        /// <summary> Initializes a new instance of <see cref="RunStepFileSearchToolCall"/>. </summary>
        /// <param name="type"> The object type. </param>
        /// <param name="id"> The ID of the tool call. This ID must be referenced when you submit tool outputs. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="fileSearch"> Reserved for future use. </param>
        internal RunStepFileSearchToolCall(string type, string id, IDictionary<string, BinaryData> serializedAdditionalRawData, IReadOnlyDictionary<string, string> fileSearch) : base(type, id, serializedAdditionalRawData)
        {
            FileSearch = fileSearch;
        }

        /// <summary> Initializes a new instance of <see cref="RunStepFileSearchToolCall"/> for deserialization. </summary>
        internal RunStepFileSearchToolCall()
        {
        }

        /// <summary> Reserved for future use. </summary>
        public IReadOnlyDictionary<string, string> FileSearch { get; }
    }
}
