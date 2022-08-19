using reenbitChat.Common.Dtos.ChatDtos;
using reenbitChat.Common.Dtos.UserDtos;

namespace reenbitChat.Common.Dtos.MessageDtos;

public record MessageDto
{
    public int Id { get; set; }
    public string Text { get; set; }
    public UserDto Sender { get; set; }
    public int ChatId { get; set; }
    public DateTime SentAt { get; set; }
}
