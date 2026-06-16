using HX.AI_Chat.Common.Enums;

namespace HX.AI_Chat.Dto
{
    public class ConversationMessageDto
    {
        public string Text { get; set; } = null!;

        public ChatRoles Role { get; set; }
    }
}
