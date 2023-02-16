using System.Security.Claims;

namespace reenbitChat.Domain.Abstraction;

public interface ITokenProvider
{
    public string GenerateAccessToken(IEnumerable<Claim> claims);
    public string GenerateRefreshToken();
    ClaimsPrincipal GetPrincipalFromToken(string token);
}
