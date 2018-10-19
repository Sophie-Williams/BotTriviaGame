﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace Bot_Builder_Echo_Bot_V4
{
    /// <summary>
    /// Stores counter state for the conversation.
    /// Stored in <see cref="Microsoft.Bot.Builder.ConversationState"/> and
    /// backed by <see cref="Microsoft.Bot.Builder.MemoryStorage"/>.
    /// </summary>
    public class CounterState
    {
        /// <summary>
        /// Gets or sets the number of turns in the conversation.
        /// </summary>
        /// <value>The number of turns in the conversation.</value>
        public int TurnCount { get; set; } = 0;

        public bool SaidHello { get; set; } = false;

        public bool GreetedName { get; set; } = false;

        public bool PlayAGame { get; set; }

        public bool OfferGame { get; set; }
    }
}
