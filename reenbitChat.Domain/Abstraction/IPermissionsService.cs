using reenbitChat.Common.Dtos.MembersDtos;
using reenbitChat.Common.Dtos.PermissionsDto;

namespace reenbitChat.Domain.Abstraction;

public interface IPermissionsService
{
    Task PromoteToAdmin(PromoteToAdminDto dto);
    Task UpdatePermissions(UpdatePermissionsDto dto);
}
