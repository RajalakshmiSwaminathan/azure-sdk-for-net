// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.KubernetesConfiguration.Models
{
    /// <summary> The provisioning state of the resource provider. </summary>
    public readonly partial struct ProvisioningStateType : IEquatable<ProvisioningStateType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ProvisioningStateType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ProvisioningStateType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AcceptedValue = "Accepted";
        private const string DeletingValue = "Deleting";
        private const string RunningValue = "Running";
        private const string SucceededValue = "Succeeded";
        private const string FailedValue = "Failed";

        /// <summary> Accepted. </summary>
        public static ProvisioningStateType Accepted { get; } = new ProvisioningStateType(AcceptedValue);
        /// <summary> Deleting. </summary>
        public static ProvisioningStateType Deleting { get; } = new ProvisioningStateType(DeletingValue);
        /// <summary> Running. </summary>
        public static ProvisioningStateType Running { get; } = new ProvisioningStateType(RunningValue);
        /// <summary> Succeeded. </summary>
        public static ProvisioningStateType Succeeded { get; } = new ProvisioningStateType(SucceededValue);
        /// <summary> Failed. </summary>
        public static ProvisioningStateType Failed { get; } = new ProvisioningStateType(FailedValue);
        /// <summary> Determines if two <see cref="ProvisioningStateType"/> values are the same. </summary>
        public static bool operator ==(ProvisioningStateType left, ProvisioningStateType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ProvisioningStateType"/> values are not the same. </summary>
        public static bool operator !=(ProvisioningStateType left, ProvisioningStateType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ProvisioningStateType"/>. </summary>
        public static implicit operator ProvisioningStateType(string value) => new ProvisioningStateType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ProvisioningStateType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ProvisioningStateType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
