namespace reenbitChat.Common.Dtos.UserDtos;

public class AuthResponseDto
{
    public bool IsAuthSuccessfull { get; set; }
    public string? ErrorMessage { get; set; }
    public string? Token { get; set; }
}
