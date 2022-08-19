using Microsoft.AspNetCore.SignalR;
using reenbitChat.Common.Dtos.MessageDtos;
using reenbitChat.Common.Dtos.UserDtos;

namespace reenbitChat.BLL.Hubs;

public class ChatHub : Hub
{
    public async Task JoinGroup(string group)
    {
        await Groups.AddToGroupAsync(Context.ConnectionId, group);
    }
}
