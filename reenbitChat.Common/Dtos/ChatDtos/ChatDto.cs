using reenbitChat.Common.Dtos.MessageDtos;
using reenbitChat.Common.Dtos.UserDtos;

namespace reenbitChat.Common.Dtos.ChatDtos;

public class ChatDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public ICollection<MessageDto> Messages { get; set; }
    public ICollection<UserDto> Members { get; set; }
    public bool? IsGroup { get; set; }
    public string ImageUrl { get; set; }
}
