﻿namespace VkNet.FluentCommands.GroupBot
{
    /// <summary>
    ///     The type of incoming message.
    /// </summary>
    internal enum MessageType
    {
        /// <summary>
        ///     Unknown type.
        /// </summary>
        None,
        
        /// <summary>
        ///     Text message type.
        /// </summary>
        Message,
        
        /// <summary>
        ///     Reply message type.
        /// </summary>
        Reply,
        
        /// <summary>
        ///     Sticker message type.
        /// </summary>
        Sticker,
        
        /// <summary>
        ///     Photo message type.
        /// </summary>
        Photo,
        
        /// <summary>
        ///     Voice message type.
        /// </summary>
        Voice
    }
}