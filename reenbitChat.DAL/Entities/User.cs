using Microsoft.AspNetCore.Identity;
namespace reenbitChat.DAL.Entities;
public class User : IdentityUser<int>
{
    public override int Id { get; set; }
    public string ProfilePhotoUrl { get; set; }
    public string? RefreshToken { get; set; }
    public DateTime RefreshTokenExpiryTime { get; set; }
    public DateTime LastSeen { get; set; }
    public IEnumerable<ChatMember> ChatMembers { get; set; }
}
