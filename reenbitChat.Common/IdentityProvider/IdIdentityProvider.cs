using Microsoft.AspNetCore.SignalR;
using reenbitChat.DAL.Constants;

namespace reenbitChat.DAL.IdentityProvider;

public class CustomIdentityProvider : IUserIdProvider
{
    public string GetUserId(HubConnectionContext connection)
    {
        var userIdClaim = connection.User.Claims.First(x => x.Type == CustomClaims.Id);
        return userIdClaim.Value;
    }
}
