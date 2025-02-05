﻿// ------------------------------------------------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace Microsoft.CoyoteActors.Runtime
{
    /// <summary>
    /// Interface for managing the state of an actor.
    /// </summary>
    internal interface IActorStateManager
    {
        /// <summary>
        /// True if the event handler of the actor is running, else false.
        /// </summary>
        bool IsEventHandlerRunning { get; set; }

        /// <summary>
        /// Id used to identify subsequent operations performed by the actor.
        /// </summary>
        Guid OperationGroupId { get; set; }

        /// <summary>
        /// Returns the cached state of the actor.
        /// </summary>
        int GetCachedState();

        /// <summary>
        /// Checks if the specified event is ignored in the current actor state.
        /// </summary>
        bool IsEventIgnoredInCurrentState(Event e, Guid opGroupId, EventInfo eventInfo);

        /// <summary>
        /// Checks if the specified event is deferred in the current actor state.
        /// </summary>
        bool IsEventDeferredInCurrentState(Event e, Guid opGroupId, EventInfo eventInfo);

        /// <summary>
        /// Checks if a default handler is installed in the current actor state.
        /// </summary>
        bool IsDefaultHandlerInstalledInCurrentState();

        /// <summary>
        /// Notifies the actor that an event has been enqueued.
        /// </summary>
        void OnEnqueueEvent(Event e, Guid opGroupId, EventInfo eventInfo);

        /// <summary>
        /// Notifies the actor that an event has been raised.
        /// </summary>
        void OnRaiseEvent(Event e, Guid opGroupId, EventInfo eventInfo);

        /// <summary>
        /// Notifies the actor that it is waiting to receive an event of one of the specified types.
        /// </summary>
        void OnWaitEvent(IEnumerable<Type> eventTypes);

        /// <summary>
        /// Notifies the actor that an event it was waiting to receive has been enqueued.
        /// </summary>
        void OnReceiveEvent(Event e, Guid opGroupId, EventInfo eventInfo);

        /// <summary>
        /// Notifies the actor that an event it was waiting to receive was already in the
        /// event queue when the actor invoked the receive statement.
        /// </summary>
        void OnReceiveEventWithoutWaiting(Event e, Guid opGroupId, EventInfo eventInfo);

        /// <summary>
        /// Notifies the actor that an event has been dropped.
        /// </summary>
        void OnDropEvent(Event e, Guid opGroupId, EventInfo eventInfo);

        /// <summary>
        /// Asserts if the specified condition holds.
        /// </summary>
        void Assert(bool predicate, string s, object arg0);

        /// <summary>
        /// Asserts if the specified condition holds.
        /// </summary>
        void Assert(bool predicate, string s, object arg0, object arg1);

        /// <summary>
        /// Asserts if the specified condition holds.
        /// </summary>
        void Assert(bool predicate, string s, object arg0, object arg1, object arg2);

        /// <summary>
        /// Asserts if the specified condition holds.
        /// </summary>
        void Assert(bool predicate, string s, params object[] args);
    }
}
