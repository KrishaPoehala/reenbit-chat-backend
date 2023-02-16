using reenbitChat.Common.Dtos.AuthorizationDtos;
using reenbitChat.Common.Dtos.UserDtos;

namespace reenbitChat.Common.Dtos.MessageDtos;

public class NewMessageDto
{
    public string Text { get; set; }
    public ChatMemberDto Sender { get; set; }
    public int ChatId { get; set; }
    public MessageDto? ReplyMessage { get; set; }
    public DateTime SentAt { get; set; }
}
