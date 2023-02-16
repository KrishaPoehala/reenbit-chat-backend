namespace reenbitChat.Common.Dtos.TokenDtos;

public class RefeshedTokenResponseDto
{
    public string? AccessToken { get; set; }
    public string? RefreshToken { get; set; }
    public string? ErrorMessage { get; set; }
    public bool IsRefreshingSuccessfull => ErrorMessage is null;
}
