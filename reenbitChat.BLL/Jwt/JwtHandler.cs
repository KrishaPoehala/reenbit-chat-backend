using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using reenbitChat.DAL.Entities;
using reenbitChat.Domain.Abstraction;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace reenbitChat.BLL.Jwt;

public class JwtHandler : ITokenProvider
{
    private readonly IConfiguration _configuration;
    private readonly IConfigurationSection _jwtSettings;

    public JwtHandler(IConfiguration configuration)
    {
        this._configuration = configuration;
        this._jwtSettings = _configuration.GetSection("JwtSettings");
    }

    public string GenerateToken(IEnumerable<Claim> claims)
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
}
