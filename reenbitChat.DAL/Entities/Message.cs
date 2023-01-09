namespace reenbitChat.DAL.Entities;

public class Message:EntityBase
{
    public int ChatId { get; set; }
    public Chat Chat { get; set; }
    public string Text { get; set; }
    public bool? IsDeletedOnlyForSender { get; set; }
    public int SenderId { get; set; }
    public User Sender { get; set; }
    public DateTime SentAt { get; set; }
}
