namespace reenbitChat.DAL.Entities;

public class Message : BaseEntity
{
    public string Text { get; set; }
    public int SenderId { get; set; }
    public User Sender { get; set; }
    public int ChatId { get; set; }
    public ChatEntity Chat { get; set; }
    public bool IsDeletedOnlyForSender { get; set; }
    public DateTime SentAt { get; set; }
}
