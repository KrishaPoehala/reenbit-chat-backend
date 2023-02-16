using reenbitChat.Common.Dtos.AuthorizationDtos;

namespace reenbitChat.Common.Dtos.MessageDtos;

public record MessageDto
{
    public int Id { get; set; }
    public string Text { get; set; }
    public ChatMemberDto Sender { get; set; }
    public int ChatId { get; set; }
    public DateTime SentAt { get; set; }
    public bool IsSeen { get; set; }
    public MessageDto? ReplyMessage { get; set; }
    public ICollection<ChatMemberDto>? ReadBy { get; set; }
}
