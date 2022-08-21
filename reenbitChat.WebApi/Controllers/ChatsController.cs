using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using reenbitChat.BLL.Services.Abstraction;
using reenbitChat.Common.Dtos.ChatDtos;
using reenbitChat.Common.Dtos.MessageDtos;
using reenbitChat.Common.Dtos.UserDtos;
using reenbitChat.DAL.Entities;
using System.Text;
using static reenbitChat.DAL.Extentions.ModelBuilderExtentions;

namespace reenbitChat.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChatsController : ControllerBase
    {
        private readonly IChatService _chatService;

        public ChatsController(IChatService chatService)
        {
            _chatService = chatService;
        }

        [HttpGet]
        [Route("chats/{userId}")]
        public ActionResult<IAsyncEnumerable<ChatDto>> GetChats(int userId)
        {
            return Ok(_chatService.GetUserChats(userId));
        }

        [HttpGet]
        [Route("messages/{chatId}/{userId}/{pageNumber}/{messagesToLoad}")]
        public async Task<ActionResult<IEnumerable<MessageDto>>> GetMessages(int chatId, int userId,
    int pageNumber = 0, int messagesToLoad = 20)
        {
            return Ok(await _chatService.GetChatMessages(chatId,userId,
                pageNumber, messagesToLoad));
        }

        [HttpGet]
        [Route("messages/{chatId}")]
        public async Task<ActionResult<IEnumerable<MessageDto>>> GetMessages(int chatId)
        {
            return Ok(await _chatService.GetChatMessages(chatId, -1,0,20));
        }
        [HttpGet]
        [Route("randomUser")]
        public async Task<ActionResult<UserDto>> GetRandomUser()
        {
            return Ok(await _chatService.GetRandomUser());
        }

        [HttpPost]
        [Route("send")]
        public async Task<ActionResult> SendMessage(NewMessageDto dto)
        {
            await _chatService.SendMessage(dto);
            return Ok();
        }

        [HttpPut]
        [Route("edit")]
        public async Task<ActionResult> EditMessage(EditMessageDto dto)
        {
            await _chatService.EditMessage(dto);
            return Ok();
        }

        [HttpDelete]
        [Route("delete/{id}/{isDeleteOnlyForSender}")]
        public async Task<ActionResult> DeleteMessage(int id, bool isDeleteOnlyForSender)
        {
            await _chatService.DeleteMessage(id, isDeleteOnlyForSender);
            return Ok();
        }

        [HttpGet]
        [Route("privateChat/{firstUserId}/{secondUserId}")]
        public ActionResult<ChatDto> GetPrivateChat(int firstUserId, int secondUserId)
        {
            return Ok(_chatService.GetPrivateChat(firstUserId, secondUserId));
        } 
    }
}
