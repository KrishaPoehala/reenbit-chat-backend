
namespace reenbitChat.Common.Dtos.UserDtos;

public class UserDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string? Email { get; set; }
    public string ProfilePhotoUrl { get; set; }

   // public ICollection<ChatDto> Chats { get; set; }
}
