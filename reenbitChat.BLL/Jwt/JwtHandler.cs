using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using reenbitChat.Domain.Abstraction;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace reenbitChat.BLL.Jwt;

public class JwtHandler : ITokenProvider
{
    private readonly IConfiguration _configuration;
    private readonly IConfigurationSection _jwtSettings;

    public JwtHandler(IConfiguration configuration)
    {
        _configuration = configuration;
        _jwtSettings = _configuration.GetSection("JwtSettings");
    }

    public string GenerateAccessToken(IEnumerable<Claim> claims)
    {
        var key = Encoding.UTF8.GetBytes(_jwtSettings.GetSection("securityKey").Value);
        var secret = new SymmetricSecurityKey(key);
        var credentials =  new SigningCredentials(secret, SecurityAlgorithms.HmacSha256Signature);

        var tokenOptions = new JwtSecurityToken(
           issuer: _jwtSettings["validIssuer"],
           audience: _jwtSettings["validAudience"],
           claims: claims,
           expires: DateTime.Now.AddMinutes(Convert.ToDouble(_jwtSettings["expiryInMinutes"])),
           signingCredentials: credentials);

        return new JwtSecurityTokenHandler().WriteToken(tokenOptions);
    }

    public string GenerateRefreshToken()
    {
        var bytes = new byte[32];
        using var rnd = RandomNumberGenerator.Create();
        rnd.GetBytes(bytes);
        return Convert.ToBase64String(bytes);
    }

    public ClaimsPrincipal GetPrincipalFromToken(string token)
    {
        var tokenHandler = new JwtSecurityTokenHandler();
        var validationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateLifetime = false,
            ValidateIssuerSigningKey = true,
            ValidIssuer = _jwtSettings["validIssuer"],
            ValidAudience = _jwtSettings["validAudience"],
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8
                    .GetBytes(_jwtSettings.GetSection("securityKey").Value))
        };
        var princital = tokenHandler.ValidateToken(token, validationParameters, out var securityToken);
        return securityToken as JwtSecurityToken is not null ? princital 
            : throw new SecurityTokenException("Invalid token");
    }
}
