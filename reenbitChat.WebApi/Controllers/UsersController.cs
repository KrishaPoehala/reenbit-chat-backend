using Microsoft.AspNetCore.Mvc;
using reenbitChat.Common.Dtos.MessageDtos;
using reenbitChat.Domain.Abstraction;

namespace reenbitChat.WebApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UsersController: ControllerBase
{
    private readonly IUsersService _userService;

    public UsersController(IUsersService userService)
    {
        _userService = userService;
    }

    [HttpGet]
    [Route("user/{userId}")]
    public async Task<IActionResult> GetUserById(int userId)
    {
        return Ok(await _userService.GetUserById(userId));
    }

    [HttpPut]
    [Route("saveReadMessages")]
    public async Task<IActionResult> SaveReadMessages(MessagesReadDto dto)
    {
        await _userService.SaveReadMessages(dto);
        return Ok();
    }
}
