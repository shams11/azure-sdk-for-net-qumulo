// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Workloads.Models
{
    /// <summary> Cache family. </summary>
    public readonly partial struct RedisCacheFamily : IEquatable<RedisCacheFamily>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="RedisCacheFamily"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public RedisCacheFamily(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string CValue = "C";
        private const string PValue = "P";

        /// <summary> C. </summary>
        public static RedisCacheFamily C { get; } = new RedisCacheFamily(CValue);
        /// <summary> P. </summary>
        public static RedisCacheFamily P { get; } = new RedisCacheFamily(PValue);
        /// <summary> Determines if two <see cref="RedisCacheFamily"/> values are the same. </summary>
        public static bool operator ==(RedisCacheFamily left, RedisCacheFamily right) => left.Equals(right);
        /// <summary> Determines if two <see cref="RedisCacheFamily"/> values are not the same. </summary>
        public static bool operator !=(RedisCacheFamily left, RedisCacheFamily right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="RedisCacheFamily"/>. </summary>
        public static implicit operator RedisCacheFamily(string value) => new RedisCacheFamily(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is RedisCacheFamily other && Equals(other);
        /// <inheritdoc />
        public bool Equals(RedisCacheFamily other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
