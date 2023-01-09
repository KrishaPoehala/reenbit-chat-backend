using AutoMapper;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using reenbitChat.BLL.Hubs;
using reenbitChat.Common.Dtos.ChatDtos;
using reenbitChat.Common.Dtos.MessageDtos;
using reenbitChat.Common.Dtos.UserDtos;
using reenbitChat.DAL.Context;
using reenbitChat.DAL.Entities;
using reenbitChat.Domain.Abstraction;

namespace reenbitChat.BLL.Services.Implementation;

public class ChatService : BaseService, IChatService
{
    public ChatService(ChatContext context, IMapper mapper,
        IHubContext<ChatHub> hub) :
        base(context, mapper, hub)
    {
    }

    public async IAsyncEnumerable<ChatDto> GetUserChats(int userId)
    {
        var chats = _context.Chats
            .Include(x => x.Members)
            .Where(x => x.Members.Any(x => x.Id == userId))
            .AsAsyncEnumerable();

        await foreach (var item in chats)
        {
            yield return _mapper.Map<ChatDto>(item);
        }
    }

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
            .Skip(messagesToSkip)
            .Take(messagesInPage)
            .Select(x => _mapper.Map<MessageDto>(x));
    }

    public async Task<UserDto> GetRandomUser()
    {
        var max = await _context.Users.CountAsync();
        var rnd = Random.Shared.Next(1, max + 1);
        var user = await _context.Users
            .FirstAsync(x => x.Id == 8);

        var userDto = _mapper.Map<UserDto>(user);
        return userDto;
    }

    public async Task<ChatDto> CreateChat(NewChatDto newChatDto)
    {
        var members = newChatDto.Members;
        newChatDto.Members = null!;
        var chat = _mapper.Map<Chat>(newChatDto);
        _context.Chats.Add(chat);
        foreach (var memberId in members.Select(x => x.Id))
        {
            var user = await _context.Users.FirstAsync(x => x.Id == memberId);
            user.Chats.Add(chat);
        }

        await _context.SaveChangesAsync();
        var result = _mapper.Map<ChatDto>(chat);
        result.Members = members;
        
        await _hub.Clients.All.SendAsync("ChatCreated", result);
        return result;
    }
}
