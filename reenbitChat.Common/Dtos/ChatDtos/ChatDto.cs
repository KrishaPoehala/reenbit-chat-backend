using reenbitChat.Common.Dtos.AuthorizationDtos;
using reenbitChat.Common.Dtos.MessageDtos;

namespace reenbitChat.Common.Dtos.ChatDtos;

public class ChatDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public IEnumerable<MessageDto> Messages { get; set; }
    public IEnumerable<ChatMemberDto> Members { get; set; }
    public bool? IsGroup { get; set; }
    public string ImageUrl { get; set; }
}
