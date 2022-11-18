﻿using AutoMapper;
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

 

    public async Task<UserDto> GetRandomUser()
    {
        var max = await _context.Users.CountAsync();
        var rnd = Random.Shared.Next(1, max + 1);
        var user = await _context.Users.FirstAsync(x => x.UserName == "Jaycee");
        //var user = await _context.Users.FirstAsync(x => x.Id == 5);
        //this method gets rnd user each time when the page is reloaded.
        //so if you'd like to test the method specify the id number
        return _mapper.Map<UserDto>(user);
    }
}
