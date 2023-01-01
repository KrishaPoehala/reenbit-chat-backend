namespace reenbitChat.DAL.Entities.Messages;

public class GroupMessage : MessageBase
{
    public int ChatId { get; set; }
    public Chat Chat { get; set; }
}
