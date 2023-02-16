using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using reenbitChat.DAL.Entities;
using reenbitChat.DAL.Enums;

namespace reenbitChat.DAL.Configurations;

public class RoleConfiguration : IEntityTypeConfiguration<Role>
{
    public void Configure(EntityTypeBuilder<Role> builder)
    {
        builder.HasMany(x => x.Members)
            .WithOne(x => x.Role)
            .HasForeignKey(x => x.RoleId);

        builder.HasMany(x => x.DefaultPermissions)
            .WithMany(x => x.Roles)
            .UsingEntity("PermissionRole");
    }

    
}
