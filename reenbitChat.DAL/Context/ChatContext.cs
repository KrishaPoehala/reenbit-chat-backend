using Microsoft.EntityFrameworkCore;
using reenbitChat.DAL.Extentions;

namespace reenbitChat.DAL.Context;

public class ChatContext : DbContext
{
    public ChatContext(DbContextOptions<ChatContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Configure();
        modelBuilder.Seed();
    }
}
