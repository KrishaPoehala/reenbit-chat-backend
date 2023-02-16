using AutoMapper;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using reenbitChat.BLL.Hubs;
using reenbitChat.Common.Dtos.MessageDtos;
using reenbitChat.Common.Dtos.UserDtos;
using reenbitChat.DAL.Context;
using reenbitChat.DAL.Entities;
using reenbitChat.Domain.Abstraction;

namespace reenbitChat.BLL.Services.Implementation;

public class UsersService:BaseService, IUsersService
{
    public UsersService(ChatContext context, IMapper mapper, IHubContext<ChatHub> hub) 
        : base(context, mapper, hub)
    {
    }

    public async Task<UserDto> GetUserById(int userId)
    {
        var user = await _context
            .Set<User>()
            .FirstAsync(x => x.Id == userId);

        return _mapper.Map<UserDto>(user);
    }

    public async Task SaveReadMessages(MessagesReadDto dto)
    {
        var member = await _context.Set<ChatMember>().FirstAsync(x => x.Id == dto.MemberId);
        foreach (var messageId in dto.MessageIds)
        {
            var message = await _context
                .Set<Message>()
                .FirstAsync(x => x.Id == messageId);

            if (!message.IsSeen)
            {
                message.IsSeen = true;
            }
            message.ReadBy.Add(member);
        }

        await _hub.Clients.Group(member.ChatId.ToString()).SendAsync("MessagesRead",
            new { member.ChatId, dto.MemberId, dto.MessageIds });
        await _context.SaveChangesAsync();
    }
}
