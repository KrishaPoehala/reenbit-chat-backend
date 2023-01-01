using reenbitChat.Common.Dtos.UserDtos;

namespace reenbitChat.Common.Dtos.MessageDtos;

public class PrivateMessageDto
{
    public int Id { get; set; }
    public UserDto Reveiver { get; set; }
    public UserDto Sender { get; set; }
    public string Text { get; set; }
}
