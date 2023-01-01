using reenbitChat.Common.Dtos.UserDtos;

namespace reenbitChat.Common.Dtos.MessageDtos;

public class NewMessageDto
{
    public string Text { get; set; }
    public UserDto? Sender { get; set; }
    public int ChatId { get; set; }
    public DateTime SentAt { get; set; }
}
