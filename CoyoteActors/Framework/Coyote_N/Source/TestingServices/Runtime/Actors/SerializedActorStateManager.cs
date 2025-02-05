﻿// ------------------------------------------------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

using Microsoft.CoyoteActors.Runtime;
using Microsoft.CoyoteActors.Threading;

namespace Microsoft.CoyoteActors.TestingServices.Runtime
{
    /// <summary>
    /// Implements a state manager that is used by a serialized actor during testing.
    /// </summary>
    internal sealed class SerializedActorStateManager : IActorStateManager
    {
        /// <summary>
        /// The runtime that executes the actor being managed.
        /// </summary>
        private readonly SystematicTestingRuntime Runtime;

        /// <summary>
        /// The actor being managed.
        /// </summary>
        private readonly Actor Actor;

        /// <summary>
        /// True if the event handler of the actor is running, else false.
        /// </summary>
        public bool IsEventHandlerRunning { get; set; }

        /// <summary>
        /// Id used to identify subsequent operations performed by the actor.
        /// </summary>
        public Guid OperationGroupId { get; set; }

        /// <summary>
        /// Program counter used for state-caching. Distinguishes
        /// scheduling from non-deterministic choices.
        /// </summary>
        internal int ProgramCounter;

        /// <summary>
        /// True if a transition statement was called in the current action, else false.
        /// </summary>
        internal bool IsTransitionStatementCalledInCurrentAction;

        /// <summary>
        /// True if the actor is currently executing an asynchronous handler
        /// that returns a <see cref="ActorTask"/>, else false.
        /// </summary>
        internal bool IsInsideActorTaskHandler;

        /// <summary>
        /// True if the actor is executing an on exit action, else false.
        /// </summary>
        internal bool IsInsideOnExit;

        /// <summary>
        /// Initializes a new instance of the <see cref="SerializedActorStateManager"/> class.
        /// </summary>
        internal SerializedActorStateManager(SystematicTestingRuntime runtime, Actor actor, Guid operationGroupId)
        {
            this.Runtime = runtime;
            this.Actor = actor;
            this.IsEventHandlerRunning = true;
            this.OperationGroupId = operationGroupId;
            this.ProgramCounter = 0;
            this.IsTransitionStatementCalledInCurrentAction = false;
            this.IsInsideActorTaskHandler = false;
            this.IsInsideOnExit = false;
        }

        /// <summary>
        /// Returns the cached state of the actor.
        /// </summary>
        public int GetCachedState() => 0;
        // {
        //    unchecked
        //    {
        //        return this.ProgramCounter.GetHashCode();
        //    }
        // }

        /// <summary>
        /// Checks if the specified event is ignored in the current actor state.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool IsEventIgnoredInCurrentState(Event e, Guid opGroupId, EventInfo eventInfo) =>
            this.Actor.IsEventIgnoredInCurrentState(e);

        /// <summary>
        /// Checks if the specified event is deferred in the current actor state.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool IsEventDeferredInCurrentState(Event e, Guid opGroupId, EventInfo eventInfo) =>
            this.Actor.IsEventDeferredInCurrentState(e);

        /// <summary>
        /// Checks if a default handler is installed in the current actor state.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool IsDefaultHandlerInstalledInCurrentState() => this.Actor.IsDefaultHandlerInstalledInCurrentState();

        /// <summary>
        /// Notifies the actor that an event has been enqueued.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void OnEnqueueEvent(Event e, Guid opGroupId, EventInfo eventInfo) =>
            this.Runtime.LogWriter.OnEnqueue(this.Actor.Id, e.GetType().FullName);

        /// <summary>
        /// Notifies the actor that an event has been raised.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void OnRaiseEvent(Event e, Guid opGroupId, EventInfo eventInfo) =>
            this.Runtime.NotifyRaisedEvent(this.Actor, e, eventInfo);

        /// <summary>
        /// Notifies the actor that it is waiting to receive an event of one of the specified types.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void OnWaitEvent(IEnumerable<Type> eventTypes) =>
            this.Runtime.NotifyWaitEvent(this.Actor, eventTypes);

        /// <summary>
        /// Notifies the actor that an event it was waiting to receive has been enqueued.
        /// </summary>
        public void OnReceiveEvent(Event e, Guid opGroupId, EventInfo eventInfo)
        {
            if (opGroupId != Guid.Empty)
            {
                // Inherit the operation group id of the receive operation, if it is non-empty.
                this.OperationGroupId = opGroupId;
            }

            this.Runtime.NotifyReceivedEvent(this.Actor, e, eventInfo);
        }

        /// <summary>
        /// Notifies the actor that an event it was waiting to receive was already in the
        /// event queue when the actor invoked the receive statement.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void OnReceiveEventWithoutWaiting(Event e, Guid opGroupId, EventInfo eventInfo)
        {
            if (opGroupId != Guid.Empty)
            {
                // Inherit the operation group id of the receive operation, if it is non-empty.
                this.OperationGroupId = opGroupId;
            }

            this.Runtime.NotifyReceivedEventWithoutWaiting(this.Actor, e, eventInfo);
        }

        /// <summary>
        /// Notifies the actor that an event has been dropped.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void OnDropEvent(Event e, Guid opGroupId, EventInfo eventInfo)
        {
            this.Runtime.Assert(!eventInfo.MustHandle, "Actor '{0}' halted before dequeueing must-handle event '{1}'.",
                this.Actor.Id, e.GetType().FullName);
            this.Runtime.TryHandleDroppedEvent(e, this.Actor.Id);
        }

        /// <summary>
        /// Asserts if the specified condition holds.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Assert(bool predicate, string s, object arg0) => this.Runtime.Assert(predicate, s, arg0);

        /// <summary>
        /// Asserts if the specified condition holds.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Assert(bool predicate, string s, object arg0, object arg1) => this.Runtime.Assert(predicate, s, arg0, arg1);

        /// <summary>
        /// Asserts if the specified condition holds.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Assert(bool predicate, string s, object arg0, object arg1, object arg2) =>
            this.Runtime.Assert(predicate, s, arg0, arg1, arg2);

        /// <summary>
        /// Asserts if the specified condition holds.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Assert(bool predicate, string s, params object[] args) => this.Runtime.Assert(predicate, s, args);
    }
}
