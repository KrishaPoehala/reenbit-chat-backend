
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using reenbitChat.DAL.Entities;
using reenbitChat.DAL.Enums;

namespace reenbitChat.DAL.Configurations;

public class PermissionConfiguration : IEntityTypeConfiguration<Permission>
{
    public void Configure(EntityTypeBuilder<Permission> builder)
    {
        builder.HasMany(x => x.Members)
            .WithMany(x => x.Permissions)
            .UsingEntity("ChatMemberPermission")
            ;

        //builder.HasData(GetPermissions());
    }
}
