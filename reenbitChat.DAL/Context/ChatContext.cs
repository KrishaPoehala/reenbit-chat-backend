using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using reenbitChat.DAL.Entities;
using reenbitChat.DAL.Entities.Messages;
using reenbitChat.DAL.Extentions;

namespace reenbitChat.DAL.Context;

public class ChatContext : IdentityDbContext<User, IdentityRole<int>, int>
{
    //public DbSet<User> Users { get; private set; }
    public DbSet<UserContact> UserContacts { get; set; }
    public DbSet<GroupMessage> Messages { get; private set; }
    public DbSet<Chat> Chats { get; private set; }
    public DbSet<PrivateMessage> PrivateMessages { get; set; }

    public ChatContext(DbContextOptions<ChatContext> options) : base(options)
    {
    }


    protected override void OnModelCreating(ModelBuilder builder)
    {
        
        builder.Configure();
        builder.Seed();
        base.OnModelCreating(builder);
    }

  

}
