// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.DevTestLabs.Models
{
    /// <summary> Response body for generating an upload URI. </summary>
    public partial class GenerateUploadUriResponse
    {
        /// <summary> Initializes a new instance of GenerateUploadUriResponse. </summary>
        internal GenerateUploadUriResponse()
        {
        }

        /// <summary> Initializes a new instance of GenerateUploadUriResponse. </summary>
        /// <param name="uploadUri"> The upload URI for the VHD. </param>
        internal GenerateUploadUriResponse(Uri uploadUri)
        {
            UploadUri = uploadUri;
        }

        /// <summary> The upload URI for the VHD. </summary>
        public Uri UploadUri { get; }
    }
}
