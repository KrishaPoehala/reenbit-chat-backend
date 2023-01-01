using Microsoft.AspNetCore.Identity;
using reenbitChat.DAL.Entities.Messages;
namespace reenbitChat.DAL.Entities;
public class User : IdentityUser<int>
{
    public override int Id { get; set; }
    public string ProfilePhotoUrl { get; set; }
    public virtual ICollection<UserContact>? Contacts { get; set; } = new List<UserContact>();
    public virtual ICollection<UserContact>? ContactsOf { get; set; } = new List<UserContact>();
    public virtual ICollection<PrivateMessage> PrivateMessagesSent { get; set; }
    public virtual ICollection<PrivateMessage> PrivateMessagesReceived { get; set; }
    public virtual ICollection<Chat> Chats { get; set; } = new LinkedList<Chat>();
}
