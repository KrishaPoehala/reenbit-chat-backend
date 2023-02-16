using AutoMapper;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using reenbitChat.BLL.Hubs;
using reenbitChat.DAL.Context;
using reenbitChat.DAL.Entities;
using reenbitChat.Domain.Abstraction;

namespace reenbitChat.BLL.Services.Implementation;

public class PresenceTracker : BaseService, IPresenceService
{
    public PresenceTracker(ChatContext context, IMapper mapper, IHubContext<ChatHub> hub) 
        : base(context, mapper, hub)
    {
    }

    private static readonly Dictionary<string, int> _onlineUsers = new();
    private readonly object _lockObject = new();

    public async Task<IEnumerable<string>> GetChatsNameToDisconnect(int userId)
    {
        var chatsIds = await _context
           .Set<Chat>()
           .Include(x => x.Members)
           .Where(x => x.Members.Any(m => m.UserId == userId))
           .Select(x => x.Id.ToString())
           .ToListAsync();

        return chatsIds;
    }

    public void OnUserConnected(string userId)
    {
        lock (_lockObject)
        {
            if (_onlineUsers.ContainsKey(userId))
            {
                _onlineUsers[userId]++;
                return;
            }

            _onlineUsers.Add(userId, 1);
        }
    }

    public void OnUserDisconnected(string userId)
    {
        lock (_lockObject)
        {
            if (_onlineUsers.ContainsKey(userId))
            {
                _onlineUsers[userId]--;
                if(_onlineUsers[userId] <= 0)
                {
                    _onlineUsers.Remove(userId);
                }
            }
        }
    }

    public bool IsUserOnline(string userId)
    {
        return _onlineUsers.ContainsKey(userId);
    }
}
