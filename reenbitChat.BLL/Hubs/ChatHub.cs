using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.SignalR;
using reenbitChat.Common.Dtos.ChatDtos;
using reenbitChat.DAL.Constants;
using reenbitChat.Domain.Abstraction;

namespace reenbitChat.BLL.Hubs;

[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
public class ChatHub : Hub
{
    private readonly IPresenceService _presenceService;
    public ChatHub(IPresenceService presenceService)
    {
        _presenceService = presenceService;
    }

    public async Task JoinGroup(string group)
    {
        await Groups.AddToGroupAsync(Context.ConnectionId, group);
    }

    public override async Task OnDisconnectedAsync(Exception? exception)
    {
        var userId = int.Parse(Context.UserIdentifier!);
        _presenceService.OnUserDisconnected(Context.UserIdentifier!);
        var groupNames = await _presenceService.GetChatsNameToDisconnect(userId);
        await Clients.Groups(groupNames)
            .SendAsync("UserDisconnected", userId);
        await base.OnDisconnectedAsync(exception);
    }

    public override async Task OnConnectedAsync()
    {
        _presenceService.OnUserConnected(Context.UserIdentifier!);
        await base.OnConnectedAsync();
    }

    public bool IsOnline(string userId)
    {
        return _presenceService.IsUserOnline(userId);
    }

    public IEnumerable<int> GetOnlineUsers(ChatDto chat)
    {
        return chat.Members.Where(x => _presenceService.IsUserOnline(x.User.Id.ToString())).Select(x => x.User.Id);
    }

    public async Task NotifyUserConnected(IEnumerable<string> groupNames)
    {
        var userId = int.Parse(Context.UserIdentifier!);
        foreach (var group in groupNames)
        {
            var groupId = int.Parse(group);
            await Clients.Group(group).SendAsync("UserConnected",
                new { userId,groupId });
        }
    }

    public async Task NotifyNewUserConnected(string groupName, int userId)
    {
        if (!_presenceService.IsUserOnline(userId.ToString()))
        {
            return;
        }

        var groupId = int.Parse(groupName);
        await Clients.Group(groupName).SendAsync("UserConnected", new { userId, groupId });
    }
}
