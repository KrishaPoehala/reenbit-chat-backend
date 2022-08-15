namespace reenbitChat.DAL.Entities;

public class User : BaseEntity
{
    public string Name { get; set; }
    public string Email { get; set; }
    public ICollection<Message> MessagesSent { get; set; }
    public ICollection<ChatEntity> Chats { get; set; }
}
