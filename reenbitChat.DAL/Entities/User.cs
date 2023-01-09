using Microsoft.AspNetCore.Identity;
namespace reenbitChat.DAL.Entities;
public class User : IdentityUser<int>
{
    public override int Id { get; set; }
    public string ProfilePhotoUrl { get; set; }
    public virtual ICollection<Chat> Chats { get; set; } = new LinkedList<Chat>();
}
