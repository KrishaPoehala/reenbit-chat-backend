using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using reenbitChat.Common.Dtos.TokenDtos;
using reenbitChat.DAL.Constants;
using reenbitChat.DAL.Entities;
using reenbitChat.Domain.Abstraction;

namespace reenbitChat.WebApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TokensController: ControllerBase
{
    private readonly ITokenProvider _tokenProvider;
    private readonly UserManager<User> _manager;

    public TokensController(ITokenProvider tokenProvider, UserManager<User> manager)
    {
        _tokenProvider = tokenProvider;
        _manager = manager;
    }

    [HttpPost]
    [Route("refresh")]
    public async Task<IActionResult> Refresh(RefreshTokenDto dto)
    {
        var principal = _tokenProvider.GetPrincipalFromToken(dto.AccessToken);
        var id = principal.Claims.FirstOrDefault(x => x.Type == CustomClaims.Id).Value;
        var user = await _manager.FindByIdAsync(id);
        if (user is null)
        {
            return BadRequest(new RefeshedTokenResponseDto()
            {
                ErrorMessage = "User was not found"
            });
        }

        if (user.RefreshToken != dto.RefreshToken)
        {
            return BadRequest(new RefeshedTokenResponseDto()
            {
                ErrorMessage = "Invalid refresh token. Go to hell, you, mama's hacker!"
            });
        }

        if (user.RefreshTokenExpiryTime <= DateTime.Now)
        {
            return BadRequest(new RefeshedTokenResponseDto()
            {
                ErrorMessage = "Token has not expired!"
            });
        }

        var newAccessToken = _tokenProvider.GenerateAccessToken(principal.Claims);
        var newRefreshToken = _tokenProvider.GenerateRefreshToken();
        user.RefreshToken = newRefreshToken;
        user.RefreshTokenExpiryTime = DateTime.Now.AddDays(10);
        await _manager.UpdateAsync(user);
        return Ok(new RefeshedTokenResponseDto()
        {
            RefreshToken = newRefreshToken,
            AccessToken = newAccessToken,
        });
    }
}
