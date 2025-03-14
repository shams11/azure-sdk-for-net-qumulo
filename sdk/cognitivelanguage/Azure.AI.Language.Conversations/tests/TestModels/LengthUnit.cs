// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.AI.Language.Conversations
{
    /// <summary> The length Unit of measurement. </summary>
    public readonly partial struct LengthUnit : IEquatable<LengthUnit>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="LengthUnit"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public LengthUnit(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UnspecifiedValue = "Unspecified";
        private const string KilometerValue = "Kilometer";
        private const string HectometerValue = "Hectometer";
        private const string DecameterValue = "Decameter";
        private const string MeterValue = "Meter";
        private const string DecimeterValue = "Decimeter";
        private const string CentimeterValue = "Centimeter";
        private const string MillimeterValue = "Millimeter";
        private const string MicrometerValue = "Micrometer";
        private const string NanometerValue = "Nanometer";
        private const string PicometerValue = "Picometer";
        private const string MileValue = "Mile";
        private const string YardValue = "Yard";
        private const string InchValue = "Inch";
        private const string FootValue = "Foot";
        private const string LightYearValue = "LightYear";
        private const string PtValue = "Pt";

        /// <summary> Unspecified. </summary>
        public static LengthUnit Unspecified { get; } = new LengthUnit(UnspecifiedValue);
        /// <summary> Kilometer. </summary>
        public static LengthUnit Kilometer { get; } = new LengthUnit(KilometerValue);
        /// <summary> Hectometer. </summary>
        public static LengthUnit Hectometer { get; } = new LengthUnit(HectometerValue);
        /// <summary> Decameter. </summary>
        public static LengthUnit Decameter { get; } = new LengthUnit(DecameterValue);
        /// <summary> Meter. </summary>
        public static LengthUnit Meter { get; } = new LengthUnit(MeterValue);
        /// <summary> Decimeter. </summary>
        public static LengthUnit Decimeter { get; } = new LengthUnit(DecimeterValue);
        /// <summary> Centimeter. </summary>
        public static LengthUnit Centimeter { get; } = new LengthUnit(CentimeterValue);
        /// <summary> Millimeter. </summary>
        public static LengthUnit Millimeter { get; } = new LengthUnit(MillimeterValue);
        /// <summary> Micrometer. </summary>
        public static LengthUnit Micrometer { get; } = new LengthUnit(MicrometerValue);
        /// <summary> Nanometer. </summary>
        public static LengthUnit Nanometer { get; } = new LengthUnit(NanometerValue);
        /// <summary> Picometer. </summary>
        public static LengthUnit Picometer { get; } = new LengthUnit(PicometerValue);
        /// <summary> Mile. </summary>
        public static LengthUnit Mile { get; } = new LengthUnit(MileValue);
        /// <summary> Yard. </summary>
        public static LengthUnit Yard { get; } = new LengthUnit(YardValue);
        /// <summary> Inch. </summary>
        public static LengthUnit Inch { get; } = new LengthUnit(InchValue);
        /// <summary> Foot. </summary>
        public static LengthUnit Foot { get; } = new LengthUnit(FootValue);
        /// <summary> LightYear. </summary>
        public static LengthUnit LightYear { get; } = new LengthUnit(LightYearValue);
        /// <summary> Pt. </summary>
        public static LengthUnit Pt { get; } = new LengthUnit(PtValue);
        /// <summary> Determines if two <see cref="LengthUnit"/> values are the same. </summary>
        public static bool operator ==(LengthUnit left, LengthUnit right) => left.Equals(right);
        /// <summary> Determines if two <see cref="LengthUnit"/> values are not the same. </summary>
        public static bool operator !=(LengthUnit left, LengthUnit right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="LengthUnit"/>. </summary>
        public static implicit operator LengthUnit(string value) => new LengthUnit(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is LengthUnit other && Equals(other);
        /// <inheritdoc />
        public bool Equals(LengthUnit other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
