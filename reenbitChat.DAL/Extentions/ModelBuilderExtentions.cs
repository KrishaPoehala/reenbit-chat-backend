using Bogus;
using Microsoft.EntityFrameworkCore;
using reenbitChat.DAL.Entities;
using reenbitChat.DAL.Enums;
using System.Text;

namespace reenbitChat.DAL.Extentions;

public static class ModelBuilderExtentions
{  
    public static void Seed(this ModelBuilder builder)
    {
        var users = GenerateUsers(10).ToList();
        var groups = GenerateGroupes(8).ToList();
        var groupMembers = GenerateMembers(groups, users);
        var messages = GenerateMessages(300, groupMembers, groups);
        var defaultPermissions = GenerateDefaultPermissions();
        var chatMemberPermissions = GenerateMembersPermissions(groupMembers,defaultPermissions);
        builder.Entity<Permission>().HasData(GetPermissions());
        builder.Entity<Role>().HasData(GetRolesData());
        builder.Entity<Chat>().HasData(groups);
        builder.Entity<User>().HasData(users);
        builder.Entity<Message>().HasData(messages);
        builder.Entity<ChatMember>().HasData(groupMembers);
        builder.Entity("ChatMemberPermission").HasData(chatMemberPermissions);
        builder.Entity("PermissionRole").HasData(defaultPermissions);
    }

    record PermissionsRoles(int DefaultPermissionsId, int RolesId);
    private static IEnumerable<PermissionsRoles> GenerateDefaultPermissions()
    {
        var roles = GetRolesData();
        var list = new List<PermissionsRoles>();
        foreach (var role in roles)
        {
            if(role.Name == Roles.Owner.ToString())
            {
                list.AddRange(OwnerPermissions());
            }

            if(role.Name == Roles.Admin.ToString())
            {
                list.AddRange(AdminPermissions());
            }

            if(role.Name == Roles.Member.ToString())
            {
                list.AddRange(GetMemberPermissions());
            }
        }

        return list.OrderBy(x => x.RolesId);
    }

    private static IEnumerable<PermissionsRoles> GetMemberPermissions()
    {
        var memberRoleId = GetRolesData().First(x => x.Name == Roles.Member.ToString()).Id;
        var memberPermissions = new[] { Permissions.SendMessages };
        foreach (var permission in GetPermissions())
        {
            if(memberPermissions.Any(x => x.ToString() == permission.Name))
            {
                yield return new(permission.Id, memberRoleId);
            }
        }
    }

    private static IEnumerable<PermissionsRoles> OwnerPermissions()
    {
        var ownerRoleId = GetRolesData().First(x => x.Name == Roles.Owner.ToString()).Id;
        foreach (var item in GetPermissions())
        {
            yield return new(item.Id, ownerRoleId);
        }
    }

    private static IEnumerable<PermissionsRoles> AdminPermissions()
    {
        var adminRoleId = GetRolesData().First(x => x.Name == Roles.Admin.ToString()).Id;
        var adminPermissions = new[] { Permissions.SendMessages,
            Permissions.DeleteMessages,Permissions.ChangeChatInfo,Permissions.RemoveUsers,
            Permissions.AddUsers, Permissions.PinMessages,
        };
        foreach (var item in GetPermissions())
        {
            if (adminPermissions.Any(x => x.ToString() == item.Name))
            {
                yield return new(item.Id, adminRoleId);
            }
        }
    }

    record MemberPermissions(int MembersId, int PermissionsId);
    private static List<MemberPermissions> GenerateMembersPermissions(List<ChatMember> groupMembers,
        IEnumerable<PermissionsRoles> defaultPermissions)
    {
        var list = new List<MemberPermissions>();
        for (int i = 0; i < groupMembers.Count; i++)
        {
            foreach (var permission in GetPermissions(groupMembers[i].RoleId, defaultPermissions))
            {
                var p = new MemberPermissions(groupMembers[i].Id, permission.Id);
                list.Add(p);
            }
        }

        return list;
    }

    private static IEnumerable<Role> GetRolesData()
    {
        var values = Enum.GetValues<Roles>();
        for (int i = 0; i < values.Length; i++)
        {
            var roleName = values[i].ToString();
            var roleOrder = (int)values[i];
            yield return new()
            {
                Id = i + 1,
                Name = roleName,
                Order = roleOrder,
            };
        }
    }

    private static IEnumerable<Permission> GetPermissions(int? roleId, IEnumerable<PermissionsRoles> defaultPermissions)
    {
        var all = GetPermissions();
        //Owner has all the permissions
        if(roleId == 3)
        {
            return all;
        }

        var list = new List<Permission>();
        var grouped = defaultPermissions.Where(x => x.RolesId == roleId);
        foreach (var item in all)
        {
            if (grouped.Any(x => x.RolesId == item.Id))
            {
                list.Add(item);
            }
        }

        return list;
    }

    private static IEnumerable<Permission> GetPermissions()
    {
        var values = Enum.GetValues<Permissions>();
        var index = 1;
        foreach (var item in values)
        {
            yield return new()
            {
                Id = index++,
                Name = item.ToString(),
            };
        }
    }

    private static List<ChatMember> GenerateMembers(List<Chat> groups, List<User> users)
    {
        var index = 1;
        var faker = new Faker();
        var list = new List<ChatMember>();

        for (int i = 0; i < groups.Count; i++)
        {
            var ownerId = faker.PickRandom(users).Id;
            var ownerMember = new ChatMember()
            {
                Id = index++,
                RoleId = 3,
                UserId = ownerId,
                ChatId = groups[i].Id,
            };
            list.Add(ownerMember);
            for (int j = 0; j < Random.Shared.Next(users.Count / 2, users.Count + 1); j++)
            {
                var member = new ChatMember()
                {
                    Id = index++,
                    RoleId = 1,
                    ChatId = groups[i].Id,
                    UserId = faker.PickRandom(users.Where(x => x.Id != ownerId)).Id,
                };

                list.Add(member);
            }
        }

        return list;
    }



    private static IEnumerable<Message> GenerateMessages(int count, 
        IEnumerable<ChatMember> members, IEnumerable<Chat> groups)
    {
        var index = 1;
        var faker = new Faker<Message>()
            .RuleFor(x => x.Text, f => f.Lorem.Sentences(2))
            .RuleFor(x => x.ChatId, f => f.PickRandom(groups).Id)
            .RuleFor(x => x.SenderId, f => f.PickRandom(members).Id)
            .RuleFor(x => x.SentAt, f => f.Date.Past())
            .RuleFor(x => x.Id, f => index++);

        return faker.Generate(count);
    }

    private static IEnumerable<User> GenerateUsers(int count)
    {
        var index = 1;
        var faker = new Faker<User>()
            .RuleFor(x => x.NormalizedEmail, f => f.Internet.Email())
            .RuleFor(x => x.UserName, f => f.Name.FirstName())
            .RuleFor(x => x.ProfilePhotoUrl, f=> f.Image.PicsumUrl(480))
            .RuleFor(x => x.Id, f => index++);


        return faker.Generate(count);
    }

    private static IEnumerable<Chat> GenerateGroupes(int count)
    {
        var index = 1;
        var faker = new Faker<Chat>()
            .RuleFor(x => x.Name, f => f.Company.CompanyName())
            .RuleFor(x => x.ImageUrl, f=> f.Image.PicsumUrl())
            .RuleFor(x => x.Id, f => index++)
            .RuleFor(x => x.IsPublic, _ => true)
            .RuleFor(x => x.IsGroup, _ => true);

        return faker.Generate(count);
    }
}
