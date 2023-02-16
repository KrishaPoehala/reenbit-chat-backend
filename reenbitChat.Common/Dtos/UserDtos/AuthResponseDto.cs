namespace reenbitChat.Common.Dtos.UserDtos;

public class AuthResponseDto
{
    public bool IsAuthSuccessfull { get; set; }
    public IEnumerable<string>? Errors { get; set; }
    public string? AccessToken { get; set; }
    public string? RefreshToken { get; set; }
}
