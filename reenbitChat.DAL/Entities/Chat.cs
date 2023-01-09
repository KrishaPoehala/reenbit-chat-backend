
namespace reenbitChat.DAL.Entities;
public class Chat : EntityBase
{
    public string Name { get; set; }
    public ICollection<User> Members { get; set; } = new LinkedList<User>();
    public ICollection<Message> Messages { get; set; } = new LinkedList<Message>();
    public string ImageUrl { get; set; }
    public bool? IsGroup { get; set; }
}
