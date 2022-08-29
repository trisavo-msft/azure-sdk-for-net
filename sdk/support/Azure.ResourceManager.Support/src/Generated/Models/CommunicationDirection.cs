// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Support.Models
{
    /// <summary> Direction of communication. </summary>
    public readonly partial struct CommunicationDirection : IEquatable<CommunicationDirection>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="CommunicationDirection"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public CommunicationDirection(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string InboundValue = "inbound";
        private const string OutboundValue = "outbound";

        /// <summary> inbound. </summary>
        public static CommunicationDirection Inbound { get; } = new CommunicationDirection(InboundValue);
        /// <summary> outbound. </summary>
        public static CommunicationDirection Outbound { get; } = new CommunicationDirection(OutboundValue);
        /// <summary> Determines if two <see cref="CommunicationDirection"/> values are the same. </summary>
        public static bool operator ==(CommunicationDirection left, CommunicationDirection right) => left.Equals(right);
        /// <summary> Determines if two <see cref="CommunicationDirection"/> values are not the same. </summary>
        public static bool operator !=(CommunicationDirection left, CommunicationDirection right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="CommunicationDirection"/>. </summary>
        public static implicit operator CommunicationDirection(string value) => new CommunicationDirection(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is CommunicationDirection other && Equals(other);
        /// <inheritdoc />
        public bool Equals(CommunicationDirection other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
