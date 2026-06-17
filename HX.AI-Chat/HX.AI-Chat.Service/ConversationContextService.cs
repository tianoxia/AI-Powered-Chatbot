using System;

namespace HX.AI_Chat.Service
{
    /// <summary>
    /// Scoped service that holds the current conversation context for tool invocations.
    /// This allows tools to access the conversation ID without requiring it as a parameter.
    /// </summary>
    public interface IConversationContextService
    {
        /// <summary>
        /// Gets or sets the current conversation ID.
        /// </summary>
        Guid? ConversationId { get; set; }

        /// <summary>
        /// Gets or sets the current user ID.
        /// </summary>
        Guid? UserId { get; set; }
    }

    public class ConversationContextService : IConversationContextService
    {
        public Guid? ConversationId { get; set; }
        public Guid? UserId { get; set; }
    }
}
