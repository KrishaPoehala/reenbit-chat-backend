using System.Security.Claims;

namespace reenbitChat.Domain.Abstraction;

public interface ITokenProvider
{
    public string GenerateToken(IEnumerable<Claim> claims);
}
