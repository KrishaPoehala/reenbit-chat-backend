namespace reenbitChat.Domain.Abstraction;

public interface IPresenceService
{
    Task<IEnumerable<string>> GetChatsNameToDisconnect(int userId);
    void OnUserConnected(string userId);
    void OnUserDisconnected(string userId);
    bool IsUserOnline(string userId);
}
