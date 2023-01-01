
using reenbitChat.Common.Dtos.MessageDtos;

namespace reenbitChat.Common.Dtos.ChatDtos;

public class RoomDto
{
    public string? Name { get; set; }
    public IEnumerable<MessageDto> Messages { get; set; }
}
