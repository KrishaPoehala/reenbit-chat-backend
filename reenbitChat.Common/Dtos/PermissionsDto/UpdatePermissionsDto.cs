using reenbitChat.Common.Dtos.AuthorizationDtos;

namespace reenbitChat.Common.Dtos.PermissionsDto;

public class UpdatePermissionsDto
{
    public int ChatId { get; set; }
    public int MemberToUpdateId { get; set; }
    public IEnumerable<PermissionDto> NewPermissions { get; set; }
}
