using AutoMapper;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using reenbitChat.BLL.Hubs;
using reenbitChat.DAL.Context;
using reenbitChat.DAL.Entities;
using reenbitChat.Domain.Abstraction;
using reenbitChat.Common.Dtos.MessageDtos;
using reenbitChat.Common.Dtos.ChatDtos;
using reenbitChat.DAL.Factories;

namespace reenbitChat.BLL.Services.Implementation;

public class ChatsService : BaseService, IChatsService
{
    private readonly IMemberFactory _memberFactory;
    public ChatsService(ChatContext context, IMapper mapper,
        IHubContext<ChatHub> hub, IMemberFactory memberFactory) :
        base(context, mapper, hub)
    {
        _memberFactory = memberFactory;
    }

    public async Task<IEnumerable<ChatDto>> GetUserChats(int userId)
    {
        var chats = await _context.Chats
            .Include(x => x.Members).ThenInclude(x => x.User)
            .Include(x => x.Members).ThenInclude(x => x.Role)
            .Include(x => x.Members).ThenInclude(x => x.Permissions)
            .Where(x => x.Members.Any(x => x.User.Id == userId))
            .ToListAsync();

        return chats.Select(x => _mapper.Map<ChatDto>(x));
    }

    public async Task<IEnumerable<MessageDto>> GetChatMessages(int chatId,int userId,int pageNumber,
        int messagesInPage)
    {
        var chat = await _context.Chats
       .Include(x => x.Messages)
           .ThenInclude(x => x.Sender)
               .ThenInclude(x => x.Permissions)
        .Include(x => x.Messages)
           .ThenInclude(x => x.Sender.Role)
       .Include(x => x.Messages)
           .ThenInclude(x => x.Sender.User)
        .Include(x => x.Messages)
            .ThenInclude(x => x.ReadBy).ThenInclude(x => x.User)
       .FirstAsync(x => x.Id == chatId);

        var messages = chat.Messages;
        var messagesToSkip = messagesInPage * pageNumber;
        if (messages.Count <= messagesToSkip)
        {
            return Enumerable.Empty<MessageDto>();
        }

        var g  = messages
           .Where(x => x.SenderId != userId || x.IsDeletedOnlyForSender == null
           || x.IsDeletedOnlyForSender == false)
           .OrderByDescending(x => x.SentAt)
           .Skip(messagesToSkip)
           .Take(messagesInPage)
           .Reverse()
           .ToList();

        var h = g.Select(x => _mapper.Map<MessageDto>(x)).ToList();

        return h;
    }


    private async Task<User> FindUser(int userId) => 
        await _context.Set<User>().FirstAsync(x => x.Id == userId);
    public async Task<ChatDto> CreateGroup(NewChatDto newChatDto)
    {
        var chat = _mapper.Map<Chat>(newChatDto);
        chat.IsPublic = chat.IsGroup;
        _context.Chats.Add(chat);
        var ownerAsUser = await FindUser(newChatDto.OwnerId);
        var owner = _memberFactory.CreateGroupOwner(ownerAsUser, chat.Id);
        chat.Members.Add(owner);
        foreach (var memberId in newChatDto.MemberIds)
        {
            var user = await FindUser(memberId);
            var member = _memberFactory.CreateGroupMember(user, chat.Id);
            _context.Set<ChatMember>().Add(member);
            chat.Members.Add(member);
        }

        await _context.SaveChangesAsync();
        var result = _mapper.Map<ChatDto>(chat);
        var userIds = chat.Members.Select(x => x.UserId.ToString());
        await _hub.Clients
            .Users(userIds)
            .SendAsync("ChatCreated", result);
        return result;
    }

    public async Task<IEnumerable<ChatDto>> GetPublicGroups(int userId)
    {
        var publicGroups = await _context.Set<Chat>()
            .Include(x => x.Members).ThenInclude(x => x.User)
            .Include(x => x.Members).ThenInclude(x => x.Role)
            .Include(x => x.Members).ThenInclude(x => x.Permissions)
            .Where(x => x.IsPublic == true)
            .ToListAsync();

        var usersGroups = await _context.Set<Chat>()
            .Include(x => x.Members)
            .Where(x => x.IsPublic == true)
            .Where(x => x.Members.Any(x => x.UserId == userId))
            .Select(x => x.Id)
            .ToListAsync();

        return publicGroups
            .ExceptBy(usersGroups,x => x.Id)
            .Select(x => _mapper.Map<ChatDto>(x));
    }

    public async Task<ChatDto> CreatePrivateChat(NewPrivateChatDto dto)
    {
        var privateChat = new Chat
        {
            IsPublic = false,
            IsGroup = false,
            Name = dto.Name,
        };
        _context.Set<Chat>().Add(privateChat);
        await _context.SaveChangesAsync();

        var leftUser = await FindUser(dto.LeftUserId);
        var rigthUser = await FindUser(dto.RightUserId);
        var leftMember = _memberFactory.CreatePrivateChatMember(leftUser, privateChat.Id);
        var rigthMember = _memberFactory.CreatePrivateChatMember(rigthUser, privateChat.Id);
        privateChat.Members.Add(leftMember);
        privateChat.Members.Add(rigthMember);
        await _context.SaveChangesAsync();
        var userIds = new[] { leftUser.Id.ToString(),rigthUser.Id.ToString() };
        var result = _mapper.Map<ChatDto>(privateChat);
        await _hub.Clients.Users(userIds).SendAsync("PrivateChatCreated", result);
        return result;
    }
}
