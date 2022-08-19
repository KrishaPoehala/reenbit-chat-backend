using reenbitChat.Common.Dtos.ChatDtos;

namespace reenbitChat.Common.Dtos.MessageDtos;

public class MessagePaginationDto
{
    public int ChatId { get; set; }
    public int PageNumber { get; set; }
    public int MessagesToLoad { get; set; }
    public int UserId { get; set; }
}
