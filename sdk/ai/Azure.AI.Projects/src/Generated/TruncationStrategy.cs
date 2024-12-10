// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.AI.Projects
{
    /// <summary> Possible truncation strategies for the thread. </summary>
    public readonly partial struct TruncationStrategy : IEquatable<TruncationStrategy>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="TruncationStrategy"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public TruncationStrategy(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AutoValue = "auto";
        private const string LastMessagesValue = "last_messages";

        /// <summary> Default value. Messages in the middle of the thread will be dropped to fit the context length of the model. </summary>
        public static TruncationStrategy Auto { get; } = new TruncationStrategy(AutoValue);
        /// <summary> The thread will truncate to the `lastMessages` count of recent messages. </summary>
        public static TruncationStrategy LastMessages { get; } = new TruncationStrategy(LastMessagesValue);
        /// <summary> Determines if two <see cref="TruncationStrategy"/> values are the same. </summary>
        public static bool operator ==(TruncationStrategy left, TruncationStrategy right) => left.Equals(right);
        /// <summary> Determines if two <see cref="TruncationStrategy"/> values are not the same. </summary>
        public static bool operator !=(TruncationStrategy left, TruncationStrategy right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="TruncationStrategy"/>. </summary>
        public static implicit operator TruncationStrategy(string value) => new TruncationStrategy(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is TruncationStrategy other && Equals(other);
        /// <inheritdoc />
        public bool Equals(TruncationStrategy other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
