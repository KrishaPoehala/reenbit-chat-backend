
namespace reenbitChat.DAL.Entities;

public class Chat : BaseEntity
{
    public string Name { get; set; }
    public ICollection<User> Members { get; set; } = new LinkedList<User>();
    public ICollection<Message> Messages { get; set; } = new LinkedList<Message>();
    public bool? IsGroup { get; set; }
    public string ImageUrl { get; set; }

}
