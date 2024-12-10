// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.AI.Projects
{
    /// <summary>
    /// Each event in a server-sent events stream has an `event` and `data` property:
    ///
    /// ```
    /// event: thread.created
    /// data: {"id": "thread_123", "object": "thread", ...}
    /// ```
    ///
    /// We emit events whenever a new object is created, transitions to a new state, or is being
    /// streamed in parts (deltas). For example, we emit `thread.run.created` when a new run
    /// is created, `thread.run.completed` when a run completes, and so on. When an Agent chooses
    /// to create a message during a run, we emit a `thread.message.created event`, a
    /// `thread.message.in_progress` event, many `thread.message.delta` events, and finally a
    /// `thread.message.completed` event.
    ///
    /// We may add additional events over time, so we recommend handling unknown events gracefully
    /// in your code.
    /// </summary>
    public readonly partial struct AgentStreamEvent : IEquatable<AgentStreamEvent>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AgentStreamEvent"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AgentStreamEvent(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ThreadCreatedValue = "thread.created";
        private const string ThreadRunCreatedValue = "thread.run.created";
        private const string ThreadRunQueuedValue = "thread.run.queued";
        private const string ThreadRunInProgressValue = "thread.run.in_progress";
        private const string ThreadRunRequiresActionValue = "thread.run.requires_action";
        private const string ThreadRunCompletedValue = "thread.run.completed";
        private const string ThreadRunIncompleteValue = "thread.run.incomplete";
        private const string ThreadRunFailedValue = "thread.run.failed";
        private const string ThreadRunCancellingValue = "thread.run.cancelling";
        private const string ThreadRunCancelledValue = "thread.run.cancelled";
        private const string ThreadRunExpiredValue = "thread.run.expired";
        private const string ThreadRunStepCreatedValue = "thread.run.step.created";
        private const string ThreadRunStepInProgressValue = "thread.run.step.in_progress";
        private const string ThreadRunStepDeltaValue = "thread.run.step.delta";
        private const string ThreadRunStepCompletedValue = "thread.run.step.completed";
        private const string ThreadRunStepFailedValue = "thread.run.step.failed";
        private const string ThreadRunStepCancelledValue = "thread.run.step.cancelled";
        private const string ThreadRunStepExpiredValue = "thread.run.step.expired";
        private const string ThreadMessageCreatedValue = "thread.message.created";
        private const string ThreadMessageInProgressValue = "thread.message.in_progress";
        private const string ThreadMessageDeltaValue = "thread.message.delta";
        private const string ThreadMessageCompletedValue = "thread.message.completed";
        private const string ThreadMessageIncompleteValue = "thread.message.incomplete";
        private const string ErrorValue = "error";
        private const string DoneValue = "done";

        /// <summary> Event sent when a new thread is created. The data of this event is of type AgentThread. </summary>
        public static AgentStreamEvent ThreadCreated { get; } = new AgentStreamEvent(ThreadCreatedValue);
        /// <summary> Event sent when a new run is created. The data of this event is of type ThreadRun. </summary>
        public static AgentStreamEvent ThreadRunCreated { get; } = new AgentStreamEvent(ThreadRunCreatedValue);
        /// <summary> Event sent when a run moves to `queued` status. The data of this event is of type ThreadRun. </summary>
        public static AgentStreamEvent ThreadRunQueued { get; } = new AgentStreamEvent(ThreadRunQueuedValue);
        /// <summary> Event sent when a run moves to `in_progress` status. The data of this event is of type ThreadRun. </summary>
        public static AgentStreamEvent ThreadRunInProgress { get; } = new AgentStreamEvent(ThreadRunInProgressValue);
        /// <summary> Event sent when a run moves to `requires_action` status. The data of this event is of type ThreadRun. </summary>
        public static AgentStreamEvent ThreadRunRequiresAction { get; } = new AgentStreamEvent(ThreadRunRequiresActionValue);
        /// <summary> Event sent when a run is completed. The data of this event is of type ThreadRun. </summary>
        public static AgentStreamEvent ThreadRunCompleted { get; } = new AgentStreamEvent(ThreadRunCompletedValue);
        /// <summary> Event sent when a run ends incompleted. The data of this event is of type ThreadRun. </summary>
        public static AgentStreamEvent ThreadRunIncomplete { get; } = new AgentStreamEvent(ThreadRunIncompleteValue);
        /// <summary> Event sent when a run fails. The data of this event is of type ThreadRun. </summary>
        public static AgentStreamEvent ThreadRunFailed { get; } = new AgentStreamEvent(ThreadRunFailedValue);
        /// <summary> Event sent when a run moves to `cancelling` status. The data of this event is of type ThreadRun. </summary>
        public static AgentStreamEvent ThreadRunCancelling { get; } = new AgentStreamEvent(ThreadRunCancellingValue);
        /// <summary> Event sent when a run is cancelled. The data of this event is of type ThreadRun. </summary>
        public static AgentStreamEvent ThreadRunCancelled { get; } = new AgentStreamEvent(ThreadRunCancelledValue);
        /// <summary> Event sent when a run is expired. The data of this event is of type ThreadRun. </summary>
        public static AgentStreamEvent ThreadRunExpired { get; } = new AgentStreamEvent(ThreadRunExpiredValue);
        /// <summary> Event sent when a new thread run step is created. The data of this event is of type RunStep. </summary>
        public static AgentStreamEvent ThreadRunStepCreated { get; } = new AgentStreamEvent(ThreadRunStepCreatedValue);
        /// <summary> Event sent when a run step moves to `in_progress` status. The data of this event is of type RunStep. </summary>
        public static AgentStreamEvent ThreadRunStepInProgress { get; } = new AgentStreamEvent(ThreadRunStepInProgressValue);
        /// <summary> Event sent when a run step is being streamed. The data of this event is of type RunStepDeltaChunk. </summary>
        public static AgentStreamEvent ThreadRunStepDelta { get; } = new AgentStreamEvent(ThreadRunStepDeltaValue);
        /// <summary> Event sent when a run step is completed. The data of this event is of type RunStep. </summary>
        public static AgentStreamEvent ThreadRunStepCompleted { get; } = new AgentStreamEvent(ThreadRunStepCompletedValue);
        /// <summary> Event sent when a run step fails. The data of this event is of type RunStep. </summary>
        public static AgentStreamEvent ThreadRunStepFailed { get; } = new AgentStreamEvent(ThreadRunStepFailedValue);
        /// <summary> Event sent when a run step is cancelled. The data of this event is of type RunStep. </summary>
        public static AgentStreamEvent ThreadRunStepCancelled { get; } = new AgentStreamEvent(ThreadRunStepCancelledValue);
        /// <summary> Event sent when a run step is expired. The data of this event is of type RunStep. </summary>
        public static AgentStreamEvent ThreadRunStepExpired { get; } = new AgentStreamEvent(ThreadRunStepExpiredValue);
        /// <summary> Event sent when a new message is created. The data of this event is of type ThreadMessage. </summary>
        public static AgentStreamEvent ThreadMessageCreated { get; } = new AgentStreamEvent(ThreadMessageCreatedValue);
        /// <summary> Event sent when a message moves to `in_progress` status. The data of this event is of type ThreadMessage. </summary>
        public static AgentStreamEvent ThreadMessageInProgress { get; } = new AgentStreamEvent(ThreadMessageInProgressValue);
        /// <summary> Event sent when a message is being streamed. The data of this event is of type MessageDeltaChunk. </summary>
        public static AgentStreamEvent ThreadMessageDelta { get; } = new AgentStreamEvent(ThreadMessageDeltaValue);
        /// <summary> Event sent when a message is completed. The data of this event is of type ThreadMessage. </summary>
        public static AgentStreamEvent ThreadMessageCompleted { get; } = new AgentStreamEvent(ThreadMessageCompletedValue);
        /// <summary> Event sent before a message is completed. The data of this event is of type ThreadMessage. </summary>
        public static AgentStreamEvent ThreadMessageIncomplete { get; } = new AgentStreamEvent(ThreadMessageIncompleteValue);
        /// <summary> Event sent when an error occurs, such as an internal server error or a timeout. </summary>
        public static AgentStreamEvent Error { get; } = new AgentStreamEvent(ErrorValue);
        /// <summary> Event sent when the stream is done. </summary>
        public static AgentStreamEvent Done { get; } = new AgentStreamEvent(DoneValue);
        /// <summary> Determines if two <see cref="AgentStreamEvent"/> values are the same. </summary>
        public static bool operator ==(AgentStreamEvent left, AgentStreamEvent right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AgentStreamEvent"/> values are not the same. </summary>
        public static bool operator !=(AgentStreamEvent left, AgentStreamEvent right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="AgentStreamEvent"/>. </summary>
        public static implicit operator AgentStreamEvent(string value) => new AgentStreamEvent(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AgentStreamEvent other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AgentStreamEvent other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
