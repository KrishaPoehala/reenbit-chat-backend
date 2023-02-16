using reenbitChat.Common.Dtos.UserDtos;

namespace reenbitChat.Common.Dtos.ChatDtos;

public class NewChatDto
{
    public string Name { get; set; }
    public int OwnerId { get; set; }
    public IEnumerable<int> MemberIds { get; set; }
    public bool? IsGroup { get; set; }
    public string? ImageUrl { get; set; }
}