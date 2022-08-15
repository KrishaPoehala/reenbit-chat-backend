
namespace reenbitChat.DAL.Entities;

public class ChatEntity : BaseEntity
{
    public string Name { get; set; }
    public ICollection<User> Members { get; set; }
    public ICollection<Message> Messages { get; set; }
    public bool IsGroup { get; set; }
}
