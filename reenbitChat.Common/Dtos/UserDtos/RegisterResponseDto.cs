namespace reenbitChat.Common.Dtos.UserDtos;

public class RegisterResponseDto
{
    public bool IsSuccessful { get; set; }
    public IEnumerable<string> Errors { get; set; }
    public string Token { get; set; }
}
