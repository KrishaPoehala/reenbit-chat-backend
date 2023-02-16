namespace reenbitChat.Common.Dtos.MessageDtos;

public class MessagesReadDto
{
    public int MemberId { get; set; }
    public IEnumerable<int> MessageIds { get; set; }
}
