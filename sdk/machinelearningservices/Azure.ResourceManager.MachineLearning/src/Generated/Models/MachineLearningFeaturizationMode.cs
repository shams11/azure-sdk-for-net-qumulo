// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary>
    /// Featurization mode - determines data featurization mode.
    /// Serialized Name: FeaturizationMode
    /// </summary>
    public readonly partial struct MachineLearningFeaturizationMode : IEquatable<MachineLearningFeaturizationMode>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="MachineLearningFeaturizationMode"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MachineLearningFeaturizationMode(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AutoValue = "Auto";
        private const string CustomValue = "Custom";
        private const string OffValue = "Off";

        /// <summary>
        /// Auto mode, system performs featurization without any custom featurization inputs.
        /// Serialized Name: FeaturizationMode.Auto
        /// </summary>
        public static MachineLearningFeaturizationMode Auto { get; } = new MachineLearningFeaturizationMode(AutoValue);
        /// <summary>
        /// Custom featurization.
        /// Serialized Name: FeaturizationMode.Custom
        /// </summary>
        public static MachineLearningFeaturizationMode Custom { get; } = new MachineLearningFeaturizationMode(CustomValue);
        /// <summary>
        /// Featurization off. &apos;Forecasting&apos; task cannot use this value.
        /// Serialized Name: FeaturizationMode.Off
        /// </summary>
        public static MachineLearningFeaturizationMode Off { get; } = new MachineLearningFeaturizationMode(OffValue);
        /// <summary> Determines if two <see cref="MachineLearningFeaturizationMode"/> values are the same. </summary>
        public static bool operator ==(MachineLearningFeaturizationMode left, MachineLearningFeaturizationMode right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MachineLearningFeaturizationMode"/> values are not the same. </summary>
        public static bool operator !=(MachineLearningFeaturizationMode left, MachineLearningFeaturizationMode right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="MachineLearningFeaturizationMode"/>. </summary>
        public static implicit operator MachineLearningFeaturizationMode(string value) => new MachineLearningFeaturizationMode(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MachineLearningFeaturizationMode other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MachineLearningFeaturizationMode other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
