namespace reenbitChat.DAL.Entities;

public class Message:EntityBase
{
    public Message ReplyMessage { get; set; }
    public int? ReplyMessageId { get; set; }
    public int ChatId { get; set; }
    public Chat Chat { get; set; }
    public string Text { get; set; }
    public bool? IsDeletedOnlyForSender { get; set; }
    public bool IsEdited { get; set; }
    public int SenderId { get; set; }
    public bool IsSeen { get; set; }
    public ChatMember Sender { get; set; }
    public DateTime SentAt { get; set; }
    public ICollection<ChatMember> ReadBy { get; set; } = new List<ChatMember>();
}
