namespace reenbitChat.DAL.Entities.Messages;

public class PrivateMessage : MessageBase
{
    public int ReceiverId { get; set; }
    public User Receiver { get; set; }
}
