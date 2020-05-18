// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Iot.Hub.Service.Models
{
    /// <summary> The status of the job. </summary>
    public readonly partial struct JobPropertiesStatus : IEquatable<JobPropertiesStatus>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="JobPropertiesStatus"/> values are the same. </summary>
        public JobPropertiesStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UnknownValue = "unknown";
        private const string EnqueuedValue = "enqueued";
        private const string RunningValue = "running";
        private const string CompletedValue = "completed";
        private const string FailedValue = "failed";
        private const string CancelledValue = "cancelled";
        private const string ScheduledValue = "scheduled";
        private const string QueuedValue = "queued";

        /// <summary> unknown. </summary>
        public static JobPropertiesStatus Unknown { get; } = new JobPropertiesStatus(UnknownValue);
        /// <summary> enqueued. </summary>
        public static JobPropertiesStatus Enqueued { get; } = new JobPropertiesStatus(EnqueuedValue);
        /// <summary> running. </summary>
        public static JobPropertiesStatus Running { get; } = new JobPropertiesStatus(RunningValue);
        /// <summary> completed. </summary>
        public static JobPropertiesStatus Completed { get; } = new JobPropertiesStatus(CompletedValue);
        /// <summary> failed. </summary>
        public static JobPropertiesStatus Failed { get; } = new JobPropertiesStatus(FailedValue);
        /// <summary> cancelled. </summary>
        public static JobPropertiesStatus Cancelled { get; } = new JobPropertiesStatus(CancelledValue);
        /// <summary> scheduled. </summary>
        public static JobPropertiesStatus Scheduled { get; } = new JobPropertiesStatus(ScheduledValue);
        /// <summary> queued. </summary>
        public static JobPropertiesStatus Queued { get; } = new JobPropertiesStatus(QueuedValue);
        /// <summary> Determines if two <see cref="JobPropertiesStatus"/> values are the same. </summary>
        public static bool operator ==(JobPropertiesStatus left, JobPropertiesStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="JobPropertiesStatus"/> values are not the same. </summary>
        public static bool operator !=(JobPropertiesStatus left, JobPropertiesStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="JobPropertiesStatus"/>. </summary>
        public static implicit operator JobPropertiesStatus(string value) => new JobPropertiesStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is JobPropertiesStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(JobPropertiesStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
