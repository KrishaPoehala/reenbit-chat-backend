using reenbitChat.DAL.Entities.Messages;

namespace reenbitChat.DAL.Entities;
public class Chat : EntityBase
{
    public string Name { get; set; }
    public ICollection<User> Members { get; set; } = new LinkedList<User>();
    public ICollection<GroupMessage> Messages { get; set; } = new LinkedList<GroupMessage>();
    public string ImageUrl { get; set; }
}
