namespace reenbitChat.DAL.Entities;

public class ChatMember:EntityBase
{
    public int UserId { get; set; }
    public User User { get; set; }
    public int? RoleId { get; set; }
    public Role? Role { get; set; }
    public IList<Permission>? Permissions { get; set; }
    public int ChatId { get; set; }
    public Chat Chat { get; set; }
    public int UnreadMessagesCount { get; set; }
    public IEnumerable<Message> MessagesSent { get; set; }
    public IEnumerable<Message> MessagesRead { get; set; }
}
