﻿// ------------------------------------------------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------------------------------------------

namespace Microsoft.CoyoteActors.TestingServices.Scheduling
{
    /// <summary>
    /// The type of an asynchronous operation
    /// </summary>
    public enum AsyncOperationType
    {
        /// <summary>
        /// An asynchronous operation performs a default context switch.
        /// </summary>
        Default = 0,

        /// <summary>
        /// An asynchronous operation starts executing.
        /// </summary>
        Start,

        /// <summary>
        /// An asynchronous operation creates another asynchronous operation.
        /// </summary>
        Create,

        /// <summary>
        /// An asynchronous operation sends an event.
        /// </summary>
        Send,

        /// <summary>
        /// An asynchronous operation receives an event.
        /// </summary>
        Receive,

        /// <summary>
        /// An asynchronous operation stops executing.
        /// </summary>
        Stop,

        /// <summary>
        /// An asynchronous operation yields.
        /// </summary>
        Yield,

        /// <summary>
        /// An asynchronous operation acquires a synchronized resource.
        /// </summary>
        Acquire,

        /// <summary>
        /// An asynchronous operation releases a synchronized resource.
        /// </summary>
        Release,

        /// <summary>
        /// An asynchronous operation waits for another asynchronous operation to stop.
        /// </summary>
        Join,

        /// <summary>
        /// An asynchronous task is injecting a failure to another task.
        /// </summary>
        InjectFailure
    }
}
