using System.Security.Claims;

namespace reenbitChat.BLL.Services.Abstraction;

public interface ITokenProvider
{
    public string GenerateToken(IEnumerable<Claim> claims);
}
