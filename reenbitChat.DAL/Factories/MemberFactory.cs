using Microsoft.EntityFrameworkCore;
using reenbitChat.DAL.Context;
using reenbitChat.DAL.Entities;
using reenbitChat.DAL.Enums;

namespace reenbitChat.DAL.Factories;

public class MemberFactory : IMemberFactory
{
    private readonly ChatContext _context;

    public MemberFactory(ChatContext context)
    {
        _context = context;
    }

    private Role FindRole(Roles role)
    {
        return _context.Set<Role>()
            .Include(x => x.DefaultPermissions)
            .First(x => x.Name == role.ToString());
    }

    public ChatMember CreateGroupAdmin(User user, int chatId)
    {
        var adminRole = FindRole(Roles.Admin);
        return new()
        {
            UserId = user.Id,
            User = user,
            ChatId = chatId,
            Role = adminRole,
            Permissions = adminRole.DefaultPermissions,
        };
    }

    public ChatMember CreateGroupMember(User user, int chatId)
    {
        var memberRole = FindRole(Roles.Member);
        return new()
        {
            UserId = user.Id,
            User = user,
            ChatId = chatId,
            Role = memberRole,
            Permissions = memberRole.DefaultPermissions,
        };
    }

    public ChatMember CreateGroupOwner(User user, int chatId)
    {
        var ownerRole = FindRole(Roles.Owner);
        return new()
        {
            UserId = user.Id,
            User = user,
            ChatId = chatId,
            Role = ownerRole,
            Permissions = ownerRole.DefaultPermissions,
        };
    }

    public ChatMember CreatePrivateChatMember(User user, int chatId)
    {
        return new()
        {
            UserId = user.Id,
            User = user,
            ChatId = chatId,
            RoleId = null,
        };
    }
}
