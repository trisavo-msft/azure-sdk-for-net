// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.SecurityCenter;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> The TopologyList. </summary>
    internal partial class TopologyList
    {
        /// <summary> Initializes a new instance of TopologyList. </summary>
        internal TopologyList()
        {
            Value = new ChangeTrackingList<TopologyResourceData>();
        }

        /// <summary> Initializes a new instance of TopologyList. </summary>
        /// <param name="value"></param>
        /// <param name="nextLink"> The URI to fetch the next page. </param>
        internal TopologyList(IReadOnlyList<TopologyResourceData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Gets the value. </summary>
        public IReadOnlyList<TopologyResourceData> Value { get; }
        /// <summary> The URI to fetch the next page. </summary>
        public string NextLink { get; }
    }
}
