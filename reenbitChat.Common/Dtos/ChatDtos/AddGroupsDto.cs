namespace reenbitChat.Common.Dtos.ChatDtos;

public class AddGroupsDto
{
    public int UserId { get; set; }
    public IEnumerable<int> GroupsIds { get; set; }
}
