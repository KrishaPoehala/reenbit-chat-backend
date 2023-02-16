using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using reenbitChat.Common.Dtos.UserDtos;
using reenbitChat.DAL.Constants;
using reenbitChat.DAL.Entities;
using reenbitChat.Domain.Abstraction;
using System.Security.Claims;

namespace reenbitChat.WebApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AccountsController : ControllerBase
{
    private readonly UserManager<User> _userManager;
    private readonly IMapper _mapper;
    private readonly ITokenProvider _tokenProvider;
    public AccountsController(UserManager<User> manager, IMapper mapper, 
        ITokenProvider tokenProvider, SignInManager<User> signInManager)
    {
        _userManager = manager;
        _mapper = mapper;
        _tokenProvider = tokenProvider;
    }

    [HttpPost]
    [Route("register")]
    public async Task<IActionResult> Register(RegisterUserDto dto)
    {
        if (dto is null || !ModelState.IsValid)
        {
            return BadRequest();
        }

        var newUser = _mapper.Map<User>(dto);
        newUser.RefreshToken = _tokenProvider.GenerateRefreshToken();
        var result = await _userManager.CreateAsync(newUser, dto.Password);
        if (result.Succeeded == false)
        {
            var errors = result.Errors.Select(x => x.Description);
            return BadRequest(new AuthResponseDto() { Errors = errors });
        }

        var claims = GetClaims(newUser);
        var accessToken = _tokenProvider.GenerateAccessToken(claims);
        return Ok(new AuthResponseDto()
        { 
            IsAuthSuccessfull = true,
            AccessToken = accessToken,
            RefreshToken = newUser.RefreshToken,
        });
    }

    [HttpPost]
    [Route("login")]
    public async Task<IActionResult> Login(LoginUserDto dto)
    {
        var user = await _userManager.FindByEmailAsync(dto.Email);
        if (user is null)
        {
            return Unauthorized(new AuthResponseDto() { Errors = new[] { "Email:Email does not exist" } });
        }

        var checkPassword = await _userManager.CheckPasswordAsync(user, dto.Password);
        if (checkPassword == false)
        {
            return Unauthorized(new AuthResponseDto() { Errors = new[] { "Password:Invalid password" }});
        }

        var claims = GetClaims(user);
        var accessToken = _tokenProvider.GenerateAccessToken(claims);
        if(user.RefreshTokenExpiryTime <= DateTime.Now)
        {
            user.RefreshToken = _tokenProvider.GenerateRefreshToken();
            user.RefreshTokenExpiryTime = DateTime.Now.AddDays(10);
        }


        await _userManager.UpdateAsync(user);
        return Ok(new AuthResponseDto()
        { 
            IsAuthSuccessfull = true, 
            AccessToken = accessToken,
            RefreshToken = user.RefreshToken,
        });
    }

    [NonAction]
    private static List<Claim> GetClaims(User user) => new()
    {
        new(CustomClaims.Id, user.Id.ToString()),
        new(CustomClaims.Email, user.Email),
        new(CustomClaims.Name, user.UserName),
    };

    [Authorize]
    [Route("user/{userId}")]
    [HttpGet]
    public async Task<IActionResult> GetUserById(int userId)
    {
        return Ok(_userManager.FindByIdAsync(userId.ToString()));
    }
}
