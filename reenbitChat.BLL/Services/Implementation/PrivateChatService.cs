using AutoMapper;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using reenbitChat.BLL.Hubs;
using reenbitChat.BLL.Services.Abstraction;
using reenbitChat.Common.Dtos.ChatDtos;
using reenbitChat.Common.Dtos.UserDtos;
using reenbitChat.DAL.Context;
using reenbitChat.DAL.Entities;

namespace reenbitChat.BLL.Services.Implementation;

public class PrivateChatService : BaseService, IPrivateChatService
{
    public PrivateChatService(ChatContext context, IMapper mapper, IHubContext<ChatHub> hub) : base(context, mapper, hub)
    {
    }

    public async Task CreateEveryPrivateChat(int userId)
    {
        var firstUser = await _context.Users.FirstAsync(x => x.Id == userId);
        var usersExecptFirst = await _context.Users.Where(x => x.Id != firstUser.Id).ToListAsync();
        foreach (var secondUser in usersExecptFirst)
        {
            bool isPrivateChatExist = DoesPrivateChatExist(firstUser.Id, secondUser.Id);
            if (isPrivateChatExist == false)
            {
                await CreatePrivateChat(firstUser, secondUser);
            }
        }
    }

    public ChatDto GetPrivateChat(int firstUserId, int secondUserId)
    {
        var privateChats = _context.Chats
                                     .Include(x => x.Members)
                                     .Include(x => x.Messages)
                                     .ThenInclude(x => x.Sender)
                                     .Where(x => x.IsGroup == false);
        foreach (var item in privateChats)
        {
            var firstUser = item.Members.FirstOrDefault(x => x.Id == firstUserId);
            var secondUser = item.Members.FirstOrDefault(x => x.Id == secondUserId);
            if (firstUser is not null && secondUser is not null)
            {
                return _mapper.Map<ChatDto>(item);
            }
        }

        throw new NullReferenceException();
    }

    public async Task<ChatDto> CreatePrivatChat(int firstUserId, int secondUserId)
    {
        if(DoesPrivateChatExist(firstUserId, secondUserId))
        {
            throw new InvalidDataException("Invalid ids");
        }

        var firstUser = await _context.Users.FirstAsync(x => x.Id == firstUserId);
        var secondUser = await _context.Users.FirstAsync(x => x.Id == secondUserId);
        var privateChat = new Chat();
        privateChat.IsGroup = false;
        privateChat.Members.Add(firstUser);
        privateChat.Members.Add(secondUser);
        await _context.Chats.AddAsync(privateChat);
        await _context.SaveChangesAsync();
        var dto = _mapper.Map<ChatDto>(privateChat);
        await _hub.Clients.All.SendAsync("ChatCreated", dto);
        return dto;
    }



    public async Task CreatePrivateChat(User firstUser, User secondUser)
    {
        var chat = new Chat();
        chat.Name = firstUser.Name + " " + secondUser.Name;
        chat.ImageUrl = "";
        chat.Members.Add(firstUser);
        chat.Members.Add(secondUser);
        chat.IsGroup = false;
        await _context.Chats.AddAsync(chat);
        await _context.SaveChangesAsync();
    }

    public bool DoesPrivateChatExist(int firstUserId, int secondUserId)
    {
        foreach (var item in _context.Chats.Include(x => x.Members))
        {
            var firstUser = item.Members.FirstOrDefault(x => x.Id == firstUserId);
            var secondUser = item.Members.FirstOrDefault(x => x.Id == secondUserId);
            bool bothUsersAreMembers = firstUser is not null && secondUser is not null;
            if (bothUsersAreMembers && item.Members.Count == 2)
            {
                return true;
            }
        }

        return false;
    }
}
