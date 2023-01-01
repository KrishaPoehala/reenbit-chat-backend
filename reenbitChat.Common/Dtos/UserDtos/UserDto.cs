using reenbitChat.Common.Dtos.ChatDtos;
using reenbitChat.Common.Dtos.MessageDtos;

namespace reenbitChat.Common.Dtos.UserDtos;

public class UserDto
{
    public int Id { get; set; }
    public string UserName { get; set; }
    public string Email { get; set; }
    public string ProfilePhotoUrl { get; set; }
    public IEnumerable<ContactDto?>? Contacts { get; set; }

   // public ICollection<ChatDto> Chats { get; set; }
}
