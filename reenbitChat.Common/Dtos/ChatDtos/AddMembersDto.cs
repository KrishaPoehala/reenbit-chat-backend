namespace reenbitChat.Common.Dtos.ChatDtos;

public class AddMembersDto
{
    public int ChatId { get; set; }
    public IEnumerable<int> NewMemberIds { get; set; }
}
