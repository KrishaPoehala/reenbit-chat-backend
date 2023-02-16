using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using reenbitChat.DAL.Entities;

namespace reenbitChat.DAL.Configurations;

public class ChatMemberConfiguration : IEntityTypeConfiguration<ChatMember>
{
    public void Configure(EntityTypeBuilder<ChatMember> builder)
    {
        builder.HasOne(x => x.User)
            .WithMany(x => x.ChatMembers)
            .HasForeignKey(x => x.UserId);

        builder.HasMany(x => x.Permissions)
            .WithMany(x => x.Members);

        builder.HasOne(x => x.Role)
            .WithMany(x => x.Members)
            .HasForeignKey(x => x.RoleId);

        builder.HasOne(x => x.Chat)
            .WithMany(x => x.Members)
            .HasForeignKey(x => x.ChatId);

    }
}
