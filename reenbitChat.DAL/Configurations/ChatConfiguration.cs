using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using reenbitChat.DAL.Entities;

namespace reenbitChat.DAL.Configurations;

public class ChatConfiguration : IEntityTypeConfiguration<Chat>
{
    public void Configure(EntityTypeBuilder<Chat> builder)
    {
        builder
          .HasMany(x => x.Messages)
          .WithOne(x => x.Chat)
          .HasForeignKey(x => x.ChatId);

        builder.HasMany(x => x.Members)
            .WithOne(x => x.Chat)
            .HasForeignKey(x => x.ChatId);
    }
}
