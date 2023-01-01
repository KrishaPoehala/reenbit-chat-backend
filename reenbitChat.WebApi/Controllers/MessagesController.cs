using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using reenbitChat.Common.Dtos.MessageDtos;
using reenbitChat.Domain.Abstraction;

namespace reenbitChat.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
   // [Authorize]
    public class MessagesController : ControllerBase
    {
        private readonly IMessageService _messageService;

        public MessagesController(IMessageService messageService)
        {
            _messageService = messageService;
        }

        [HttpPost]
        [Route("send")]
        public async Task<ActionResult> SendMessage(NewMessageDto dto)
        {
            await _messageService.SendMessage(dto);
            return Ok();
        }

        [HttpPut]
        [Route("edit")]
        public async Task<ActionResult> EditMessage(EditMessageDto dto)
        {
            await _messageService.EditMessage(dto);
            return Ok();
        }

        [HttpDelete]
        [Route("delete/{id}/{isDeleteOnlyForSender}")]
        public async Task<ActionResult> DeleteMessage(int id, bool isDeletedOnlyForSender)
        {
            await _messageService.DeleteMessage(id, isDeletedOnlyForSender);
            return Ok();
        }


        [HttpPost]
        [Route("sendPrivate")] 
        public async Task SendPrivateMessages(NewPrivateMessageDto dto)
        {
            await _messageService.SendPrivateMessage(dto);
            Ok();
        }
    }
}
