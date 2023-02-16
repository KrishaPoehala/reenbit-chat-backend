

namespace reenbitChat.DAL.Entities;
public class Chat : EntityBase
{
    public string Name { get; set; }
    public ICollection<ChatMember> Members { get; set; } = new List<ChatMember>();
    public ICollection<Message> Messages { get; set; }
    public string ImageUrl { get; set; }
    public bool? IsGroup { get; set; }
    public bool? IsPublic { get; set; }
}
