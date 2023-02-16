using AutoMapper;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using reenbitChat.BLL.Hubs;
using reenbitChat.Common.Dtos.AuthorizationDtos;
using reenbitChat.Common.Dtos.MembersDtos;
using reenbitChat.Common.Dtos.PermissionsDto;
using reenbitChat.DAL.Context;
using reenbitChat.DAL.Entities;
using reenbitChat.DAL.Enums;
using reenbitChat.Domain.Abstraction;

namespace reenbitChat.BLL.Services.Implementation;

public class PermissionsService :BaseService, IPermissionsService
{
    public PermissionsService(ChatContext context, IMapper mapper, IHubContext<ChatHub> hub)
        : base(context, mapper, hub)
    {
    }

    public async Task PromoteToAdmin(PromoteToAdminDto dto)
    {
        var memberToPromote = await _context
            .Set<ChatMember>()
            .Include(x => x.Permissions)
            .FirstAsync(x => x.Id == dto.MemberToPromoteId);

        var adminRole = await _context
            .Set<Role>()
            .Include(x => x.DefaultPermissions)
            .FirstOrDefaultAsync(x => x.Name == Roles.Admin.ToString());
        memberToPromote.RoleId = adminRole!.Id;
        memberToPromote.Permissions = adminRole.DefaultPermissions;
        await _context.SaveChangesAsync();
        var result = _mapper.Map<ChatMemberDto>(memberToPromote);
        await _hub.Clients.Group(dto.ChatId.ToString()).SendAsync("MemberPromoted", result);
    }

    public async Task UpdatePermissions(UpdatePermissionsDto dto)
    {
        var memberToUpdate = await _context
            .Set<ChatMember>()
            .Include(x => x.Permissions)
            .FirstAsync(x => x.Id == dto.MemberToUpdateId);


        var newPermissions =  _context
            .Set<Permission>()
            .AsEnumerable()
            .Where(x => dto.NewPermissions.Any(y => y.Name == x.Name))
            .ToList();


        memberToUpdate.Permissions = newPermissions;
        var result = _mapper.Map<ChatMemberDto>(memberToUpdate);
        await _hub.Clients.Group(dto.ChatId.ToString())
            .SendAsync("PermissionsChanged", result);
        await _context.SaveChangesAsync();
    }
}
