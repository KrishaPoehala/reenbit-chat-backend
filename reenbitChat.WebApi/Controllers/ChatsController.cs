using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using reenbitChat.BLL.Queries;
using reenbitChat.BLL.Services.Abstraction;
using reenbitChat.Common.Dtos.ChatDtos;
using reenbitChat.Common.Dtos.MessageDtos;
using reenbitChat.Common.Dtos.UserDtos;

namespace reenbitChat.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
    public class ChatsController : ControllerBase
    {
        private readonly IChatService _chatService;
        private readonly IPrivateChatService _privateChatService;
        private readonly ISender _mediator;
        public ChatsController(IChatService chatService, IPrivateChatService privateChatService, ISender mediator)
        {
            _chatService = chatService;
            _privateChatService = privateChatService;
            _mediator = mediator;
        }

        [HttpGet]
        [Route("chats/{userId}")]
        public async Task<ActionResult<IEnumerable<ChatDto>>> GetChats(int userId)
        {
            var request = new GetUsersChatQuery(userId);
            return Ok(await _mediator.Send(request));
        }

        [HttpGet]
        [Route("messages/{chatId}/{userId}/{pageNumber}/{messagesToLoad}")]
        public async Task<ActionResult<IEnumerable<MessageDto>>> GetMessages(int chatId, int userId,
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

        [HttpGet]
        [Route("privateChat/{firstUserId}/{secondUserId}")]
        public async Task<IActionResult> GetPrivateChat(int firstUserId, int secondUserId)
        {
            try
            {
                var request = new GetPrivateChatQuery(firstUserId, secondUserId);
                return Ok(await _mediator.Send(request));
            }
            catch (NullReferenceException)
            {
                return NotFound();
            }
        } 

        [HttpPost]
        [Route("privateChat/create")]
        public async Task<ActionResult<ChatDto>> CreatePrivateChat(NewChatDto dto)
        {
            var chat = await _privateChatService.CreatePrivatChat(dto.FirstUserId, dto.SecondUserId);
            return Ok(chat);
        }
    }
}
