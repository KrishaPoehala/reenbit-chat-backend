using reenbitChat.Common.Dtos.ChatDtos;
using reenbitChat.Common.Dtos.UserDtos;

namespace reenbitChat.Common.Dtos.AuthorizationDtos;

public class ChatMemberDto
{
    public int Id { get; set; }
    public UserDto User { get; set; }
    public int ChatId { get; set; }
    public int UnreadMessagesCount { get; set; }
    public RoleDto? Role { get; set; }
    public IEnumerable<PermissionDto>? Permissions { get; set; }
}
