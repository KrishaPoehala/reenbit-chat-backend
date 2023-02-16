using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using reenbitChat.DAL.Entities;

namespace reenbitChat.DAL.Configurations;

public class MessageConfiguration : IEntityTypeConfiguration<Message>
{
    public void Configure(EntityTypeBuilder<Message> builder)
    {
        builder
           .HasOne(x => x.Chat)
           .WithMany(x => x.Messages)
           .HasForeignKey(x => x.ChatId)
           .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(x => x.Sender)
            .WithMany(x => x.MessagesSent)
            .HasForeignKey(x => x.SenderId);

        builder.HasOne(x => x.ReplyMessage)
            .WithOne()
            .HasForeignKey<Message>(x => x.ReplyMessageId)
            .IsRequired(false)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(x => x.ReadBy)
            .WithMany(x => x.MessagesRead);

        builder
            .HasIndex(x =>x.ReplyMessageId)
            .IsUnique(false);

        builder.Property(x => x.IsEdited).HasDefaultValue(false);
    }
}
