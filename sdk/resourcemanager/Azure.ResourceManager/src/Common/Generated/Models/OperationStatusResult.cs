// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;
using Azure.Core;

namespace Azure.ResourceManager.Models
{
    /// <summary> The current status of an async operation. </summary>
    [TypeReferenceType]
    public partial class OperationStatusResult
    {
        /// <summary> Initializes a new instance of <see cref="OperationStatusResult"/>. </summary>
        /// <param name="status"> Operation status. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="status"/> is null. </exception>
        [InitializationConstructor]
        public OperationStatusResult(string status)
        {
            Argument.AssertNotNull(status, nameof(status));

            Status = status;
            Operations = new ChangeTrackingList<OperationStatusResult>();
        }

        /// <summary> Initializes a new instance of <see cref="OperationStatusResult"/>. </summary>
        /// <param name="id"> Fully qualified ID for the async operation. </param>
        /// <param name="name"> Name of the async operation. </param>
        /// <param name="status"> Operation status. </param>
        /// <param name="percentComplete"> Percent of the operation that is complete. </param>
        /// <param name="startOn"> The start time of the operation. </param>
        /// <param name="endOn"> The end time of the operation. </param>
        /// <param name="operations"> The operations list. </param>
        /// <param name="error"> If present, details of the operation error. </param>
        [SerializationConstructor]
        protected OperationStatusResult(ResourceIdentifier id, string name, string status, float? percentComplete, DateTimeOffset? startOn, DateTimeOffset? endOn, IReadOnlyList<OperationStatusResult> operations, ResponseError error)
        {
            Id = id;
            Name = name;
            Status = status;
            PercentComplete = percentComplete;
            StartOn = startOn;
            EndOn = endOn;
            Operations = operations;
            Error = error;
        }

        /// <summary> Initializes a new instance of <see cref="OperationStatusResult"/> for deserialization. </summary>
        protected OperationStatusResult()
        {
        }

        /// <summary> Fully qualified ID for the async operation. </summary>
        public ResourceIdentifier Id { get; }
        /// <summary> Name of the async operation. </summary>
        public string Name { get; }
        /// <summary> Operation status. </summary>
        public string Status { get; }
        /// <summary> Percent of the operation that is complete. </summary>
        public float? PercentComplete { get; }
        /// <summary> The start time of the operation. </summary>
        public DateTimeOffset? StartOn { get; }
        /// <summary> The end time of the operation. </summary>
        public DateTimeOffset? EndOn { get; }
        /// <summary> The operations list. </summary>
        public IReadOnlyList<OperationStatusResult> Operations { get; }
        /// <summary> If present, details of the operation error. </summary>
        public ResponseError Error { get; }
    }
}
