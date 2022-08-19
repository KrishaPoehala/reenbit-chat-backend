using Microsoft.EntityFrameworkCore;
using reenbitChat.DAL.Entities;
using reenbitChat.DAL.Extentions;

namespace reenbitChat.DAL.Context;

public class ChatContext : DbContext
{
    public DbSet<User> Users { get; private set; }
    public DbSet<Message> Messages { get; private set; }
    public DbSet<Chat> Chats { get; private set; }

    public ChatContext(DbContextOptions<ChatContext> options) : base(options)
    {
    }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Configure();
        modelBuilder.Seed();
    }

}
