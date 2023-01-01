using reenbitChat.Common.Dtos.MessageDtos;

namespace reenbitChat.Common.Dtos.UserDtos;

public class ContactDto
{
    public UserDto Receiver { get; set; }
    public IEnumerable<NewPrivateMessageDto> PrivateMessages { get; set; } = new List<NewPrivateMessageDto>();
}
