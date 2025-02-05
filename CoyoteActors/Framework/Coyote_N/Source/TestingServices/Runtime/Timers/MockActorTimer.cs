﻿// ------------------------------------------------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------------------------------------------

using Microsoft.CoyoteActors.Timers;

namespace Microsoft.CoyoteActors.TestingServices.Timers
{
    /// <summary>
    /// A mock timer that replaces <see cref="ActorTimer"/> during testing.
    /// It is implemented as an actor.
    /// </summary>
    internal class MockActorTimer : Actor, IActorTimer
    {
        /// <summary>
        /// Stores information about this timer.
        /// </summary>
        private TimerInfo TimerInfo;

        /// <summary>
        /// Stores information about this timer.
        /// </summary>
        TimerInfo IActorTimer.Info => this.TimerInfo;

        /// <summary>
        /// The actor that owns this timer.
        /// </summary>
        private Actor Owner;

        /// <summary>
        /// The timeout event.
        /// </summary>
        private TimerElapsedEvent TimeoutEvent;

        /// <summary>
        /// Adjusts the probability of firing a timeout event.
        /// </summary>
        private uint Delay;

        [Start]
        [OnEntry(nameof(Setup))]
        [OnEventDoAction(typeof(Default), nameof(HandleTimeout))]
        private class Active : ActorState
        {
        }

        /// <summary>
        /// Initializes the timer with the specified configuration.
        /// </summary>
        private void Setup()
        {
            this.TimerInfo = (this.ReceivedEvent as TimerSetupEvent).Info;
            this.Owner = (this.ReceivedEvent as TimerSetupEvent).Owner;
            this.Delay = (this.ReceivedEvent as TimerSetupEvent).Delay;
            this.TimeoutEvent = new TimerElapsedEvent(this.TimerInfo);
        }

        /// <summary>
        /// Handles the timeout.
        /// </summary>
        private void HandleTimeout()
        {
            // Try to send the next timeout event.
            bool isTimeoutSent = false;
            int delay = (int)this.Delay > 0 ? (int)this.Delay : 1;
            if ((this.RandomInteger(delay) == 0) && this.FairRandom())
            {
                // The probability of sending a timeout event is atmost 1/N.
                this.Send(this.Owner.Id, this.TimeoutEvent);
                isTimeoutSent = true;
            }

            // If non-periodic, and a timeout was successfully sent, then become
            // inactive until disposal. Else retry.
            if (isTimeoutSent && this.TimerInfo.Period.TotalMilliseconds < 0)
            {
                this.Goto<Inactive>();
            }
        }

        private class Inactive : ActorState
        {
        }

        /// <summary>
        /// Determines whether the specified System.Object is equal
        /// to the current System.Object.
        /// </summary>
        public override bool Equals(object obj)
        {
            if (obj is MockActorTimer timer)
            {
                return this.Id == timer.Id;
            }

            return false;
        }

        /// <summary>
        /// Returns the hash code for this instance.
        /// </summary>
        public override int GetHashCode() => this.Id.GetHashCode();

        /// <summary>
        /// Returns a string that represents the current instance.
        /// </summary>
        public override string ToString() => this.Id.Name;

        /// <summary>
        /// Indicates whether the specified <see cref="ActorId"/> is equal
        /// to the current <see cref="ActorId"/>.
        /// </summary>
        /// <param name="other">An object to compare with this object.</param>
        /// <returns>true if the current object is equal to the other parameter; otherwise, false.</returns>
        public bool Equals(ActorTimer other)
        {
            return this.Equals((object)other);
        }

        /// <summary>
        /// Disposes the resources held by this timer.
        /// </summary>
        public void Dispose()
        {
            this.Runtime.SendEvent(this.Id, new Halt());
        }
    }
}
