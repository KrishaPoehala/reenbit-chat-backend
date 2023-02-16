using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using reenbitChat.Common.Dtos.AuthorizationDtos;
using reenbitChat.Common.Dtos.ChatDtos;
using reenbitChat.Common.Dtos.MembersDtos;
using reenbitChat.Domain.Abstraction;

namespace reenbitChat.WebApi.Controllers;

[ApiController]
[Route("api/[controller]")]
[Authorize]
public class MembersController: ControllerBase
{
    private readonly IMembersService _membersService;

    public MembersController(IMembersService membersService)
    {
        _membersService = membersService;
    }

    [HttpPut]
    [Route("addMembers")]
    public async Task<IActionResult> AddMembers(AddMembersDto dto)
    {
        await _membersService.AddMembers(dto);
        return Ok();
    }

    [HttpPut]
    [Route("joinUser")]
    public async Task<IActionResult> JoinUser(AddGroupsDto dto)
    {
        await _membersService.JoinPublicGroups(dto);
        return Ok();
    }

   [HttpDelete]
   [Route("removeMember/{memberId}")]
   public async Task<IActionResult> RemoveUser(int memberId)
   {
        await _membersService.RemoveUser(memberId);
        return Ok();
   }
}
