using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using reenbitChat.Domain.Abstraction;
using reenbitChat.Common.Dtos.MessageDtos;
using reenbitChat.Common.Dtos.ChatDtos;

namespace reenbitChat.WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
//[Authorize]
public class ChatsController : ControllerBase
{
    private readonly IChatsService _chatService;
    public ChatsController(IChatsService chatService)
    {
        _chatService = chatService;
    }

    [HttpGet]
    [Route("chats/{userId}")]
    public async Task<IActionResult> GetChats(int userId)
    {
        return Ok(await _chatService.GetUserChats(userId));
    }

    [HttpGet]
    [Route("messages/{chatId}/{userId}/{pageNumber}/{messagesToLoad}")]
    public async Task<IActionResult> GetMessages(int chatId, int userId,
int pageNumber = 0, int messagesToLoad = 20)
    {
        return Ok(await _chatService.GetChatMessages(chatId,userId,pageNumber,messagesToLoad));
    }

    [HttpGet]
    [Route("messages/{chatId}")]
    public async Task<ActionResult<IEnumerable<MessageDto>>> GetMessages(int chatId)
    {
        return Ok(await _chatService.GetChatMessages(chatId, -1,0,20));
    }

    [HttpPost]
    [Route("createPublic")]
    public async Task<IActionResult> CreateChat(NewChatDto dto)
    {
        return Ok(await _chatService.CreateGroup(dto));
    }

    [HttpPost]
    [Route("createPrivate")]
    public async Task<IActionResult> CreatePrivateChat(NewPrivateChatDto dto)
    {
        return Ok(await _chatService.CreatePrivateChat(dto));
    }

    [HttpGet]
    [Route("publicGroups/{userId}")]
    public async Task<IActionResult> GetPublicGroups(int userId)
    {
        return Ok(await _chatService.GetPublicGroups(userId));
    }


}
