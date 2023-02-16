using reenbitChat.Common.Dtos.AuthorizationDtos;

namespace reenbitChat.Common.Dtos.ChatDtos;

public class UserJoinedDto
{
    public ChatMemberDto JoinedMember { get; set; }
    public int GroupId { get; set; }
}
