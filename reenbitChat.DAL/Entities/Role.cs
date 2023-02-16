namespace reenbitChat.DAL.Entities;

public class Role:EntityBase
{
    public string Name { get; set; }
    public int Order { get; set; }
    public IEnumerable<ChatMember> Members { get; set; }
    public IList<Permission> DefaultPermissions { get; set; }
}
