using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using reenbitChat.BLL.Queries;
using reenbitChat.Common.Dtos.ChatDtos;
using reenbitChat.Common.Dtos.MessageDtos;
using reenbitChat.Common.Dtos.UserDtos;
using reenbitChat.DAL.Context;
using reenbitChat.Domain.Abstraction;

namespace reenbitChat.WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ChatsController : ControllerBase
{
    private readonly IChatService _chatService;
    private readonly ISender _mediator;
    private readonly IMapper _mapper;
    public ChatsController(IChatService chatService, ISender mediator, IMapper mapper)
    {
        _chatService = chatService;
        _mediator = mediator;
        _mapper = mapper;
    }

    [HttpGet("claims")]
    public IActionResult GetClaims()
    {
        return Ok(User.Claims.Select(x => new { x.Type, x.Value }));
    }

    [HttpGet]
    [Route("chats/{userId}")]
    public async Task<IActionResult> GetChats(int userId)
    {
        var request = new GetUsersChatQuery(userId);
        return Ok(await _mediator.Send(request));
    }

    [HttpGet]
    [Route("messages/{chatId}/{userId}/{pageNumber}/{messagesToLoad}")]
    public async Task<IActionResult> GetMessages(int chatId, int userId,
int pageNumber = 0, int messagesToLoad = 20)
    {
        var request = new GetChatMessagesQuery(chatId, userId, pageNumber, messagesToLoad);
        return Ok(await _mediator.Send(request));
    }

    [HttpGet]
    [Route("messages/{chatId}")]
    public async Task<ActionResult<IEnumerable<MessageDto>>> GetMessages(int chatId)
    {
        var request = new GetChatMessagesQuery(chatId, -1, 0, 20);
        return Ok(await _mediator.Send(request));
    }

    [HttpGet]
    [Route("randomUser")]
    public async Task<ActionResult<UserDto>> GetRandomUser()
    {
        var user = await _chatService.GetRandomUser();
        return Ok(user);
    }

    [HttpPost]
    [Route("create")]
    public async Task<IActionResult> CreateChat(NewChatDto dto)
    {
        return Ok(await _chatService.CreateChat(dto));
    }
}
