
namespace reenbitChat.DAL.Entities;

public class Permission:EntityBase
{
    public string Name { get; set; }
    public IEnumerable<ChatMember> Members { get; set; }
    public IEnumerable<Role> Roles { get; set; }
}
