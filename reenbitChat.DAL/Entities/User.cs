namespace reenbitChat.DAL.Entities;

public class User : BaseEntity
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string ProfilePhotoUrl { get; set; }
    public virtual ICollection<Message> MessagesSent { get; set; } = new LinkedList<Message>();
    public virtual ICollection<Chat> Chats { get; set; } = new LinkedList<Chat>();
}
