namespace reenbitChat.DAL.Entities.Messages;

public class MessageBase : EntityBase
{
    public string Text { get; set; }
    public bool? IsDeletedOnlyForSender { get; set; }
    public int SenderId { get; set; }
    public User Sender { get; set; }
    public DateTime SentAt { get; set; }
}
