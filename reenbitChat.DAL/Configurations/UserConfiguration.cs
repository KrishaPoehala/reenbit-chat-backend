using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using reenbitChat.DAL.Entities;

namespace reenbitChat.DAL.Configurations;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasMany(x => x.ChatMembers)
            .WithOne(x => x.User)
            .HasForeignKey(x => x.UserId);
    }
}
