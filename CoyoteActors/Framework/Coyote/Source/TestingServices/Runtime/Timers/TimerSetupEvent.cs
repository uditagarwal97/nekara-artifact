﻿// ------------------------------------------------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------------------------------------------

using Microsoft.CoyoteActors.Timers;

namespace Microsoft.CoyoteActors.TestingServices.Timers
{
    /// <summary>
    /// Defines a timer elapsed event that is sent from a timer to the actor that owns the timer.
    /// </summary>
    internal class TimerSetupEvent : Event
    {
        /// <summary>
        /// Stores information about the timer.
        /// </summary>
        internal readonly TimerInfo Info;

        /// <summary>
        /// The actor that owns the timer.
        /// </summary>
        internal readonly Actor Owner;

        /// <summary>
        /// Adjusts the probability of firing a timeout event.
        /// </summary>
        internal readonly uint Delay;

        /// <summary>
        /// Initializes a new instance of the <see cref="TimerSetupEvent"/> class.
        /// </summary>
        /// <param name="info">Stores information about the timer.</param>
        /// <param name="owner">The actor that owns the timer.</param>
        /// <param name="delay">Adjusts the probability of firing a timeout event.</param>
        internal TimerSetupEvent(TimerInfo info, Actor owner, uint delay)
        {
            this.Info = info;
            this.Owner = owner;
            this.Delay = delay;
        }
    }
}
