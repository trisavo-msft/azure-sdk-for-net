// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;
using MgmtTypeSpec;

namespace MgmtTypeSpec.Models
{
    /// <summary> Type of managed service identity (where both SystemAssigned and UserAssigned types are allowed). </summary>
    public readonly partial struct ManagedServiceIdentityType : IEquatable<ManagedServiceIdentityType>
    {
        private readonly string _value;
        /// <summary> No managed identity. </summary>
        private const string NoneValue = "None";
        /// <summary> System assigned managed identity. </summary>
        private const string SystemAssignedValue = "SystemAssigned";
        /// <summary> User assigned managed identity. </summary>
        private const string UserAssignedValue = "UserAssigned";
        /// <summary> System and user assigned managed identity. </summary>
        private const string SystemAndUserAssignedValue = "SystemAssigned,UserAssigned";

        /// <summary> Initializes a new instance of <see cref="ManagedServiceIdentityType"/>. </summary>
        /// <param name="value"> The value. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ManagedServiceIdentityType(string value)
        {
            Argument.AssertNotNull(value, nameof(value));

            _value = value;
        }

        /// <summary> No managed identity. </summary>
        public static ManagedServiceIdentityType None { get; } = new ManagedServiceIdentityType(NoneValue);

        /// <summary> System assigned managed identity. </summary>
        public static ManagedServiceIdentityType SystemAssigned { get; } = new ManagedServiceIdentityType(SystemAssignedValue);

        /// <summary> User assigned managed identity. </summary>
        public static ManagedServiceIdentityType UserAssigned { get; } = new ManagedServiceIdentityType(UserAssignedValue);

        /// <summary> System and user assigned managed identity. </summary>
        public static ManagedServiceIdentityType SystemAndUserAssigned { get; } = new ManagedServiceIdentityType(SystemAndUserAssignedValue);

        /// <summary> Determines if two <see cref="ManagedServiceIdentityType"/> values are the same. </summary>
        /// <param name="left"> The left value to compare. </param>
        /// <param name="right"> The right value to compare. </param>
        public static bool operator ==(ManagedServiceIdentityType left, ManagedServiceIdentityType right) => left.Equals(right);

        /// <summary> Determines if two <see cref="ManagedServiceIdentityType"/> values are not the same. </summary>
        /// <param name="left"> The left value to compare. </param>
        /// <param name="right"> The right value to compare. </param>
        public static bool operator !=(ManagedServiceIdentityType left, ManagedServiceIdentityType right) => !left.Equals(right);

        /// <summary> Converts a string to a <see cref="ManagedServiceIdentityType"/>. </summary>
        /// <param name="value"> The value. </param>
        public static implicit operator ManagedServiceIdentityType(string value) => new ManagedServiceIdentityType(value);

        /// <param name="obj"> The object to compare. </param>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ManagedServiceIdentityType other && Equals(other);

        /// <param name="other"> The instance to compare. </param>
        public bool Equals(ManagedServiceIdentityType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc/>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;

        /// <inheritdoc/>
        public override string ToString() => _value;
    }
}
