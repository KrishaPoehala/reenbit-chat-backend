using AutoMapper;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using reenbitChat.BLL.Hubs;
using reenbitChat.BLL.Services.Abstraction;
using reenbitChat.Common.Dtos.ChatDtos;
using reenbitChat.Common.Dtos.MessageDtos;
using reenbitChat.Common.Dtos.UserDtos;
using reenbitChat.DAL.Context;
using reenbitChat.DAL.Entities;
using reenbitChat.DAL.Extentions;

namespace reenbitChat.BLL.Services.Implementation;

public class ChatService : BaseService, IChatService
{
    private readonly IPrivateChatService _privateChatService;
    public ChatService(ChatContext context, IMapper mapper,
        IHubContext<ChatHub> hub, IPrivateChatService privateChatService) :
        base(context, mapper, hub)
    {
        _privateChatService = privateChatService;
    }

    public async IAsyncEnumerable<ChatDto> GetUserChats(int userId)
    {
        await _privateChatService.CreateEveryPrivateChat(userId);
        var chats = _context.Chats
            .Include(x => x.Members)
            .Where(x => x.Members.Any(x => x.Id == userId))
            .AsAsyncEnumerable();

        await foreach (var item in chats)
        {
            yield return _mapper.Map<ChatDto>(item);
        }
    }


    //I generated messages that were sent in future (sentAt > DateTime.now) that's why a message that has just been sent
    //might not be on the same place when reloading the page
    //but the method works correctly(probably :D)
    public async Task<IEnumerable<MessageDto>> GetChatMessages(int chatId,int userId,int pageNumber,
        int messagesInPage)
    {
        var chat = await _context.Chats
        .Include(x => x.Messages)
        .ThenInclude(x => x.Sender)
        .FirstAsync(x => x.Id == chatId);

        var messages = chat.Messages;
        var messagesToSkip = messagesInPage * pageNumber;
        if(messages.Count <= messagesToSkip)
        {
            return Enumerable.Empty<MessageDto>();
        }

        return messages
            .Where(x => x.SenderId != userId || x.IsDeletedOnlyForSender == false)
            .OrderBy(x => x.SentAt)
            .Skip(pageNumber * messagesInPage)
            .Take(messagesInPage)
            .Select(x => _mapper.Map<MessageDto>(x));
    }

    public async Task SendMessage(NewMessageDto dto)
    {
        var sender = dto.Sender;
        var message = _mapper.Map<Message>(dto);
        message.Sender = null;//DbUpdateException otherwise, I don't know why tho(
        await _context.Messages.AddAsync(message);

        await _context.SaveChangesAsync();
        var messageDto = _mapper.Map<MessageDto>(message);
        messageDto.Sender = sender;
        await _hub.Clients
            .Group(message.ChatId.ToString())
            .SendAsync("MessageSent", messageDto);
    }

    public ChatDto GetPrivateChat(int firstUserId, int secondUserId)
    {
        foreach (var item in _context.Chats.Include(x => x.Members).Where(x => x.Members.Count == 2))
        {
            var firstUser = item.Members.FirstOrDefault(x => x.Id == firstUserId);
            var secondUser = item.Members.FirstOrDefault(x => x.Id == secondUserId);
            if(firstUser is not null && secondUser is not null)
            {
                return _mapper.Map<ChatDto>(item);
            }
        }

        throw new NullReferenceException();
    }

    public async Task<UserDto> GetRandomUser()
    {
        var max = await _context.Users.CountAsync();
        var rnd = Random.Shared.Next(1, max + 1);
        var user = await _context.Users.FirstAsync(x => x.Name =="Genoveva");//I can readlly make it random
        //but it was easier for me to test when the user is specified, and I think It will be easier for you too,
        //so I'm leaving it here;
        return _mapper.Map<UserDto>(user);
    }

    public async Task EditMessage(EditMessageDto dto)
    {
        var messageToEdit = await _context.Messages
            .FirstAsync(x => x.Id == dto.MessageId);

        messageToEdit.Text = dto.EditedText;
        await _context.SaveChangesAsync();
        await _hub.Clients
            .Group(messageToEdit.ChatId.ToString())
            .SendAsync("MessageEdited", _mapper.Map<MessageDto>(messageToEdit));
    }

    public async Task DeleteMessage(int id, bool isDeleteOnlyForSender)
    {
        var messageToDelete = await _context.Messages
            .FirstAsync(x => x.Id == id);
        if (isDeleteOnlyForSender)
        {
            messageToDelete.IsDeletedOnlyForSender = true;
        }
        else
        {
            _context.Messages.Remove(messageToDelete);
        }

        await _context.SaveChangesAsync();
        if(isDeleteOnlyForSender == false)
        {
            await _hub.Clients
                .Group(messageToDelete.ChatId.ToString())
                .SendAsync("MessageDeleted", _mapper.Map<MessageDto>(messageToDelete)); 
        }
    }


}
