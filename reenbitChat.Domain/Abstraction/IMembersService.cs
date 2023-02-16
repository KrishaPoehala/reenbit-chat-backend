using reenbitChat.Common.Dtos.AuthorizationDtos;
using reenbitChat.Common.Dtos.ChatDtos;
using reenbitChat.Common.Dtos.MembersDtos;

namespace reenbitChat.Domain.Abstraction;

public interface IMembersService
{
    Task AddMembers(AddMembersDto dto);
    Task JoinPublicGroups(AddGroupsDto dto);
    Task RemoveUser(int memberId);
}
