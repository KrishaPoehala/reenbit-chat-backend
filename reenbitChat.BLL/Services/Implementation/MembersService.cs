using AutoMapper;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using reenbitChat.BLL.Hubs;
using reenbitChat.DAL.Context;
using reenbitChat.DAL.Entities;
using reenbitChat.Domain.Abstraction;
using reenbitChat.DAL.Enums;
using reenbitChat.Common.Dtos.AuthorizationDtos;
using reenbitChat.Common.Dtos.ChatDtos;
using reenbitChat.DAL.Factories;
using reenbitChat.Common.Dtos.MembersDtos;

namespace reenbitChat.BLL.Services.Implementation;

public class MembersService :BaseService, IMembersService
{
    private readonly IMemberFactory _memberFactory;
    public MembersService(ChatContext context, IMapper mapper, 
        IHubContext<ChatHub> hub, IMemberFactory memberFactory)
        : base(context, mapper, hub)
    {
        _memberFactory = memberFactory;
    }
    private async Task<User> FindUser(int userId) => await _context.Set<User>().FirstAsync(x => x.Id == userId);
    public async Task AddMembers(AddMembersDto dto)
    {
        var chat = await _context.Set<Chat>()
            .Include(x => x.Members)
            .FirstAsync(x => x.Id == dto.ChatId);
        foreach (var newMemberId in dto.NewMemberIds)
        {
            var user = await FindUser(newMemberId);
            var member = _memberFactory.CreateGroupMember(user, chat.Id);
            chat.Members.Add(member);
            var userJoinedDto = new UserJoinedDto()
            {
                GroupId = chat.Id,
                JoinedMember = _mapper.Map<ChatMemberDto>(member),
            };

            await _hub.Clients.Group(chat.Id.ToString()).SendAsync("UserJoined", userJoinedDto);
        }

        var userIds = dto.NewMemberIds.Select(x => x.ToString());
        await _hub.Clients.Users(userIds).SendAsync("ChatCreated", _mapper.Map<ChatDto>(chat));
        await _context.SaveChangesAsync();
    }

    public async Task JoinPublicGroups(AddGroupsDto dto)
    {
        var user = await _context.Set<User>().FirstAsync(x => x.Id == dto.UserId);
        foreach (var groupId in dto.GroupsIds)
        {
            var groupToAdd = await _context.Set<Chat>().Include(x => x.Members).FirstAsync(x => x.Id == groupId);
            var member = _memberFactory.CreateGroupMember(user, groupToAdd.Id);
            groupToAdd.Members.Add(member);
            await _context.SaveChangesAsync();
            var joinedUserDto = new UserJoinedDto()
            {
                JoinedMember = _mapper.Map<ChatMemberDto>(member),
                GroupId = groupId,
            };

            await _hub.Clients.Group(groupId.ToString())
                .SendAsync("UserJoined", joinedUserDto);
        }

    }

    public async Task RemoveUser(int memberId)
    {
        var memberToRemove = await _context
            .Set<ChatMember>()
            .FirstAsync(x => x.Id == memberId);

        var chat = await _context
            .Set<Chat>()
            .FirstAsync(x => x.Id == memberToRemove.ChatId);

        chat.Members.Remove(memberToRemove);
        await _context.SaveChangesAsync();
        await _hub.Clients.Group(memberToRemove.ChatId.ToString())
            .SendAsync("UserRemoved", memberToRemove.Id);
    }
}
