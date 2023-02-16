namespace reenbitChat.Common.Dtos.ChatDtos;

public class UpdateChatsOrderDto
{
    public int UserId { get; set; }
    public IEnumerable<ChatOrderDto> ChatsOrder { get; set; }
}

public class ChatOrderDto
{
    public int ChatId { get; set; }
    public int ChatOrder { get; set; }
}
