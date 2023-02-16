using Microsoft.AspNetCore.Mvc;
using reenbitChat.Common.Dtos.MembersDtos;
using reenbitChat.Common.Dtos.PermissionsDto;
using reenbitChat.Domain.Abstraction;

namespace reenbitChat.WebApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PermissionsController:ControllerBase
{
    private readonly IPermissionsService _permissionsService;

    public PermissionsController(IPermissionsService permissionsService)
    {
        _permissionsService = permissionsService;
    }

    [HttpPut]
    [Route("promoteToAdmin")]
    public async Task<IActionResult> PromoteToAdmin(PromoteToAdminDto dto)
    {
        await _permissionsService.PromoteToAdmin(dto);
        return Ok();
    }

    [HttpPut]
    [Route("update")]
    public async Task<IActionResult> UpdatePermissions(UpdatePermissionsDto dto)
    {
        await _permissionsService.UpdatePermissions(dto);
        return Ok();
    }
}
