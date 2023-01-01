using reenbitChat.Common.Dtos.UserDtos;

namespace reenbitChat.Common.Dtos.MessageDtos;

public class NewPrivateMessageDto
{
    public string Text { get; set; }
    public UserDto Sender { get; set; }
    public int SenderId { get; set; }
    public int ReceiverId { get; set; }
    public UserDto Receiver { get; set; }
}
