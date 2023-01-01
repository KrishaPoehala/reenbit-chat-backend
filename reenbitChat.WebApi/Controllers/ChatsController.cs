using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using reenbitChat.BLL.Queries;
using reenbitChat.Common.Dtos.ChatDtos;
using reenbitChat.Common.Dtos.MessageDtos;
using reenbitChat.Common.Dtos.UserDtos;
using reenbitChat.DAL.Context;
using reenbitChat.Domain.Abstraction;

namespace reenbitChat.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ChatsController : ControllerBase
    {
        private readonly IChatService _chatService;
        private readonly ISender _mediator;
        private readonly IMapper _mapper;
        private readonly ChatContext _context;
        public ChatsController(IChatService chatService, ISender mediator,
            ChatContext context, IMapper mapper)
        {
            _chatService = chatService;
            _mediator = mediator;
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("contacts/{id}")]
        public async Task<IActionResult> GetUserContacts(int id)
        {
            var user = await _context.Users
                .Include(x => x.Contacts)
                    .ThenInclude(x => x.ContactUser)
                .FirstOrDefaultAsync(x => x.Id == id);

            var ids = user.Contacts.Select(x => x.ContactUser);
            return Ok(ids.Select(x => _mapper.Map<ContactDto>(x)));
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
        [Route("privateMessages/{senderId}/{receiverId}")]
        public async Task<IActionResult> GetPrivateChatMessages(int senderId, int receiverId)
        {
            var messages = _context.PrivateMessages
                .Include(x => x.Sender)
                .Include(x => x.Receiver)
                .Where(x => x.SenderId == senderId && x.ReceiverId == receiverId
                || x.SenderId == receiverId && x.ReceiverId == senderId)
                .OrderBy(x => x.SentAt)
                .Skip(30)
                .Take(10);


            return Ok(messages.Select(x => _mapper.Map<PrivateMessageDto>(x)));
        }

        [HttpPost]
        [Route("add/{userId}/{contactId}")]
        public async Task AddContact(int userId, int contactId)
        {
            var user = await _context.Users
                .Include(x => x.Contacts)
                .FirstAsync(x => x.Id == userId);
            var contact = await _context.Users
                .Include(x => x.Contacts)
                .FirstAsync(x => x.Id == contactId);

            if(user.Contacts.Any(x => x.ContactUserId == contactId) is false)
            {
                user.Contacts.Add(new() {User = user, ContactUser = contact });
                contact.Contacts.Add(new() { User = contact, ContactUser = user });

                await _context.SaveChangesAsync();
            }
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
    }
}
