using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using reenbitChat.BLL.Jwt;
using reenbitChat.BLL.Services.Abstraction;
using reenbitChat.Common.Dtos.UserDtos;
using reenbitChat.DAL.Context;
using reenbitChat.DAL.Entities;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace reenbitChat.WebApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AccountsController : ControllerBase
{
    private readonly UserManager<User> _userManager;
    private readonly SignInManager<User> _signInManager;
    private readonly IMapper _mapper;
    private readonly ITokenProvider _tokenProvider;
    public AccountsController(UserManager<User> manager, IMapper mapper, 
        ITokenProvider tokenProvider, SignInManager<User> signInManager)
    {
        _userManager = manager;
        _mapper = mapper;
        _tokenProvider = tokenProvider;
        _signInManager = signInManager;
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
        var result = await _userManager.CreateAsync(newUser, dto.Password);
        if (result.Succeeded == false)
        {
            var errors = result.Errors.Select(x => x.Description);
            return BadRequest(new RegisterResponseDto() { Errors = errors });
        }

        var claims = GetClaims(newUser);
        var token = _tokenProvider.GenerateToken(claims);
        return Ok(new RegisterResponseDto() { IsSuccessful = true, Token = token});
    }

    [HttpPost]
    [Route("login")]
    public async Task<IActionResult> Login(LoginUserDto dto)
    {
        var user = await _userManager.FindByEmailAsync(dto.Email);
        if (user is null)
        {
            return Unauthorized(new AuthResponseDto() { ErrorMessage = "Email does not exist" });
        }

        var checkPassword = await _userManager.CheckPasswordAsync(user, dto.Password);
        if (checkPassword == false)
        {
            return Unauthorized(new AuthResponseDto() { ErrorMessage = "Invalid password" });
        }

        var claims = GetClaims(user);
        var token = _tokenProvider.GenerateToken(claims);
        return Ok(new AuthResponseDto() { IsAuthSuccessfull = true, Token = token });
    }

   

    [NonAction]
    private List<Claim> GetClaims(User user) => new()
    {
        new(ClaimTypes.Email, user.Email),
        new(ClaimTypes.Name, user.UserName),
    };
}
